<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtfirstnum = New TextBox()
        txtSecondnum = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        lblResult = New Label()
        btnAdd = New Button()
        SuspendLayout()
        ' 
        ' txtfirstnum
        ' 
        txtfirstnum.Location = New Point(30, 52)
        txtfirstnum.Name = "txtfirstnum"
        txtfirstnum.Size = New Size(100, 23)
        txtfirstnum.TabIndex = 0
        ' 
        ' txtSecondnum
        ' 
        txtSecondnum.Location = New Point(30, 100)
        txtSecondnum.Name = "txtSecondnum"
        txtSecondnum.Size = New Size(100, 23)
        txtSecondnum.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 15)
        Label1.TabIndex = 2
        Label1.Text = "First number:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 15)
        Label2.TabIndex = 3
        Label2.Text = "Second Number:"
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(30, 171)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(41, 15)
        lblResult.TabIndex = 4
        lblResult.Text = "Label3"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(30, 132)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 5
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnAdd)
        Controls.Add(lblResult)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtSecondnum)
        Controls.Add(txtfirstnum)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtfirstnum As TextBox
    Friend WithEvents txtSecondnum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents btnAdd As Button
End Class
