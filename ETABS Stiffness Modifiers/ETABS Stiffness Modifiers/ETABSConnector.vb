﻿Public Class ETABSConnector
    Implements ETABSConnection

    'ATTRIBUTES ***********************************************************************************'

    'Private Instance - SINGLETON PATTERN
    Private Shared instance As ETABSConnector
    'ETABS OAPI Interoperability Variables
    Private helperObject As ETABSv1.cHelper   ' Helper Class Object Variable                  'O(1)
    Private ETABSApp As ETABSv1.cOAPI         ' ETABS Application Object Variable             'O(1)
    'Utility Variables
    Private ret As Integer                                                                    'O(1)
    Const etabsVisibility As Boolean = False                                                  'O(1)


    'PRIVATE CONSTRUCTOR **********************************************************************************'
    Private Sub New()
    End Sub


    'METHODS **************************************************************************************'

    'GETINSTANCE() METHOD - SINGLETON PATTERN
    Public Shared Function getInstance() As ETABSConnector
        If instance Is Nothing Then
            instance = New ETABSConnector()
        End If
        Return instance
    End Function


    'INITIALIZEETABS() METHOD
    Public Sub initialize() Implements ETABSConnection.initialize
        'Helper Class Object Variable
        helperObject = New ETABSv1.Helper                                                                            'O(1)
        'ETABS Application Object Variable                                                                           'O(1)
        ETABSApp = Nothing                                                                                           'O(1)
        ETABSApp = helperObject.CreateObjectProgID("CSI.ETABS.API.ETABSObject")                                      'O(1)
        'ETABSApp = helperObject.CreateObject("c:\Program Files\Computers and Structures\ETABS 20\ETABS.exe")        'O(1)
        'ETABSApp = helperObject.GetObject("CSI.ETABS.API.ETABSObject")                                              'O(1)
    End Sub


    ' DISPOSEETABS() METHOD
    Public Sub dispose() Implements ETABSConnection.dispose
        'Close the ETABS Application
        ETABSApp.ApplicationExit(False) 'O(1)
        'Release Memory
        ETABSApp = Nothing              'O(1)
    End Sub


    ' SETETABSVISIBILITY() METHOD
    Private Sub setEtabsVisibility(bool As Boolean) Implements ETABSConnection.setETABSVisibility
        If bool = False Then
            ret = ETABSApp.Hide()
        Else
            ret = ETABSApp.Unhide()
        End If
    End Sub


    'Getters

    'GET ETABS APP
    Public Function getEtabsApp()
        Return Me.ETABSApp
    End Function


End Class
