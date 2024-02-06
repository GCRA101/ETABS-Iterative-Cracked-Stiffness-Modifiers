Imports System.ComponentModel

Public Class Form1

    'VARIABLES
    'Generic
    Private ret As Integer                                                                                           'O(1)
    Private i, j, k As Integer                                                                                       'O(1)
    'ETABS OAPI Interoperability Variables
    Private HelperObject As ETABSv1.cHelper   ' Helper Class Object Variable                                         'O(1)
    Private etabsApp As ETABSv1.cOAPI         ' ETABS Application Object Variable                                    'O(1)
    Private etabsModel As ETABSv1.cSapModel  ' ETABS Model Object Variable                                           'O(1)
    'ETABS OAPI Utility Variables
    Dim loadCasesNum, loadCombosNum As Integer
    Dim loadCasesNames, loadComboNames As String()
    Dim selLoadCombos, selGroupNames As String()
    Dim CrackedWalls_GroupName, UncrackedWalls_GroupName As String
    Const etabsVisibility As Boolean = False
    'PROJECT SPECIFIC Utility Variables
    Dim wallNames As New List(Of String)
    Dim unCrackedWallsModifiers As AreaObjModifiers
    Dim crackedWallsModifiers As AreaObjModifiers
    Dim maxTensileStress As Double
    Dim iterNumMax As Integer

    Private Sub btnAttachETABSInstance_Click_1(sender As Object, e As EventArgs) Handles btnAttachETABSInstance.Click
        extractEtabsModelData()
    End Sub

    Private Sub btnRunIteration_Click(sender As Object, e As EventArgs) Handles btnRunIteration.Click

        importUserInputData()

        Dim progrBarStep As Integer = (Me.progrBar.Maximum - Me.progrBar.Minimum) \ iterNumMax

        For iter As Integer = 0 To iterNumMax
            runIteration()
            Me.progrBar.Increment(progrBarStep)
            Me.Refresh()
        Next

        Me.lblProgrBar.Text = "TRANSFER COMPLETED!"
        Me.Refresh()


        'SAVE THE MODEL
        etabsModel.File.Save(setNewFilePath(etabsModel.GetModelFilename(True)))

        'CLOSE ETABS APPLICATION
        etabsApp.ApplicationExit(False)

        'MEMORY RELEASE
        etabsModel = Nothing        'O(1)
        etabsApp = Nothing          'O(1)

        'CLOSE AND DISPOSE FORM
        Me.Close()
        Me.Dispose()

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SplashScreen.ShowDialog()
        'AboutBox.ShowDialog()
        InitializeForm()
        InitializeETABS()
    End Sub

    Private Sub InitializeETABS()

        'ETABS OAPI Variables Assignment

        'Helper Class Object Variable
        HelperObject = New ETABSv1.Helper                                                                            'O(1)
        'ETABS Application Object Variable                                                                           'O(1)
        etabsApp = Nothing                                                                                           'O(1)
        'ETABSApp = HelperObject.CreateObjectProgID("CSI.ETABS.API.ETABSObject")                                      'O(1)
        'ETABSApp = HelperObject.CreateObject("c:\Program Files\Computers and Structures\ETABS 20\ETABS.exe")        'O(1)
        etabsApp = HelperObject.GetObject("CSI.ETABS.API.ETABSObject")                                              'O(1)

    End Sub

    Private Sub InitializeForm()


        Me.cklbGroups.Items.Clear()
        Me.cklbLoadCombos.Items.Clear()
        For Each comp As Component In tlbModifiers.Controls
            If CStr(comp.GetType().Name) = "ComboBox" Then
                Dim cbBox = CType(comp, ComboBox)
                If cbBox.Name.Contains("UnCracked") Then
                    cbBox.SelectedText = "1.0"
                Else
                    cbBox.SelectedText = "0.7"
                End If
            End If
        Next

        Me.cbTensileCapacity.SelectedValue = Nothing
        Me.cbIterations.SelectedValue = Nothing

    End Sub

    Private Sub setEtabsVisibility()
        If Not etabsVisibility Then
            ret = etabsApp.Hide()
        End If
    End Sub


    Private Function getSelectedFile(dialogTitle As String) As String

        Dim fileName As String = Nothing

        With ofdEtabsModel
            .Title = dialogTitle
            .InitialDirectory = "C:\"
            .Multiselect = False
            .Filter = "Etabs Files|*.edb"
            Dim dialogResult As DialogResult = .ShowDialog()
            If dialogResult = Windows.Forms.DialogResult.OK Then
                fileName = .FileName
            End If
        End With

        Return fileName

    End Function

    Private Function setNewFilePath(filePath As String) As String
        Dim newFilePath As String
        Dim dateObj As Date = Date.Today

        Dim sep() As Char = {"/", "\", "//"}

        With dateObj
            newFilePath = filePath.Remove(filePath.IndexOf(filePath.Split(sep).Last())) + "ISM" +
                            .Year.ToString + .Month.ToString("D2") +
                            .Day.ToString("D2") + "_" + filePath.Split(sep).Last()
        End With

        Return newFilePath

    End Function


    Private Sub extractEtabsModelData()

        'Open ETABS Application
        'ret = ETABSApp.ApplicationStart()

        'Show/Hide ETABS Application
        setEtabsVisibility()


        ''ETABS Model Object Variable
        etabsModel = etabsApp.SapModel                                                              'O(1)

        'etabsModel.InitializeNewModel()

        'ret = etabsModel.File.OpenFile(etabsFileName)

        ret = etabsModel.View.RefreshView

        ret = etabsModel.SetModelIsLocked(False)


        'EXTRACT LOAD CASES

        ret = etabsModel.LoadCases.GetNameList(loadCasesNum, loadCasesNames)


        'ACTIVATE ALL LOAD CASES FOR RUNNING THE ANALYSIS

        ret = etabsModel.Analyze.SetRunCaseFlag(loadCasesNames(0), True, All:=True)


        'EXTRACT LOAD COMBINATIONS


        ret = etabsModel.RespCombo.GetNameList(loadCombosNum, loadComboNames)

        With Me.cklbLoadCombos
            .CheckOnClick = True
            .Items.AddRange(loadComboNames)
            .ClearSelected()
        End With


        'RESET CRACKED/UNCRACKED WALLS GROUPS

        createGroups()

        'EXTRACT GROUP NAMES

        Dim sourceNumberGroups As Integer, sourceGroupNames As String()
        ret = etabsModel.GroupDef.GetNameList(sourceNumberGroups, sourceGroupNames)
        'Remove the "All" Group - *** STREAMS and LAMBDA FUNCTIONS
        sourceGroupNames = sourceGroupNames.Where(Function(name) name <> "All" And
                                                      name <> CrackedWalls_GroupName And
                                                      name <> UncrackedWalls_GroupName).ToArray()

        With Me.cklbGroups
            .CheckOnClick = True
            .Items.AddRange(sourceGroupNames)
            .ClearSelected()
        End With


    End Sub



    Private Sub createGroups()

        'Groups Name Assignment
        CrackedWalls_GroupName = "Cracked Walls"
        UncrackedWalls_GroupName = "Uncracked Walls"

        'Delete Cracked/Uncracked Walls Groups if they are already existing
        ret = etabsModel.GroupDef.Delete(CrackedWalls_GroupName)
        ret = etabsModel.GroupDef.Delete(UncrackedWalls_GroupName)

        'Create them again from scratch
        ret = etabsModel.GroupDef.SetGroup(CrackedWalls_GroupName, RGB(255, 0, 0))
        ret = etabsModel.GroupDef.SetGroup(UncrackedWalls_GroupName, RGB(0, 255, 0))



    End Sub




    Public Sub importUserInputData()

        'GET THE SELECTED GROUPS
        ReDim selGroupNames(Me.cklbGroups.CheckedItems.Count - 1)
        For i = 0 To (Me.cklbGroups.CheckedItems.Count - 1) Step 1
            selGroupNames(i) = CStr(Me.cklbGroups.CheckedItems(i))
        Next


        'GET THE WALL NAMES

        Dim numberItems As Integer, objectTypes As Integer(), objectNames As String()
        Dim objTypesList As New List(Of Integer), objNamesList As New List(Of String)
        Dim areaDesignOrientation As ETABSv1.eAreaDesignOrientation

        For Each selGroupName As String In selGroupNames
            ret = etabsModel.GroupDef.GetAssignments(selGroupName, numberItems, objectTypes, objectNames)
            objTypesList.AddRange(objectTypes)
            objNamesList.AddRange(objectNames)
        Next

        For i As Integer = 0 To objNamesList.Count - 1
            If objTypesList(i) = 5 Then
                ret = etabsModel.AreaObj.GetDesignOrientation(objNamesList(i), areaDesignOrientation)
                If areaDesignOrientation = ETABSv1.eAreaDesignOrientation.Wall Then
                    wallNames.Add(objNamesList(i))
                End If
            End If

        Next

        'GET THE SELECTED LOAD COMBOS
        ReDim selLoadCombos(Me.cklbLoadCombos.CheckedItems.Count - 1)
        For i = 0 To (Me.cklbLoadCombos.CheckedItems.Count - 1) Step 1
            selLoadCombos(i) = CStr(Me.cklbLoadCombos.CheckedItems(i))
        Next


        'GET THE OBJ PROPERTY MODIFIERS

        Dim f11, f22, f12, m11, m22, m12, v13, v23 As Double
        Dim mass As Double = 1
        Dim weight As Double = 1

        With tlbModifiers
            f11 = CDbl(.GetControlFromPosition(1, 1).Text)
            f22 = CDbl(.GetControlFromPosition(1, 2).Text)
            f12 = CDbl(.GetControlFromPosition(1, 3).Text)
            m11 = CDbl(.GetControlFromPosition(1, 4).Text)
            m22 = CDbl(.GetControlFromPosition(1, 5).Text)
            m12 = CDbl(.GetControlFromPosition(1, 6).Text)
            v13 = CDbl(.GetControlFromPosition(1, 7).Text)
            v23 = CDbl(.GetControlFromPosition(1, 8).Text)
        End With

        unCrackedWallsModifiers = New AreaObjModifiers("CrackedWalls",
                                        f11, f22, f12, m11, m22, m12, v13, v23, mass, weight)

        With tlbModifiers
            f11 = CDbl(.GetControlFromPosition(2, 1).Text)
            f22 = CDbl(.GetControlFromPosition(2, 2).Text)
            f12 = CDbl(.GetControlFromPosition(2, 3).Text)
            m11 = CDbl(.GetControlFromPosition(2, 4).Text)
            m22 = CDbl(.GetControlFromPosition(2, 5).Text)
            m12 = CDbl(.GetControlFromPosition(2, 6).Text)
            v13 = CDbl(.GetControlFromPosition(2, 7).Text)
            v23 = CDbl(.GetControlFromPosition(2, 8).Text)
        End With

        crackedWallsModifiers = New AreaObjModifiers("CrackedWalls",
                                        f11, f22, f12, m11, m22, m12, v13, v23, mass, weight)


        'GET THE CONCRETE MAX TENSILE CAPACITY

        maxTensileStress = CDbl(cbTensileCapacity.Text)

        'GET THE MAXIMUM NUMBER OF ITERATIONS

        iterNumMax = CInt(cbIterations.Text)



        'SET THE SELECTED LOAD COMBOS FOR OUTPUTS

        'Deselect all previously selected Load Combos/Load Cases
        ret = etabsModel.Results.Setup.DeselectAllCasesAndCombosForOutput
        'Flick through the selected Load Combos and set them for outputs production
        For Each selLoadComboName In selLoadCombos
            ret = etabsModel.Results.Setup.SetComboSelectedForOutput(selLoadComboName, True)
        Next


        'REMOVE UNCRACKED/CRACKED PROPERTIES ASSIGNMENTS TO ALL WALLS

        For Each wallName As String In wallNames
            ret = etabsModel.AreaObj.SetGroupAssign(wallName, UncrackedWalls_GroupName, True)
            ret = etabsModel.AreaObj.SetGroupAssign(wallName, CrackedWalls_GroupName, True)
        Next
    End Sub


    Public Sub runIteration()                                                                               'T(n)

        'RUN THE ANALYSIS

        ret = etabsModel.Analyze.RunAnalysis                                                                'θ(n)


        'EXTRACT SHELL FORCES AND ASSIGN CRACKED PROPERTIES IF REQUIRED                                     

        Dim ItemTypeElm As CSiAPIv1.eItemTypeElm                                                            'θ(1)
        Dim NumberResults As Integer                                                                        'θ(1)
        Dim Obj, Elm, PointElm, LoadCase, StepType As String()                                              'θ(1)
        Dim StepNum As Double()                                                                             'θ(1)
        Dim f_11, f_22, f_12, f_Max, f_Min, f_Angle, f_VM As Double()                                       'θ(1)
        Dim m_11, m_22, m_12, m_Max, m_Min, m_Angle As Double()                                             'θ(1)
        Dim v_13, v_23, v_Max, v_Angle As Double()                                                          'θ(1)

        Dim wallProperty As WallProperty                                                                    'θ(1)
        Dim wallObj As AreaObj                                                                              'θ(1)
        Dim shellForces As ShellForces                                                                      'θ(1)
        Dim wallDataSet As AreaDataSet                                                                      'θ(1)
        Dim wallDataSets As New HashSet(Of AreaDataSet)                                                     'θ(1)


        For Each wallName As String In wallNames                                                            'n*θ(1)+θ(1)

            '1. BUILD THE WALLPROPERTY OBJECT

            'Get the Area Property Name
            Dim wallPropName As String                                                                      'θ(1)
            ret = etabsModel.AreaObj.GetProperty(wallName, wallPropName)                                    'θ(1)
            'Get the Wall Properties Values
            Dim wallPropType As ETABSv1.eWallPropType, shellType As ETABSv1.eShellType, matProp As String   'θ(1)
            Dim thk As Double, color As Integer, notes As String, guid As String                            'θ(1)
            ret = etabsModel.PropArea.GetWall(wallPropName, wallPropType, shellType, matProp, thk, color, notes, guid)
            'Build the Wall Property Wrapper Class
            wallProperty = New WallProperty(wallPropName, wallPropType, shellType, matProp, thk)            'θ(1)


            '2. BUILD THE SHELLFORCES OBJECT

            'Get the Area Shell Forces
            ret = etabsModel.Results.AreaForceShell(                                                        'θ(1)
                wallName, ItemTypeElm, NumberResults, Obj, Elm, PointElm, LoadCase, StepType,
                StepNum, f_11, f_22, f_12, f_Max, f_Min, f_Angle, f_VM, m_11, m_22, m_12, m_Max, m_Min,
                m_Angle, v_13, v_23, v_Max, v_Angle)
            'Build the ShellForces Wrapper Class
            shellForces = New ShellForces(NumberResults, Obj, Elm, PointElm, LoadCase, StepType,            'θ(1)
                StepNum, f_11, f_22, f_12, f_Max, f_Min, f_Angle, f_VM, m_11, m_22, m_12, m_Max, m_Min,
                m_Angle, v_13, v_23, v_Max, v_Angle)


            '3. BUILD THE WALLOBJ OBJECT


            Array.Sort(f_Max)                                                                               'θ(mlogm)
            Dim maxTensileForce As Double                                                                   'θ(1)
            maxTensileForce = maxTensileStress * thk                                                        'θ(1)

            If f_Max(UBound(f_Max)) > maxTensileForce Then                                                  'θ(1)
                wallObj = New AreaObj(wallName, CrackedWalls_GroupName, crackedWallsModifiers)              'θ(1)
            Else                                                                                            'θ(1)
                wallObj = New AreaObj(wallName, UncrackedWalls_GroupName, unCrackedWallsModifiers)          'θ(1)
            End If                                                                                          'θ(1)

            wallDataSet = New AreaDataSet(wallObj, shellForces)                                             'θ(1)

            wallDataSets.Add(wallDataSet)                                                                   'θ(1)

        Next                                                                                                'θ(1)

        ret = etabsModel.SetModelIsLocked(False)                                                            'θ(1)

        For Each wallDS As AreaDataSet In wallDataSets                                                      'n*θ(1)+θ(1)
            With wallDS.getAreaObj                                                                          'θ(1)
                'Assign Cracked/Uncracked Group to the Wall Panel
                ret = etabsModel.AreaObj.SetGroupAssign(.getName(), .getGroupName())                        'θ(1)
                'Assign Cracked/Uncracked Walls Modifiers to the Wall Panel
                ret = etabsModel.AreaObj.SetModifiers(.getName(), .getPropertyModifiers.getValues())        'θ(1)
            End With                                                                                        'θ(1)

        Next

        'Computational Cost
        'T(n) = θ(n)+θ(1)+n*θ(m*logm)+θ(1)++θ(n)=θ(n*m*logm)


    End Sub

End Class
