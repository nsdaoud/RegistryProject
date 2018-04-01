Imports System.Data.SqlClient
Imports System.Xml
Imports System.Windows.Forms
Public Class DBFunctions
    Private _Sqlconnection As SqlConnection
    Public Property DBSqlconnection() As SqlConnection
        Get
            Return _Sqlconnection
        End Get
        Set(ByVal value As SqlConnection)
            _Sqlconnection = value
        End Set
    End Property

    Private _SqlconnectionString As String
    Public Property DBSqlconnectionString() As String
        Get
            Return _SqlconnectionString
        End Get
        Set(ByVal value As String)
            _SqlconnectionString = value
        End Set
    End Property

    Private _filepathString As String
    Public Property filepathString() As String
        Get
            Return _filepathString
        End Get
        Set(ByVal value As String)
            _filepathString = value
        End Set
    End Property

    Sub New()
        ReadFromFileXML()
    End Sub

    Sub ReadFromFileXML()
        Try
            Using reader As XmlReader = XmlReader.Create("D:\Sijjel.xml")
                'Dim appPath As String = Application.StartupPath()
                'Using reader As XmlReader = XmlReader.Create(appPath + "\Sijjel.xml")

                While reader.Read()

                    If reader.IsStartElement() Then

                        Select Case reader.Name.ToString()

                            Case "connectionString"
                                DBSqlconnectionString = reader.ReadString()
                                'Console.WriteLine("Name of the Element is : " + reader.ReadString());

                                Exit Select
                            Case "filepath"
                                filepathString = reader.ReadString()
                                'Console.WriteLine("Name of the Element is : " + reader.ReadString());

                                Exit Select



                            Case "Location"

                                Console.WriteLine("Your Location is : " + reader.ReadString())

                                Exit Select


                        End Select
                    End If


                    Console.WriteLine("")

                End While
            End Using
        Catch ex As Exception

        End Try
  



    End Sub
#Region "Tbl_User"
    Function GetAllUsers() As List(Of Users)
        Dim lstofUsers As New List(Of Users)
        Try
            Dim strQuerry As String
            Dim SelectedUsers As New Users

            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select id_User,UserName,UserLastName,UserLogin,UserPassword,isAdmin,isVisitor,isUser  from Tbl_User"

            DBSqlconnection.Open()

            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    SelectedUsers = New Users
                    SelectedUsers.id_User = Integer.Parse(dt.Rows(i)("id_User").ToString())
                    SelectedUsers.UserName = dt.Rows(i)("UserName")
                    SelectedUsers.UserLastName = dt.Rows(i)("UserLastName")
                    SelectedUsers.UserLogin = dt.Rows(i)("UserLogin")
                    SelectedUsers.UserPassword = dt.Rows(i)("UserPassword")
                    SelectedUsers.isAdmin = (dt.Rows(i)("isAdmin"))
                    SelectedUsers.isUser = (dt.Rows(i)("isUser"))
                    SelectedUsers.isVisitor = (dt.Rows(i)("isVisitor"))
                  
                    lstofUsers.Add(SelectedUsers)
                Next
            End If

        Catch ex As Exception

        Finally
            DBSqlconnection.Close()
        End Try

        Return lstofUsers
    End Function

    Function GetUserInfo(ByVal _Username As String, ByVal _UserPassword As String) As Users
        Dim SelectedUsers As New Users
        Try
            Dim strQuerry As String
            Dim strWhereQuerry As String


            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select id_User,UserName,UserLastName,UserLogin,UserPassword,isAdmin,isVisitor,isUser  from Tbl_User"
            strWhereQuerry = " where UserLogin = '" & _Username & "' and UserPassword = '" & _UserPassword & "'"
            strQuerry = strQuerry + strWhereQuerry
            DBSqlconnection.Open()

            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1

                    SelectedUsers.id_User = Integer.Parse(dt.Rows(i)("id_User").ToString())
                    SelectedUsers.UserName = dt.Rows(i)("UserName")
                    SelectedUsers.UserLastName = dt.Rows(i)("UserLastName")
                    SelectedUsers.UserLogin = dt.Rows(i)("UserLogin")
                    SelectedUsers.UserPassword = dt.Rows(i)("UserPassword")
                    SelectedUsers.isAdmin = (dt.Rows(i)("isAdmin"))
                    SelectedUsers.isUser = (dt.Rows(i)("isUser"))
                    SelectedUsers.isVisitor = (dt.Rows(i)("isVisitor"))


                Next
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            DBSqlconnection.Close()
        End Try

        Return SelectedUsers
    End Function

    Function SaveUsersData(ByVal _lstofUsers As List(Of Users)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_UserInsert @UserName,@UserLastName,@UserLogin,@UserPassword,@isAdmin,@isVisitor,@isUser"
            For i As Integer = 0 To _lstofUsers.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandText = strQuerry
                cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = _lstofUsers(i).UserName
                cmd.Parameters.Add("@UserLastName", SqlDbType.NVarChar).Value = _lstofUsers(i).UserLastName
                cmd.Parameters.Add("@UserLogin", SqlDbType.NVarChar).Value = _lstofUsers(i).UserLogin
                cmd.Parameters.Add("@UserPassword", SqlDbType.NVarChar).Value = _lstofUsers(i).UserPassword
                cmd.Parameters.Add("@isAdmin", SqlDbType.Bit).Value = _lstofUsers(i).isAdmin
                cmd.Parameters.Add("@isVisitor", SqlDbType.Bit).Value = _lstofUsers(i).isVisitor
                cmd.Parameters.Add("@isUser", SqlDbType.Bit).Value = _lstofUsers(i).isUser

                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                DBSqlconnection.Close()
            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Function UpdateUserData(ByVal _lstofUsers As List(Of Users)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_UserUpdate @id_User,@UserName,@UserLastName,@UserLogin,@UserPassword,@isAdmin,@isVisitor,@isUser"
            For i As Integer = 0 To _lstofUsers.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandText = strQuerry
                cmd.Parameters.Add("@id_User", SqlDbType.Int).Value = _lstofUsers(i).id_User
                cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = _lstofUsers(i).UserName
                cmd.Parameters.Add("@UserLastName", SqlDbType.NVarChar).Value = _lstofUsers(i).UserLastName
                cmd.Parameters.Add("@UserLogin", SqlDbType.NVarChar).Value = _lstofUsers(i).UserLogin
                cmd.Parameters.Add("@UserPassword", SqlDbType.NVarChar).Value = _lstofUsers(i).UserPassword
                cmd.Parameters.Add("@isAdmin", SqlDbType.Bit).Value = _lstofUsers(i).isAdmin
                cmd.Parameters.Add("@isVisitor", SqlDbType.Bit).Value = _lstofUsers(i).isVisitor
                cmd.Parameters.Add("@isUser", SqlDbType.Bit).Value = _lstofUsers(i).isUser
                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                DBSqlconnection.Close()
            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function
    Function DeleteUserData(ByVal _lstofUsers As List(Of Users)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_UserDelete @id_User"
            For i As Integer = 0 To _lstofUsers.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandText = strQuerry
                cmd.Parameters.Add("@id_User", SqlDbType.Int).Value = _lstofUsers(i).id_User

                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                DBSqlconnection.Close()
            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Function UpdateUserPasswordData(ByVal _UsersInfo As Users) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_UserPasswordUpdate @id_User,@UserPassword"

            Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
            cmd.CommandText = strQuerry
            cmd.Parameters.Add("@id_User", SqlDbType.Int).Value = _UsersInfo.id_User
          
            cmd.Parameters.Add("@UserPassword", SqlDbType.NVarChar).Value = _UsersInfo.UserPassword

            DBSqlconnection.Open()
            cmd.ExecuteNonQuery()
            DBSqlconnection.Close()




        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function
#End Region

#Region "Tbl_DeliveredFor"
    Function GetAllDeliveredFor() As List(Of DeliveredFor)
        Dim lstofDeliveredFor As New List(Of DeliveredFor)
        Try
            Dim strQuerry As String
            Dim SelectedDeliveredFor As New DeliveredFor

            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select id_PaperSource as id_DeliveredFor,PaperSourceDescription as DeliveredForDescription from Tbl_PaperSource order by PaperSourceDescription"

            DBSqlconnection.Open()

            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    SelectedDeliveredFor = New DeliveredFor
                    SelectedDeliveredFor.id_DeliveredFor = dt.Rows(i)("id_DeliveredFor")
                    SelectedDeliveredFor.DeliveredForDescription = dt.Rows(i)("DeliveredForDescription")
                  

                    lstofDeliveredFor.Add(SelectedDeliveredFor)
                Next
            End If

        Catch ex As Exception

        Finally
            DBSqlconnection.Close()
        End Try

        Return lstofDeliveredFor
    End Function

    Function GetDTAllDeliveredFor() As DataTable
        Dim lstofDeliveredFor As New List(Of DeliveredFor)
        Dim dt As New DataTable()
        Try
            Dim strQuerry As String
            Dim SelectedDeliveredFor As New DeliveredFor

            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select id_PaperSource as id_DeliveredFor,PaperSourceDescription as DeliveredForDescription from Tbl_PaperSource order by PaperSourceDescription"

            DBSqlconnection.Open()

            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    SelectedDeliveredFor = New DeliveredFor
                    SelectedDeliveredFor.id_DeliveredFor = dt.Rows(i)("id_DeliveredFor")

                    SelectedDeliveredFor.DeliveredForDescription = dt.Rows(i)("DeliveredForDescription")

                    lstofDeliveredFor.Add(SelectedDeliveredFor)
                Next
            End If

        Catch ex As Exception

        Finally
            DBSqlconnection.Close()
        End Try

        Return dt
    End Function

    Function GetDTAllUserTransActions() As DataTable
        Dim lstofUserTransactions As New List(Of UserTransactions)
        Dim dt As New DataTable()
        Try
            Dim strQuerry As String
            Dim SelectedUserTransactions As New UserTransactions

            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select id_PaperSource as id_UserTransactions,PaperSourceDescription as UserTransactions from Tbl_PaperSource order by PaperSourceDescription"

            DBSqlconnection.Open()

            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)

            'If dt.Rows.Count > 0 Then
            '    For i As Integer = 0 To dt.Rows.Count - 1
            '        SelectedUserTransactions = New UserTransactions
            '        SelectedUserTransactions.id_UserTransactions = dt.Rows(i)("id_UserTransactions")

            '        SelectedUserTransactions.UserTransactions = dt.Rows(i)("UserTransactions")

            '        lstofUserTransactions.Add(SelectedUserTransactions)
            '    Next
            'End If

        Catch ex As Exception

        Finally
            DBSqlconnection.Close()
        End Try

        Return dt
    End Function




    Function SaveDeliveredForData(ByVal _lstofDeliveredFor As List(Of DeliveredFor)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_DeliveredForInsert @DeliveredForDescription"
            For i As Integer = 0 To _lstofDeliveredFor.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandText = strQuerry
                cmd.Parameters.Add("@DeliveredForDescription", SqlDbType.NVarChar).Value = _lstofDeliveredFor(i).DeliveredForDescription
             

                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                DBSqlconnection.Close()
            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Function UpdateDeliveredForData(ByVal _lstofDeliveredFor As List(Of DeliveredFor)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_DeliveredForUpdate @id_DeliveredFor,@DeliveredForDescription"
            For i As Integer = 0 To _lstofDeliveredFor.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandText = strQuerry
                cmd.Parameters.Add("@id_DeliveredFor", SqlDbType.Int).Value = _lstofDeliveredFor(i).id_DeliveredFor
                cmd.Parameters.Add("@DeliveredForDescription", SqlDbType.NVarChar).Value = _lstofDeliveredFor(i).DeliveredForDescription
             
                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                DBSqlconnection.Close()
            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function
    Function DeleteDeliveredForData(ByVal _lstofDeliveredFor As List(Of DeliveredFor)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_DeliveredForDelete @id_DeliveredFor"
            For i As Integer = 0 To _lstofDeliveredFor.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandText = strQuerry
                cmd.Parameters.Add("@id_DeliveredFor", SqlDbType.Int).Value = _lstofDeliveredFor(i).id_DeliveredFor

                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                DBSqlconnection.Close()
            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function
#End Region

#Region "Tbl_PaperSource"
    Function GetAllpapersource() As List(Of papersource)
        Dim lstofpapersource As New List(Of papersource)
        Try
            Dim strQuerry As String
            Dim Selectedpapersource As New papersource

            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select id_PaperSource,PaperSourceDescription from Tbl_PaperSource order by PaperSourceDescription "

            DBSqlconnection.Open()

            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    Selectedpapersource = New papersource
                    Selectedpapersource.id_PaperSource = dt.Rows(i)("id_PaperSource")
                    Selectedpapersource.PaperSourceDescription = dt.Rows(i)("PaperSourceDescription")


                    lstofpapersource.Add(Selectedpapersource)
                Next
            End If

        Catch ex As Exception

        Finally
            DBSqlconnection.Close()
        End Try

        Return lstofpapersource
    End Function

    Function GetAllDtpapersource() As DataTable
        Dim lstofpapersource As New List(Of papersource)
        Dim dt As New DataTable()
        Try
            Dim strQuerry As String
            Dim Selectedpapersource As New papersource

            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select id_PaperSource,PaperSourceDescription from Tbl_PaperSource order by PaperSourceDescription "

            DBSqlconnection.Open()

            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)

            'If dt.Rows.Count > 0 Then
            '    For i As Integer = 0 To dt.Rows.Count - 1
            '        Selectedpapersource = New papersource
            '        Selectedpapersource.id_PaperSource = dt.Rows(i)("id_PaperSource")
            '        Selectedpapersource.PaperSourceDescription = dt.Rows(i)("PaperSourceDescription")


            '        lstofpapersource.Add(Selectedpapersource)
            '    Next
            'End If

        Catch ex As Exception

        Finally
            DBSqlconnection.Close()
        End Try

        Return dt
    End Function

    Function GetAll304Dtpapersource() As DataTable
        Dim lstofpapersource As New List(Of papersource)
        Dim dt As New DataTable()
        Try
            Dim strQuerry As String
            Dim Selectedpapersource As New papersource

            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select id_PaperSource as id_WFDestination,PaperSourceDescription as WFDestination from Tbl_PaperSource order by PaperSourceDescription "

            DBSqlconnection.Open()

            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)

            'If dt.Rows.Count > 0 Then
            '    For i As Integer = 0 To dt.Rows.Count - 1
            '        Selectedpapersource = New papersource
            '        Selectedpapersource.id_PaperSource = dt.Rows(i)("id_PaperSource")
            '        Selectedpapersource.PaperSourceDescription = dt.Rows(i)("PaperSourceDescription")


            '        lstofpapersource.Add(Selectedpapersource)
            '    Next
            'End If

        Catch ex As Exception

        Finally
            DBSqlconnection.Close()
        End Try

        Return dt
    End Function


    Function GetAllpapersourceforregister(ByVal idRegistery As Integer) As List(Of papersource)
        Dim lstofpapersource As New List(Of papersource)
        Try
            Dim strQuerry As String
            Dim Selectedpapersource As New papersource

            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select id_PaperSource,PaperSourceDescription,dbo.fn_papersourcehasregister(" + idRegistery.ToString + ",id_PaperSource) as checked from Tbl_PaperSource order by PaperSourceDescription "

            DBSqlconnection.Open()

            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    Selectedpapersource = New papersource
                    Selectedpapersource.id_PaperSource = dt.Rows(i)("id_PaperSource")
                    Selectedpapersource.PaperSourceDescription = dt.Rows(i)("PaperSourceDescription")
                    If dt.Rows(i)("checked") Is DBNull.Value Then
                        Selectedpapersource.Selected = False
                    Else
                        Selectedpapersource.Selected = True
                    End If

                    lstofpapersource.Add(Selectedpapersource)
                Next
            End If

        Catch ex As Exception

        Finally
            DBSqlconnection.Close()
        End Try

        Return lstofpapersource
    End Function


    Function SavepapersourceData(ByVal _lstofpapersource As List(Of papersource)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_PaperSourceInsert @PaperSourceDescription"
            For i As Integer = 0 To _lstofpapersource.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandText = strQuerry
                cmd.Parameters.Add("@PaperSourceDescription", SqlDbType.NVarChar).Value = _lstofpapersource(i).PaperSourceDescription


                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                DBSqlconnection.Close()
            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Function UpdatePaperSourceData(ByVal _lstofPaperSource As List(Of papersource)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_PaperSourceUpdate @id_PaperSource,@PaperSourceDescription"
            For i As Integer = 0 To _lstofPaperSource.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandText = strQuerry
                cmd.Parameters.Add("@id_PaperSource", SqlDbType.Int).Value = _lstofPaperSource(i).id_PaperSource
                cmd.Parameters.Add("@PaperSourceDescription", SqlDbType.NVarChar).Value = _lstofPaperSource(i).PaperSourceDescription

                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                DBSqlconnection.Close()
            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function
    Function DeletePaperSourceData(ByVal _lstofpapersource As List(Of papersource)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_PaperSourceDelete @id_PaperSource"
            For i As Integer = 0 To _lstofpapersource.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandText = strQuerry
                cmd.Parameters.Add("@id_PaperSource", SqlDbType.Int).Value = _lstofpapersource(i).id_PaperSource

                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                DBSqlconnection.Close()
            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function
#End Region


#Region "Tbl_Documents"
    Function GetAllDocuments(ByVal idRegistry As Integer, ByVal RegistryType As String) As List(Of Documents)
        Dim lstofDocuments As New List(Of Documents)
        Try
            Dim strQuerry As String
            Dim SelectedDocuments As New Documents

            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select id_Document,id_Registry,RegistryType,DocumentName,CreationDate,DocumentDescription,fileextensionName,SeqDocument from Tbl_Documents where id_Registry = " & idRegistry & " and RegistryType = '" & RegistryType & "' order by  CreationDate desc"

            DBSqlconnection.Open()

            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    SelectedDocuments = New Documents
                    SelectedDocuments.id_Document = dt.Rows(i)("id_Document")
                    SelectedDocuments.id_Registry = dt.Rows(i)("id_Registry")
                    SelectedDocuments.RegistryType = dt.Rows(i)("RegistryType")
                    SelectedDocuments.SeqDocument = dt.Rows(i)("SeqDocument")
                    If dt.Rows(i)("DocumentName") Is DBNull.Value Then
                        SelectedDocuments.DocumentName = Nothing
                    Else
                        SelectedDocuments.DocumentName = dt.Rows(i)("DocumentName")

                    End If

                    SelectedDocuments.CreationDate = dt.Rows(i)("CreationDate")
                    If dt.Rows(i)("DocumentDescription") Is DBNull.Value Then
                        SelectedDocuments.DocumentDescription = Nothing
                    Else
                        SelectedDocuments.DocumentDescription = dt.Rows(i)("DocumentDescription")

                    End If
                    If dt.Rows(i)("fileextensionName") Is DBNull.Value Then
                        SelectedDocuments.fileName = Nothing
                    Else
                        SelectedDocuments.fileName = dt.Rows(i)("fileextensionName")

                    End If

                    lstofDocuments.Add(SelectedDocuments)
                Next
            End If

        Catch ex As Exception

        Finally
            DBSqlconnection.Close()
        End Try

        Return lstofDocuments
    End Function

    Function SaveDocumentsData(ByVal _lstofDocuments As List(Of Documents)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_DocumentInsert @id_Registry,@RegistryType,@DocumentName,@CreationDate,@DocumentDescription"
            For i As Integer = 0 To _lstofDocuments.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandText = strQuerry
                cmd.Parameters.Add("@id_Registry", SqlDbType.Int).Value = _lstofDocuments(i).id_Registry
                cmd.Parameters.Add("@RegistryType", SqlDbType.NVarChar).Value = _lstofDocuments(i).RegistryType
                cmd.Parameters.Add("@CreationDate", SqlDbType.DateTime).Value = _lstofDocuments(i).CreationDate

                If _lstofDocuments(i).DocumentName Is Nothing Then
                    cmd.Parameters.Add("@DocumentName", SqlDbType.NVarChar).Value = ""
                Else
                    cmd.Parameters.Add("@DocumentName", SqlDbType.NVarChar).Value = _lstofDocuments(i).DocumentName
                End If

                If _lstofDocuments(i).DocumentDescription Is Nothing Then
                    cmd.Parameters.Add("@DocumentDescription", SqlDbType.NVarChar).Value = ""
                Else
                    cmd.Parameters.Add("@DocumentDescription", SqlDbType.NVarChar).Value = _lstofDocuments(i).DocumentDescription
                End If


                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                DBSqlconnection.Close()
            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Function UpdateDocumentsData(ByVal _lstofDocuments As List(Of Documents)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_DocumentUpdate @id_Document,@DocumentName,@DocumentDescription"
            For i As Integer = 0 To _lstofDocuments.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandText = strQuerry
                cmd.Parameters.Add("@id_Document", SqlDbType.Int).Value = _lstofDocuments(i).id_Document
                cmd.Parameters.Add("@DocumentName", SqlDbType.NVarChar).Value = _lstofDocuments(i).DocumentName
                cmd.Parameters.Add("@DocumentDescription", SqlDbType.NVarChar).Value = _lstofDocuments(i).DocumentDescription

                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                DBSqlconnection.Close()
            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Function UpdateDocumentNameData(ByVal idDocument As Integer, ByVal DocumentName As String) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_DocumentNameUpdate @id_Document,@filename"

            Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
            cmd.CommandText = strQuerry
            cmd.Parameters.Add("@id_Document", SqlDbType.Int).Value = idDocument
            cmd.Parameters.Add("@filename", SqlDbType.NVarChar).Value = DocumentName

            DBSqlconnection.Open()
            cmd.ExecuteNonQuery()
            DBSqlconnection.Close()




        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function
    Function DeleteDocumentsData(ByVal _lstofDocuments As List(Of Documents)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_DocumentDelete @id_Document"
            For i As Integer = 0 To _lstofDocuments.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandText = strQuerry
                cmd.Parameters.Add("@id_Document", SqlDbType.Int).Value = _lstofDocuments(i).id_Document

                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                DBSqlconnection.Close()
            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function
#End Region

#Region "Registry"

    Function GetRegistryyears(ByVal _type206 As String) As DataTable
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select distinct year(Registry_Date) from Tbl_Registry"
            strQuerry = strQuerry + " where type206 = N'" + _type206 + "'"
            strQuerry = strQuerry + " order by year(Registry_Date) desc"
            DBSqlconnection.Open()

            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            Return dt
        Catch ex As Exception

        End Try
    End Function
    Function GetAllRegistry(ByVal _type206 As String, ByVal _selectedyear As String) As List(Of Registry)
        Dim lstofRegistry As New List(Of Registry)
        Try
            Dim strQuerry As String
            Dim SelectedRegistry As New Registry

            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select id_Registry,Registry_Seq,Registry_Year,Registry_Date,Registry_Submitted,Papernumber,"
            strQuerry = strQuerry + "PaperDate,Registry_Description,DeliveredTo_duedate,DeliveredFrom_duedate,SubmissionDate,SubjectSentFor,DateOfRegistration,"
            strQuerry = strQuerry + "Registry_BackSide,id_PaperSource,PaperSourceDescription,id_DeliveredFor,DeliveredForDescription,UserLogin,UserName,UserLastName,id_User,Comments,RegistryType,RegistrydueDate,"
            strQuerry = strQuerry + "id_204Registry,OldValues204,Values204,id_User2,UserLogin2,type206,id_UserTransactions,UserTransactions,RegistrySubmittedyear,id_CompleteRegistry from vue_getAllRegistry"
            strQuerry = strQuerry + " where type206 = N'" + _type206 + "'"
            If _selectedyear <> "All" Then
                strQuerry = strQuerry + " and year(Registry_Date)  = '" + _selectedyear + "'"
            End If
            strQuerry = strQuerry + " order by id_Registry desc"
            DBSqlconnection.Open()

            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    SelectedRegistry = New Registry
                    SelectedRegistry.id_Registry = dt.Rows(i)("id_Registry")
                    If dt.Rows(i)("id_PaperSource") Is DBNull.Value Then
                        SelectedRegistry.id_PaperSource = Nothing
                    Else
                        SelectedRegistry.id_PaperSource = dt.Rows(i)("id_PaperSource")

                    End If
                    'SelectedRegistry.PaperDate = DateTime.Parse(dt.Rows(i)("PaperDate"))
                    If dt.Rows(i)("PaperDate") Is DBNull.Value Then
                        SelectedRegistry.PaperDate = Nothing
                    Else
                        SelectedRegistry.PaperDate = DateTime.Parse(dt.Rows(i)("PaperDate").ToString)
                    End If
                    If dt.Rows(i)("Papernumber") Is DBNull.Value Then
                        SelectedRegistry.Papernumber = Nothing
                    Else
                        SelectedRegistry.Papernumber = dt.Rows(i)("Papernumber")
                    End If

                    If dt.Rows(i)("id_204Registry") Is DBNull.Value Then
                        SelectedRegistry.id204Registry = Nothing
                    Else
                        SelectedRegistry.id204Registry = dt.Rows(i)("id_204Registry")
                    End If

                    If dt.Rows(i)("PaperSourceDescription") Is DBNull.Value Then
                        SelectedRegistry.PaperSourceDescription = Nothing
                    Else
                        SelectedRegistry.PaperSourceDescription = dt.Rows(i)("PaperSourceDescription")
                    End If

                    If dt.Rows(i)("Registry_BackSide") Is DBNull.Value Then
                        SelectedRegistry.Registry_BackSide = Nothing
                    Else
                        SelectedRegistry.Registry_BackSide = (dt.Rows(i)("Registry_BackSide"))
                    End If

                    If dt.Rows(i)("Registry_Date") Is DBNull.Value Then
                        SelectedRegistry.Registry_Date = Nothing
                    Else
                        SelectedRegistry.Registry_Date = DateTime.Parse(dt.Rows(i)("Registry_Date").ToString)
                    End If
                    If dt.Rows(i)("Registry_Description") Is DBNull.Value Then
                        SelectedRegistry.Registry_Description = ""
                    Else
                        SelectedRegistry.Registry_Description = dt.Rows(i)("Registry_Description")
                    End If

                    'SelectedRegistry.DeliveredFrom_duedate = DateTime.Parse(dt.Rows(i)("DeliveredFrom_duedate"))
                    If dt.Rows(i)("DeliveredFrom_duedate") Is DBNull.Value Then
                        SelectedRegistry.DeliveredFrom_duedate = Nothing
                    Else
                        SelectedRegistry.DeliveredFrom_duedate = DateTime.Parse(dt.Rows(i)("DeliveredFrom_duedate").ToString)
                    End If

                    If dt.Rows(i)("RegistrydueDate") Is DBNull.Value Then
                        SelectedRegistry.RegistrydueDate = Nothing
                    Else
                        SelectedRegistry.RegistrydueDate = DateTime.Parse(dt.Rows(i)("RegistrydueDate").ToString)
                    End If

                    'SelectedRegistry.DeliveredTo_duedate = DateTime.Parse(dt.Rows(i)("DeliveredTo_duedate"))

                    If dt.Rows(i)("DeliveredTo_duedate") Is DBNull.Value Then
                        SelectedRegistry.DeliveredTo_duedate = Nothing
                    Else
                        SelectedRegistry.DeliveredTo_duedate = DateTime.Parse(dt.Rows(i)("DeliveredTo_duedate").ToString)
                    End If
                    If dt.Rows(i)("Registry_Seq") Is DBNull.Value Then
                        SelectedRegistry.Registry_Seq = Nothing
                    Else
                        SelectedRegistry.Registry_Seq = Integer.Parse(dt.Rows(i)("Registry_Seq"))

                    End If
                    If dt.Rows(i)("Registry_Submitted") Is DBNull.Value Then
                        SelectedRegistry.Registry_Submitted = Nothing
                    Else
                        SelectedRegistry.Registry_Submitted = (dt.Rows(i)("Registry_Submitted"))

                    End If
                    SelectedRegistry.Registry_Year = (dt.Rows(i)("Registry_Year"))
                    If dt.Rows(i)("SubjectSentFor") Is DBNull.Value Then
                        SelectedRegistry.SubjectSentFor = ""
                    Else
                        SelectedRegistry.SubjectSentFor = (dt.Rows(i)("SubjectSentFor"))
                    End If


                    If dt.Rows(i)("SubmissionDate") Is DBNull.Value Then
                        SelectedRegistry.SubmissionDate = Nothing
                    Else
                        SelectedRegistry.SubmissionDate = DateTime.Parse(dt.Rows(i)("SubmissionDate").ToString)
                    End If
                    'SelectedRegistry.SubmissionDate = DateTime.Parse(dt.Rows(i)("SubmissionDate"))

                    'Dim _lstofdelivered As New List(Of DeliveredFor)
                    ''Dim deliveredfor1 As New DeliveredFor()
                    ''deliveredfor1.id_DeliveredFor = New Integer() {9, 6, 10, 7}
                    'SelectedRegistry.id_DeliveredFor = GetListOfRegistryDeleviredFor(dt.Rows(i)("id_Registry"))
                    'SelectedRegistry.DeliveredForDescription = GetRegistryDeleviredForDescription(dt.Rows(i)("id_Registry"))

                    If dt.Rows(i)("id_DeliveredFor") Is DBNull.Value Then
                        SelectedRegistry.id_DeliveredFor = 0
                    Else
                        SelectedRegistry.id_DeliveredFor = Integer.Parse(dt.Rows(i)("id_DeliveredFor"))
                    End If

                    If dt.Rows(i)("DeliveredForDescription") Is DBNull.Value Then
                        SelectedRegistry.DeliveredForDescription = Nothing
                    Else
                        SelectedRegistry.DeliveredForDescription = (dt.Rows(i)("DeliveredForDescription"))
                    End If
                    If dt.Rows(i)("id_User") Is DBNull.Value Then
                        SelectedRegistry.id_User = 0
                    Else
                        SelectedRegistry.id_User = Integer.Parse(dt.Rows(i)("id_User"))
                    End If

                    If dt.Rows(i)("UserLogin") Is DBNull.Value Then
                        SelectedRegistry.UserLogin = Nothing
                    Else
                        SelectedRegistry.UserLogin = dt.Rows(i)("UserLogin")
                    End If

                    If dt.Rows(i)("Comments") Is DBNull.Value Then
                        SelectedRegistry.Comments = Nothing
                    Else
                        SelectedRegistry.Comments = dt.Rows(i)("Comments")
                    End If
                    SelectedRegistry.RegistryType = dt.Rows(i)("RegistryType")
                    If dt.Rows(i)("Values204") Is DBNull.Value Then
                        SelectedRegistry.Values204 = Nothing
                    Else
                        SelectedRegistry.Values204 = dt.Rows(i)("Values204")
                    End If

                    If dt.Rows(i)("OldValues204") Is DBNull.Value Then
                        SelectedRegistry.OldValues204 = Nothing
                    Else
                        SelectedRegistry.OldValues204 = dt.Rows(i)("OldValues204")
                    End If

                    If dt.Rows(i)("id_User2") Is DBNull.Value Then
                        SelectedRegistry.id_User2 = 0
                    Else
                        SelectedRegistry.id_User2 = Integer.Parse(dt.Rows(i)("id_User2"))
                    End If

                    If dt.Rows(i)("UserLogin2") Is DBNull.Value Then
                        SelectedRegistry.UserLogin2 = Nothing
                    Else
                        SelectedRegistry.UserLogin2 = dt.Rows(i)("UserLogin2")
                    End If
                    If dt.Rows(i)("type206") Is DBNull.Value Then
                        SelectedRegistry.type206 = Nothing
                    Else
                        SelectedRegistry.type206 = dt.Rows(i)("type206")
                    End If
                    If dt.Rows(i)("RegistrySubmittedyear") Is DBNull.Value Then
                        SelectedRegistry.RegistrySubmittedyear = Nothing
                    Else
                        SelectedRegistry.RegistrySubmittedyear = DateTime.Parse(dt.Rows(i)("RegistrySubmittedyear"))
                    End If

                    If dt.Rows(i)("id_UserTransactions") Is DBNull.Value Then
                        SelectedRegistry.id_UserTransactions = 0
                    Else
                        SelectedRegistry.id_UserTransactions = Integer.Parse(dt.Rows(i)("id_UserTransactions"))
                    End If

                    If dt.Rows(i)("UserTransactions") Is DBNull.Value Then
                        SelectedRegistry.UserTransactions = Nothing
                    Else
                        SelectedRegistry.UserTransactions = (dt.Rows(i)("UserTransactions"))
                    End If

                    If dt.Rows(i)("id_CompleteRegistry") Is DBNull.Value Then
                        SelectedRegistry.id_CompleteRegistry = 0
                    Else
                        SelectedRegistry.id_CompleteRegistry = Integer.Parse(dt.Rows(i)("id_CompleteRegistry"))
                    End If

                    lstofRegistry.Add(SelectedRegistry)
                Next
            End If

        Catch ex As Exception

        Finally
            DBSqlconnection.Close()
        End Try

        Return lstofRegistry
    End Function
    'Private Function GetRegistryDeleviredForDescription(ByVal _idRegister As Integer) As String
    '    Dim lstofDescription As String
    '    Try
    '        Dim strQuerry As String
    '        Dim SelectedRegistry As New Registry
    '        lstofDescription = String.Empty

    '        DBSqlconnection = New SqlConnection(DBSqlconnectionString)

    '        strQuerry = "select id_Registry,id_RegistryDeleviredFor,id_PaperSource as id_DeliveredFor,PaperSourceDescription as DeliveredForDescription from vue_getAllDeliveredForRegistry where id_Registry = " & _idRegister

    '        DBSqlconnection.Open()
    '        Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
    '        Dim da As New SqlDataAdapter(cmd)
    '        Dim dt As New DataTable()
    '        da.Fill(dt)

    '        For i As Integer = 0 To dt.Rows.Count - 1
    '            If lstofDescription = "" Then
    '                lstofDescription = dt.Rows(i).Item("DeliveredForDescription")
    '            Else
    '                lstofDescription = lstofDescription + ";" + dt.Rows(i).Item("DeliveredForDescription")
    '            End If


    '        Next

    '    Catch ex As Exception

    '    Finally
    '        DBSqlconnection.Close()
    '    End Try

    '    Return lstofDescription
    'End Function
    'Private Function GetListOfRegistryDeleviredFor(ByVal _idRegister As Integer) As Integer()
    '    Dim wyj As Integer()
    '    Try
    '        Dim strQuerry As String
    '        Dim SelectedRegistry As New Registry
    '        Dim lstofinteger As New List(Of Integer)

    '        DBSqlconnection = New SqlConnection(DBSqlconnectionString)

    '        strQuerry = "select id_Registry,id_RegistryDeleviredFor,id_PaperSource as id_DeliveredFor,PaperSourceDescription as DeliveredForDescription from vue_getAllDeliveredForRegistry where id_Registry = " & _idRegister

    '        DBSqlconnection.Open()
    '        Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
    '        Dim da As New SqlDataAdapter(cmd)
    '        Dim dt As New DataTable()
    '        da.Fill(dt)

    '        For i As Integer = 0 To dt.Rows.Count - 1
    '            lstofinteger.Add(dt.Rows(i).Item("id_DeliveredFor"))

    '        Next
    '        wyj = lstofinteger.ToArray()
    '    Catch ex As Exception

    '    Finally
    '        DBSqlconnection.Close()
    '    End Try

    '    Return wyj

    'End Function


    Public Function GetListOfRegistryDeleviredFor(ByVal _idRegister As Integer) As List(Of Integer)
        Dim wyj As Integer()
        Dim lstofinteger As New List(Of Integer)
        Try
            Dim strQuerry As String
            Dim SelectedRegistry As New Registry


            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select id_Registry,id_RegistryDeleviredFor,id_PaperSource as id_DeliveredFor,PaperSourceDescription as DeliveredForDescription from vue_getAllDeliveredForRegistry where id_Registry = " & _idRegister

            DBSqlconnection.Open()
            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            For i As Integer = 0 To dt.Rows.Count - 1
                lstofinteger.Add(dt.Rows(i).Item("id_DeliveredFor"))

            Next
            wyj = lstofinteger.ToArray()
        Catch ex As Exception

        Finally
            DBSqlconnection.Close()
        End Try

        Return lstofinteger

    End Function


    Function SaveRegistryData(ByVal _lstofRegistry As List(Of Registry)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_RegistryInsert @Registry_Year,@Registry_Date,@Registry_Submitted,@Papernumber,@PaperDate,@Registry_Description,@DeliveredFrom_duedate,@Registry_BackSide,@id_DeliveredFor,@id_PaperSource,@id_User,@RegistryType,@id_User2,@id_Registry,@type206,@id_UserTransactions,@RegistrySubmittedyear"
            For i As Integer = 0 To _lstofRegistry.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "sp_RegistryInsert"
                'cmd.CommandText = strQuerry
                cmd.Parameters.Add("@Registry_Year", SqlDbType.NVarChar).Value = _lstofRegistry(i).Registry_Date.Value.Year
                If _lstofRegistry(i).Registry_Date Is Nothing Then
                    cmd.Parameters.Add("@Registry_Date", SqlDbType.DateTime).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@Registry_Date", SqlDbType.DateTime).Value = _lstofRegistry(i).Registry_Date
                End If
                'cmd.Parameters.Add("@Registry_Date", SqlDbType.DateTime).Value = _lstofRegistry(i).Registry_Date
                If _lstofRegistry(i).Registry_Submitted Is Nothing Then
                    cmd.Parameters.Add("@Registry_Submitted", SqlDbType.NVarChar).Value = DBNull.Value

                Else
                    cmd.Parameters.Add("@Registry_Submitted", SqlDbType.NVarChar).Value = _lstofRegistry(i).Registry_Submitted

                End If

                If _lstofRegistry(i).Papernumber Is Nothing Then
                    cmd.Parameters.Add("@Papernumber", SqlDbType.NVarChar).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@Papernumber", SqlDbType.NVarChar).Value = _lstofRegistry(i).Papernumber
                End If


                If _lstofRegistry(i).PaperDate Is Nothing Then
                    cmd.Parameters.Add("@PaperDate", SqlDbType.DateTime).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@PaperDate", SqlDbType.DateTime).Value = _lstofRegistry(i).PaperDate
                End If

                If _lstofRegistry(i).Registry_Description Is Nothing Then
                    cmd.Parameters.Add("@Registry_Description", SqlDbType.NVarChar).Value = ""
                Else
                    cmd.Parameters.Add("@Registry_Description", SqlDbType.NVarChar).Value = _lstofRegistry(i).Registry_Description
                End If
                'cmd.Parameters.Add("@PaperDate", SqlDbType.DateTime).Value = _lstofRegistry(i).PaperDate


                If _lstofRegistry(i).DeliveredFrom_duedate Is Nothing Then
                    cmd.Parameters.Add("@DeliveredFrom_duedate", SqlDbType.DateTime).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@DeliveredFrom_duedate", SqlDbType.DateTime).Value = _lstofRegistry(i).DeliveredFrom_duedate
                End If

                'cmd.Parameters.Add("@DeliveredFrom_duedate", SqlDbType.DateTime).Value = _lstofRegistry(i).DeliveredFrom_duedate
                'cmd.Parameters.Add("@DeliveredTo_duedate", SqlDbType.DateTime).Value = _lstofRegistry(i).DeliveredTo_duedate
                'If _lstofRegistry(i).DeliveredTo_duedate Is Nothing Then
                '    cmd.Parameters.Add("@DeliveredTo_duedate", SqlDbType.DateTime).Value = DBNull.Value
                'Else
                '    cmd.Parameters.Add("@DeliveredTo_duedate", SqlDbType.DateTime).Value = _lstofRegistry(i).DeliveredTo_duedate
                'End If
                'cmd.Parameters.Add("@SubmissionDate", SqlDbType.DateTime).Value = _lstofRegistry(i).SubmissionDate



                'cmd.Parameters.Add("@DateOfRegistration", SqlDbType.DateTime).Value = _lstofRegistry(i).DateOfRegistration
                If _lstofRegistry(i).Registry_BackSide Is Nothing Then
                    cmd.Parameters.Add("@Registry_BackSide", SqlDbType.NVarChar).Value = DBNull.Value

                Else
                    cmd.Parameters.Add("@Registry_BackSide", SqlDbType.NVarChar).Value = _lstofRegistry(i).Registry_BackSide

                End If

                If _lstofRegistry(i).id_PaperSource = 0 Then
                    cmd.Parameters.Add("@id_PaperSource", SqlDbType.Int).Value = DBNull.Value

                Else
                    cmd.Parameters.Add("@id_PaperSource", SqlDbType.Int).Value = _lstofRegistry(i).id_PaperSource

                End If

                'cmd.Parameters.Add("@id_PaperSource", SqlDbType.Int).Value = _lstofRegistry(i).id_PaperSource


                If _lstofRegistry(i).id_DeliveredFor = 0 Then
                    cmd.Parameters.Add("@id_DeliveredFor", SqlDbType.Int).Value = DBNull.Value

                Else
                    cmd.Parameters.Add("@id_DeliveredFor", SqlDbType.Int).Value = _lstofRegistry(i).id_DeliveredFor

                End If

                'cmd.Parameters.Add("@id_DeliveredFor", SqlDbType.Int).Value = _lstofRegistry(i).id_DeliveredFor
                cmd.Parameters.Add("@id_User", SqlDbType.Int).Value = _lstofRegistry(i).id_User
               
                cmd.Parameters.Add("@RegistryType", SqlDbType.NVarChar).Value = _lstofRegistry(i).RegistryType
             
                'If _lstofRegistry(i).Values204 Is Nothing Then
                '    cmd.Parameters.Add("@Values204", SqlDbType.NVarChar).Value = DBNull.Value

                'Else
                '    cmd.Parameters.Add("@Values204", SqlDbType.NVarChar).Value = _lstofRegistry(i).Values204

                'End If
                'cmd.Parameters.Add("@id_User2", SqlDbType.Int).Value = _lstofRegistry(i).id_User2
                cmd.Parameters.Add("@id_Registry", SqlDbType.Int)

                cmd.Parameters("@id_Registry").Direction = ParameterDirection.Output
                If _lstofRegistry(i).type206 Is Nothing Then
                    cmd.Parameters.Add("@type206", SqlDbType.NVarChar).Value = DBNull.Value

                Else
                    cmd.Parameters.Add("@type206", SqlDbType.NVarChar).Value = _lstofRegistry(i).type206

                End If

                If _lstofRegistry(i).RegistrySubmittedyear Is Nothing Then
                    cmd.Parameters.Add("@RegistrySubmittedyear", SqlDbType.DateTime).Value = DBNull.Value

                Else
                    cmd.Parameters.Add("@RegistrySubmittedyear", SqlDbType.DateTime).Value = _lstofRegistry(i).RegistrySubmittedyear

                End If
                cmd.Parameters.Add("@id_UserTransactions", SqlDbType.Int).Value = _lstofRegistry(i).id_UserTransactions
                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                Dim id_Registry As Integer = 0
                id_Registry = cmd.Parameters("@id_Registry").Value
                DBSqlconnection.Close()
                'If _lstofRegistry(i).id_DeliveredFor IsNot Nothing Then
                '    If _lstofRegistry(i).id_DeliveredFor.Count > 0 Then
                '        DeleteRegistryDeliveredForData(id_Registry)
                '        SaveRegistryDeliveredForData(_lstofRegistry(i).id_DeliveredFor, cmd.Parameters("@id_Registry").Value)
                '    End If
                'End If
                SaveCompleteRegistryData(_lstofRegistry.Item(i), id_Registry)
            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Function InsertCompleteRegistryData(ByVal _Registry As Registry, ByVal idUser As Integer) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_CompleteRegistryInsert @id_Registry,@RegistrydueDate,@SubmissionDate,@SubjectSentFor,@Comments,@DeliveredTo_duedate,@id_User2,@id_DeliveredFor,@id_UserTransactions,@OldValues204"

            Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_CompleteRegistryInsert"
            'cmd.CommandText = strQuerry
            cmd.Parameters.Add("@id_Registry", SqlDbType.Int).Value = _Registry.id_Registry

            If _Registry.DeliveredTo_duedate Is Nothing Then
                cmd.Parameters.Add("@DeliveredTo_duedate", SqlDbType.DateTime).Value = DBNull.Value
            Else
                cmd.Parameters.Add("@DeliveredTo_duedate", SqlDbType.DateTime).Value = _Registry.DeliveredTo_duedate
            End If
            If _Registry.SubmissionDate Is Nothing Then
                cmd.Parameters.Add("@SubmissionDate", SqlDbType.DateTime).Value = DBNull.Value
            Else
                cmd.Parameters.Add("@SubmissionDate", SqlDbType.DateTime).Value = _Registry.SubmissionDate
            End If

            If _Registry.SubjectSentFor Is Nothing Then
                cmd.Parameters.Add("@SubjectSentFor", SqlDbType.NVarChar).Value = DBNull.Value
            Else
                cmd.Parameters.Add("@SubjectSentFor", SqlDbType.NVarChar).Value = _Registry.SubjectSentFor
            End If


            If _Registry.Comments Is Nothing Then
                cmd.Parameters.Add("@Comments", SqlDbType.NVarChar).Value = DBNull.Value
            Else
                cmd.Parameters.Add("@Comments", SqlDbType.NVarChar).Value = _Registry.Comments
            End If





            If _Registry.RegistrydueDate Is Nothing Then
                cmd.Parameters.Add("@RegistrydueDate", SqlDbType.DateTime).Value = DBNull.Value
            Else
                cmd.Parameters.Add("@RegistrydueDate", SqlDbType.DateTime).Value = _Registry.RegistrydueDate
            End If

            cmd.Parameters.Add("@id_User2", SqlDbType.Int).Value = idUser

            If _Registry.id_DeliveredFor = 0 Then
                cmd.Parameters.Add("@id_DeliveredFor", SqlDbType.Int).Value = DBNull.Value
            Else
                cmd.Parameters.Add("@id_DeliveredFor", SqlDbType.Int).Value = _Registry.id_DeliveredFor
            End If
            If _Registry.id_UserTransactions = 0 Then
                cmd.Parameters.Add("@id_UserTransactions", SqlDbType.Int).Value = DBNull.Value
            Else
                cmd.Parameters.Add("@id_UserTransactions", SqlDbType.Int).Value = _Registry.id_UserTransactions
            End If


            If _Registry.OldValues204 Is Nothing Then
                cmd.Parameters.Add("@OldValues204", SqlDbType.NVarChar).Value = DBNull.Value
            Else
                cmd.Parameters.Add("@OldValues204", SqlDbType.NVarChar).Value = _Registry.OldValues204
            End If


            DBSqlconnection.Open()
            cmd.ExecuteNonQuery()

            DBSqlconnection.Close()
            'If _lstofRegistry(i).id_DeliveredFor IsNot Nothing Then
            '    If _lstofRegistry(i).id_DeliveredFor.Count > 0 Then
            '        DeleteRegistryDeliveredForData(id_Registry)
            '        SaveRegistryDeliveredForData(_lstofRegistry(i).id_DeliveredFor, cmd.Parameters("@id_Registry").Value)
            '    End If
            'End If





        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function



    Function SaveCompleteRegistryData(ByVal _206Registry As Registry, ByVal _idRegistry As Integer) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_CompleteRegistryInsert @id_Registry,@RegistrydueDate,@SubmissionDate,@SubjectSentFor,@Comments,@id_204Registry,@DeliveredTo_duedate,@id_DeliveredFor,@id_UserTransactions,@OldValues204"

            Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_CompleteRegistryInsert"
            'cmd.CommandText = strQuerry
            cmd.Parameters.Add("@id_Registry", SqlDbType.Int).Value = _idRegistry



            If _206Registry.DeliveredTo_duedate Is Nothing Then
                cmd.Parameters.Add("@DeliveredTo_duedate", SqlDbType.DateTime).Value = DBNull.Value
            Else
                cmd.Parameters.Add("@DeliveredTo_duedate", SqlDbType.DateTime).Value = _206Registry.DeliveredTo_duedate
            End If
            'cmd.Parameters.Add("@SubmissionDate", SqlDbType.DateTime).Value = _lstofRegistry(i).SubmissionDate
            If _206Registry.SubmissionDate Is Nothing Then
                cmd.Parameters.Add("@SubmissionDate", SqlDbType.DateTime).Value = DBNull.Value
            Else
                cmd.Parameters.Add("@SubmissionDate", SqlDbType.DateTime).Value = _206Registry.SubmissionDate
            End If
            If _206Registry.SubjectSentFor Is Nothing Then
                cmd.Parameters.Add("@SubjectSentFor", SqlDbType.NVarChar).Value = ""
            Else
                cmd.Parameters.Add("@SubjectSentFor", SqlDbType.NVarChar).Value = _206Registry.SubjectSentFor
            End If


            If _206Registry.Comments Is Nothing Then
                cmd.Parameters.Add("@Comments", SqlDbType.NVarChar).Value = DBNull.Value

            Else
                cmd.Parameters.Add("@Comments", SqlDbType.NVarChar).Value = _206Registry.Comments

            End If
            If _206Registry.RegistrydueDate Is Nothing Then
                cmd.Parameters.Add("@RegistrydueDate", SqlDbType.DateTime).Value = DBNull.Value
            Else
                cmd.Parameters.Add("@RegistrydueDate", SqlDbType.DateTime).Value = _206Registry.RegistrydueDate
            End If

            cmd.Parameters.Add("@id_User2", SqlDbType.Int).Value = _206Registry.id_User2
            If _206Registry.id_DeliveredFor = 0 Then
                cmd.Parameters.Add("@id_DeliveredFor", SqlDbType.Int).Value = DBNull.Value
            Else
                cmd.Parameters.Add("@id_DeliveredFor", SqlDbType.Int).Value = _206Registry.id_DeliveredFor
            End If

            If _206Registry.id_UserTransactions = 0 Then
                cmd.Parameters.Add("@id_UserTransactions", SqlDbType.Int).Value = DBNull.Value
            Else
                cmd.Parameters.Add("@id_UserTransactions", SqlDbType.Int).Value = _206Registry.id_UserTransactions

            End If
            If _206Registry.OldValues204 Is Nothing Then
                cmd.Parameters.Add("@OldValues204", SqlDbType.NVarChar).Value = DBNull.Value
            Else
                cmd.Parameters.Add("@OldValues204", SqlDbType.NVarChar).Value = _206Registry.OldValues204
            End If


            DBSqlconnection.Open()
            cmd.ExecuteNonQuery()

            DBSqlconnection.Close()
            'If _lstofRegistry(i).id_DeliveredFor IsNot Nothing Then
            '    If _lstofRegistry(i).id_DeliveredFor.Count > 0 Then
            '        DeleteRegistryDeliveredForData(id_Registry)
            '        SaveRegistryDeliveredForData(_lstofRegistry(i).id_DeliveredFor, cmd.Parameters("@id_Registry").Value)
            '    End If
            'End If





        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Function SaveRegistryDeliveredForData(ByVal _idDeliveredFor As Integer, ByVal _idregister As Integer) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_RegistryDeliveredForInsert @id_Registry,@id_DeliveredFor"
            Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
            cmd.CommandText = strQuerry
            cmd.Parameters.Add("@id_Registry", SqlDbType.Int).Value = _idregister
            cmd.Parameters.Add("@id_DeliveredFor", SqlDbType.Int).Value = _idDeliveredFor


            DBSqlconnection.Open()
            cmd.ExecuteNonQuery()
            DBSqlconnection.Close()




        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Function UpdateRegistryData(ByVal _lstofRegistry As List(Of Registry)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_RegistryUpdate @id_Registry,@Registry_Submitted,@Papernumber,@PaperDate,@Registry_Description,@DeliveredFrom_duedate,@DeliveredTo_duedate,@SubmissionDate,@SubjectSentFor,@Registry_BackSide,@id_DeliveredFor,@id_PaperSource,@id_User,@Comments,@RegistryType,@RegistrydueDate,@id_User2,@id_UserTransactions,@RegistrySubmittedyear"
            For i As Integer = 0 To _lstofRegistry.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandText = strQuerry
                cmd.Parameters.Add("@id_Registry", SqlDbType.Int).Value = _lstofRegistry(i).id_Registry
                If _lstofRegistry(i).Registry_Date Is Nothing Then
                    cmd.Parameters.Add("@Registry_Date", SqlDbType.DateTime).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@Registry_Date", SqlDbType.DateTime).Value = _lstofRegistry(i).Registry_Date
                End If
                'cmd.Parameters.Add("@Registry_Date", SqlDbType.DateTime).Value = _lstofRegistry(i).Registry_Date
                If _lstofRegistry(i).Registry_Submitted Is Nothing Then
                    cmd.Parameters.Add("@Registry_Submitted", SqlDbType.NVarChar).Value = DBNull.Value

                Else
                    cmd.Parameters.Add("@Registry_Submitted", SqlDbType.NVarChar).Value = _lstofRegistry(i).Registry_Submitted

                End If

                If _lstofRegistry(i).Papernumber Is Nothing Then
                    cmd.Parameters.Add("@Papernumber", SqlDbType.NVarChar).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@Papernumber", SqlDbType.NVarChar).Value = _lstofRegistry(i).Papernumber
                End If


                If _lstofRegistry(i).PaperDate Is Nothing Then
                    cmd.Parameters.Add("@PaperDate", SqlDbType.DateTime).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@PaperDate", SqlDbType.DateTime).Value = _lstofRegistry(i).PaperDate
                End If

                If _lstofRegistry(i).Registry_Description Is Nothing Then
                    cmd.Parameters.Add("@Registry_Description", SqlDbType.NVarChar).Value = ""
                Else
                    cmd.Parameters.Add("@Registry_Description", SqlDbType.NVarChar).Value = _lstofRegistry(i).Registry_Description
                End If
                'cmd.Parameters.Add("@PaperDate", SqlDbType.DateTime).Value = _lstofRegistry(i).PaperDate


                If _lstofRegistry(i).DeliveredFrom_duedate Is Nothing Then
                    cmd.Parameters.Add("@DeliveredFrom_duedate", SqlDbType.DateTime).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@DeliveredFrom_duedate", SqlDbType.DateTime).Value = _lstofRegistry(i).DeliveredFrom_duedate
                End If

                'cmd.Parameters.Add("@DeliveredFrom_duedate", SqlDbType.DateTime).Value = _lstofRegistry(i).DeliveredFrom_duedate
                'cmd.Parameters.Add("@DeliveredTo_duedate", SqlDbType.DateTime).Value = _lstofRegistry(i).DeliveredTo_duedate
                If _lstofRegistry(i).DeliveredTo_duedate Is Nothing Then
                    cmd.Parameters.Add("@DeliveredTo_duedate", SqlDbType.DateTime).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@DeliveredTo_duedate", SqlDbType.DateTime).Value = _lstofRegistry(i).DeliveredTo_duedate
                End If
                'cmd.Parameters.Add("@SubmissionDate", SqlDbType.DateTime).Value = _lstofRegistry(i).SubmissionDate
                If _lstofRegistry(i).SubmissionDate Is Nothing Then
                    cmd.Parameters.Add("@SubmissionDate", SqlDbType.DateTime).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@SubmissionDate", SqlDbType.DateTime).Value = _lstofRegistry(i).SubmissionDate
                End If
                If _lstofRegistry(i).SubjectSentFor Is Nothing Then
                    cmd.Parameters.Add("@SubjectSentFor", SqlDbType.NVarChar).Value = ""
                Else
                    cmd.Parameters.Add("@SubjectSentFor", SqlDbType.NVarChar).Value = _lstofRegistry(i).SubjectSentFor
                End If

                'cmd.Parameters.Add("@DateOfRegistration", SqlDbType.DateTime).Value = _lstofRegistry(i).DateOfRegistration
                If _lstofRegistry(i).Registry_BackSide Is Nothing Then
                    cmd.Parameters.Add("@Registry_BackSide", SqlDbType.NVarChar).Value = DBNull.Value

                Else
                    cmd.Parameters.Add("@Registry_BackSide", SqlDbType.NVarChar).Value = _lstofRegistry(i).Registry_BackSide

                End If

                If _lstofRegistry(i).id_PaperSource = 0 Then
                    cmd.Parameters.Add("@id_PaperSource", SqlDbType.Int).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@id_PaperSource", SqlDbType.Int).Value = _lstofRegistry(i).id_PaperSource
                End If


                cmd.Parameters.Add("@id_DeliveredFor", SqlDbType.Int).Value = _lstofRegistry(i).id_DeliveredFor
                cmd.Parameters.Add("@id_User", SqlDbType.Int).Value = _lstofRegistry(i).id_User
                If _lstofRegistry(i).Comments Is Nothing Then
                    cmd.Parameters.Add("@Comments", SqlDbType.NVarChar).Value = DBNull.Value

                Else
                    cmd.Parameters.Add("@Comments", SqlDbType.NVarChar).Value = _lstofRegistry(i).Comments

                End If
                cmd.Parameters.Add("@RegistryType", SqlDbType.NVarChar).Value = _lstofRegistry(i).RegistryType
                If _lstofRegistry(i).RegistrydueDate Is Nothing Then
                    cmd.Parameters.Add("@RegistrydueDate", SqlDbType.DateTime).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@RegistrydueDate", SqlDbType.DateTime).Value = _lstofRegistry(i).RegistrydueDate
                End If

                'If _lstofRegistry(i).OldValues204 Is Nothing Then
                '    cmd.Parameters.Add("@OldValues204", SqlDbType.NVarChar).Value = DBNull.Value
                'Else
                '    cmd.Parameters.Add("@OldValues204", SqlDbType.NVarChar).Value = _lstofRegistry(i).OldValues204
                'End If
                If _lstofRegistry(i).RegistrySubmittedyear Is Nothing Then
                    cmd.Parameters.Add("@RegistrySubmittedyear", SqlDbType.DateTime).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@RegistrySubmittedyear", SqlDbType.DateTime).Value = _lstofRegistry(i).RegistrySubmittedyear
                End If
                cmd.Parameters.Add("@id_User2", SqlDbType.Int).Value = _lstofRegistry(i).id_User2
                cmd.Parameters.Add("@id_UserTransactions", SqlDbType.Int).Value = _lstofRegistry(i).id_UserTransactions

                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                DBSqlconnection.Close()
                'If _lstofRegistry(i).id_DeliveredFor IsNot Nothing Then
                '    If _lstofRegistry(i).id_DeliveredFor.Count > 0 Then
                '        DeleteRegistryDeliveredForData(_lstofRegistry(i).id_Registry)
                '        SaveRegistryDeliveredForData(_lstofRegistry(i).id_DeliveredFor, _lstofRegistry(i).id_Registry)
                '    End If
                'End If

                UpdateComplateRegistryData(_lstofRegistry.Item(i))
            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function


    Function UpdateComplateRegistryData(ByVal _206Registry As Registry) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_CompleteRegistryUpdate @id_CompleteRegistry,@RegistrydueDate,@SubmissionDate,@SubjectSentFor,@Comments,@DeliveredTo_duedate,@id_User2,@id_DeliveredFor,@id_UserTransactions,@OldValues204"

            Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
            cmd.CommandText = strQuerry
            cmd.Parameters.Add("@id_CompleteRegistry", SqlDbType.Int).Value = _206Registry.id_CompleteRegistry
            If _206Registry.RegistrydueDate Is Nothing Then
                cmd.Parameters.Add("@RegistrydueDate", SqlDbType.DateTime).Value = DBNull.Value
            Else
                cmd.Parameters.Add("@RegistrydueDate", SqlDbType.DateTime).Value = _206Registry.RegistrydueDate
            End If
            'cmd.Parameters.Add("@Registry_Date", SqlDbType.DateTime).Value = _lstofRegistry(i).Registry_Date
            If _206Registry.SubmissionDate Is Nothing Then
                cmd.Parameters.Add("@SubmissionDate", SqlDbType.DateTime).Value = DBNull.Value

            Else
                cmd.Parameters.Add("@SubmissionDate", SqlDbType.DateTime).Value = _206Registry.SubmissionDate

            End If


            If _206Registry.SubjectSentFor Is Nothing Then
                cmd.Parameters.Add("@SubjectSentFor", SqlDbType.NVarChar).Value = ""
            Else
                cmd.Parameters.Add("@SubjectSentFor", SqlDbType.NVarChar).Value = _206Registry.SubjectSentFor
            End If
            'cmd.Parameters.Add("@PaperDate", SqlDbType.DateTime).Value = _lstofRegistry(i).PaperDate



            If _206Registry.Comments Is Nothing Then
                cmd.Parameters.Add("@Comments", SqlDbType.NVarChar).Value = ""
            Else
                cmd.Parameters.Add("@Comments", SqlDbType.NVarChar).Value = _206Registry.Comments
            End If

            'cmd.Parameters.Add("@DateOfRegistration", SqlDbType.DateTime).Value = _lstofRegistry(i).DateOfRegistration
            If _206Registry.DeliveredTo_duedate Is Nothing Then
                cmd.Parameters.Add("@DeliveredTo_duedate", SqlDbType.DateTime).Value = DBNull.Value

            Else
                cmd.Parameters.Add("@DeliveredTo_duedate", SqlDbType.DateTime).Value = _206Registry.DeliveredTo_duedate

            End If

            cmd.Parameters.Add("@id_User2", SqlDbType.Int).Value = _206Registry.id_User2
            If _206Registry.id_DeliveredFor = 0 Then
                cmd.Parameters.Add("@id_DeliveredFor", SqlDbType.Int).Value = DBNull.Value
            Else
                cmd.Parameters.Add("@id_DeliveredFor", SqlDbType.Int).Value = _206Registry.id_DeliveredFor
            End If
            If _206Registry.id_UserTransactions = 0 Then
                cmd.Parameters.Add("@id_UserTransactions", SqlDbType.Int).Value = DBNull.Value
            Else
                cmd.Parameters.Add("@id_UserTransactions", SqlDbType.Int).Value = _206Registry.id_UserTransactions
            End If
            'cmd.Parameters.Add("@id_DeliveredFor", SqlDbType.Int).Value = _206Registry.id_DeliveredFor
            'cmd.Parameters.Add("@id_UserTransactions", SqlDbType.Int).Value = _206Registry.id_UserTransactions
            If _206Registry.OldValues204 Is Nothing Then
                cmd.Parameters.Add("@OldValues204", SqlDbType.NVarChar).Value = DBNull.Value
            Else
                cmd.Parameters.Add("@OldValues204", SqlDbType.NVarChar).Value = _206Registry.OldValues204
            End If
            DBSqlconnection.Open()
            cmd.ExecuteNonQuery()
            DBSqlconnection.Close()
            'If _lstofRegistry(i).id_DeliveredFor IsNot Nothing Then
            '    If _lstofRegistry(i).id_DeliveredFor.Count > 0 Then
            '        DeleteRegistryDeliveredForData(_lstofRegistry(i).id_Registry)
            '        SaveRegistryDeliveredForData(_lstofRegistry(i).id_DeliveredFor, _lstofRegistry(i).id_Registry)
            '    End If
            'End If






        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function


    Function DeleteRegistryData(ByVal _lstofRegistry As List(Of Registry)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_RegistryDelete @id_Registry"
            For i As Integer = 0 To _lstofRegistry.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandText = strQuerry
                cmd.Parameters.Add("@id_Registry", SqlDbType.Int).Value = _lstofRegistry(i).id_Registry

                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                DBSqlconnection.Close()
            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Function ClearRegistryData(ByVal _idCompleteRegistry As Integer) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_206Clear204 @id_CompleteRegistry"

            Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
            cmd.CommandText = strQuerry
            cmd.Parameters.Add("@id_CompleteRegistry", SqlDbType.Int).Value = _idCompleteRegistry

            DBSqlconnection.Open()
            cmd.ExecuteNonQuery()
            DBSqlconnection.Close()



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Function DeleteCompleteRegistryData(ByVal _completeregistry As Integer, ByVal _id204Registry As Integer) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_CompleteRegistryDelete @id_CompleteRegistry,@id_204Registry"
            Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
            cmd.CommandText = strQuerry
            

            cmd.Parameters.Add("@id_CompleteRegistry", SqlDbType.Int).Value = _completeregistry
            If _id204Registry = 0 Then
                cmd.Parameters.Add("@id_204Registry", SqlDbType.Int).Value = 0
            Else
                cmd.Parameters.Add("@id_204Registry", SqlDbType.Int).Value = _id204Registry
            End If

            DBSqlconnection.Open()
            cmd.ExecuteNonQuery()
            DBSqlconnection.Close()



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Function DeleteRegistryDeliveredForData(ByVal _idRegistry As Integer) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_RegistryDeliveredForDelete @id_Registry"

            Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
            cmd.CommandText = strQuerry
            cmd.Parameters.Add("@id_Registry", SqlDbType.Int).Value = _idRegistry

            DBSqlconnection.Open()
            cmd.ExecuteNonQuery()




        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        Finally
            DBSqlconnection.Close()
        End Try

        Return True
    End Function
#End Region

#Region "RegistryWalet"
    Function GetAllRegistryWallet() As List(Of registryWallet)
        Dim lstofregistryWallet As New List(Of registryWallet)
        Try
            Dim strQuerry As String
            Dim SelectedRegistryWallet As New registryWallet

            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select id_RegistryWallet,RegistryWalletSeq,RegistryWalletDate,RWPapernumber,RWSubject,RWComments, "
            strQuerry = strQuerry + "RWYear,id_PaperSource,PaperSourceDescription,RWPaperdate,id_User,UserLogin"
            strQuerry = strQuerry + " from vue_getAllRegistryWallet"
            strQuerry = strQuerry + " order by RegistryWalletDate desc"
            DBSqlconnection.Open()

            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    SelectedRegistryWallet = New registryWallet
                    SelectedRegistryWallet.id_RegistryWallet = dt.Rows(i)("id_RegistryWallet")
                    SelectedRegistryWallet.RegistryWalletSeq = dt.Rows(i)("RegistryWalletSeq")
                    If dt.Rows(i)("id_PaperSource") Is DBNull.Value Then
                        SelectedRegistryWallet.id_PaperSource = Nothing
                    Else
                        SelectedRegistryWallet.id_PaperSource = dt.Rows(i)("id_PaperSource")

                    End If
                    If dt.Rows(i)("RegistryWalletDate") Is DBNull.Value Then
                        SelectedRegistryWallet.RegistryWalletDate = Nothing
                    Else
                        SelectedRegistryWallet.RegistryWalletDate = DateTime.Parse(dt.Rows(i)("RegistryWalletDate").ToString)
                    End If
                    If dt.Rows(i)("RWPapernumber") Is DBNull.Value Then
                        SelectedRegistryWallet.RWPapernumber = Nothing
                    Else
                        SelectedRegistryWallet.RWPapernumber = dt.Rows(i)("RWPapernumber")
                    End If


                    If dt.Rows(i)("RWComments") Is DBNull.Value Then
                        SelectedRegistryWallet.RWComments = Nothing
                    Else
                        SelectedRegistryWallet.RWComments = dt.Rows(i)("RWComments")
                    End If

                    If dt.Rows(i)("RWSubject") Is DBNull.Value Then
                        SelectedRegistryWallet.RWSubject = Nothing
                    Else
                        SelectedRegistryWallet.RWSubject = (dt.Rows(i)("RWSubject"))
                    End If

                    If dt.Rows(i)("PaperSourceDescription") Is DBNull.Value Then
                        SelectedRegistryWallet.PaperSourceDescription = Nothing
                    Else
                        SelectedRegistryWallet.PaperSourceDescription = dt.Rows(i)("PaperSourceDescription").ToString
                    End If

                    If dt.Rows(i)("RWPaperdate") Is DBNull.Value Then
                        SelectedRegistryWallet.RWPaperdate = Nothing
                    Else
                        SelectedRegistryWallet.RWPaperdate = DateTime.Parse(dt.Rows(i)("RWPaperdate").ToString)
                    End If

                    If dt.Rows(i)("id_User") Is DBNull.Value Then
                        SelectedRegistryWallet.id_User = 0
                    Else
                        SelectedRegistryWallet.id_User = Integer.Parse(dt.Rows(i)("id_User"))
                    End If

                    If dt.Rows(i)("UserLogin") Is DBNull.Value Then
                        SelectedRegistryWallet.UserLogin = Nothing
                    Else
                        SelectedRegistryWallet.UserLogin = dt.Rows(i)("UserLogin")
                    End If


                    lstofregistryWallet.Add(SelectedRegistryWallet)
                Next
            End If

        Catch ex As Exception

        Finally
            DBSqlconnection.Close()
        End Try

        Return lstofregistryWallet
    End Function

    Function SaveRegistryWalletData(ByVal _lstofRegistryWallet As List(Of registryWallet)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_RegistryWalletInsert @RegistryWalletDate,@RWPapernumber,@idPaperSource,@RWSubject,@RWComments,@RWYear,@RWPaperdate,@idUser"
            For i As Integer = 0 To _lstofRegistryWallet.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "sp_RegistryWalletInsert"
                'cmd.CommandText = strQuerry
                If _lstofRegistryWallet(i).RegistryWalletDate Is Nothing Then
                    cmd.Parameters.Add("@RegistryWalletDate", SqlDbType.DateTime).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@RegistryWalletDate", SqlDbType.DateTime).Value = _lstofRegistryWallet(i).RegistryWalletDate
                End If

                If _lstofRegistryWallet(i).RWPapernumber Is Nothing Then
                    cmd.Parameters.Add("@RWPapernumber", SqlDbType.NVarChar).Value = DBNull.Value

                Else
                    cmd.Parameters.Add("@RWPapernumber", SqlDbType.NVarChar).Value = _lstofRegistryWallet(i).RWPapernumber

                End If

                If _lstofRegistryWallet(i).RWSubject Is Nothing Then
                    cmd.Parameters.Add("@RWSubject", SqlDbType.NVarChar).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@RWSubject", SqlDbType.NVarChar).Value = _lstofRegistryWallet(i).RWSubject
                End If



                cmd.Parameters.Add("@idPaperSource", SqlDbType.Int).Value = _lstofRegistryWallet(i).id_PaperSource

                If _lstofRegistryWallet(i).RWComments Is Nothing Then
                    cmd.Parameters.Add("@RWComments", SqlDbType.NVarChar).Value = ""
                Else
                    cmd.Parameters.Add("@RWComments", SqlDbType.NVarChar).Value = _lstofRegistryWallet(i).RWComments
                End If
                cmd.Parameters.Add("@RWYear", SqlDbType.NVarChar).Value = DateTime.Now.Year.ToString()

                If _lstofRegistryWallet(i).RWPaperdate Is Nothing Then
                    cmd.Parameters.Add("@RWPaperdate", SqlDbType.DateTime).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@RWPaperdate", SqlDbType.DateTime).Value = _lstofRegistryWallet(i).RWPaperdate
                End If
                cmd.Parameters.Add("@idUser", SqlDbType.Int).Value = _lstofRegistryWallet(i).id_User

                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()

                DBSqlconnection.Close()


            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function


    Function UpdateRegistryWalletData(ByVal _lstofRegistryWallet As List(Of registryWallet)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_RegistryWalletUpdate @id_RegistryWallet,@RegistryWalletDate,@RWPapernumber,@idPaperSource,@RWSubject,@RWComments,@RWPaperdate,@idUser"
            For i As Integer = 0 To _lstofRegistryWallet.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandText = strQuerry
                cmd.Parameters.Add("@id_RegistryWallet", SqlDbType.Int).Value = _lstofRegistryWallet(i).id_RegistryWallet
                If _lstofRegistryWallet(i).RegistryWalletDate Is Nothing Then
                    cmd.Parameters.Add("@RegistryWalletDate", SqlDbType.DateTime).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@RegistryWalletDate", SqlDbType.DateTime).Value = _lstofRegistryWallet(i).RegistryWalletDate
                End If

                cmd.Parameters.Add("@idPaperSource", SqlDbType.NVarChar).Value = _lstofRegistryWallet(i).id_PaperSource


                If _lstofRegistryWallet(i).RWPapernumber Is Nothing Then
                    cmd.Parameters.Add("@RWPapernumber", SqlDbType.NVarChar).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@RWPapernumber", SqlDbType.NVarChar).Value = _lstofRegistryWallet(i).RWPapernumber
                End If


                If _lstofRegistryWallet(i).RWComments Is Nothing Then
                    cmd.Parameters.Add("@RWComments", SqlDbType.NVarChar).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@RWComments", SqlDbType.NVarChar).Value = _lstofRegistryWallet(i).RWComments
                End If

                If _lstofRegistryWallet(i).RWSubject Is Nothing Then
                    cmd.Parameters.Add("@RWSubject", SqlDbType.NVarChar).Value = ""
                Else
                    cmd.Parameters.Add("@RWSubject", SqlDbType.NVarChar).Value = _lstofRegistryWallet(i).RWSubject
                End If

                If _lstofRegistryWallet(i).RWPaperdate Is Nothing Then
                    cmd.Parameters.Add("@RWPaperdate", SqlDbType.DateTime).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@RWPaperdate", SqlDbType.DateTime).Value = _lstofRegistryWallet(i).RWPaperdate
                End If

                cmd.Parameters.Add("@idUser", SqlDbType.Int).Value = _lstofRegistryWallet(i).id_User

                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                DBSqlconnection.Close()


            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function

#End Region

#Region "RegistryDescription"
    Function GetAllRegistryDescription() As DataTable
        Dim lstofRegistry As New List(Of RegistryDescription)
        Dim dt As New DataTable()
        Try
            Dim strQuerry As String
            Dim SelectedRegistry As New RegistryDescription

            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select distinct(Registry_Description) as Registry_Description from Tbl_Registry"
            DBSqlconnection.Open()

            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)

            'If dt.Rows.Count > 0 Then
            '    For i As Integer = 0 To dt.Rows.Count - 1
            '        SelectedRegistry = New RegistryDescription



            '        If dt.Rows(i)("Registry_Description") Is DBNull.Value Then
            '            SelectedRegistry.Registry_Description = Nothing
            '        Else
            '            SelectedRegistry.Registry_Description = dt.Rows(i)("Registry_Description")
            '        End If




            '        lstofRegistry.Add(SelectedRegistry)
            '    Next
            'End If

        Catch ex As Exception

        Finally
            DBSqlconnection.Close()
        End Try

        Return dt
    End Function
#End Region
#Region "RegistrySubjectSentFor"
    Function GetAllRegistrySubjectSentFor() As DataTable
        Dim lstofRegistry As New List(Of Registry)
        Dim dt As New DataTable()
        Try
            Dim strQuerry As String
            Dim SelectedRegistry As New Registry

            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select distinct(SubjectSentFor) as SubjectSentFor from Tbl_Registry"
            DBSqlconnection.Open()

            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)

            'If dt.Rows.Count > 0 Then
            '    For i As Integer = 0 To dt.Rows.Count - 1
            '        SelectedRegistry = New Registry



            '        If dt.Rows(i)("SubjectSentFor") Is DBNull.Value Then
            '            SelectedRegistry.SubjectSentFor = Nothing
            '        Else
            '            SelectedRegistry.SubjectSentFor = dt.Rows(i)("SubjectSentFor")
            '        End If




            '        lstofRegistry.Add(SelectedRegistry)
            '    Next
            'End If

        Catch ex As Exception

        Finally
            DBSqlconnection.Close()
        End Try

        Return dt
    End Function

#End Region


#Region "Registry204"
    Function GetAll204Registry(ByVal _type204 As String) As List(Of Registry204)
        Dim lstof204Registry As New List(Of Registry204)
        Try
            Dim strQuerry As String
            Dim Selected204Registry As New Registry204

            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select id_204Registry,Registry_204Seq,Registry_204Date,"
            strQuerry = strQuerry + "Registry_Description,IncomingNumber,IncomingDate,id_User,UserLogin,id_User2,UserLogin2,id_Registry206,type204,id_DeliveredFor,DeliveredForDescription "
            strQuerry = strQuerry + "from vue_getAll204Registry"
            strQuerry = strQuerry + " where type204 = N'" + _type204 + "'"
            strQuerry = strQuerry + " order by Registry_204Seq desc"
            DBSqlconnection.Open()

            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    Selected204Registry = New Registry204
                    Selected204Registry.id_204Registry = dt.Rows(i)("id_204Registry")

                    If dt.Rows(i)("Registry_204Seq") Is DBNull.Value Then
                        Selected204Registry.Registry_204Seq = Nothing
                    Else
                        Selected204Registry.Registry_204Seq = Integer.Parse(dt.Rows(i)("Registry_204Seq"))

                    End If

                    If dt.Rows(i)("Registry_204Date") Is DBNull.Value Then
                        Selected204Registry.Registry_204Date = Nothing
                    Else
                        Selected204Registry.Registry_204Date = DateTime.Parse(dt.Rows(i)("Registry_204Date").ToString)
                    End If
                    If dt.Rows(i)("Registry_Description") Is DBNull.Value Then
                        Selected204Registry.Registry_Description = Nothing
                    Else
                        Selected204Registry.Registry_Description = dt.Rows(i)("Registry_Description")
                    End If

                    If dt.Rows(i)("IncomingNumber") Is DBNull.Value Then
                        Selected204Registry.IncomingNumber = Nothing
                    Else
                        Selected204Registry.IncomingNumber = dt.Rows(i)("IncomingNumber")
                    End If


                    If dt.Rows(i)("IncomingDate") Is DBNull.Value Then
                        Selected204Registry.IncomingDate = Nothing
                    Else
                        Selected204Registry.IncomingDate = DateTime.Parse(dt.Rows(i)("IncomingDate").ToString)
                    End If

                    'Selected204Registry.SubmissionDate = DateTime.Parse(dt.Rows(i)("SubmissionDate"))

                    'Dim _lstofdelivered As New List(Of DeliveredFor)
                    'Dim deliveredfor1 As New DeliveredFor()
                    'deliveredfor1.id_DeliveredFor = New Integer() {9, 6, 10, 7}
                    'Selected204Registry.id_DeliveredFor = Get204ListOfRegistryDeleviredFor(dt.Rows(i)("id_204Registry"))
                    'Selected204Registry.DeliveredForDescription = Get204RegistryDeleviredForDescription(dt.Rows(i)("id_204Registry"))

                    If dt.Rows(i)("id_DeliveredFor") Is DBNull.Value Then
                        Selected204Registry.id_DeliveredFor = 0
                    Else
                        Selected204Registry.id_DeliveredFor = Integer.Parse(dt.Rows(i)("id_DeliveredFor"))
                    End If

                    If dt.Rows(i)("DeliveredForDescription") Is DBNull.Value Then
                        Selected204Registry.DeliveredForDescription = Nothing
                    Else
                        Selected204Registry.DeliveredForDescription = (dt.Rows(i)("DeliveredForDescription"))
                    End If
                    If dt.Rows(i)("id_User") Is DBNull.Value Then
                        Selected204Registry.id_User = 0
                    Else
                        Selected204Registry.id_User = Integer.Parse(dt.Rows(i)("id_User"))
                    End If

                    If dt.Rows(i)("UserLogin") Is DBNull.Value Then
                        Selected204Registry.UserLogin = Nothing
                    Else
                        Selected204Registry.UserLogin = dt.Rows(i)("UserLogin")
                    End If


                    If dt.Rows(i)("id_User2") Is DBNull.Value Then
                        Selected204Registry.id_User2 = 0
                    Else
                        Selected204Registry.id_User2 = Integer.Parse(dt.Rows(i)("id_User2"))
                    End If

                    If dt.Rows(i)("UserLogin2") Is DBNull.Value Then
                        Selected204Registry.UserLogin2 = Nothing
                    Else
                        Selected204Registry.UserLogin2 = dt.Rows(i)("UserLogin2")
                    End If

                    If dt.Rows(i)("id_Registry206") Is DBNull.Value Then
                        Selected204Registry.id_Registry206 = Nothing
                    Else
                        Selected204Registry.id_Registry206 = dt.Rows(i)("id_Registry206")
                    End If
                    If dt.Rows(i)("type204") Is DBNull.Value Then
                        Selected204Registry.Type204 = Nothing
                    Else
                        Selected204Registry.Type204 = dt.Rows(i)("type204")
                    End If
                    lstof204Registry.Add(Selected204Registry)
                Next
            End If

        Catch ex As Exception

        Finally
            DBSqlconnection.Close()
        End Try

        Return lstof204Registry
    End Function
    Private Function Get204RegistryDeleviredForDescription(ByVal _idRegister As Integer) As String
        Dim lstofDescription As String
        Try
            Dim strQuerry As String
            Dim SelectedRegistry As New Registry
            lstofDescription = String.Empty

            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select id_204Registry,id_RegistryDeleviredFor,id_PaperSource as id_DeliveredFor,PaperSourceDescription as DeliveredForDescription from vue_getAllDeliveredForRegistry204 where id_204Registry = " & _idRegister

            DBSqlconnection.Open()
            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            For i As Integer = 0 To dt.Rows.Count - 1
                If lstofDescription = "" Then
                    lstofDescription = dt.Rows(i).Item("DeliveredForDescription")
                Else
                    lstofDescription = lstofDescription + ";" + dt.Rows(i).Item("DeliveredForDescription")
                End If


            Next

        Catch ex As Exception

        Finally
            DBSqlconnection.Close()
        End Try

        Return lstofDescription
    End Function
    Private Function Get204ListOfRegistryDeleviredFor(ByVal _idRegister As Integer) As Integer()
        Dim wyj As Integer()
        Try
            Dim strQuerry As String
            Dim SelectedRegistry As New Registry
            Dim lstofinteger As New List(Of Integer)

            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select id_204Registry,id_Registry204DeleviredFor,id_PaperSource as id_DeliveredFor,PaperSourceDescription as DeliveredForDescription from vue_getAllDeliveredForRegistry204 where id_204Registry = " & _idRegister

            DBSqlconnection.Open()
            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            For i As Integer = 0 To dt.Rows.Count - 1
                lstofinteger.Add(dt.Rows(i).Item("id_DeliveredFor"))

            Next
            wyj = lstofinteger.ToArray()
        Catch ex As Exception

        Finally
            DBSqlconnection.Close()
        End Try

        Return wyj

    End Function
    Function Save204RegistryData(ByVal _lstofRegistry As List(Of Registry204)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_204RegistryInsert @Registry_204Year,@Registry_204Date,@Registry_Description,@IncomingNumber,@IncomingDate,@id_User,@RegistryType,@id_User2,@id_Registry206,@id_204Registry,@type204"
            For i As Integer = 0 To _lstofRegistry.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "sp_204RegistryInsert"
                'cmd.CommandText = strQuerry
                cmd.Parameters.Add("@Registry_204Year", SqlDbType.NVarChar).Value = _lstofRegistry(i).Registry_204Date.Value.Year
                If _lstofRegistry(i).Registry_204Date Is Nothing Then
                    cmd.Parameters.Add("@Registry_204Date", SqlDbType.DateTime).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@Registry_204Date", SqlDbType.DateTime).Value = _lstofRegistry(i).Registry_204Date
                End If
                'cmd.Parameters.Add("@Registry_Date", SqlDbType.DateTime).Value = _lstofRegistry(i).Registry_Date
                If _lstofRegistry(i).Registry_Description Is Nothing Then
                    cmd.Parameters.Add("@Registry_Description", SqlDbType.NVarChar).Value = DBNull.Value

                Else
                    cmd.Parameters.Add("@Registry_Description", SqlDbType.NVarChar).Value = _lstofRegistry(i).Registry_Description

                End If

                If _lstofRegistry(i).IncomingNumber Is Nothing Then
                    cmd.Parameters.Add("@IncomingNumber", SqlDbType.NVarChar).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@IncomingNumber", SqlDbType.NVarChar).Value = _lstofRegistry(i).IncomingNumber
                End If
                'If _lstofRegistry(i).id_DeliveredFor Is DBNull.Value Then
                '    cmd.Parameters.Add("@id_DeliveredFor", SqlDbType.NVarChar).Value = DBNull.Value
                'Else
                cmd.Parameters.Add("@id_DeliveredFor", SqlDbType.NVarChar).Value = _lstofRegistry(i).id_DeliveredFor
                'End If
                If _lstofRegistry(i).IncomingDate Is Nothing Then
                    cmd.Parameters.Add("@IncomingDate", SqlDbType.DateTime).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@IncomingDate", SqlDbType.DateTime).Value = _lstofRegistry(i).IncomingDate
                End If

                cmd.Parameters.Add("@id_User", SqlDbType.Int).Value = _lstofRegistry(i).id_User

                cmd.Parameters.Add("@RegistryType", SqlDbType.NVarChar).Value = _lstofRegistry(i).RegistryType

                cmd.Parameters.Add("@id_User2", SqlDbType.Int).Value = _lstofRegistry(i).id_User2


                If _lstofRegistry(i).id_Registry206 = 0 Then
                    cmd.Parameters.Add("@id_Registry206", SqlDbType.Int).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@id_Registry206", SqlDbType.Int).Value = _lstofRegistry(i).id_Registry206
                End If

                If _lstofRegistry(i).Type204 Is Nothing Then
                    cmd.Parameters.Add("@type204", SqlDbType.NVarChar).Value = DBNull.Value

                Else
                    cmd.Parameters.Add("@type204", SqlDbType.NVarChar).Value = _lstofRegistry(i).Type204

                End If

                cmd.Parameters.Add("@id_204Registry", SqlDbType.Int)

                cmd.Parameters("@id_204Registry").Direction = ParameterDirection.Output
                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                Dim id_Registry As Integer = 0
                id_Registry = cmd.Parameters("@id_204Registry").Value
                DBSqlconnection.Close()
                'If _lstofRegistry(i).id_DeliveredFor IsNot Nothing Then
                '    If _lstofRegistry(i).id_DeliveredFor.Count > 0 Then
                '        Delete204RegistryDeliveredForData(id_Registry)
                '        Save204RegistryDeliveredForData(_lstofRegistry(i).id_DeliveredFor, cmd.Parameters("@id_204Registry").Value)
                '    End If
                'End If
                'Update204RegistryData(id_Registry, _lstofRegistry(i).id)
            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function


    Function Create204RegistryData(ByVal _lstofRegistry As List(Of Registry204), ByVal _idCompleteRegistry As Integer, ByVal _idUser2 As Integer) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_204RegistryInsert @Registry_204Year,@Registry_204Date,@Registry_Description,@IncomingNumber,@IncomingDate,@id_User,@RegistryType,@id_User2,@id_Registry206,@id_204Registry,@type204"
            For i As Integer = 0 To _lstofRegistry.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "sp_204RegistryInsert"
                'cmd.CommandText = strQuerry
                cmd.Parameters.Add("@Registry_204Year", SqlDbType.NVarChar).Value = _lstofRegistry(i).Registry_204Date.Value.Year
                If _lstofRegistry(i).Registry_204Date Is Nothing Then
                    cmd.Parameters.Add("@Registry_204Date", SqlDbType.DateTime).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@Registry_204Date", SqlDbType.DateTime).Value = _lstofRegistry(i).Registry_204Date
                End If
                'cmd.Parameters.Add("@Registry_Date", SqlDbType.DateTime).Value = _lstofRegistry(i).Registry_Date
                If _lstofRegistry(i).Registry_Description Is Nothing Then
                    cmd.Parameters.Add("@Registry_Description", SqlDbType.NVarChar).Value = DBNull.Value

                Else
                    cmd.Parameters.Add("@Registry_Description", SqlDbType.NVarChar).Value = _lstofRegistry(i).Registry_Description

                End If

                If _lstofRegistry(i).IncomingNumber Is Nothing Then
                    cmd.Parameters.Add("@IncomingNumber", SqlDbType.NVarChar).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@IncomingNumber", SqlDbType.NVarChar).Value = _lstofRegistry(i).IncomingNumber
                End If
                'If _lstofRegistry(i).id_DeliveredFor Is DBNull.Value Then
                '    cmd.Parameters.Add("@id_DeliveredFor", SqlDbType.NVarChar).Value = DBNull.Value
                'Else
                cmd.Parameters.Add("@id_DeliveredFor", SqlDbType.NVarChar).Value = _lstofRegistry(i).id_DeliveredFor
                'End If
                If _lstofRegistry(i).IncomingDate Is Nothing Then
                    cmd.Parameters.Add("@IncomingDate", SqlDbType.DateTime).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@IncomingDate", SqlDbType.DateTime).Value = _lstofRegistry(i).IncomingDate
                End If

                cmd.Parameters.Add("@id_User", SqlDbType.Int).Value = _lstofRegistry(i).id_User

                cmd.Parameters.Add("@RegistryType", SqlDbType.NVarChar).Value = _lstofRegistry(i).RegistryType

                cmd.Parameters.Add("@id_User2", SqlDbType.Int).Value = _lstofRegistry(i).id_User2


                If _lstofRegistry(i).id_Registry206 = 0 Then
                    cmd.Parameters.Add("@id_Registry206", SqlDbType.Int).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@id_Registry206", SqlDbType.Int).Value = _lstofRegistry(i).id_Registry206
                End If

                If _lstofRegistry(i).Type204 Is Nothing Then
                    cmd.Parameters.Add("@type204", SqlDbType.NVarChar).Value = DBNull.Value

                Else
                    cmd.Parameters.Add("@type204", SqlDbType.NVarChar).Value = _lstofRegistry(i).Type204

                End If

                cmd.Parameters.Add("@id_204Registry", SqlDbType.Int)

                cmd.Parameters("@id_204Registry").Direction = ParameterDirection.Output
                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                Dim id_Registry As Integer = 0
                id_Registry = cmd.Parameters("@id_204Registry").Value
                DBSqlconnection.Close()
                'If _lstofRegistry(i).id_DeliveredFor IsNot Nothing Then
                '    If _lstofRegistry(i).id_DeliveredFor.Count > 0 Then
                '        Delete204RegistryDeliveredForData(id_Registry)
                '        Save204RegistryDeliveredForData(_lstofRegistry(i).id_DeliveredFor, cmd.Parameters("@id_204Registry").Value)
                '    End If
                'End If
                Update204RegistryData(id_Registry, _idCompleteRegistry, _idUser2)
            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Function Update204RegistryData(ByVal _lstofRegistry As List(Of Registry204)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_204RegistryUpdate @id_204Registry,@Registry_Description,@IncomingNumber,@IncomingDate,@id_User2,@id_DeliveredFor"
            For i As Integer = 0 To _lstofRegistry.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandText = strQuerry
                cmd.Parameters.Add("@id_204Registry", SqlDbType.Int).Value = _lstofRegistry(i).id_204Registry

                'cmd.Parameters.Add("@Registry_Date", SqlDbType.DateTime).Value = _lstofRegistry(i).Registry_Date
                If _lstofRegistry(i).Registry_Description Is Nothing Then
                    cmd.Parameters.Add("@Registry_Description", SqlDbType.NVarChar).Value = DBNull.Value

                Else
                    cmd.Parameters.Add("@Registry_Description", SqlDbType.NVarChar).Value = _lstofRegistry(i).Registry_Description

                End If

                If _lstofRegistry(i).IncomingNumber Is Nothing Then
                    cmd.Parameters.Add("@IncomingNumber", SqlDbType.NVarChar).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@IncomingNumber", SqlDbType.NVarChar).Value = _lstofRegistry(i).IncomingNumber
                End If


                If _lstofRegistry(i).IncomingDate Is Nothing Then
                    cmd.Parameters.Add("@IncomingDate", SqlDbType.DateTime).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@IncomingDate", SqlDbType.DateTime).Value = _lstofRegistry(i).IncomingDate
                End If



                cmd.Parameters.Add("@id_User2", SqlDbType.Int).Value = _lstofRegistry(i).id_User2
                cmd.Parameters.Add("@id_DeliveredFor", SqlDbType.Int).Value = _lstofRegistry(i).id_DeliveredFor
                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                DBSqlconnection.Close()
                'If _lstofRegistry(i).id_DeliveredFor IsNot Nothing Then
                '    If _lstofRegistry(i).id_DeliveredFor.Count > 0 Then
                '        Delete204RegistryDeliveredForData(_lstofRegistry(i).id_204Registry)
                '        Save204RegistryDeliveredForData(_lstofRegistry(i).id_DeliveredFor, _lstofRegistry(i).id_204Registry)
                '    End If
                'End If


            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function
    Function Delete204RegistryData(ByVal _id204Registry As Integer) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_204RegistryDelete @id_204Registry"
            'For i As Integer = 0 To _lstofRegistry.Count - 1
            Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
            cmd.CommandText = strQuerry
            cmd.Parameters.Add("@id_204Registry", SqlDbType.Int).Value = _id204Registry

            DBSqlconnection.Open()
            cmd.ExecuteNonQuery()
            DBSqlconnection.Close()
            'Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Function Delete204RegistryDeliveredForData(ByVal _idRegistry As Integer) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_Registry204DeliveredForDelete @id_Registry204"

            Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
            cmd.CommandText = strQuerry
            cmd.Parameters.Add("@id_Registry204", SqlDbType.Int).Value = _idRegistry

            DBSqlconnection.Open()
            cmd.ExecuteNonQuery()




        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        Finally
            DBSqlconnection.Close()
        End Try

        Return True
    End Function

    Function Save204RegistryDeliveredForData(ByVal _lstofDeliveredFor As Integer(), ByVal _idregister As Integer) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_Registry204DeliveredForInsert @id_204Registry,@id_DeliveredFor"
            For i As Integer = 0 To _lstofDeliveredFor.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandText = strQuerry
                cmd.Parameters.Add("@id_204Registry", SqlDbType.Int).Value = _idregister
                cmd.Parameters.Add("@id_DeliveredFor", SqlDbType.Int).Value = _lstofDeliveredFor(i)


                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                DBSqlconnection.Close()
            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Function Update204RegistryData(ByVal _id204register As Integer, ByVal _idCompleteRegistry As Integer, ByVal _idUser2 As Integer) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_CompleteRegistry204Update @id_CompleteRegistry,@id_User2,@id_204Registry"

            Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
            cmd.CommandText = strQuerry
            cmd.Parameters.Add("@id_204Registry", SqlDbType.Int).Value = _id204register
            cmd.Parameters.Add("@id_CompleteRegistry", SqlDbType.Int).Value = _idCompleteRegistry
            cmd.Parameters.Add("@id_User2", SqlDbType.Int).Value = _idUser2


            DBSqlconnection.Open()
            cmd.ExecuteNonQuery()
            DBSqlconnection.Close()




        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function
#End Region


#Region "UsersPrivilege"
    Function GetUsersPrivilege(ByVal _id_User As Integer) As List(Of UserPrivilege)
        Dim lstofUserPrivilege As New List(Of UserPrivilege)
        Try
            Dim strQuerry As String
            Dim SelectedUserPrivilege As New UserPrivilege

            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select id_MenuUserPrivileges,id_Menu,id_User,MenuName,id_Form,FormName,ArabicFormName,RegistryType,isReadOnly, "
            strQuerry = strQuerry + "id_ParentForm,ParentFormName,ArabicParentFormName,toolbarname,isEditable,canCreate "
            strQuerry = strQuerry + "from vue_getAllUserPrivilege"
            strQuerry = strQuerry + " where id_User = " + _id_User.ToString()
            DBSqlconnection.Open()

            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    SelectedUserPrivilege = New UserPrivilege
                    If dt.Rows(i)("id_MenuUserPrivileges") IsNot DBNull.Value Then
                        SelectedUserPrivilege.id_MenuUserPrivileges = Integer.Parse(dt.Rows(i)("id_MenuUserPrivileges"))
                    Else
                        SelectedUserPrivilege.id_MenuUserPrivileges = 0
                    End If

                    SelectedUserPrivilege.id_User = Integer.Parse(dt.Rows(i)("id_User"))
                    If dt.Rows(i)("id_Menu") IsNot DBNull.Value Then
                        SelectedUserPrivilege.id_Menu = Integer.Parse(dt.Rows(i)("id_Menu"))
                    Else
                        SelectedUserPrivilege.id_Menu = 0
                    End If
                    If dt.Rows(i)("id_Form") IsNot DBNull.Value Then
                        SelectedUserPrivilege.id_Form = Integer.Parse(dt.Rows(i)("id_Form"))
                    Else
                        SelectedUserPrivilege.id_Form = 0
                    End If

                    If dt.Rows(i)("id_ParentForm") IsNot DBNull.Value Then
                        SelectedUserPrivilege.id_ParentFormName = Integer.Parse(dt.Rows(i)("id_ParentForm"))
                    Else
                        SelectedUserPrivilege.id_ParentFormName = 0
                    End If



                    If dt.Rows(i)("MenuName") Is DBNull.Value Then
                        SelectedUserPrivilege.MenuName = Nothing
                    Else
                        SelectedUserPrivilege.MenuName = (dt.Rows(i)("MenuName"))

                    End If

                    If dt.Rows(i)("FormName") Is DBNull.Value Then
                        SelectedUserPrivilege.FormName = Nothing
                    Else
                        SelectedUserPrivilege.FormName = (dt.Rows(i)("FormName"))

                    End If

                    If dt.Rows(i)("ArabicFormName") Is DBNull.Value Then
                        SelectedUserPrivilege.ArabicFormName = Nothing
                    Else
                        SelectedUserPrivilege.ArabicFormName = (dt.Rows(i)("ArabicFormName"))

                    End If

                    If dt.Rows(i)("ParentFormName") Is DBNull.Value Then
                        SelectedUserPrivilege.ParentFormName = Nothing
                    Else
                        SelectedUserPrivilege.ParentFormName = (dt.Rows(i)("ParentFormName"))

                    End If

                    If dt.Rows(i)("ArabicParentFormName") Is DBNull.Value Then
                        SelectedUserPrivilege.ArabicParentFormName = Nothing
                    Else
                        SelectedUserPrivilege.ArabicParentFormName = (dt.Rows(i)("ArabicParentFormName"))

                    End If

                    If dt.Rows(i)("RegistryType") Is DBNull.Value Then
                        SelectedUserPrivilege.RegistryType = Nothing
                    Else
                        SelectedUserPrivilege.RegistryType = (dt.Rows(i)("RegistryType"))

                    End If
                    If dt.Rows(i)("toolbarname") Is DBNull.Value Then
                        SelectedUserPrivilege.toolbarname = Nothing
                    Else
                        SelectedUserPrivilege.toolbarname = (dt.Rows(i)("toolbarname"))

                    End If


                    SelectedUserPrivilege.UserPrivilegeReadOnly = Boolean.Parse(dt.Rows(i)("isReadOnly"))

                    SelectedUserPrivilege.isEditable = Boolean.Parse(dt.Rows(i)("isEditable"))
                    SelectedUserPrivilege.canCreate = Boolean.Parse(dt.Rows(i)("canCreate"))



                    lstofUserPrivilege.Add(SelectedUserPrivilege)
                Next
            End If

        Catch ex As Exception

        Finally
            DBSqlconnection.Close()
        End Try

        Return lstofUserPrivilege
    End Function

    Function GetAllUsersPrivilege() As List(Of UserPrivilege)
        Dim lstofUserPrivilege As New List(Of UserPrivilege)
        Try
            Dim strQuerry As String
            Dim SelectedUserPrivilege As New UserPrivilege

            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select id_MenuUserPrivileges,id_Menu,id_User,MenuName,id_Form,FormName,ArabicFormName,RegistryType,isReadOnly, "
            strQuerry = strQuerry + "id_ParentForm,ParentFormName,ArabicParentFormName,toolbarname,isEditable,canCreate "
            strQuerry = strQuerry + "from vue_getAllUserPrivilege"
            DBSqlconnection.Open()

            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    SelectedUserPrivilege = New UserPrivilege
                    SelectedUserPrivilege.id_MenuUserPrivileges = Integer.Parse(dt.Rows(i)("id_MenuUserPrivileges"))
                    SelectedUserPrivilege.id_User = Integer.Parse(dt.Rows(i)("id_User"))
                    If dt.Rows(i)("id_Menu") IsNot DBNull.Value Then
                        SelectedUserPrivilege.id_Menu = Integer.Parse(dt.Rows(i)("id_Menu"))
                    Else
                        SelectedUserPrivilege.id_Menu = 0
                    End If
                    If dt.Rows(i)("id_Form") IsNot DBNull.Value Then
                        SelectedUserPrivilege.id_Form = Integer.Parse(dt.Rows(i)("id_Form"))
                    Else
                        SelectedUserPrivilege.id_Form = 0
                    End If

                    If dt.Rows(i)("id_ParentForm") IsNot DBNull.Value Then
                        SelectedUserPrivilege.id_ParentFormName = Integer.Parse(dt.Rows(i)("id_ParentForm"))
                    Else
                        SelectedUserPrivilege.id_ParentFormName = 0
                    End If



                    If dt.Rows(i)("MenuName") Is DBNull.Value Then
                        SelectedUserPrivilege.MenuName = Nothing
                    Else
                        SelectedUserPrivilege.MenuName = (dt.Rows(i)("MenuName"))

                    End If

                    If dt.Rows(i)("FormName") Is DBNull.Value Then
                        SelectedUserPrivilege.FormName = Nothing
                    Else
                        SelectedUserPrivilege.FormName = (dt.Rows(i)("FormName"))

                    End If

                    If dt.Rows(i)("ArabicFormName") Is DBNull.Value Then
                        SelectedUserPrivilege.ArabicFormName = Nothing
                    Else
                        SelectedUserPrivilege.ArabicFormName = (dt.Rows(i)("ArabicFormName"))

                    End If

                    If dt.Rows(i)("ParentFormName") Is DBNull.Value Then
                        SelectedUserPrivilege.ParentFormName = Nothing
                    Else
                        SelectedUserPrivilege.ParentFormName = (dt.Rows(i)("ParentFormName"))

                    End If

                    If dt.Rows(i)("ArabicParentFormName") Is DBNull.Value Then
                        SelectedUserPrivilege.ArabicParentFormName = Nothing
                    Else
                        SelectedUserPrivilege.ArabicParentFormName = (dt.Rows(i)("ArabicParentFormName"))

                    End If

                    If dt.Rows(i)("RegistryType") Is DBNull.Value Then
                        SelectedUserPrivilege.RegistryType = Nothing
                    Else
                        SelectedUserPrivilege.RegistryType = (dt.Rows(i)("RegistryType"))

                    End If

                    If dt.Rows(i)("toolbarname") Is DBNull.Value Then
                        SelectedUserPrivilege.toolbarname = Nothing
                    Else
                        SelectedUserPrivilege.toolbarname = (dt.Rows(i)("toolbarname"))

                    End If


                    SelectedUserPrivilege.UserPrivilegeReadOnly = Boolean.Parse(dt.Rows(i)("isReadOnly"))
                    SelectedUserPrivilege.isEditable = Boolean.Parse(dt.Rows(i)("isEditable"))
                    SelectedUserPrivilege.canCreate = Boolean.Parse(dt.Rows(i)("canCreate"))



                    lstofUserPrivilege.Add(SelectedUserPrivilege)
                Next
            End If

        Catch ex As Exception

        Finally
            DBSqlconnection.Close()
        End Try

        Return lstofUserPrivilege
    End Function

    Function SaveMenuUserPrivileges(ByVal _lstofUserPrivilege As List(Of UserPrivilege)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_MenuUserPrivilegeInsert @id_User,@id_Menu,@isReadOnly,@isEditable,@canCreate"
            For i As Integer = 0 To _lstofUserPrivilege.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandText = strQuerry
                cmd.Parameters.Add("@id_Menu", SqlDbType.Int).Value = _lstofUserPrivilege(i).id_Menu
                cmd.Parameters.Add("@id_User", SqlDbType.Int).Value = _lstofUserPrivilege(i).id_User
                cmd.Parameters.Add("@isReadOnly", SqlDbType.Bit).Value = _lstofUserPrivilege(i).UserPrivilegeReadOnly
                cmd.Parameters.Add("@isEditable", SqlDbType.Bit).Value = _lstofUserPrivilege(i).isEditable
                cmd.Parameters.Add("@canCreate", SqlDbType.Bit).Value = _lstofUserPrivilege(i).canCreate


                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                DBSqlconnection.Close()
            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Function UpdateMenuUserPrivileges(ByVal _lstofUserPrivilege As List(Of UserPrivilege)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_MenuUserPrivilegesUpdate @id_MenuUserPrivileges,@id_Menu,@isReadOnly,@isEditable,@canCreate"
            For i As Integer = 0 To _lstofUserPrivilege.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandText = strQuerry
                cmd.Parameters.Add("@id_Menu", SqlDbType.Int).Value = _lstofUserPrivilege(i).id_Menu
                cmd.Parameters.Add("@isReadOnly", SqlDbType.Bit).Value = _lstofUserPrivilege(i).UserPrivilegeReadOnly
                cmd.Parameters.Add("@id_MenuUserPrivileges", SqlDbType.Int).Value = _lstofUserPrivilege(i).id_MenuUserPrivileges
                cmd.Parameters.Add("@isEditable", SqlDbType.Bit).Value = _lstofUserPrivilege(i).isEditable
                cmd.Parameters.Add("@canCreate", SqlDbType.Bit).Value = _lstofUserPrivilege(i).canCreate
                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                DBSqlconnection.Close()
            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Function DeleteUserPrivilegeData(ByVal _lstofUserPrivilege As List(Of UserPrivilege)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_MenuUserPrivilegeDelete @id_MenuUserPrivilege"
            For i As Integer = 0 To _lstofUserPrivilege.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandText = strQuerry
                cmd.Parameters.Add("@id_MenuUserPrivilege", SqlDbType.Int).Value = _lstofUserPrivilege(i).id_MenuUserPrivileges

                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                DBSqlconnection.Close()
            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function

#End Region

#Region "Tbl_Menu"
    Function GetDTAllMenus() As DataTable
        Dim lstofDeliveredFor As New List(Of DeliveredFor)
        Dim dt As New DataTable()
        Try
            Dim strQuerry As String
            Dim SelectedDeliveredFor As New DeliveredFor

            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select id_Menu ,MenuName from Tbl_Menu order by MenuName"

            DBSqlconnection.Open()

            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)



        Catch ex As Exception

        Finally
            DBSqlconnection.Close()
        End Try

        Return dt
    End Function

    Function GetDTMenusbyForm(ByVal _idForm As Integer) As DataTable
        Dim lstofDeliveredFor As New List(Of DeliveredFor)
        Dim dt As New DataTable()
        Try
            Dim strQuerry As String
            Dim SelectedDeliveredFor As New DeliveredFor

            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select id_Menu ,MenuName from Tbl_Menu "
            strQuerry = strQuerry + " where id_ParentForm = " + _idForm.ToString + " order by MenuName"

            DBSqlconnection.Open()

            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)



        Catch ex As Exception

        Finally
            DBSqlconnection.Close()
        End Try

        Return dt
    End Function
#End Region

#Region "Tbl_Form"
    Function GetDTAllForm() As DataTable

        Dim dt As New DataTable()
        Try
            Dim strQuerry As String

            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select id_Form ,FormName,ArabicFormName from Tbl_Form order by FormName"

            DBSqlconnection.Open()

            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)



        Catch ex As Exception

        Finally
            DBSqlconnection.Close()
        End Try

        Return dt
    End Function

    Function GetDTAllParentForm() As DataTable

        Dim dt As New DataTable()
        Try
            Dim strQuerry As String

            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select id_Form as id_ParentFormName ,FormName as ParentFormName,ArabicFormName as ArabicParentFormName from Tbl_Form order by FormName"

            DBSqlconnection.Open()

            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)



        Catch ex As Exception

        Finally
            DBSqlconnection.Close()
        End Try

        Return dt
    End Function
#End Region
#Region "Tbl_ItemCategory"
    Function GetAllItemsCategory() As List(Of ItemCategory)
        Dim lstofItemCategory As New List(Of ItemCategory)
        Try
            Dim strQuerry As String
            Dim SelectedItemCategory As New ItemCategory

            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select id_ItemCategory,descriptionItemCategory from Tbl_ItemCategory "

            DBSqlconnection.Open()

            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    SelectedItemCategory = New ItemCategory
                    SelectedItemCategory.id_ItemCategory = dt.Rows(i)("id_ItemCategory")
                    SelectedItemCategory.descriptionItemCategory = dt.Rows(i)("descriptionItemCategory")



                    lstofItemCategory.Add(SelectedItemCategory)
                Next
            End If

        Catch ex As Exception

        Finally
            DBSqlconnection.Close()
        End Try

        Return lstofItemCategory
    End Function

    Function SaveItemCategoryData(ByVal _lstofItemCategory As List(Of ItemCategory)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_InsertItemsCategory @ItemsDescription"
            For i As Integer = 0 To _lstofItemCategory.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandText = strQuerry
                cmd.Parameters.Add("@ItemsDescription", SqlDbType.NVarChar).Value = _lstofItemCategory(i).descriptionItemCategory






                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                DBSqlconnection.Close()
            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Function UpdateItemCategoryData(ByVal _lstofItemCategory As List(Of ItemCategory)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_UpdateItemsCategory @id_ItemCategory,@ItemsDescription"
            For i As Integer = 0 To _lstofItemCategory.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandText = strQuerry
                cmd.Parameters.Add("@id_Document", SqlDbType.Int).Value = _lstofItemCategory(i).id_ItemCategory
                cmd.Parameters.Add("@ItemsDescription", SqlDbType.NVarChar).Value = _lstofItemCategory(i).descriptionItemCategory

                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                DBSqlconnection.Close()
            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Function DeleteItemsCategoryData(ByVal _lstofItemsCategory As List(Of ItemCategory)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_ItemsCategoryDelete @id_Document"
            For i As Integer = 0 To _lstofItemsCategory.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandText = strQuerry
                cmd.Parameters.Add("@id_ItemCategory", SqlDbType.Int).Value = _lstofItemsCategory(i).id_ItemCategory

                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                DBSqlconnection.Close()
            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function
#End Region

#Region "Tbl_Items"
    Function GetAllItems() As List(Of Items)
        Dim lstofItems As New List(Of Items)
        Try
            Dim strQuerry As String
            Dim SelectedItems As New Items

            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "select id_ItemCategory,descriptionItemCategory from Tbl_ItemCategory "

            DBSqlconnection.Open()

            Dim cmd As New SqlCommand(strQuerry, DBSqlconnection)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    SelectedItems = New Items
                    SelectedItems.id_ItemCategory = dt.Rows(i)("id_ItemCategory")
                    SelectedItems.descriptionItemCategory = dt.Rows(i)("descriptionItemCategory")



                    lstofItems.Add(SelectedItems)
                Next
            End If

        Catch ex As Exception

        Finally
            DBSqlconnection.Close()
        End Try

        Return lstofItems
    End Function

    Function SaveItemsData(ByVal _lstofItems As List(Of Items)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_ItemsInsert @id_ItemCategory,@id_Unite,@ItemsDescription,@ItemPrice,@id_Currency"
            For i As Integer = 0 To _lstofItems.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandText = strQuerry
                cmd.Parameters.Add("@id_ItemCategory", SqlDbType.Int).Value = _lstofItems(i).id_ItemCategory
                cmd.Parameters.Add("@id_Unite", SqlDbType.Int).Value = _lstofItems(i).id_Unite
                cmd.Parameters.Add("@ItemsDescription", SqlDbType.NVarChar).Value = _lstofItems(i).ItemsDescription
                cmd.Parameters.Add("@ItemPrice", SqlDbType.Float).Value = _lstofItems(i).ItemPrice
                cmd.Parameters.Add("@id_Currency", SqlDbType.Int).Value = _lstofItems(i).id_Currency


                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                DBSqlconnection.Close()
            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Function UpdateItemsData(ByVal _lstofItems As List(Of Items)) As Boolean
        Try
            Dim strQuerry As String
            DBSqlconnection = New SqlConnection(DBSqlconnectionString)

            strQuerry = "Execute sp_ItemsUpdate @id_Items,@id_Unite,@ItemsDescription,@ItemPrice,@id_Currency"
            For i As Integer = 0 To _lstofItems.Count - 1
                Dim cmd As SqlCommand = DBSqlconnection.CreateCommand()
                cmd.CommandText = strQuerry
                cmd.Parameters.Add("@id_Items", SqlDbType.Int).Value = _lstofItems(i).id_Items
                cmd.Parameters.Add("@id_Unite", SqlDbType.Int).Value = _lstofItems(i).id_Unite
                cmd.Parameters.Add("@ItemsDescription", SqlDbType.NVarChar).Value = _lstofItems(i).ItemsDescription
                cmd.Parameters.Add("@ItemPrice", SqlDbType.Float).Value = _lstofItems(i).ItemPrice
                cmd.Parameters.Add("@id_Currency", SqlDbType.Int).Value = _lstofItems(i).id_Currency

                DBSqlconnection.Open()
                cmd.ExecuteNonQuery()
                DBSqlconnection.Close()
            Next



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return True
    End Function

#End Region

End Class
