Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Text
Imports System.Globalization
Imports GabSoftware.Utils

Public Class frmFile

    Private sf As String = String.Empty 'source file
    Private se As System.Text.Encoding  'source encoding
    Private df As String = String.Empty 'destination file
    Private de As System.Text.Encoding  'destination encoding

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal this_sf As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.sf = this_sf
        Me.Text = New FileInfo(Me.sf).Name

    End Sub

    Private Sub frmFile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.MdiParent = My.Forms.frmMain
        Me.txts.Parent = Me.gpinput
        Me.txtd.Parent = Me.gpoutput

        LoadComboBoxesEncodings()

        If sf.Length > 0 Then
            Me.se = FindBestEncodingForFile(sf)
            Me.de = Encoding.GetEncoding(se.CodePage)
            DoWorkFile()
        Else
            Me.se = System.Text.Encoding.Default
            Me.de = System.Text.Encoding.Default
        End If

        Me.cbse.SelectedValue = Me.se.CodePage
        Me.cbde.SelectedValue = Me.de.CodePage


    End Sub

    Private Sub mainPanel_Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles mainPanel.Layout
        gpoutput.Width = mainPanel.Width \ 2
    End Sub

    Private Sub LoadComboBoxesEncodings()

        Dim encodings() As System.Text.EncodingInfo
        'Dim sortedEncodings As sortedArray

        Dim item As cbItem
        Dim i As Integer

        encodings = System.Text.Encoding.GetEncodings()

        CbItemBindingSourceSe.SuspendBinding()
        CbItemBindingSourceDe.SuspendBinding()

        CbItemBindingSourceSe.RaiseListChangedEvents = False
        CbItemBindingSourceDe.RaiseListChangedEvents = False

        Me.cbse.BeginUpdate()
        Me.cbde.BeginUpdate()

        For i = 0 To encodings.Length - 1
            item = New cbItem(encodings(i).CodePage, encodings(i).CodePage.ToString().PadRight(7) & encodings(i).DisplayName.PadRight(38) & encodings(i).Name)

            CbItemBindingSourceSe.Add(item)
            CbItemBindingSourceDe.Add(item)
        Next

        Me.cbse.EndUpdate()
        Me.cbde.EndUpdate()

        CbItemBindingSourceSe.RaiseListChangedEvents = True
        CbItemBindingSourceDe.RaiseListChangedEvents = True

        CbItemBindingSourceSe.ResumeBinding()
        CbItemBindingSourceDe.ResumeBinding()

    End Sub

    ''' <summary>
    ''' Travaille bien
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DoWorkFile()
        Try
            Dim strInput As String
            Dim strmReader As StreamReader
            Dim strOutput As String

            strmReader = New StreamReader(sf, se, False)
            strInput = strmReader.ReadToEnd()
            strmReader.Close()
            strmReader.Dispose()

            strOutput = Me.EncodeString(strInput, se, de)

            Me.txts.Text = strInput
            Me.txtd.Text = strOutput


        Catch ex As Exception

        End Try
    End Sub

    ''' <summary>
    ''' Travaille bien
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DoWorkTxt()
        Try
            Dim strInput As String
            Dim strmReader As StreamReader
            Dim memStrm As MemoryStream
            Dim strOutput As String

            'strmReader = New StreamReader(sf, se, False)

            memStrm = New MemoryStream(Encoding.UTF8.GetBytes(txts.Text))
            strmReader = New StreamReader(memStrm, se, False)
            strInput = strmReader.ReadToEnd()
            strmReader.Close()
            strmReader.Dispose()

            strOutput = Me.EncodeString(strInput, se, de)

            'Me.txts.Text = strInput
            Me.txtd.Text = strOutput


        Catch ex As Exception

        End Try
    End Sub


    Private Sub Errors(ByVal strError As String)

        Select Case strError
            Case "FILENOTFOUND"
                Console.WriteLine("The source file can't be found. Please check its path and try again.")
            Case "BADSOURCEFILEENCODING"
                Console.WriteLine("Invalid source file encoding codepage")
            Case "BADDESTINATIONFILEENCODING"
                Console.WriteLine("Invalid destination file encoding codepage")
        End Select

    End Sub

    ''' <summary>
    ''' Convertit une chaine d'un encodage à un autre.
    ''' </summary>
    ''' <param name="SourceString"></param>
    ''' <param name="senc"></param>
    ''' <param name="denc"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function EncodeString(ByVal SourceString As String, ByVal senc As Encoding, ByVal denc As Encoding) As String
        'get a byte pointer To the source data
        Dim bsourcedata As Byte() = senc.GetBytes(SourceString)

        'Encode the data To destination code page/charset
        Dim b As Byte() = System.Text.Encoding.Convert(senc, denc, bsourcedata)

        'return the converted string
        Return denc.GetString(b)

    End Function

    Private Sub cbse_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbse.SelectedValueChanged

        Try
            se = System.Text.Encoding.GetEncoding(DirectCast(Me.cbse.SelectedValue, Int32))
        Catch
            se = Encoding.Default
        End Try

        If sf.Length > 0 Then
            DoWorkFile()
        ElseIf txts.Text <> String.Empty Then
            DoWorkTxt()
        End If


    End Sub


    Private Sub cbde_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbde.SelectedValueChanged
        Try
            de = System.Text.Encoding.GetEncoding(DirectCast(Me.cbde.SelectedValue, Int32))
        Catch
            de = Encoding.Default
        End Try

        If sf.Length > 0 Then
            DoWorkFile()
        ElseIf txts.Text <> String.Empty Then
            DoWorkTxt()
        End If
    End Sub

    ''' <summary>
    ''' Cherche et trouve l'encoding le plus probable pour un fichier.
    ''' </summary>
    ''' <param name="file"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function FindBestEncodingForFile(ByVal file As String) As Encoding

        Dim targetEncoding As Encoding
        Dim fileContent As Byte()
        fileContent = System.IO.File.ReadAllBytes(file)
        targetEncoding = EncodingTools.DetectInputCodepage(fileContent)
        Return targetEncoding

    End Function

    ''' <summary>
    ''' Cherche et trouve l'encoding le plus probable pour une chaine de caractères.
    ''' </summary>
    ''' <param name="txt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function FindBestEncodingForText(ByVal txt As String) As Encoding

        Dim targetEncoding As Encoding
        Dim txtContent As Byte()
        txtContent = Encoding.UTF8.GetBytes(txt)
        targetEncoding = EncodingTools.DetectInputCodepage(txtContent)
        Return targetEncoding

    End Function

    Friend Sub Save()

        File.Delete(sf & ".old")
        File.Copy(sf, sf & ".old")
        Dim strmw As New StreamWriter(sf, False, de)
        strmw.Write(Me.txts.Text)
        strmw.Close()
        strmw.Dispose()

    End Sub

    Friend Sub SaveAs(ByVal path As String)

        Me.sf = path
        If Not File.Exists(sf) Then
            File.Create(sf).Close()
        End If
        Me.Save()

        My.Forms.frmMain.currentWindow = New frmFile(sf)
        My.Forms.frmMain.currentWindow.Show()

    End Sub

    Private Sub txts_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txts.TextChanged

        If txts.Text <> String.Empty Then
            'Me.se = FindBestEncodingForText(txts.Text)
            'Me.de = Encoding.GetEncoding(se.CodePage)
            DoWorkTxt()
        Else
            'Me.se = System.Text.Encoding.Default
            'Me.de = System.Text.Encoding.Default
        End If

        'Me.cbse.SelectedValue = Me.se.CodePage
        'Me.cbde.SelectedValue = Me.de.CodePage


    End Sub

End Class