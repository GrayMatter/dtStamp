'Imports System
Imports System.IO


Module Module1

    Sub Main()
        Dim dateStr As String
        Dim foutStr As String = "datestamp.cmd"
        dateStr = Now.ToString("yyyyMMddHHmmss")
        File.WriteAllText(foutStr, "set datetime=" & dateStr)

    End Sub

End Module
