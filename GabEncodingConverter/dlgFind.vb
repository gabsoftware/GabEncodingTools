Imports System.Windows.Forms

Public Class dlgFind

    Private tb As TextBox
    Private position As Integer = 0

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find_Button.Click
        'Me.DialogResult = System.Windows.Forms.DialogResult.OK
        'Me.Close()

        Dim pos As Integer

        If txtFind.Text <> String.Empty Then

            If rbUp.Checked And position = 0 Then
                position = tb.Text.Length - 1
            End If

            If rbDown.Checked Then
                pos = SearchText(tb, txtFind.Text, position, 0, True, chkMatchCase.Checked, False)
            Else
                pos = SearchText(tb, txtFind.Text, position, 0, True, chkMatchCase.Checked, True)
            End If


            If pos > -1 Then
                If rbDown.Checked Then
                    position = pos + 1
                Else
                    position = pos - 1
                End If
            Else
                If rbDown.Checked Then
                    position = 0
                Else
                    position = tb.Text.Length - 1
                End If

                Microsoft.VisualBasic.Beep()
            End If

        End If


    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dlgFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.txtFind.Focus()

    End Sub

    Public Sub New(ByVal thisTextBox As TextBox)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        tb = thisTextBox
        Me.txtFind.Focus()

    End Sub


    Public Overloads Function SearchText(ByRef txtbox As TextBox, ByVal textToFind As String, Optional ByVal startPosition As Integer = 0, Optional ByVal endPosition As Integer = 0, Optional ByVal highlightText As Boolean = True, Optional ByVal matchCase As Boolean = False, Optional ByVal SearchUp As Boolean = False) As Integer

        'Contains the return value of the search. IT it returns -1, then a match was not found.
        Dim i As Integer
        Dim temp As String

        If startPosition < 0 Then
            i = -1
        Else
            If endPosition < 1 Then
                If Not matchCase Then
                    textToFind = textToFind.ToLower
                    temp = txtbox.Text.ToLower
                Else
                    temp = txtbox.Text
                End If
                If SearchUp Then
                    i = temp.LastIndexOf(textToFind, startPosition, startPosition + 1)
                Else
                    i = temp.IndexOf(textToFind, startPosition, txtbox.Text.Length - startPosition)
                End If
            Else
                If matchCase = False Then
                    textToFind = textToFind.ToLower
                    temp = txtbox.Text.ToLower
                Else
                    temp = txtbox.Text
                End If
                If SearchUp Then
                    i = temp.LastIndexOf(textToFind, startPosition, startPosition - endPosition)
                Else
                    i = temp.IndexOf(textToFind, startPosition, endPosition)
                End If
            End If
            If i > -1 Then
                If highlightText Then
                    txtbox.Focus()
                    txtbox.SelectionStart = i
                    txtbox.SelectionLength = textToFind.Length
                End If
                txtbox.ScrollToCaret()
            End If
        End If

        'Returns the position the text was found at, otherwise it will report -1, which means that the search string was not found.
        Return i

    End Function

    Private Sub txtFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFind.TextChanged
        Try
            If rbDown.Checked Then
                position = 0
            Else
                position = tb.Text.Length - 1
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub rbUp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbUp.CheckedChanged
        Try
            If rbDown.Checked Then
                If position >= tb.Text.Length - 1 Then
                    position = 0
                End If
            Else
                If position <= 0 Then
                    position = tb.Text.Length - 1
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub rbDown_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbDown.CheckedChanged
        Try
            If rbDown.Checked Then
                If position >= tb.Text.Length - 1 Then
                    position = 0
                End If
            Else
                If position <= 0 Then
                    position = tb.Text.Length - 1
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class
