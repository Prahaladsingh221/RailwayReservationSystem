Imports System.Data.SqlClient

Public Class form4

    Dim connectionString As String = "Server=ASUSVIVOBOOK\SQLEXPRESS;Database=RailwayDB;Integrated Security=True"

    Private Sub StationsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStations()
    End Sub


    Private Sub LoadStations()
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM Stations"
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim table As New DataTable()

            Try
                conn.Open()
                adapter.Fill(table)
                dgvStations.DataSource = table
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Sub Add_Stations_Click(sender As Object, e As EventArgs) Handles Add_Stations.Click
        ' Validate input
        If TextBox2.Text = "" Or TextBox3.Text = "" Then
            MessageBox.Show("Please enter all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "INSERT INTO Stations (StationName, Location) VALUES (@StationName, @Location)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@StationName", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@Location", TextBox3.Text)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Station added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


                TextBox2.Clear()
                TextBox3.Clear()


                LoadStations()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
