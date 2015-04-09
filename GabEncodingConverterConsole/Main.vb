Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Text

Module Main

    Private sf As String = String.Empty
    Private se As String = String.Empty
    Private df As String = String.Empty
    Private de As String = String.Empty

    Sub Main()

        Dim args(5) As String
        Dim nbArgs As Integer = My.Application.CommandLineArgs.Count
        Dim i As Integer


        If nbArgs = 0 Then
            Help()
        Else
            If My.Application.CommandLineArgs(0) = "-help" OrElse My.Application.CommandLineArgs.Count <> 4 Then
                Help()
                Exit Sub
            End If
            Console.WriteLine("Checking arguments ...")
            For i = 0 To nbArgs - 1
                If Left(My.Application.CommandLineArgs(i).ToString, 3) = "-sf" Then
                    sf = Mid(My.Application.CommandLineArgs(i), 4)
                    Console.WriteLine("Source file : " & sf)
                End If
                If Left(My.Application.CommandLineArgs(i).ToString, 3) = "-se" Then
                    se = Mid(My.Application.CommandLineArgs(i), 4)
                    Console.WriteLine("Source file encoding code : " & se)
                End If
                If Left(My.Application.CommandLineArgs(i).ToString, 3) = "-df" Then
                    df = Mid(My.Application.CommandLineArgs(i), 4)
                    Console.WriteLine("Destination file : " & df)
                End If
                If Left(My.Application.CommandLineArgs(i).ToString, 3) = "-de" Then
                    de = Mid(My.Application.CommandLineArgs(i), 4)
                    Console.WriteLine("Destination file encoding code : " & de)
                End If

            Next
            If sf = String.Empty Or se = String.Empty Or df = String.Empty Or de = String.Empty Then
                Help()
            Else
                DoWork()
            End If
        End If

    End Sub

    Private Sub DoWork()
        Try

            Dim sencoding As Encoding
            Dim dencoding As Encoding
            Dim strInput As String
            Dim strmReader As StreamReader

            If Not File.Exists(sf) Then
                Errors("FILENOTFOUND")
                Exit Sub
            End If

            Try
                sencoding = Encoding.GetEncoding(Convert.ToInt32(se))
            Catch exa As Exception
                Errors("BADSOURCEFILEENCODING")
                Exit Sub
            End Try
            Try
                dencoding = Encoding.GetEncoding(Convert.ToInt32(de))
            Catch exa As Exception
                Errors("BADDESTINATIONFILEENCODING")
                Exit Sub
            End Try

            Console.WriteLine("Reading source file...")
            Console.WriteLine("Specified encoding : " & sencoding.EncodingName)

            strmReader = New StreamReader(sf, sencoding, False)
            strInput = strmReader.ReadToEnd()
            strmReader.Close()

            Console.WriteLine("Writing destination file...")
            Console.WriteLine("Specified encoding : " & dencoding.EncodingName)
            File.WriteAllText(df, strInput, dencoding)

            Console.WriteLine("File " & New FileInfo(sf).Name & " successfuly converted to " & New FileInfo(df).Name & ".")

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub Help()
        Console.WriteLine(vbNewLine)
        Console.WriteLine("GabEncodingConverterConsole")
        Console.WriteLine(vbNewLine)
        Console.WriteLine("Syntax")
        Console.WriteLine("-------------------------------------------------------------------")
        Console.WriteLine("GabEncodingConverterConsole {-help | -sfSourceFile -seSourceFileEncoding -dsDestinationFile -dsDestinationFileEncoding}")
        Console.WriteLine(vbNewLine)
        Console.WriteLine("Description :")
        Console.WriteLine("-------------------------------------------------------------------")
        Console.WriteLine("help (optional) : Display this help.")
        Console.WriteLine("SourceFile : Path of the source file to convert.")
        Console.WriteLine("SourceFileEncoding : an encoding codepage.")
        Console.WriteLine("DestinationFile : Path of the converted file.")
        Console.WriteLine("DestinationFileEncoding : an encoding codepage.")
        Console.WriteLine(vbNewLine)
        Console.WriteLine("Encodings list :")
        Console.WriteLine("Codepage--------Name----------------------------------Description--")
        Console.WriteLine()
        Dim encodings() As System.Text.EncodingInfo
        Dim i As Integer
        encodings = System.Text.Encoding.GetEncodings()
        For i = 0 To encodings.Length - 1
            Console.WriteLine(encodings(i).CodePage.ToString().PadRight(8) & vbTab & encodings(i).DisplayName.PadRight(38) & encodings(i).Name)
        Next
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

End Module
