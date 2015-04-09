<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFile))
        Me.gpinput = New System.Windows.Forms.GroupBox()
        Me.txts = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbse = New System.Windows.Forms.ComboBox()
        Me.CbItemBindingSourceSe = New System.Windows.Forms.BindingSource(Me.components)
        Me.gpoutput = New System.Windows.Forms.GroupBox()
        Me.txtd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbde = New System.Windows.Forms.ComboBox()
        Me.CbItemBindingSourceDe = New System.Windows.Forms.BindingSource(Me.components)
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.gpinput.SuspendLayout()
        CType(Me.CbItemBindingSourceSe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoutput.SuspendLayout()
        CType(Me.CbItemBindingSourceDe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpinput
        '
        Me.gpinput.Controls.Add(Me.txts)
        Me.gpinput.Controls.Add(Me.Label1)
        Me.gpinput.Controls.Add(Me.cbse)
        resources.ApplyResources(Me.gpinput, "gpinput")
        Me.gpinput.Name = "gpinput"
        Me.gpinput.TabStop = False
        '
        'txts
        '
        Me.txts.AcceptsReturn = True
        Me.txts.AcceptsTab = True
        resources.ApplyResources(Me.txts, "txts")
        Me.txts.Name = "txts"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'cbse
        '
        resources.ApplyResources(Me.cbse, "cbse")
        Me.cbse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbse.DataSource = Me.CbItemBindingSourceSe
        Me.cbse.DisplayMember = "DisplayString"
        Me.cbse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbse.FormattingEnabled = True
        Me.cbse.Name = "cbse"
        Me.cbse.ValueMember = "CodePage"
        '
        'CbItemBindingSourceSe
        '
        Me.CbItemBindingSourceSe.DataSource = GetType(GabEncodingConverter.cbItem)
        '
        'gpoutput
        '
        Me.gpoutput.Controls.Add(Me.txtd)
        Me.gpoutput.Controls.Add(Me.Label2)
        Me.gpoutput.Controls.Add(Me.cbde)
        resources.ApplyResources(Me.gpoutput, "gpoutput")
        Me.gpoutput.Name = "gpoutput"
        Me.gpoutput.TabStop = False
        '
        'txtd
        '
        Me.txtd.AcceptsReturn = True
        Me.txtd.AcceptsTab = True
        resources.ApplyResources(Me.txtd, "txtd")
        Me.txtd.Name = "txtd"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'cbde
        '
        resources.ApplyResources(Me.cbde, "cbde")
        Me.cbde.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbde.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbde.DataSource = Me.CbItemBindingSourceDe
        Me.cbde.DisplayMember = "DisplayString"
        Me.cbde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbde.FormattingEnabled = True
        Me.cbde.Name = "cbde"
        Me.cbde.ValueMember = "CodePage"
        '
        'CbItemBindingSourceDe
        '
        Me.CbItemBindingSourceDe.DataSource = GetType(GabEncodingConverter.cbItem)
        '
        'mainPanel
        '
        Me.mainPanel.Controls.Add(Me.gpinput)
        Me.mainPanel.Controls.Add(Me.gpoutput)
        resources.ApplyResources(Me.mainPanel, "mainPanel")
        Me.mainPanel.Name = "mainPanel"
        '
        'frmFile
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.mainPanel)
        Me.DoubleBuffered = True
        Me.Name = "frmFile"
        Me.ShowInTaskbar = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gpinput.ResumeLayout(False)
        Me.gpinput.PerformLayout()
        CType(Me.CbItemBindingSourceSe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoutput.ResumeLayout(False)
        Me.gpoutput.PerformLayout()
        CType(Me.CbItemBindingSourceDe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpinput As System.Windows.Forms.GroupBox
    Friend WithEvents gpoutput As System.Windows.Forms.GroupBox
    Friend WithEvents cbse As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbde As System.Windows.Forms.ComboBox
    Friend WithEvents txts As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtd As System.Windows.Forms.TextBox
    Friend WithEvents mainPanel As System.Windows.Forms.Panel
    Friend WithEvents CbItemBindingSourceSe As System.Windows.Forms.BindingSource
    Friend WithEvents CbItemBindingSourceDe As System.Windows.Forms.BindingSource
End Class
