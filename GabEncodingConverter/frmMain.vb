Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Text
Imports System.Globalization

Public Class frmMain

    Private frmNew As frmFile
    Private EnglishCulture As New CultureInfo("en-US")
    Private FrenchCulture As New CultureInfo("fr-FR")
    Friend currentWindow As frmFile
    Public Shared argument As String = String.Empty

    Private Sub frmMain_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim MyFiles() As String

            ' Assign the files to an array.
            MyFiles = e.Data.GetData(DataFormats.FileDrop)
            ManageDragDrop(MyFiles)

        End If
    End Sub

    Private Sub frmMain_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub


    Private Sub ManageDragDrop(ByVal fileList() As String)

        Dim i As Integer

        ' Loop through the array and add the files to the list.
        For i = 0 To fileList.Length - 1

            Me.currentWindow = New frmFile(fileList(i))
            Me.currentWindow.Show()

        Next

    End Sub


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources.Note

        If My.Settings.PreferedUICulture <> String.Empty Then
            UpdateUICulture(New CultureInfo(My.Settings.PreferedUICulture))
        End If

        Select Case My.Application.Culture.TwoLetterISOLanguageName
            Case "fr"
                Me.FrenchToolStripMenuItem.Checked = True
                Me.EnglishToolStripMenuItem.Checked = False
            Case "en"
                Me.FrenchToolStripMenuItem.Checked = False
                Me.EnglishToolStripMenuItem.Checked = True
        End Select

        Me.RefreshFavoritesMenu()

        If argument = String.Empty Then
            frmNew = New frmFile()
            frmNew.Show()
            Me.currentWindow = frmNew
        Else
            Me.currentWindow = New frmFile(argument)
            Me.currentWindow.Show()
        End If

    End Sub

    Public Sub OnNewInstance(ByVal arg As String)

        argument = arg
        Me.currentWindow = New frmFile(argument)
        Me.currentWindow.Show()

    End Sub

    Private Sub EnglishToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnglishToolStripMenuItem.Click

        Me.EnglishToolStripMenuItem.Checked = True
        Me.FrenchToolStripMenuItem.Checked = False

        UpdateUICulture(Me.EnglishCulture)

    End Sub

    Private Sub FrenchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrenchToolStripMenuItem.Click

        Me.EnglishToolStripMenuItem.Checked = False
        Me.FrenchToolStripMenuItem.Checked = True

        UpdateUICulture(Me.FrenchCulture)

    End Sub


    Private Sub UpdateUICulture(ByVal thisCulture As CultureInfo)

        System.Threading.Thread.CurrentThread.CurrentUICulture = thisCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = thisCulture

        'Main window
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))

        resources.ApplyResources(Me.MainMenu, "MainMenu")
        resources.ApplyResources(Me.MainMenuFile, "MainMenuFile")
        resources.ApplyResources(Me.NewToolStripMenuItem, "NewToolStripMenuItem")
        resources.ApplyResources(Me.OpenToolStripMenuItem, "OpenToolStripMenuItem")
        resources.ApplyResources(Me.ToolStripSeparator5, "ToolStripSeparator5")
        resources.ApplyResources(Me.SaveToolStripMenuItem, "SaveToolStripMenuItem")
        resources.ApplyResources(Me.SaveasToolStripMenuItem, "SaveasToolStripMenuItem")
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        resources.ApplyResources(Me.CloseToolStripMenuItem, "CloseToolStripMenuItem")
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        resources.ApplyResources(Me.ExitToolStripMenuItem, "ExitToolStripMenuItem")
        resources.ApplyResources(Me.EditToolStripMenuItem, "EditToolStripMenuItem")
        resources.ApplyResources(Me.UndoToolStripMenuItem, "UndoToolStripMenuItem")
        resources.ApplyResources(Me.RedoToolStripMenuItem, "RedoToolStripMenuItem")
        resources.ApplyResources(Me.ToolStripSeparator10, "ToolStripSeparator10")
        resources.ApplyResources(Me.CopyToolStripMenuItem, "CopyToolStripMenuItem")
        resources.ApplyResources(Me.CutToolStripMenuItem, "CutToolStripMenuItem")
        resources.ApplyResources(Me.PasteToolStripMenuItem, "PasteToolStripMenuItem")
        resources.ApplyResources(Me.ToolStripSeparator3, "ToolStripSeparator3")
        resources.ApplyResources(Me.FindToolStripMenuItem, "FindToolStripMenuItem")
        resources.ApplyResources(Me.ReplaceToolStripMenuItem, "ReplaceToolStripMenuItem")
        resources.ApplyResources(Me.OptionsToolStripMenuItem, "OptionsToolStripMenuItem")
        resources.ApplyResources(Me.LanguageToolStripMenuItem, "LanguageToolStripMenuItem")
        resources.ApplyResources(Me.EnglishToolStripMenuItem, "EnglishToolStripMenuItem")
        resources.ApplyResources(Me.FrenchToolStripMenuItem, "FrenchToolStripMenuItem")
        resources.ApplyResources(Me.FavoritesToolStripMenuItem, "FavoritesToolStripMenuItem")
        resources.ApplyResources(Me.AddCurrentConversionPairToFavoritesToolStripMenuItem, "AddCurrentConversionPairToFavoritesToolStripMenuItem")
        resources.ApplyResources(Me.DeleteFavoritesToolStripMenuItem, "DeleteFavoritesToolStripMenuItem")
        resources.ApplyResources(Me.EditFavoritesToolStripMenuItem, "EditFavoritesToolStripMenuItem")
        resources.ApplyResources(Me.EditFavoritesToolStripTextBox, "EditFavoritesToolStripTextBox")
        resources.ApplyResources(Me.ToolStripSeparator9, "ToolStripSeparator9")
        resources.ApplyResources(Me.ViewToolStripMenuItem, "ViewToolStripMenuItem")
        resources.ApplyResources(Me.HelpToolStripMenuItem, "HelpToolStripMenuItem")
        resources.ApplyResources(Me.UserGuideToolStripMenuItem, "UserGuideToolStripMenuItem")
        resources.ApplyResources(Me.ToolStripSeparator4, "ToolStripSeparator4")
        resources.ApplyResources(Me.AboutToolStripMenuItem, "AboutToolStripMenuItem")
        resources.ApplyResources(Me.ofd, "ofd")
        resources.ApplyResources(Me.sfd, "sfd")
        resources.ApplyResources(Me.StatusBar, "StatusBar")
        resources.ApplyResources(Me.MainToolStrip, "MainToolStrip")
        resources.ApplyResources(Me.ToolStripButtonNew, "ToolStripButtonNew")
        resources.ApplyResources(Me.ToolStripButtonOpen, "ToolStripButtonOpen")
        resources.ApplyResources(Me.ToolStripSeparator6, "ToolStripSeparator6")
        resources.ApplyResources(Me.ToolStripButtonSave, "ToolStripButtonSave")
        resources.ApplyResources(Me.ToolStripSeparator7, "ToolStripSeparator7")
        resources.ApplyResources(Me.ToolStripButtonUndo, "ToolStripButtonUndo")
        resources.ApplyResources(Me.ToolStripButtonRedo, "ToolStripButtonRedo")
        resources.ApplyResources(Me.ToolStripSeparator11, "ToolStripSeparator11")
        resources.ApplyResources(Me.ToolStripButtonCopy, "ToolStripButtonCopy")
        resources.ApplyResources(Me.ToolStripButtonCut, "ToolStripButtonCut")
        resources.ApplyResources(Me.ToolStripButtonPaste, "ToolStripButtonPaste")
        resources.ApplyResources(Me.ToolStripSeparator8, "ToolStripSeparator8")
        resources.ApplyResources(Me.ToolStripButtonFind, "ToolStripButtonFind")
        resources.ApplyResources(Me.ToolStripButtonReplace, "ToolStripButtonReplace")
        resources.ApplyResources(Me.ToolStripSeparator12, "ToolStripSeparator12")
        resources.ApplyResources(Me.ToolStripButtonHelp, "ToolStripButtonHelp")
        resources.ApplyResources(Me, "$this")

        'frmFile windows
        resources = New System.ComponentModel.ComponentResourceManager(GetType(frmFile))
        Dim caption As String = String.Empty
        For Each document As frmFile In Me.MdiChildren
            caption = document.Text
            resources.ApplyResources(document.gpinput, "gpinput")
            resources.ApplyResources(document.txts, "txts")
            resources.ApplyResources(document.Label1, "Label1")
            resources.ApplyResources(document.cbse, "cbse")
            resources.ApplyResources(document.gpoutput, "gpoutput")
            resources.ApplyResources(document.txtd, "txtd")
            resources.ApplyResources(document.Label2, "Label2")
            resources.ApplyResources(document.cbde, "cbde")
            resources.ApplyResources(document.mainPanel, "mainPanel")
            resources.ApplyResources(document, "$this")
            document.Text = caption
        Next


        My.Settings.PreferedUICulture = thisCulture.Name

    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click

        Dim dr As DialogResult
        dr = Me.ofd.ShowDialog()
        If dr = Windows.Forms.DialogResult.OK Then
            Me.currentWindow = New frmFile(ofd.FileName)
            Me.currentWindow.Show()
        End If

    End Sub

    
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()

    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click

        frmNew = New frmFile()
        frmNew.Show()
        Me.currentWindow = frmNew

    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click

        If Me.currentWindow IsNot Nothing Then
            Me.currentWindow.Close()
        End If

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click

        If Me.currentWindow IsNot Nothing Then
            Me.currentWindow.Save()
        End If

    End Sub

    Private Sub frmMain_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MdiChildActivate

        Me.currentWindow = Me.ActiveMdiChild

    End Sub

    Private Sub SaveasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveasToolStripMenuItem.Click

        If Me.currentWindow IsNot Nothing Then
            Dim dr As DialogResult
            dr = Me.sfd.ShowDialog()
            If dr = Windows.Forms.DialogResult.OK Then
                Me.currentWindow.SaveAs(sfd.FileName)
            End If
        End If

    End Sub

    Private Sub ToolStripButtonNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonNew.Click
        Me.NewToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ToolStripButtonOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonOpen.Click
        Me.OpenToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ToolStripButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonSave.Click
        Me.SaveToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub ToolStripButtonCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonCopy.Click
        Copy()
    End Sub

    Private Sub ToolStripButtonCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonCut.Click
        Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Copy()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        Cut()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        Paste()
    End Sub

    Private Sub FindToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindToolStripMenuItem.Click
        Find()
    End Sub

    Private Sub ReplaceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplaceToolStripMenuItem.Click
        Replace()
    End Sub

    Private Sub UserGuideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserGuideToolStripMenuItem.Click
        ShowHelp()
    End Sub

    Private Sub ToolStripButtonPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonPaste.Click
        Paste()
    End Sub

    Private Sub ToolStripButtonFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonFind.Click
        Find()
    End Sub

    Private Sub ToolStripButtonReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonReplace.Click
        Replace()
    End Sub

    Private Sub ToolStripButtonHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonHelp.Click
        ShowHelp()
    End Sub

    Private Sub Copy()

        If Me.currentWindow IsNot Nothing Then
            If Me.currentWindow.txts.Focused Then
                Me.currentWindow.txts.Copy()
            End If
            If Me.currentWindow.txtd.Focused Then
                Me.currentWindow.txtd.Copy()
            End If
        End If

    End Sub

    Private Sub Cut()

        If Me.currentWindow IsNot Nothing Then
            If Me.currentWindow.txts.Focused Then
                Me.currentWindow.txts.Cut()
            End If
            If Me.currentWindow.txtd.Focused Then
                Me.currentWindow.txtd.Cut()
            End If
        End If

    End Sub

    Private Sub Paste()
        Try
            If Me.currentWindow.txts.Focused Then
                Me.currentWindow.txts.Paste()
            End If
            If Me.currentWindow.txtd.Focused Then
                Me.currentWindow.txtd.Paste()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Find()
        Dim f As dlgFind = Nothing

        If Me.currentWindow IsNot Nothing Then
            If Me.currentWindow.txts.Focused Then
                f = New dlgFind(Me.currentWindow.txts)
            ElseIf Me.currentWindow.txtd.Focused Then
                f = New dlgFind(Me.currentWindow.txtd)
            Else
                Me.currentWindow.txts.Focus()
                f = New dlgFind(Me.currentWindow.txts)
            End If

            If f IsNot Nothing Then
                f.Show()
            End If
        End If

    End Sub

    Private Sub Replace()
        Dim f As dlgFindReplace = Nothing

        If Me.currentWindow IsNot Nothing Then
            If Me.currentWindow.txts.Focused Then
                f = New dlgFindReplace(Me.currentWindow.txts)
            ElseIf Me.currentWindow.txtd.Focused Then
                f = New dlgFindReplace(Me.currentWindow.txtd)
            Else
                Me.currentWindow.txts.Focus()
                f = New dlgFindReplace(Me.currentWindow.txts)
            End If

            If f IsNot Nothing Then
                f.Show()
            End If
        End If

    End Sub

    Private Sub ShowHelp()
        Help.ShowHelp(Me, Application.StartupPath & "\GabEncodingToolsHelp.chm")
    End Sub

    Private Sub Undo()

        If Me.currentWindow IsNot Nothing Then
            If Me.currentWindow.txts.Focused And Me.currentWindow.txts.CanUndo Then
                Me.currentWindow.txts.Undo()
            End If
            If Me.currentWindow.txtd.Focused And Me.currentWindow.txtd.CanUndo Then
                Me.currentWindow.txtd.Undo()
            End If
        End If

    End Sub

    Private Sub Redo()

        If Me.currentWindow IsNot Nothing Then
            If Me.currentWindow.txts.Focused And Me.currentWindow.txts.CanUndo Then
                Me.currentWindow.txts.Undo()
            End If
            If Me.currentWindow.txtd.Focused And Me.currentWindow.txtd.CanUndo Then
                Me.currentWindow.txtd.Undo()
            End If
        End If

    End Sub


    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        Redo()
    End Sub

    Private Sub ToolStripButtonUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonUndo.Click
        Undo()
    End Sub

    Private Sub ToolStripButtonRedo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonRedo.Click
        Redo()
    End Sub

    Private Sub AddCurrentConversionPairToFavoritesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCurrentConversionPairToFavoritesToolStripMenuItem.Click
        Dim favorite As String = String.Empty

        Try
            If Me.currentWindow IsNot Nothing Then
                favorite = Me.currentWindow.cbse.SelectedValue & ":" & Me.currentWindow.cbde.SelectedValue
                If My.Settings.FavoritesConversionPairs <> String.Empty Then
                    If Not My.Settings.FavoritesConversionPairs.Contains(favorite) Then
                        My.Settings.FavoritesConversionPairs &= ";" & favorite
                    End If
                Else
                    My.Settings.FavoritesConversionPairs = favorite
                End If

                RefreshFavoritesMenu()

            End If
        Catch ex As Exception


        End Try
    End Sub

    Friend Sub RefreshFavoritesMenu()

        Dim tsmi As ToolStripMenuItem
        Dim favlist As String = My.Settings.FavoritesConversionPairs
        Dim favs() As String = New String() {}
        Dim fav As String
        Dim encs() As String = New String() {}
        Dim se As Integer
        Dim de As Integer
        Dim text As String
        Dim name As String
        Dim itm As ToolStripItem
        Dim nb As Integer
        Dim ft As System.Drawing.Font = New System.Drawing.Font("Lucida Console", 9, System.Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)

        'we don't use a foreach as the code modifies the items collection
        nb = Me.FavoritesToolStripMenuItem.DropDownItems.Count
        For i As Integer = nb - 1 To 0 Step -1
            itm = Me.FavoritesToolStripMenuItem.DropDownItems(i)
            If itm.Name.Contains("tsmi") Then
                Me.FavoritesToolStripMenuItem.DropDownItems.Remove(itm)
            End If
        Next

        If favlist Is Nothing OrElse favlist = String.Empty Then
            Exit Sub
        End If

        Me.EditFavoritesToolStripTextBox.Text = My.Settings.FavoritesConversionPairs

        favs = favlist.Split(";")
        nb = 0
        For Each fav In favs
            Array.Clear(encs, 0, encs.Length)
            encs = fav.Split(":")
            se = Convert.ToInt32(encs(0))
            de = Convert.ToInt32(encs(1))

            text = encs(0).PadRight(6) & Encoding.GetEncoding(se).EncodingName.PadRight(37) & " --> " & encs(1).PadRight(6) & Encoding.GetEncoding(de).EncodingName
            name = "tsmi_" & se & "_" & de

            tsmi = New ToolStripMenuItem(text, Nothing, AddressOf Me.ThisFavoriteToolStripMenuItem_Click, name)
            tsmi.Tag = se & ":" & de
            tsmi.Font = ft

            nb += 1
            If nb < 11 Then 'avoid to enter the switch
                Select Case nb
                    Case 1 : tsmi.ShortcutKeys = Keys.Control Or Keys.NumPad1
                    Case 2 : tsmi.ShortcutKeys = Keys.Control Or Keys.NumPad2
                    Case 3 : tsmi.ShortcutKeys = Keys.Control Or Keys.NumPad3
                    Case 4 : tsmi.ShortcutKeys = Keys.Control Or Keys.NumPad4
                    Case 5 : tsmi.ShortcutKeys = Keys.Control Or Keys.NumPad5
                    Case 6 : tsmi.ShortcutKeys = Keys.Control Or Keys.NumPad6
                    Case 7 : tsmi.ShortcutKeys = Keys.Control Or Keys.NumPad7
                    Case 8 : tsmi.ShortcutKeys = Keys.Control Or Keys.NumPad8
                    Case 9 : tsmi.ShortcutKeys = Keys.Control Or Keys.NumPad9
                    Case 10 : tsmi.ShortcutKeys = Keys.Control Or Keys.NumPad0
                End Select
            End If

            FavoritesToolStripMenuItem.DropDownItems.Add(tsmi)

        Next
        Array.Clear(favs, 0, favs.Length)
        ft.Dispose()


    End Sub

    Private Sub ThisFavoriteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim pairs() As String

        If Me.currentWindow IsNot Nothing Then
            pairs = DirectCast(DirectCast(sender, ToolStripMenuItem).Tag, String).Split(":")
            Me.currentWindow.cbse.SelectedValue = Convert.ToInt32(pairs(0))
            Me.currentWindow.cbde.SelectedValue = Convert.ToInt32(pairs(1))
        End If

    End Sub

    Private Sub DeleteFavoritesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteFavoritesToolStripMenuItem.Click

        My.Settings.FavoritesConversionPairs = ""
        Me.RefreshFavoritesMenu()

    End Sub

    Private Sub EditFavoritesToolStripTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles EditFavoritesToolStripTextBox.GotFocus
        EditFavoritesToolStripTextBox.Text = My.Settings.FavoritesConversionPairs
    End Sub

    Private Sub EditFavoritesToolStripTextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles EditFavoritesToolStripTextBox.KeyUp
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Return Then
            Try
                My.Settings.FavoritesConversionPairs = EditFavoritesToolStripTextBox.Text
                Me.RefreshFavoritesMenu()
                My.Settings.Save()
            Catch ex As Exception
                My.Settings.Reload()
                Me.RefreshFavoritesMenu()
            End Try

        End If
    End Sub

End Class
