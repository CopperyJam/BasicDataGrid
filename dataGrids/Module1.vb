
Imports System.IO
Module Module1
    'used any where in the project
    Public fullPath As String 'path to find file
    Public fileLoc_User As String 'file location for user
    Public securityLevel As String 'level of access across the program

    Public Sub setFileLocations()

        fullPath = Application.StartupPath 'which folder your looking in 

        fileLoc_User = fullPath & "\users.txt" 'finds the exact file 

        If Dir$(fileLoc_User) = "" Then 'to create a new file if it doesn't exists 

            Dim sw As New StreamWriter(fileLoc_User, True)
            sw.WriteLine("1,admin,password,1") 'not a good way no encryption as well
            sw.Close()
            MsgBox("File Created")
        End If

    End Sub


End Module
