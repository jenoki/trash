Friend Module Main
	Public Sub Main()
		'Parse Options
		Dim Options As String() = Environment.GetCommandLineArgs()
		Dim TargetFile As String
		If Options.Length = 1 Then
			Console.WriteLine("Usage: {0} <file>", arg0:=My.Application.Info.Title)
			Exit Sub
		End If
		TargetFile = Options.Last

		Try
			My.Computer.FileSystem.DeleteFile(TargetFile,
		  showUI:=FileIO.UIOption.OnlyErrorDialogs,
		  recycle:=FileIO.RecycleOption.SendToRecycleBin)
		Catch ex As Exception
			Console.WriteLine(ex.Message)
			Exit Sub
		End Try

	End Sub

End Module
