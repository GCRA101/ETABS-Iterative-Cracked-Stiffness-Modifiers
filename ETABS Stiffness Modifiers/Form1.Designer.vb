<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblGroups = New System.Windows.Forms.Label()
        Me.cklbGroups = New System.Windows.Forms.CheckedListBox()
        Me.lblLoadCombos = New System.Windows.Forms.Label()
        Me.cklbLoadCombos = New System.Windows.Forms.CheckedListBox()
        Me.cbIterations = New System.Windows.Forms.ComboBox()
        Me.lblIterations = New System.Windows.Forms.Label()
        Me.lblProgrBar = New System.Windows.Forms.Label()
        Me.progrBar = New System.Windows.Forms.ProgressBar()
        Me.btnRunIteration = New System.Windows.Forms.Button()
        Me.lblMaxTensileCap = New System.Windows.Forms.Label()
        Me.cbTensileCapacity = New System.Windows.Forms.ComboBox()
        Me.lblF11 = New System.Windows.Forms.Label()
        Me.lblF22 = New System.Windows.Forms.Label()
        Me.lblF12 = New System.Windows.Forms.Label()
        Me.lblM12 = New System.Windows.Forms.Label()
        Me.lblM22 = New System.Windows.Forms.Label()
        Me.lblM11 = New System.Windows.Forms.Label()
        Me.lblV23 = New System.Windows.Forms.Label()
        Me.lblV13 = New System.Windows.Forms.Label()
        Me.cbF11UnCracked = New System.Windows.Forms.ComboBox()
        Me.cbF22UnCracked = New System.Windows.Forms.ComboBox()
        Me.cbF12UnCracked = New System.Windows.Forms.ComboBox()
        Me.cbM11UnCracked = New System.Windows.Forms.ComboBox()
        Me.cbM22UnCracked = New System.Windows.Forms.ComboBox()
        Me.cbM12UnCracked = New System.Windows.Forms.ComboBox()
        Me.cbV13UnCracked = New System.Windows.Forms.ComboBox()
        Me.cbV23UnCracked = New System.Windows.Forms.ComboBox()
        Me.lblUnCracked = New System.Windows.Forms.Label()
        Me.lblCracked = New System.Windows.Forms.Label()
        Me.tlbModifiers = New System.Windows.Forms.TableLayoutPanel()
        Me.cbV13Cracked = New System.Windows.Forms.ComboBox()
        Me.cbM12Cracked = New System.Windows.Forms.ComboBox()
        Me.cbM22Cracked = New System.Windows.Forms.ComboBox()
        Me.cbM11Cracked = New System.Windows.Forms.ComboBox()
        Me.cbF12Cracked = New System.Windows.Forms.ComboBox()
        Me.cbF22Cracked = New System.Windows.Forms.ComboBox()
        Me.cbF11Cracked = New System.Windows.Forms.ComboBox()
        Me.lblStiffMod = New System.Windows.Forms.Label()
        Me.cbV23Cracked = New System.Windows.Forms.ComboBox()
        Me.ofdEtabsModel = New System.Windows.Forms.OpenFileDialog()
        Me.btnAttachETABSInstance = New System.Windows.Forms.Button()
        Me.tlbModifiers.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblGroups
        '
        Me.lblGroups.AutoSize = True
        Me.lblGroups.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblGroups.Location = New System.Drawing.Point(31, 99)
        Me.lblGroups.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGroups.Name = "lblGroups"
        Me.lblGroups.Size = New System.Drawing.Size(69, 20)
        Me.lblGroups.TabIndex = 16
        Me.lblGroups.Text = "GROUPS"
        '
        'cklbGroups
        '
        Me.cklbGroups.FormattingEnabled = True
        Me.cklbGroups.Location = New System.Drawing.Point(32, 121)
        Me.cklbGroups.Margin = New System.Windows.Forms.Padding(4)
        Me.cklbGroups.Name = "cklbGroups"
        Me.cklbGroups.Size = New System.Drawing.Size(345, 72)
        Me.cklbGroups.TabIndex = 15
        '
        'lblLoadCombos
        '
        Me.lblLoadCombos.AutoSize = True
        Me.lblLoadCombos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLoadCombos.Location = New System.Drawing.Point(28, 215)
        Me.lblLoadCombos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLoadCombos.Name = "lblLoadCombos"
        Me.lblLoadCombos.Size = New System.Drawing.Size(117, 20)
        Me.lblLoadCombos.TabIndex = 18
        Me.lblLoadCombos.Text = "LOAD COMBOS"
        '
        'cklbLoadCombos
        '
        Me.cklbLoadCombos.FormattingEnabled = True
        Me.cklbLoadCombos.Location = New System.Drawing.Point(32, 237)
        Me.cklbLoadCombos.Margin = New System.Windows.Forms.Padding(4)
        Me.cklbLoadCombos.Name = "cklbLoadCombos"
        Me.cklbLoadCombos.Size = New System.Drawing.Size(345, 89)
        Me.cklbLoadCombos.TabIndex = 17
        '
        'cbIterations
        '
        Me.cbIterations.FormattingEnabled = True
        Me.cbIterations.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "10", "20", "50", "100"})
        Me.cbIterations.Location = New System.Drawing.Point(281, 681)
        Me.cbIterations.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbIterations.Name = "cbIterations"
        Me.cbIterations.Size = New System.Drawing.Size(97, 24)
        Me.cbIterations.TabIndex = 20
        '
        'lblIterations
        '
        Me.lblIterations.AutoSize = True
        Me.lblIterations.Location = New System.Drawing.Point(29, 685)
        Me.lblIterations.Name = "lblIterations"
        Me.lblIterations.Size = New System.Drawing.Size(191, 16)
        Me.lblIterations.TabIndex = 19
        Me.lblIterations.Text = "Max Num of Analysis Iterations:"
        '
        'lblProgrBar
        '
        Me.lblProgrBar.AutoSize = True
        Me.lblProgrBar.Location = New System.Drawing.Point(32, 818)
        Me.lblProgrBar.Name = "lblProgrBar"
        Me.lblProgrBar.Size = New System.Drawing.Size(134, 16)
        Me.lblProgrBar.TabIndex = 23
        Me.lblProgrBar.Text = "Iteration in Progress..."
        '
        'progrBar
        '
        Me.progrBar.Location = New System.Drawing.Point(35, 838)
        Me.progrBar.Margin = New System.Windows.Forms.Padding(4)
        Me.progrBar.Maximum = 100000
        Me.progrBar.Name = "progrBar"
        Me.progrBar.Size = New System.Drawing.Size(347, 27)
        Me.progrBar.TabIndex = 22
        '
        'btnRunIteration
        '
        Me.btnRunIteration.Location = New System.Drawing.Point(131, 728)
        Me.btnRunIteration.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRunIteration.Name = "btnRunIteration"
        Me.btnRunIteration.Size = New System.Drawing.Size(165, 47)
        Me.btnRunIteration.TabIndex = 24
        Me.btnRunIteration.Text = "RUN ITERATION"
        Me.btnRunIteration.UseVisualStyleBackColor = True
        '
        'lblMaxTensileCap
        '
        Me.lblMaxTensileCap.AutoSize = True
        Me.lblMaxTensileCap.Location = New System.Drawing.Point(29, 648)
        Me.lblMaxTensileCap.Name = "lblMaxTensileCap"
        Me.lblMaxTensileCap.Size = New System.Drawing.Size(232, 16)
        Me.lblMaxTensileCap.TabIndex = 25
        Me.lblMaxTensileCap.Text = "Concrete Max Tensile Capacity [MPa]"
        '
        'cbTensileCapacity
        '
        Me.cbTensileCapacity.FormattingEnabled = True
        Me.cbTensileCapacity.Items.AddRange(New Object() {"Automatic"})
        Me.cbTensileCapacity.Location = New System.Drawing.Point(281, 644)
        Me.cbTensileCapacity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbTensileCapacity.Name = "cbTensileCapacity"
        Me.cbTensileCapacity.Size = New System.Drawing.Size(97, 24)
        Me.cbTensileCapacity.TabIndex = 26
        '
        'lblF11
        '
        Me.lblF11.AutoSize = True
        Me.lblF11.BackColor = System.Drawing.Color.Transparent
        Me.lblF11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblF11.Location = New System.Drawing.Point(4, 52)
        Me.lblF11.Name = "lblF11"
        Me.lblF11.Size = New System.Drawing.Size(71, 25)
        Me.lblF11.TabIndex = 30
        Me.lblF11.Text = "f11"
        Me.lblF11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblF22
        '
        Me.lblF22.AutoSize = True
        Me.lblF22.BackColor = System.Drawing.Color.Transparent
        Me.lblF22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblF22.Location = New System.Drawing.Point(4, 78)
        Me.lblF22.Name = "lblF22"
        Me.lblF22.Size = New System.Drawing.Size(71, 25)
        Me.lblF22.TabIndex = 31
        Me.lblF22.Text = "f22"
        Me.lblF22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblF12
        '
        Me.lblF12.AutoSize = True
        Me.lblF12.BackColor = System.Drawing.Color.Transparent
        Me.lblF12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblF12.Location = New System.Drawing.Point(4, 104)
        Me.lblF12.Name = "lblF12"
        Me.lblF12.Size = New System.Drawing.Size(71, 25)
        Me.lblF12.TabIndex = 32
        Me.lblF12.Text = "f12"
        Me.lblF12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblM12
        '
        Me.lblM12.AutoSize = True
        Me.lblM12.BackColor = System.Drawing.Color.Transparent
        Me.lblM12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblM12.Location = New System.Drawing.Point(4, 182)
        Me.lblM12.Name = "lblM12"
        Me.lblM12.Size = New System.Drawing.Size(71, 25)
        Me.lblM12.TabIndex = 35
        Me.lblM12.Text = "m12"
        Me.lblM12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblM22
        '
        Me.lblM22.AutoSize = True
        Me.lblM22.BackColor = System.Drawing.Color.Transparent
        Me.lblM22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblM22.Location = New System.Drawing.Point(4, 156)
        Me.lblM22.Name = "lblM22"
        Me.lblM22.Size = New System.Drawing.Size(71, 25)
        Me.lblM22.TabIndex = 34
        Me.lblM22.Text = "m22"
        Me.lblM22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblM11
        '
        Me.lblM11.AutoSize = True
        Me.lblM11.BackColor = System.Drawing.Color.Transparent
        Me.lblM11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblM11.Location = New System.Drawing.Point(4, 130)
        Me.lblM11.Name = "lblM11"
        Me.lblM11.Size = New System.Drawing.Size(71, 25)
        Me.lblM11.TabIndex = 33
        Me.lblM11.Text = "m11"
        Me.lblM11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblV23
        '
        Me.lblV23.AutoSize = True
        Me.lblV23.BackColor = System.Drawing.Color.Transparent
        Me.lblV23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblV23.Location = New System.Drawing.Point(4, 234)
        Me.lblV23.Name = "lblV23"
        Me.lblV23.Size = New System.Drawing.Size(71, 26)
        Me.lblV23.TabIndex = 37
        Me.lblV23.Text = "v23"
        Me.lblV23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblV13
        '
        Me.lblV13.AutoSize = True
        Me.lblV13.BackColor = System.Drawing.Color.Transparent
        Me.lblV13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblV13.Location = New System.Drawing.Point(4, 208)
        Me.lblV13.Name = "lblV13"
        Me.lblV13.Size = New System.Drawing.Size(71, 25)
        Me.lblV13.TabIndex = 36
        Me.lblV13.Text = "v13"
        Me.lblV13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbF11UnCracked
        '
        Me.cbF11UnCracked.FormattingEnabled = True
        Me.cbF11UnCracked.ItemHeight = 16
        Me.cbF11UnCracked.Items.AddRange(New Object() {"0.00001", "0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7", "0.8", "0.9", "1.0"})
        Me.cbF11UnCracked.Location = New System.Drawing.Point(79, 52)
        Me.cbF11UnCracked.Margin = New System.Windows.Forms.Padding(0)
        Me.cbF11UnCracked.Name = "cbF11UnCracked"
        Me.cbF11UnCracked.Size = New System.Drawing.Size(133, 24)
        Me.cbF11UnCracked.TabIndex = 30
        '
        'cbF22UnCracked
        '
        Me.cbF22UnCracked.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbF22UnCracked.FormattingEnabled = True
        Me.cbF22UnCracked.Items.AddRange(New Object() {"0.00001", "0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7", "0.8", "0.9", "1.0"})
        Me.cbF22UnCracked.Location = New System.Drawing.Point(79, 78)
        Me.cbF22UnCracked.Margin = New System.Windows.Forms.Padding(0)
        Me.cbF22UnCracked.Name = "cbF22UnCracked"
        Me.cbF22UnCracked.Size = New System.Drawing.Size(135, 24)
        Me.cbF22UnCracked.TabIndex = 38
        '
        'cbF12UnCracked
        '
        Me.cbF12UnCracked.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbF12UnCracked.FormattingEnabled = True
        Me.cbF12UnCracked.Items.AddRange(New Object() {"0.00001", "0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7", "0.8", "0.9", "1.0"})
        Me.cbF12UnCracked.Location = New System.Drawing.Point(79, 104)
        Me.cbF12UnCracked.Margin = New System.Windows.Forms.Padding(0)
        Me.cbF12UnCracked.Name = "cbF12UnCracked"
        Me.cbF12UnCracked.Size = New System.Drawing.Size(135, 24)
        Me.cbF12UnCracked.TabIndex = 39
        '
        'cbM11UnCracked
        '
        Me.cbM11UnCracked.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbM11UnCracked.FormattingEnabled = True
        Me.cbM11UnCracked.Items.AddRange(New Object() {"0.00001", "0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7", "0.8", "0.9", "1.0"})
        Me.cbM11UnCracked.Location = New System.Drawing.Point(79, 130)
        Me.cbM11UnCracked.Margin = New System.Windows.Forms.Padding(0)
        Me.cbM11UnCracked.Name = "cbM11UnCracked"
        Me.cbM11UnCracked.Size = New System.Drawing.Size(135, 24)
        Me.cbM11UnCracked.TabIndex = 40
        '
        'cbM22UnCracked
        '
        Me.cbM22UnCracked.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbM22UnCracked.FormattingEnabled = True
        Me.cbM22UnCracked.Items.AddRange(New Object() {"0.00001", "0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7", "0.8", "0.9", "1.0"})
        Me.cbM22UnCracked.Location = New System.Drawing.Point(79, 156)
        Me.cbM22UnCracked.Margin = New System.Windows.Forms.Padding(0)
        Me.cbM22UnCracked.Name = "cbM22UnCracked"
        Me.cbM22UnCracked.Size = New System.Drawing.Size(135, 24)
        Me.cbM22UnCracked.TabIndex = 41
        '
        'cbM12UnCracked
        '
        Me.cbM12UnCracked.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbM12UnCracked.FormattingEnabled = True
        Me.cbM12UnCracked.Items.AddRange(New Object() {"0.00001", "0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7", "0.8", "0.9", "1.0"})
        Me.cbM12UnCracked.Location = New System.Drawing.Point(79, 182)
        Me.cbM12UnCracked.Margin = New System.Windows.Forms.Padding(0)
        Me.cbM12UnCracked.Name = "cbM12UnCracked"
        Me.cbM12UnCracked.Size = New System.Drawing.Size(135, 24)
        Me.cbM12UnCracked.TabIndex = 42
        '
        'cbV13UnCracked
        '
        Me.cbV13UnCracked.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbV13UnCracked.FormattingEnabled = True
        Me.cbV13UnCracked.Items.AddRange(New Object() {"0.00001", "0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7", "0.8", "0.9", "1.0"})
        Me.cbV13UnCracked.Location = New System.Drawing.Point(79, 208)
        Me.cbV13UnCracked.Margin = New System.Windows.Forms.Padding(0)
        Me.cbV13UnCracked.Name = "cbV13UnCracked"
        Me.cbV13UnCracked.Size = New System.Drawing.Size(135, 24)
        Me.cbV13UnCracked.TabIndex = 43
        '
        'cbV23UnCracked
        '
        Me.cbV23UnCracked.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbV23UnCracked.FormattingEnabled = True
        Me.cbV23UnCracked.Items.AddRange(New Object() {"0.00001", "0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7", "0.8", "0.9", "1.0"})
        Me.cbV23UnCracked.Location = New System.Drawing.Point(79, 234)
        Me.cbV23UnCracked.Margin = New System.Windows.Forms.Padding(0)
        Me.cbV23UnCracked.Name = "cbV23UnCracked"
        Me.cbV23UnCracked.Size = New System.Drawing.Size(135, 24)
        Me.cbV23UnCracked.TabIndex = 44
        '
        'lblUnCracked
        '
        Me.lblUnCracked.AutoSize = True
        Me.lblUnCracked.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUnCracked.Location = New System.Drawing.Point(82, 1)
        Me.lblUnCracked.Name = "lblUnCracked"
        Me.lblUnCracked.Size = New System.Drawing.Size(129, 50)
        Me.lblUnCracked.TabIndex = 45
        Me.lblUnCracked.Text = "Un-cracked"
        Me.lblUnCracked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCracked
        '
        Me.lblCracked.AutoSize = True
        Me.lblCracked.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCracked.Location = New System.Drawing.Point(215, 1)
        Me.lblCracked.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCracked.Name = "lblCracked"
        Me.lblCracked.Size = New System.Drawing.Size(131, 50)
        Me.lblCracked.TabIndex = 46
        Me.lblCracked.Text = "Cracked"
        Me.lblCracked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlbModifiers
        '
        Me.tlbModifiers.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlbModifiers.ColumnCount = 3
        Me.tlbModifiers.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.69231!))
        Me.tlbModifiers.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.61538!))
        Me.tlbModifiers.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.69231!))
        Me.tlbModifiers.Controls.Add(Me.cbV13Cracked, 2, 7)
        Me.tlbModifiers.Controls.Add(Me.cbM12Cracked, 2, 6)
        Me.tlbModifiers.Controls.Add(Me.cbM22Cracked, 2, 5)
        Me.tlbModifiers.Controls.Add(Me.cbM11Cracked, 2, 4)
        Me.tlbModifiers.Controls.Add(Me.cbF12Cracked, 2, 3)
        Me.tlbModifiers.Controls.Add(Me.cbF22Cracked, 2, 2)
        Me.tlbModifiers.Controls.Add(Me.cbF11Cracked, 2, 1)
        Me.tlbModifiers.Controls.Add(Me.cbV23UnCracked, 1, 8)
        Me.tlbModifiers.Controls.Add(Me.cbM12UnCracked, 1, 6)
        Me.tlbModifiers.Controls.Add(Me.cbM11UnCracked, 1, 4)
        Me.tlbModifiers.Controls.Add(Me.cbF12UnCracked, 1, 3)
        Me.tlbModifiers.Controls.Add(Me.lblStiffMod, 0, 0)
        Me.tlbModifiers.Controls.Add(Me.lblV23, 0, 8)
        Me.tlbModifiers.Controls.Add(Me.lblUnCracked, 1, 0)
        Me.tlbModifiers.Controls.Add(Me.lblV13, 0, 7)
        Me.tlbModifiers.Controls.Add(Me.lblF11, 0, 1)
        Me.tlbModifiers.Controls.Add(Me.lblM12, 0, 6)
        Me.tlbModifiers.Controls.Add(Me.lblF22, 0, 2)
        Me.tlbModifiers.Controls.Add(Me.lblM22, 0, 5)
        Me.tlbModifiers.Controls.Add(Me.lblF12, 0, 3)
        Me.tlbModifiers.Controls.Add(Me.lblM11, 0, 4)
        Me.tlbModifiers.Controls.Add(Me.lblCracked, 2, 0)
        Me.tlbModifiers.Controls.Add(Me.cbF22UnCracked, 1, 2)
        Me.tlbModifiers.Controls.Add(Me.cbM22UnCracked, 1, 5)
        Me.tlbModifiers.Controls.Add(Me.cbV13UnCracked, 1, 7)
        Me.tlbModifiers.Controls.Add(Me.cbF11UnCracked, 1, 1)
        Me.tlbModifiers.Controls.Add(Me.cbV23Cracked, 2, 8)
        Me.tlbModifiers.Location = New System.Drawing.Point(32, 358)
        Me.tlbModifiers.Margin = New System.Windows.Forms.Padding(4)
        Me.tlbModifiers.Name = "tlbModifiers"
        Me.tlbModifiers.RowCount = 9
        Me.tlbModifiers.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlbModifiers.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlbModifiers.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlbModifiers.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlbModifiers.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlbModifiers.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlbModifiers.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlbModifiers.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlbModifiers.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlbModifiers.Size = New System.Drawing.Size(347, 261)
        Me.tlbModifiers.TabIndex = 30
        '
        'cbV13Cracked
        '
        Me.cbV13Cracked.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbV13Cracked.FormattingEnabled = True
        Me.cbV13Cracked.Items.AddRange(New Object() {"0.00001", "0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7", "0.8", "0.9", "1.0"})
        Me.cbV13Cracked.Location = New System.Drawing.Point(215, 208)
        Me.cbV13Cracked.Margin = New System.Windows.Forms.Padding(0)
        Me.cbV13Cracked.Name = "cbV13Cracked"
        Me.cbV13Cracked.Size = New System.Drawing.Size(131, 24)
        Me.cbV13Cracked.TabIndex = 54
        '
        'cbM12Cracked
        '
        Me.cbM12Cracked.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbM12Cracked.FormattingEnabled = True
        Me.cbM12Cracked.Items.AddRange(New Object() {"0.00001", "0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7", "0.8", "0.9", "1.0"})
        Me.cbM12Cracked.Location = New System.Drawing.Point(215, 182)
        Me.cbM12Cracked.Margin = New System.Windows.Forms.Padding(0)
        Me.cbM12Cracked.Name = "cbM12Cracked"
        Me.cbM12Cracked.Size = New System.Drawing.Size(131, 24)
        Me.cbM12Cracked.TabIndex = 53
        '
        'cbM22Cracked
        '
        Me.cbM22Cracked.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbM22Cracked.FormattingEnabled = True
        Me.cbM22Cracked.Items.AddRange(New Object() {"0.00001", "0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7", "0.8", "0.9", "1.0"})
        Me.cbM22Cracked.Location = New System.Drawing.Point(215, 156)
        Me.cbM22Cracked.Margin = New System.Windows.Forms.Padding(0)
        Me.cbM22Cracked.Name = "cbM22Cracked"
        Me.cbM22Cracked.Size = New System.Drawing.Size(131, 24)
        Me.cbM22Cracked.TabIndex = 52
        '
        'cbM11Cracked
        '
        Me.cbM11Cracked.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbM11Cracked.FormattingEnabled = True
        Me.cbM11Cracked.Items.AddRange(New Object() {"0.00001", "0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7", "0.8", "0.9", "1.0"})
        Me.cbM11Cracked.Location = New System.Drawing.Point(215, 130)
        Me.cbM11Cracked.Margin = New System.Windows.Forms.Padding(0)
        Me.cbM11Cracked.Name = "cbM11Cracked"
        Me.cbM11Cracked.Size = New System.Drawing.Size(131, 24)
        Me.cbM11Cracked.TabIndex = 51
        '
        'cbF12Cracked
        '
        Me.cbF12Cracked.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbF12Cracked.FormattingEnabled = True
        Me.cbF12Cracked.Items.AddRange(New Object() {"0.00001", "0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7", "0.8", "0.9", "1.0"})
        Me.cbF12Cracked.Location = New System.Drawing.Point(215, 104)
        Me.cbF12Cracked.Margin = New System.Windows.Forms.Padding(0)
        Me.cbF12Cracked.Name = "cbF12Cracked"
        Me.cbF12Cracked.Size = New System.Drawing.Size(131, 24)
        Me.cbF12Cracked.TabIndex = 50
        '
        'cbF22Cracked
        '
        Me.cbF22Cracked.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbF22Cracked.FormattingEnabled = True
        Me.cbF22Cracked.Items.AddRange(New Object() {"0.00001", "0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7", "0.8", "0.9", "1.0"})
        Me.cbF22Cracked.Location = New System.Drawing.Point(215, 78)
        Me.cbF22Cracked.Margin = New System.Windows.Forms.Padding(0)
        Me.cbF22Cracked.Name = "cbF22Cracked"
        Me.cbF22Cracked.Size = New System.Drawing.Size(131, 24)
        Me.cbF22Cracked.TabIndex = 49
        '
        'cbF11Cracked
        '
        Me.cbF11Cracked.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbF11Cracked.FormattingEnabled = True
        Me.cbF11Cracked.Items.AddRange(New Object() {"0.00001", "0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7", "0.8", "0.9", "1.0"})
        Me.cbF11Cracked.Location = New System.Drawing.Point(215, 52)
        Me.cbF11Cracked.Margin = New System.Windows.Forms.Padding(0)
        Me.cbF11Cracked.Name = "cbF11Cracked"
        Me.cbF11Cracked.Size = New System.Drawing.Size(131, 24)
        Me.cbF11Cracked.TabIndex = 48
        '
        'lblStiffMod
        '
        Me.lblStiffMod.AutoSize = True
        Me.lblStiffMod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStiffMod.Location = New System.Drawing.Point(4, 1)
        Me.lblStiffMod.Name = "lblStiffMod"
        Me.lblStiffMod.Size = New System.Drawing.Size(71, 50)
        Me.lblStiffMod.TabIndex = 47
        Me.lblStiffMod.Text = "Stiffness Modifier"
        Me.lblStiffMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbV23Cracked
        '
        Me.cbV23Cracked.FormattingEnabled = True
        Me.cbV23Cracked.Items.AddRange(New Object() {"0.00001", "0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7", "0.8", "0.9", "1.0"})
        Me.cbV23Cracked.Location = New System.Drawing.Point(215, 234)
        Me.cbV23Cracked.Margin = New System.Windows.Forms.Padding(0)
        Me.cbV23Cracked.Name = "cbV23Cracked"
        Me.cbV23Cracked.Size = New System.Drawing.Size(128, 24)
        Me.cbV23Cracked.TabIndex = 55
        '
        'btnAttachETABSInstance
        '
        Me.btnAttachETABSInstance.Location = New System.Drawing.Point(111, 35)
        Me.btnAttachETABSInstance.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAttachETABSInstance.Name = "btnAttachETABSInstance"
        Me.btnAttachETABSInstance.Size = New System.Drawing.Size(216, 47)
        Me.btnAttachETABSInstance.TabIndex = 31
        Me.btnAttachETABSInstance.Text = "ATTACH TO ETABS INSTANCE"
        Me.btnAttachETABSInstance.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(420, 894)
        Me.Controls.Add(Me.btnAttachETABSInstance)
        Me.Controls.Add(Me.tlbModifiers)
        Me.Controls.Add(Me.cbTensileCapacity)
        Me.Controls.Add(Me.lblMaxTensileCap)
        Me.Controls.Add(Me.btnRunIteration)
        Me.Controls.Add(Me.lblProgrBar)
        Me.Controls.Add(Me.progrBar)
        Me.Controls.Add(Me.cbIterations)
        Me.Controls.Add(Me.lblIterations)
        Me.Controls.Add(Me.lblLoadCombos)
        Me.Controls.Add(Me.cklbLoadCombos)
        Me.Controls.Add(Me.lblGroups)
        Me.Controls.Add(Me.cklbGroups)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Etabs Cracked Stiffness Modifiers"
        Me.tlbModifiers.ResumeLayout(False)
        Me.tlbModifiers.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGroups As Label
    Friend WithEvents cklbGroups As CheckedListBox
    Friend WithEvents lblLoadCombos As Label
    Friend WithEvents cklbLoadCombos As CheckedListBox
    Friend WithEvents cbIterations As ComboBox
    Friend WithEvents lblIterations As Label
    Friend WithEvents lblProgrBar As Label
    Friend WithEvents progrBar As ProgressBar
    Friend WithEvents btnRunIteration As Button
    Friend WithEvents lblMaxTensileCap As Label
    Friend WithEvents cbTensileCapacity As ComboBox
    Friend WithEvents lblF11 As Label
    Friend WithEvents lblF22 As Label
    Friend WithEvents lblF12 As Label
    Friend WithEvents lblM12 As Label
    Friend WithEvents lblM22 As Label
    Friend WithEvents lblM11 As Label
    Friend WithEvents lblV23 As Label
    Friend WithEvents lblV13 As Label
    Friend WithEvents cbF11UnCracked As ComboBox
    Friend WithEvents cbF22UnCracked As ComboBox
    Friend WithEvents cbF12UnCracked As ComboBox
    Friend WithEvents cbM11UnCracked As ComboBox
    Friend WithEvents cbM22UnCracked As ComboBox
    Friend WithEvents cbM12UnCracked As ComboBox
    Friend WithEvents cbV13UnCracked As ComboBox
    Friend WithEvents cbV23UnCracked As ComboBox
    Friend WithEvents lblUnCracked As Label
    Friend WithEvents lblCracked As Label
    Friend WithEvents tlbModifiers As TableLayoutPanel
    Friend WithEvents lblStiffMod As Label
    Friend WithEvents cbV23Cracked As ComboBox
    Friend WithEvents cbV13Cracked As ComboBox
    Friend WithEvents cbM12Cracked As ComboBox
    Friend WithEvents cbM22Cracked As ComboBox
    Friend WithEvents cbM11Cracked As ComboBox
    Friend WithEvents cbF12Cracked As ComboBox
    Friend WithEvents cbF22Cracked As ComboBox
    Friend WithEvents cbF11Cracked As ComboBox
    Friend WithEvents ofdEtabsModel As OpenFileDialog
    Friend WithEvents btnAttachETABSInstance As Button
End Class
