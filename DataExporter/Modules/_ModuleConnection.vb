Imports System.Data
Imports System.Data.SqlClient

Module _ModuleConnecton
    Public Con As New SqlConnection
    Public Cmd As New SqlCommand
    Public Dr As SqlDataReader
    Public Da As New SqlDataAdapter
    Public Ds As New DataSet

    Public Constring As String = "server=172.20.63.14;User Id=ihomis;password=1homis;database=hospital_dbo"
    'Public Constring As String = "server=localhost;User Id=sa;password=root;database=hospital_dbo"

    Public Sub opencon()
        Con.ConnectionString = Constring
        Con.Open()
        Cmd.Connection = Con
    End Sub

    Public Sub closecon()
        Con.Close()
        Con.ConnectionString = Nothing
        Cmd.CommandText = Nothing
    End Sub

End Module
