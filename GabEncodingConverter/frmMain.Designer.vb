<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.MainMenuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReplaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnglishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FrenchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FavoritesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCurrentConversionPairToFavoritesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteFavoritesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditFavoritesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditFavoritesToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserGuideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.MainToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonOpen = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonUndo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonRedo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonCopy = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonCut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonPaste = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonFind = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonReplace = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonHelp = New System.Windows.Forms.ToolStripButton()
        Me.MainMenu.SuspendLayout()
        Me.MainToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.AllowMerge = False
        Me.MainMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuFile, Me.EditToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.FavoritesToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        resources.ApplyResources(Me.MainMenu, "MainMenu")
        Me.MainMenu.MdiWindowListItem = Me.ViewToolStripMenuItem
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.ShowItemToolTips = True
        '
        'MainMenuFile
        '
        Me.MainMenuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ToolStripSeparator5, Me.SaveToolStripMenuItem, Me.SaveasToolStripMenuItem, Me.ToolStripSeparator1, Me.CloseToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.MainMenuFile.Name = "MainMenuFile"
        resources.ApplyResources(Me.MainMenuFile, "MainMenuFile")
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = Global.GabEncodingConverter.My.Resources.Resources.NewDocumentHS
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        resources.ApplyResources(Me.NewToolStripMenuItem, "NewToolStripMenuItem")
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = Global.GabEncodingConverter.My.Resources.Resources.openHS
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        resources.ApplyResources(Me.OpenToolStripMenuItem, "OpenToolStripMenuItem")
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        resources.ApplyResources(Me.ToolStripSeparator5, "ToolStripSeparator5")
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = Global.GabEncodingConverter.My.Resources.Resources.saveHS
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        resources.ApplyResources(Me.SaveToolStripMenuItem, "SaveToolStripMenuItem")
        '
        'SaveasToolStripMenuItem
        '
        Me.SaveasToolStripMenuItem.Name = "SaveasToolStripMenuItem"
        resources.ApplyResources(Me.SaveasToolStripMenuItem, "SaveasToolStripMenuItem")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Image = Global.GabEncodingConverter.My.Resources.Resources.DeleteHS
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        resources.ApplyResources(Me.CloseToolStripMenuItem, "CloseToolStripMenuItem")
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        resources.ApplyResources(Me.ExitToolStripMenuItem, "ExitToolStripMenuItem")
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.ToolStripSeparator10, Me.CopyToolStripMenuItem, Me.CutToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ToolStripSeparator3, Me.FindToolStripMenuItem, Me.ReplaceToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        resources.ApplyResources(Me.EditToolStripMenuItem, "EditToolStripMenuItem")
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Image = Global.GabEncodingConverter.My.Resources.Resources.Edit_UndoHS
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        resources.ApplyResources(Me.UndoToolStripMenuItem, "UndoToolStripMenuItem")
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Image = Global.GabEncodingConverter.My.Resources.Resources.Edit_RedoHS
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        resources.ApplyResources(Me.RedoToolStripMenuItem, "RedoToolStripMenuItem")
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        resources.ApplyResources(Me.ToolStripSeparator10, "ToolStripSeparator10")
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = Global.GabEncodingConverter.My.Resources.Resources.CopyHS
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        resources.ApplyResources(Me.CopyToolStripMenuItem, "CopyToolStripMenuItem")
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = Global.GabEncodingConverter.My.Resources.Resources.CutHS
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        resources.ApplyResources(Me.CutToolStripMenuItem, "CutToolStripMenuItem")
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = Global.GabEncodingConverter.My.Resources.Resources.PasteHS
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        resources.ApplyResources(Me.PasteToolStripMenuItem, "PasteToolStripMenuItem")
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        resources.ApplyResources(Me.ToolStripSeparator3, "ToolStripSeparator3")
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Image = Global.GabEncodingConverter.My.Resources.Resources.FindHS
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        resources.ApplyResources(Me.FindToolStripMenuItem, "FindToolStripMenuItem")
        '
        'ReplaceToolStripMenuItem
        '
        Me.ReplaceToolStripMenuItem.Image = Global.GabEncodingConverter.My.Resources.Resources.ActualSizeHS
        Me.ReplaceToolStripMenuItem.Name = "ReplaceToolStripMenuItem"
        resources.ApplyResources(Me.ReplaceToolStripMenuItem, "ReplaceToolStripMenuItem")
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LanguageToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        resources.ApplyResources(Me.OptionsToolStripMenuItem, "OptionsToolStripMenuItem")
        '
        'LanguageToolStripMenuItem
        '
        Me.LanguageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnglishToolStripMenuItem, Me.FrenchToolStripMenuItem})
        Me.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem"
        resources.ApplyResources(Me.LanguageToolStripMenuItem, "LanguageToolStripMenuItem")
        '
        'EnglishToolStripMenuItem
        '
        Me.EnglishToolStripMenuItem.Checked = True
        Me.EnglishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EnglishToolStripMenuItem.Name = "EnglishToolStripMenuItem"
        resources.ApplyResources(Me.EnglishToolStripMenuItem, "EnglishToolStripMenuItem")
        '
        'FrenchToolStripMenuItem
        '
        Me.FrenchToolStripMenuItem.Name = "FrenchToolStripMenuItem"
        resources.ApplyResources(Me.FrenchToolStripMenuItem, "FrenchToolStripMenuItem")
        '
        'FavoritesToolStripMenuItem
        '
        Me.FavoritesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCurrentConversionPairToFavoritesToolStripMenuItem, Me.DeleteFavoritesToolStripMenuItem, Me.EditFavoritesToolStripMenuItem, Me.ToolStripSeparator9})
        Me.FavoritesToolStripMenuItem.Name = "FavoritesToolStripMenuItem"
        resources.ApplyResources(Me.FavoritesToolStripMenuItem, "FavoritesToolStripMenuItem")
        '
        'AddCurrentConversionPairToFavoritesToolStripMenuItem
        '
        Me.AddCurrentConversionPairToFavoritesToolStripMenuItem.Name = "AddCurrentConversionPairToFavoritesToolStripMenuItem"
        resources.ApplyResources(Me.AddCurrentConversionPairToFavoritesToolStripMenuItem, "AddCurrentConversionPairToFavoritesToolStripMenuItem")
        '
        'DeleteFavoritesToolStripMenuItem
        '
        Me.DeleteFavoritesToolStripMenuItem.Name = "DeleteFavoritesToolStripMenuItem"
        resources.ApplyResources(Me.DeleteFavoritesToolStripMenuItem, "DeleteFavoritesToolStripMenuItem")
        '
        'EditFavoritesToolStripMenuItem
        '
        Me.EditFavoritesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditFavoritesToolStripTextBox})
        Me.EditFavoritesToolStripMenuItem.Name = "EditFavoritesToolStripMenuItem"
        resources.ApplyResources(Me.EditFavoritesToolStripMenuItem, "EditFavoritesToolStripMenuItem")
        '
        'EditFavoritesToolStripTextBox
        '
        resources.ApplyResources(Me.EditFavoritesToolStripTextBox, "EditFavoritesToolStripTextBox")
        Me.EditFavoritesToolStripTextBox.Name = "EditFavoritesToolStripTextBox"
        Me.EditFavoritesToolStripTextBox.Text = Global.GabEncodingConverter.My.MySettings.Default.FavoritesConversionPairs
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        resources.ApplyResources(Me.ToolStripSeparator9, "ToolStripSeparator9")
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        resources.ApplyResources(Me.ViewToolStripMenuItem, "ViewToolStripMenuItem")
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserGuideToolStripMenuItem, Me.ToolStripSeparator4, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        resources.ApplyResources(Me.HelpToolStripMenuItem, "HelpToolStripMenuItem")
        '
        'UserGuideToolStripMenuItem
        '
        Me.UserGuideToolStripMenuItem.Image = Global.GabEncodingConverter.My.Resources.Resources.Help
        Me.UserGuideToolStripMenuItem.Name = "UserGuideToolStripMenuItem"
        resources.ApplyResources(Me.UserGuideToolStripMenuItem, "UserGuideToolStripMenuItem")
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        resources.ApplyResources(Me.ToolStripSeparator4, "ToolStripSeparator4")
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        resources.ApplyResources(Me.AboutToolStripMenuItem, "AboutToolStripMenuItem")
        '
        'ofd
        '
        Me.ofd.DefaultExt = "txt"
        resources.ApplyResources(Me.ofd, "ofd")
        Me.ofd.RestoreDirectory = True
        Me.ofd.SupportMultiDottedExtensions = True
        '
        'sfd
        '
        Me.sfd.DefaultExt = "txt"
        resources.ApplyResources(Me.sfd, "sfd")
        Me.sfd.RestoreDirectory = True
        Me.sfd.SupportMultiDottedExtensions = True
        '
        'StatusBar
        '
        resources.ApplyResources(Me.StatusBar, "StatusBar")
        Me.StatusBar.Name = "StatusBar"
        '
        'MainToolStrip
        '
        Me.MainToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonNew, Me.ToolStripButtonOpen, Me.ToolStripSeparator6, Me.ToolStripButtonSave, Me.ToolStripSeparator7, Me.ToolStripButtonUndo, Me.ToolStripButtonRedo, Me.ToolStripSeparator11, Me.ToolStripButtonCopy, Me.ToolStripButtonCut, Me.ToolStripButtonPaste, Me.ToolStripSeparator8, Me.ToolStripButtonFind, Me.ToolStripButtonReplace, Me.ToolStripSeparator12, Me.ToolStripButtonHelp})
        resources.ApplyResources(Me.MainToolStrip, "MainToolStrip")
        Me.MainToolStrip.Name = "MainToolStrip"
        '
        'ToolStripButtonNew
        '
        Me.ToolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonNew.Image = Global.GabEncodingConverter.My.Resources.Resources.NewDocumentHS
        resources.ApplyResources(Me.ToolStripButtonNew, "ToolStripButtonNew")
        Me.ToolStripButtonNew.Name = "ToolStripButtonNew"
        '
        'ToolStripButtonOpen
        '
        Me.ToolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonOpen.Image = Global.GabEncodingConverter.My.Resources.Resources.openHS
        resources.ApplyResources(Me.ToolStripButtonOpen, "ToolStripButtonOpen")
        Me.ToolStripButtonOpen.Name = "ToolStripButtonOpen"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        resources.ApplyResources(Me.ToolStripSeparator6, "ToolStripSeparator6")
        '
        'ToolStripButtonSave
        '
        Me.ToolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonSave.Image = Global.GabEncodingConverter.My.Resources.Resources.saveHS
        resources.ApplyResources(Me.ToolStripButtonSave, "ToolStripButtonSave")
        Me.ToolStripButtonSave.Name = "ToolStripButtonSave"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        resources.ApplyResources(Me.ToolStripSeparator7, "ToolStripSeparator7")
        '
        'ToolStripButtonUndo
        '
        Me.ToolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonUndo.Image = Global.GabEncodingConverter.My.Resources.Resources.Edit_UndoHS
        resources.ApplyResources(Me.ToolStripButtonUndo, "ToolStripButtonUndo")
        Me.ToolStripButtonUndo.Name = "ToolStripButtonUndo"
        '
        'ToolStripButtonRedo
        '
        Me.ToolStripButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonRedo.Image = Global.GabEncodingConverter.My.Resources.Resources.Edit_RedoHS
        resources.ApplyResources(Me.ToolStripButtonRedo, "ToolStripButtonRedo")
        Me.ToolStripButtonRedo.Name = "ToolStripButtonRedo"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        resources.ApplyResources(Me.ToolStripSeparator11, "ToolStripSeparator11")
        '
        'ToolStripButtonCopy
        '
        Me.ToolStripButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonCopy.Image = Global.GabEncodingConverter.My.Resources.Resources.CopyHS
        resources.ApplyResources(Me.ToolStripButtonCopy, "ToolStripButtonCopy")
        Me.ToolStripButtonCopy.Name = "ToolStripButtonCopy"
        '
        'ToolStripButtonCut
        '
        Me.ToolStripButtonCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonCut.Image = Global.GabEncodingConverter.My.Resources.Resources.CutHS
        resources.ApplyResources(Me.ToolStripButtonCut, "ToolStripButtonCut")
        Me.ToolStripButtonCut.Name = "ToolStripButtonCut"
        '
        'ToolStripButtonPaste
        '
        Me.ToolStripButtonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonPaste.Image = Global.GabEncodingConverter.My.Resources.Resources.PasteHS
        resources.ApplyResources(Me.ToolStripButtonPaste, "ToolStripButtonPaste")
        Me.ToolStripButtonPaste.Name = "ToolStripButtonPaste"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        resources.ApplyResources(Me.ToolStripSeparator8, "ToolStripSeparator8")
        '
        'ToolStripButtonFind
        '
        Me.ToolStripButtonFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonFind.Image = Global.GabEncodingConverter.My.Resources.Resources.FindHS
        resources.ApplyResources(Me.ToolStripButtonFind, "ToolStripButtonFind")
        Me.ToolStripButtonFind.Name = "ToolStripButtonFind"
        '
        'ToolStripButtonReplace
        '
        Me.ToolStripButtonReplace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonReplace.Image = Global.GabEncodingConverter.My.Resources.Resources.ActualSizeHS
        resources.ApplyResources(Me.ToolStripButtonReplace, "ToolStripButtonReplace")
        Me.ToolStripButtonReplace.Name = "ToolStripButtonReplace"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        resources.ApplyResources(Me.ToolStripSeparator12, "ToolStripSeparator12")
        '
        'ToolStripButtonHelp
        '
        Me.ToolStripButtonHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonHelp.Image = Global.GabEncodingConverter.My.Resources.Resources.Help
        resources.ApplyResources(Me.ToolStripButtonHelp, "ToolStripButtonHelp")
        Me.ToolStripButtonHelp.Name = "ToolStripButtonHelp"
        '
        'frmMain
        '
        Me.AllowDrop = True
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MainToolStrip)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.MainMenu)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MainMenu
        Me.Name = "frmMain"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.MainToolStrip.ResumeLayout(False)
        Me.MainToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainMenuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FindToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReplaceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LanguageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnglishToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FrenchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserGuideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents StatusBar As System.Windows.Forms.StatusStrip
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents MainToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonCut As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonPaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonFind As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonReplace As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonUndo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonRedo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FavoritesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddCurrentConversionPairToFavoritesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteFavoritesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditFavoritesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditFavoritesToolStripTextBox As System.Windows.Forms.ToolStripTextBox

End Class
