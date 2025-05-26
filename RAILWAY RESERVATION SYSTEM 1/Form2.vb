Imports System.Data.SqlClient
Imports System.Text

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(100, 0, 0, 0)
    End Sub
    Dim connectionString As String = "Server=ASUSVIVOBOOK\SQLEXPRESS;Database=RailwayDB;Integrated Security=True;"
    Dim connection As New SqlConnection(connectionString)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim UserID As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        Dim query As String = "SELECT  UserID FROM Users WHERE UserID = @UserID AND password = @password"

        ' Using SQL connection and command
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@UserID", UserID)
                command.Parameters.AddWithValue("@password", password)

                Try
                    ' Open the connection
                    connection.Open()

                    ' Execute the query and retrieve the role
                    Dim result As Object = command.ExecuteScalar()

                    If result IsNot Nothing Then
                        ' User found, check the UserID
                        Dim Role As String = result.ToString()

                        ' Check if user is an Admin or Staff
                        If UserID = "101" Then
                            MessageBox.Show("Admin logged in successfully.")
                            ' Redirect to Admin Dashboard
                            Form3.Show()
                            Me.Hide()
                        ElseIf UserID = "102" Then
                            MessageBox.Show("Staff logged in successfully.")
                            ' Redirect to Staff Dashboard
                            Form7.Show()
                            Me.Hide()
                        ElseIf UserID = "103" Then
                            MessageBox.Show("Staff logged in successfully.")
                            ' Redirect to Staff Dashboard
                            Form5.Show()
                            Me.Hide()
                        ElseIf UserID = "104" Then
                            MessageBox.Show("Staff logged in successfully.")
                            ' Redirect to Staff Dashboard
                            Form5.Show()
                            Me.Hide()
                        End If
                    Else
                        MessageBox.Show("Invalid Username or Password.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End Using
        End Using
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TextBox1.Text = ""
        TextBox2.Text = ""
        CheckBox1.Checked = False
        TextBox2.UseSystemPasswordChar = True
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class