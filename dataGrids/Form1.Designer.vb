<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgv_users = New System.Windows.Forms.DataGridView()
        Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnUsername = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPassword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnSecurityLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_userID = New System.Windows.Forms.TextBox()
        Me.txt_userName = New System.Windows.Forms.TextBox()
        Me.txt_passWord = New System.Windows.Forms.TextBox()
        Me.txt_levelSecurity = New System.Windows.Forms.TextBox()
        Me.btn_first = New System.Windows.Forms.Button()
        Me.btn_previous = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_last = New System.Windows.Forms.Button()
        Me.btn_addNew = New System.Windows.Forms.Button()
        Me.btn_saveNew = New System.Windows.Forms.Button()
        Me.btn_deleteCurrentUser = New System.Windows.Forms.Button()
        Me.btn_saveChanges = New System.Windows.Forms.Button()
        Me.btn_quitUserdgv = New System.Windows.Forms.Button()
        Me.lbl_userID = New System.Windows.Forms.Label()
        Me.lbl_userName = New System.Windows.Forms.Label()
        Me.lbl_passWord = New System.Windows.Forms.Label()
        Me.lbl_Level = New System.Windows.Forms.Label()
        CType(Me.dgv_users, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_users
        '
        Me.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_users.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnUsername, Me.ColumnPassword, Me.ColumnSecurityLevel})
        Me.dgv_users.Location = New System.Drawing.Point(13, 12)
        Me.dgv_users.Name = "dgv_users"
        Me.dgv_users.ReadOnly = True
        Me.dgv_users.Size = New System.Drawing.Size(441, 231)
        Me.dgv_users.TabIndex = 0
        '
        'ColumnID
        '
        Me.ColumnID.HeaderText = "ID"
        Me.ColumnID.Name = "ColumnID"
        Me.ColumnID.ReadOnly = True
        '
        'ColumnUsername
        '
        Me.ColumnUsername.HeaderText = "Username"
        Me.ColumnUsername.Name = "ColumnUsername"
        Me.ColumnUsername.ReadOnly = True
        '
        'ColumnPassword
        '
        Me.ColumnPassword.HeaderText = "Password"
        Me.ColumnPassword.Name = "ColumnPassword"
        Me.ColumnPassword.ReadOnly = True
        '
        'ColumnSecurityLevel
        '
        Me.ColumnSecurityLevel.HeaderText = "SecurityLevel"
        Me.ColumnSecurityLevel.Name = "ColumnSecurityLevel"
        Me.ColumnSecurityLevel.ReadOnly = True
        '
        'txt_userID
        '
        Me.txt_userID.Location = New System.Drawing.Point(75, 296)
        Me.txt_userID.Name = "txt_userID"
        Me.txt_userID.Size = New System.Drawing.Size(100, 20)
        Me.txt_userID.TabIndex = 1
        '
        'txt_userName
        '
        Me.txt_userName.Location = New System.Drawing.Point(75, 322)
        Me.txt_userName.Name = "txt_userName"
        Me.txt_userName.Size = New System.Drawing.Size(100, 20)
        Me.txt_userName.TabIndex = 2
        '
        'txt_passWord
        '
        Me.txt_passWord.Location = New System.Drawing.Point(76, 344)
        Me.txt_passWord.Name = "txt_passWord"
        Me.txt_passWord.Size = New System.Drawing.Size(100, 20)
        Me.txt_passWord.TabIndex = 3
        '
        'txt_levelSecurity
        '
        Me.txt_levelSecurity.Location = New System.Drawing.Point(76, 371)
        Me.txt_levelSecurity.Name = "txt_levelSecurity"
        Me.txt_levelSecurity.Size = New System.Drawing.Size(100, 20)
        Me.txt_levelSecurity.TabIndex = 4
        '
        'btn_first
        '
        Me.btn_first.Location = New System.Drawing.Point(182, 267)
        Me.btn_first.Name = "btn_first"
        Me.btn_first.Size = New System.Drawing.Size(62, 23)
        Me.btn_first.TabIndex = 5
        Me.btn_first.Text = "First"
        Me.btn_first.UseVisualStyleBackColor = True
        '
        'btn_previous
        '
        Me.btn_previous.Location = New System.Drawing.Point(250, 267)
        Me.btn_previous.Name = "btn_previous"
        Me.btn_previous.Size = New System.Drawing.Size(62, 23)
        Me.btn_previous.TabIndex = 6
        Me.btn_previous.Text = "Previous"
        Me.btn_previous.UseVisualStyleBackColor = True
        '
        'btn_next
        '
        Me.btn_next.Location = New System.Drawing.Point(318, 267)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(62, 23)
        Me.btn_next.TabIndex = 7
        Me.btn_next.Text = "Next"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'btn_last
        '
        Me.btn_last.Location = New System.Drawing.Point(386, 267)
        Me.btn_last.Name = "btn_last"
        Me.btn_last.Size = New System.Drawing.Size(62, 23)
        Me.btn_last.TabIndex = 8
        Me.btn_last.Text = "Last"
        Me.btn_last.UseVisualStyleBackColor = True
        '
        'btn_addNew
        '
        Me.btn_addNew.Location = New System.Drawing.Point(208, 322)
        Me.btn_addNew.Name = "btn_addNew"
        Me.btn_addNew.Size = New System.Drawing.Size(75, 23)
        Me.btn_addNew.TabIndex = 9
        Me.btn_addNew.Text = "Add New"
        Me.btn_addNew.UseVisualStyleBackColor = True
        '
        'btn_saveNew
        '
        Me.btn_saveNew.Location = New System.Drawing.Point(289, 322)
        Me.btn_saveNew.Name = "btn_saveNew"
        Me.btn_saveNew.Size = New System.Drawing.Size(75, 23)
        Me.btn_saveNew.TabIndex = 10
        Me.btn_saveNew.Text = "Save"
        Me.btn_saveNew.UseVisualStyleBackColor = True
        '
        'btn_deleteCurrentUser
        '
        Me.btn_deleteCurrentUser.Location = New System.Drawing.Point(230, 368)
        Me.btn_deleteCurrentUser.Name = "btn_deleteCurrentUser"
        Me.btn_deleteCurrentUser.Size = New System.Drawing.Size(117, 23)
        Me.btn_deleteCurrentUser.TabIndex = 11
        Me.btn_deleteCurrentUser.Text = "Delete Current User"
        Me.btn_deleteCurrentUser.UseVisualStyleBackColor = True
        '
        'btn_saveChanges
        '
        Me.btn_saveChanges.Location = New System.Drawing.Point(230, 397)
        Me.btn_saveChanges.Name = "btn_saveChanges"
        Me.btn_saveChanges.Size = New System.Drawing.Size(117, 23)
        Me.btn_saveChanges.TabIndex = 12
        Me.btn_saveChanges.Text = "Save Changes"
        Me.btn_saveChanges.UseVisualStyleBackColor = True
        '
        'btn_quitUserdgv
        '
        Me.btn_quitUserdgv.Location = New System.Drawing.Point(230, 426)
        Me.btn_quitUserdgv.Name = "btn_quitUserdgv"
        Me.btn_quitUserdgv.Size = New System.Drawing.Size(117, 41)
        Me.btn_quitUserdgv.TabIndex = 13
        Me.btn_quitUserdgv.Text = "Exit"
        Me.btn_quitUserdgv.UseVisualStyleBackColor = True
        '
        'lbl_userID
        '
        Me.lbl_userID.AutoSize = True
        Me.lbl_userID.Location = New System.Drawing.Point(26, 299)
        Me.lbl_userID.Name = "lbl_userID"
        Me.lbl_userID.Size = New System.Drawing.Size(40, 13)
        Me.lbl_userID.TabIndex = 14
        Me.lbl_userID.Text = "UserID"
        '
        'lbl_userName
        '
        Me.lbl_userName.AutoSize = True
        Me.lbl_userName.Location = New System.Drawing.Point(13, 322)
        Me.lbl_userName.Name = "lbl_userName"
        Me.lbl_userName.Size = New System.Drawing.Size(55, 13)
        Me.lbl_userName.TabIndex = 15
        Me.lbl_userName.Text = "Username"
        '
        'lbl_passWord
        '
        Me.lbl_passWord.AutoSize = True
        Me.lbl_passWord.Location = New System.Drawing.Point(13, 347)
        Me.lbl_passWord.Name = "lbl_passWord"
        Me.lbl_passWord.Size = New System.Drawing.Size(53, 13)
        Me.lbl_passWord.TabIndex = 16
        Me.lbl_passWord.Text = "Password"
        '
        'lbl_Level
        '
        Me.lbl_Level.AutoSize = True
        Me.lbl_Level.Location = New System.Drawing.Point(21, 378)
        Me.lbl_Level.Name = "lbl_Level"
        Me.lbl_Level.Size = New System.Drawing.Size(29, 13)
        Me.lbl_Level.TabIndex = 17
        Me.lbl_Level.Text = "level"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 501)
        Me.Controls.Add(Me.lbl_Level)
        Me.Controls.Add(Me.lbl_passWord)
        Me.Controls.Add(Me.lbl_userName)
        Me.Controls.Add(Me.lbl_userID)
        Me.Controls.Add(Me.btn_quitUserdgv)
        Me.Controls.Add(Me.btn_saveChanges)
        Me.Controls.Add(Me.btn_deleteCurrentUser)
        Me.Controls.Add(Me.btn_saveNew)
        Me.Controls.Add(Me.btn_addNew)
        Me.Controls.Add(Me.btn_last)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.btn_previous)
        Me.Controls.Add(Me.btn_first)
        Me.Controls.Add(Me.txt_levelSecurity)
        Me.Controls.Add(Me.txt_passWord)
        Me.Controls.Add(Me.txt_userName)
        Me.Controls.Add(Me.txt_userID)
        Me.Controls.Add(Me.dgv_users)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgv_users, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_users As DataGridView
    Friend WithEvents txt_userID As TextBox
    Friend WithEvents txt_userName As TextBox
    Friend WithEvents txt_passWord As TextBox
    Friend WithEvents txt_levelSecurity As TextBox
    Friend WithEvents btn_first As Button
    Friend WithEvents btn_previous As Button
    Friend WithEvents btn_next As Button
    Friend WithEvents btn_last As Button
    Friend WithEvents btn_addNew As Button
    Friend WithEvents btn_saveNew As Button
    Friend WithEvents btn_deleteCurrentUser As Button
    Friend WithEvents btn_saveChanges As Button
    Friend WithEvents btn_quitUserdgv As Button
    Friend WithEvents lbl_userID As Label
    Friend WithEvents lbl_userName As Label
    Friend WithEvents lbl_passWord As Label
    Friend WithEvents lbl_Level As Label
    Friend WithEvents ColumnID As DataGridViewTextBoxColumn
    Friend WithEvents ColumnUsername As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPassword As DataGridViewTextBoxColumn
    Friend WithEvents ColumnSecurityLevel As DataGridViewTextBoxColumn
End Class
