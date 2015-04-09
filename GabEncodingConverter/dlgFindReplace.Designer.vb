<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgFindReplace
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgFindReplace))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbDown = New System.Windows.Forms.RadioButton
        Me.rbUp = New System.Windows.Forms.RadioButton
        Me.chkMatchCase = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFind = New System.Windows.Forms.TextBox
        Me.Find_Button = New System.Windows.Forms.Button
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.ReplaceAll_Button = New System.Windows.Forms.Button
        Me.Replace_Button = New System.Windows.Forms.Button
        Me.txtReplace = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Font = Nothing
        Me.Label1.Name = "Label1"
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
        'Find_Button
        '
        Me.Find_Button.AccessibleDescription = Nothing
        Me.Find_Button.AccessibleName = Nothing
        resources.ApplyResources(Me.Find_Button, "Find_Button")
        Me.Find_Button.BackgroundImage = Nothing
        Me.Find_Button.Font = Nothing
        Me.Find_Button.Name = "Find_Button"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AccessibleDescription = Nothing
        Me.TableLayoutPanel1.AccessibleName = Nothing
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.BackgroundImage = Nothing
        Me.TableLayoutPanel1.Controls.Add(Me.Find_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ReplaceAll_Button, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Replace_Button, 0, 1)
        Me.TableLayoutPanel1.Font = Nothing
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
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
        'ReplaceAll_Button
        '
        Me.ReplaceAll_Button.AccessibleDescription = Nothing
        Me.ReplaceAll_Button.AccessibleName = Nothing
        resources.ApplyResources(Me.ReplaceAll_Button, "ReplaceAll_Button")
        Me.ReplaceAll_Button.BackgroundImage = Nothing
        Me.ReplaceAll_Button.Font = Nothing
        Me.ReplaceAll_Button.Name = "ReplaceAll_Button"
        '
        'Replace_Button
        '
        Me.Replace_Button.AccessibleDescription = Nothing
        Me.Replace_Button.AccessibleName = Nothing
        resources.ApplyResources(Me.Replace_Button, "Replace_Button")
        Me.Replace_Button.BackgroundImage = Nothing
        Me.Replace_Button.Font = Nothing
        Me.Replace_Button.Name = "Replace_Button"
        '
        'txtReplace
        '
        Me.txtReplace.AccessibleDescription = Nothing
        Me.txtReplace.AccessibleName = Nothing
        resources.ApplyResources(Me.txtReplace, "txtReplace")
        Me.txtReplace.BackgroundImage = Nothing
        Me.txtReplace.Font = Nothing
        Me.txtReplace.Name = "txtReplace"
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Font = Nothing
        Me.Label2.Name = "Label2"
        '
        'dlgFindReplace
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtReplace)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkMatchCase)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFindReplace"
        Me.ShowInTaskbar = False
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbDown As System.Windows.Forms.RadioButton
    Friend WithEvents rbUp As System.Windows.Forms.RadioButton
    Friend WithEvents chkMatchCase As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents Find_Button As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents txtReplace As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ReplaceAll_Button As System.Windows.Forms.Button
    Friend WithEvents Replace_Button As System.Windows.Forms.Button

End Class
