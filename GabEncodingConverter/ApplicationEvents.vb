Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup

            Dim n As Integer
            n = e.CommandLine.Count

            If n > 0 Then
                GabEncodingConverter.frmMain.argument = e.CommandLine(0)
            End If

        End Sub


        Private Sub MyApplication_StartupNextInstance(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance

            Dim n As Integer
            n = e.CommandLine.Count

            If n > 0 Then
                GabEncodingConverter.frmMain.OnNewInstance(e.CommandLine(0))
            End If


        End Sub
    End Class

End Namespace

