
Imports System.IO

Public Class Form1

    Dim lineCount As Integer
    Dim newUserid As String
    Dim rowindex As Integer 'keeps track of current row in datagrid

    Private Sub firstSelected() 'for the first row on the data grid 

        rowindex = 0



        txt_userID.Text = dgv_users.Rows(rowindex).Cells(0).Value 'replaces text boxes with the each collom
        txt_userName.Text = dgv_users.Rows(rowindex).Cells(1).Value
        txt_passWord.Text = dgv_users.Rows(rowindex).Cells(2).Value
        txt_levelSecurity.Text = dgv_users.Rows(rowindex).Cells(3).Value

        dgv_users.ClearSelection()
        dgv_users.Rows(rowindex).Selected = True

    End Sub

    Private Sub lastSelected()

        rowindex = lineCount - 1 'we count from zero so we need to subtrack -1 

        txt_userID.Text = dgv_users.Rows(rowindex).Cells(0).Value 'replaces text boxes with the each collom
        txt_userName.Text = dgv_users.Rows(rowindex).Cells(1).Value
        txt_passWord.Text = dgv_users.Rows(rowindex).Cells(2).Value
        txt_levelSecurity.Text = dgv_users.Rows(rowindex).Cells(3).Value

        dgv_users.ClearSelection()
        dgv_users.Rows(rowindex).Selected = True

    End Sub

    Private Sub previousSelected()

        If rowindex > 0 Then

            rowindex = rowindex - 1 'if it was two it now becomes 1

        Else 'so if its less than 0

            MsgBox("Already at the start you twat")

        End If

        txt_userID.Text = dgv_users.Rows(rowindex).Cells(0).Value 'replaces text boxes with the each collom
        txt_userName.Text = dgv_users.Rows(rowindex).Cells(1).Value
        txt_passWord.Text = dgv_users.Rows(rowindex).Cells(2).Value
        txt_levelSecurity.Text = dgv_users.Rows(rowindex).Cells(3).Value

        dgv_users.ClearSelection()
        dgv_users.Rows(rowindex).Selected = True


    End Sub

    Private Sub nextSelected()

        If rowindex < (lineCount - 1) Then

            rowindex = rowindex + 1
        Else

            MsgBox("Your Already at Maximum")

        End If

        txt_userID.Text = dgv_users.Rows(rowindex).Cells(0).Value 'replaces text boxes with the each collom
        txt_userName.Text = dgv_users.Rows(rowindex).Cells(1).Value
        txt_passWord.Text = dgv_users.Rows(rowindex).Cells(2).Value
        txt_levelSecurity.Text = dgv_users.Rows(rowindex).Cells(3).Value

        dgv_users.ClearSelection()
        dgv_users.Rows(rowindex).Selected = True

    End Sub


    Private Sub fillGrid() 'seprate private sub so that we can call it up later 

        dgv_users.Rows.Clear() 'clears rows


        lineCount = File.ReadAllLines(fileLoc_User).Length 'reads all the lines of the file 

        Dim sr As New StreamReader(fileLoc_User)
        Dim oneLine As String
        Dim oneUser() As String 'so that we can store it as an array 

        While sr.Peek() >= 0 'top of text file aslong as it has a value greater than one it will contine till the end of the file once 0 = 0

            oneLine = sr.ReadLine() 'reads the line from the fileLoc_User
            oneUser = oneLine.Split(",") 'gets rid of the commers and splits the word at these points

            Dim index = dgv_users.Rows.Add 'allows a row to be added 
            dgv_users.Rows(index).SetValues(oneUser) 'create rows to the the sr.peek value , index is always set to 0 


        End While 'end the while once the value of sr.peek = 0

        sr.Close() 'closes the file so it can be opened again

        dgv_users.RowHeadersVisible = False ' hides the row name 

    End Sub



    Private Sub setButtons()

        btn_saveChanges.Enabled = True 'shows buttons
        btn_addNew.Enabled = True
        btn_deleteCurrentUser.Enabled = True
        btn_saveNew.Enabled = False ' hides this button

        btn_first.Enabled = True
        btn_last.Enabled = True
        btn_next.Enabled = True
        btn_previous.Enabled = True


    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        firstSelected()
        setFileLocations() 'loads private and public subs
        setButtons()
        fillGrid()



    End Sub



    Private Sub btn_addNew_Click(sender As Object, e As EventArgs) Handles btn_addNew.Click
        
        btn_saveNew.Enabled = True
        Dim max As Integer = -1 'always set to a small value for this algthym
        Dim counter As Integer

        'change the status of buttons
        For counter = 0 To (lineCount - 1) ' counter goes up to last number 

            If dgv_users.Rows(counter).Cells(0).Value > max Then 'cell = first collom for userID exceeds the max value it will contine untill the counter value is the less than max 

                max = dgv_users.Rows(counter).Cells(0).Value ' this sets the max value to the current counter value of this if so if counter is 0 which is larger than -1 the max value is then set to 0 for the next number

            End If

        Next


        newUserid = max + 1
        txt_userID.Text = newUserid

    End Sub

    Private Sub btn_saveNew_Click(sender As Object, e As EventArgs) Handles btn_saveNew.Click

        'saves the file to the current list and refils the grid

        Dim newUserMain As String
        Dim newUserName As String
        Dim newPasswordv As String
        Dim newSLevelv As Integer

        newUserName = txt_userName.Text
        newPasswordv = txt_passWord.Text 'use encryption here
        newSLevelv = Val(txt_levelSecurity.Text)

        newUserMain = newUserid & "," & newUserName & "," & newPasswordv & "," & newSLevelv

        Dim sw As New StreamWriter(fileLoc_User, True)

        sw.WriteLine(newUserMain)
        sw.Close()

        btn_saveNew.Enabled = False

        fillGrid()

    End Sub

    Private Sub btn_first_Click(sender As Object, e As EventArgs) Handles btn_first.Click

        'first in list

        firstSelected()



    End Sub

    Private Sub btn_last_Click(sender As Object, e As EventArgs) Handles btn_last.Click

        'last in list

        lastSelected()



    End Sub

    Private Sub btn_previous_Click(sender As Object, e As EventArgs) Handles btn_previous.Click 'more complex than last and first

        'previous in list

        previousSelected()



    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click 'more complex than last and first

        'btn next in list

        nextSelected()



    End Sub

    Private Sub btn_deleteCurrentUser_Click(sender As Object, e As EventArgs) Handles btn_deleteCurrentUser.Click 'you dont delete you just dont copy it across 

        Dim lookingat_UserID As Integer 'tempry fle
        Dim lookingat_UserName As String
        Dim lookingat_Password As String
        Dim lookingat_SLevel As Integer
        Dim counterDCU As Integer
        If MsgBox("Are you sure you want to delete this account? ", vbYesNo) = vbYes Then

            Dim sw As New StreamWriter(fileLoc_User, False) 'will deleted 

            For counterDCU = 0 To (lineCount - 1)

                lookingat_UserID = dgv_users.Rows(counterDCU).Cells(0).Value
                lookingat_UserName = dgv_users.Rows(counterDCU).Cells(1).Value
                lookingat_Password = dgv_users.Rows(counterDCU).Cells(2).Value
                lookingat_SLevel = dgv_users.Rows(counterDCU).Cells(3).Value

                If lookingat_UserID <> txt_userID.Text Then 'if they dont match they are coppied across

                    sw.WriteLine(lookingat_UserID & "," & lookingat_UserName & "," & lookingat_Password & "," & lookingat_SLevel)

                End If

            Next 'will check through the entrie file 

            sw.Close()
            MsgBox("User account has been Deleted")

        End If

        fillGrid()
        firstSelected()

    End Sub
End Class
