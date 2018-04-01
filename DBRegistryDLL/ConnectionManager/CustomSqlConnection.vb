Imports System.Configuration
Imports System.Data.SqlClient

Public Class CustomSqlConnection

    Private _sqlConn As SqlConnection
    Public Property sqlConn() As SqlConnection
        Get
            Return _sqlConn
        End Get
        Set(ByVal value As SqlConnection)
            _sqlConn = value
        End Set
    End Property
    Public Sub New(Optional ByVal database As Databases = Databases.Main)


        Dim connectionString As String = ConfigurationManager.ConnectionStrings(database.ToString()).ConnectionString
        If String.IsNullOrEmpty(connectionString) Then Throw New Exception(String.Format("Connection string was not found in config file '{0}'", AppDomain.CurrentDomain.SetupInformation.ConfigurationFile))
        sqlConn = New SqlConnection(connectionString)
        sqlConn.Open()
    End Sub

    Public Sub DisposeConnection()
        sqlConn.Close()

        sqlConn.Dispose()

    End Sub

End Class
