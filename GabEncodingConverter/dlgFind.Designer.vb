<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgFind
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgFind))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Find_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.txtFind = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkMatchCase = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbDown = New System.Windows.Forms.RadioButton
        Me.rbUp = New System.Windows.Forms.RadioButton
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AccessibleDescription = Nothing
        Me.TableLayoutPanel1.AccessibleName = Nothing
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.BackgroundImage = Nothing
        Me.TableLayoutPanel1.Controls.Add(Me.Find_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 0, 1)
        Me.TableLayoutPanel1.Font = Nothing
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'Find_Button
        '
        Me.Find_Button.AccessibleDescription = Nothing
        Me.Find_Button.AccessibleName = Nothing
        resources.ApplyResources(Me.Find_Button, "Find_Button")
        Me.Find_Button.BackgroundImage = Nothing
        Me.Find_Button.Font = Nothing
        Me.Find_Button.Name = "Find_Button"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.AccessibleDescription = Nothing
        Me.Cancel_Button.AccessibleName = Nothing
        resources.ApplyResources(Me.Cancel_Button, "Cancel_Button")
        Me.Cancel_Button.BackgroundImage = Nothing
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Font = Nothing
        Me.Cancel_Button.Name = "Cancel_Button"
        '
        'txtFind
        '
        Me.txtFind.AccessibleDescription = Nothing
        Me.txtFind.AccessibleName = Nothing
        resources.ApplyResources(Me.txtFind, "txtFind")
        Me.txtFind.BackgroundImage = Nothing
        Me.txtFind.Font = Nothing
        Me.txtFind.Name = "txtFind"
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Font = Nothing
        Me.Label1.Name = "Label1"
        '
        'chkMatchCase
        '
        Me.chkMatchCase.AccessibleDescription = Nothing
        Me.chkMatchCase.AccessibleName = Nothing
        resources.ApplyResources(Me.chkMatchCase, "chkMatchCase")
        Me.chkMatchCase.BackgroundImage = Nothing
        Me.chkMatchCase.Font = Nothing
        Me.chkMatchCase.Name = "chkMatchCase"
        Me.chkMatchCase.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = Nothing
        Me.GroupBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.BackgroundImage = Nothing
        Me.GroupBox1.Controls.Add(Me.rbDown)
        Me.GroupBox1.Controls.Add(Me.rbUp)
        Me.GroupBox1.Font = Nothing
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'rbDown
        '
        Me.rbDown.AccessibleDescription = Nothing
        Me.rbDown.AccessibleName = Nothing
        resources.ApplyResources(Me.rbDown, "rbDown")
        Me.rbDown.BackgroundImage = Nothing
        Me.rbDown.Checked = True
        Me.rbDown.Font = Nothing
        Me.rbDown.Name = "rbDown"
        Me.rbDown.TabStop = True
        Me.rbDown.UseVisualStyleBackColor = True
        '
        'rbUp
        '
        Me.rbUp.AccessibleDescription = Nothing
        Me.rbUp.AccessibleName = Nothing
        resources.ApplyResources(Me.rbUp, "rbUp")
        Me.rbUp.BackgroundImage = Nothing
        Me.rbUp.Font = Nothing
        Me.rbUp.Name = "rbUp"
        Me.rbUp.UseVisualStyleBackColor = True
        '
        'dlgFind
        '
        Me.AcceptButton = Me.Find_Button
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.CancelButton = Me.Cancel_Button
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkMatchCase)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFind"
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Find_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkMatchCase As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbDown As System.Windows.Forms.RadioButton
    Friend WithEvents rbUp As System.Windows.Forms.RadioButton

End Class
