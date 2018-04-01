Imports System.Data.SqlClient
Imports DBRegistryDLL

Public Class WaredFaxManager
    Implements IWaredFax304Manager

    Public Function GetWaredFax304Data() As DataTable Implements IWaredFax304Manager.GetWaredFax304Data
        Dim sqlconnection As New CustomSqlConnection()
        Dim strQuerry As String


        strQuerry = "select id_304waredfax,waredfax304_seq,waredfax304Destination,waredfax304_Date,waredfax304_Number,marboutatnumber,Waredfax304.id_WFDestination,Tbl_PaperSource.PaperSourceDescription as WFDestination, "
        strQuerry = strQuerry + "waredfax304_Note,id_CreationUser,id_UpdateUser,waredfax304_year,Tbl_User.UserName as CreationUser,UpdateUser.UserName as UpdateUser "
        strQuerry = strQuerry + "From Waredfax304 "
        strQuerry = strQuerry + "left outer join Tbl_PaperSource on Waredfax304.id_WFDestination = Tbl_PaperSource.id_PaperSource "
        strQuerry = strQuerry + "left outer join Tbl_User on Waredfax304.id_CreationUser = Tbl_User.id_User "
        strQuerry = strQuerry + "left outer join Tbl_User UpdateUser on Waredfax304.id_UpdateUser = UpdateUser.id_User "
        Dim cmd As New SqlCommand(strQuerry, sqlconnection.sqlConn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)

        Return dt
    End Function

    Public Function insertWaredFax304Data(_lstofWaredfax304 As List(Of Waredfax304)) As Boolean Implements IWaredFax304Manager.insertWaredFax304Data
        Try
            Dim sqlconnection As New CustomSqlConnection()

            For i As Integer = 0 To _lstofWaredfax304.Count - 1
                Dim cmd As SqlCommand = New SqlCommand("sp_Insert304waredfax", sqlconnection.sqlConn)
                cmd.CommandType = CommandType.StoredProcedure


                cmd.Parameters.Add("waredfax304_Date", SqlDbType.DateTime).Value = DateTime.Now



                If _lstofWaredfax304(i).waredfax304_Number Is Nothing Then
                    cmd.Parameters.Add("@waredfax304_Number", SqlDbType.NVarChar).Value = DBNull.Value

                Else
                    cmd.Parameters.Add("@waredfax304_Number", SqlDbType.NVarChar).Value = _lstofWaredfax304(i).waredfax304_Number

                End If

                If _lstofWaredfax304(i).marboutatnumber Is Nothing Then
                    cmd.Parameters.Add("@marboutatnumber", SqlDbType.NVarChar).Value = DBNull.Value

                Else
                    cmd.Parameters.Add("@marboutatnumber", SqlDbType.NVarChar).Value = _lstofWaredfax304(i).marboutatnumber

                End If

                If _lstofWaredfax304(i).waredfax304Destination Is Nothing Then
                    cmd.Parameters.Add("@waredfax304Destination", SqlDbType.NVarChar).Value = DBNull.Value

                Else
                    cmd.Parameters.Add("@waredfax304Destination", SqlDbType.NVarChar).Value = _lstofWaredfax304(i).waredfax304Destination

                End If

                If _lstofWaredfax304(i).waredfax304Note Is Nothing Then
                    cmd.Parameters.Add("@waredfax304_Note", SqlDbType.NVarChar).Value = DBNull.Value

                Else
                    cmd.Parameters.Add("@waredfax304_Note", SqlDbType.NVarChar).Value = _lstofWaredfax304(i).waredfax304Note

                End If

                cmd.Parameters.Add("@id_WFDestination", SqlDbType.Int).Value = _lstofWaredfax304(i).id_WFDestination
                cmd.Parameters.Add("@id_CreationUser", SqlDbType.Int).Value = _lstofWaredfax304(i).id_CreationUser
                cmd.Parameters.Add("@waredfax304_year", SqlDbType.NVarChar).Value = DateTime.Now.Year




                cmd.ExecuteNonQuery()
                sqlconnection.DisposeConnection()
            Next
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateWaredFax304Data(_lstofWaredfax304 As List(Of Waredfax304)) As Boolean Implements IWaredFax304Manager.UpdateWaredFax304Data
        Try
            Dim sqlconnection As New CustomSqlConnection()

            For i As Integer = 0 To _lstofWaredfax304.Count - 1
                Dim cmd As SqlCommand = New SqlCommand("sp_Update304waredfax", sqlconnection.sqlConn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("id_304waredfax", SqlDbType.Int).Value = _lstofWaredfax304(i).id_304waredfax

                If _lstofWaredfax304(i).waredfax304Desc Is Nothing Then
                    cmd.Parameters.Add("@waredfax304_Desc", SqlDbType.NVarChar).Value = DBNull.Value

                Else
                    cmd.Parameters.Add("@waredfax304_Desc", SqlDbType.NVarChar).Value = _lstofWaredfax304(i).waredfax304Desc

                End If




                If _lstofWaredfax304(i).waredfax304_Number Is Nothing Then
                    cmd.Parameters.Add("@waredfax304_Number", SqlDbType.NVarChar).Value = DBNull.Value

                Else
                    cmd.Parameters.Add("@waredfax304_Number", SqlDbType.NVarChar).Value = _lstofWaredfax304(i).waredfax304_Number

                End If

                If _lstofWaredfax304(i).marboutatnumber Is Nothing Then
                    cmd.Parameters.Add("@marboutatnumber", SqlDbType.NVarChar).Value = DBNull.Value

                Else
                    cmd.Parameters.Add("@marboutatnumber", SqlDbType.NVarChar).Value = _lstofWaredfax304(i).marboutatnumber

                End If

                If _lstofWaredfax304(i).waredfax304Destination Is Nothing Then
                    cmd.Parameters.Add("@waredfax304Destination", SqlDbType.NVarChar).Value = DBNull.Value

                Else
                    cmd.Parameters.Add("@waredfax304Destination", SqlDbType.NVarChar).Value = _lstofWaredfax304(i).waredfax304Destination

                End If

                If _lstofWaredfax304(i).waredfax304Note Is Nothing Then
                    cmd.Parameters.Add("@waredfax304_Note", SqlDbType.NVarChar).Value = DBNull.Value

                Else
                    cmd.Parameters.Add("@waredfax304_Note", SqlDbType.NVarChar).Value = _lstofWaredfax304(i).waredfax304Note

                End If


                cmd.Parameters.Add("@id_UpdateUser", SqlDbType.Int).Value = _lstofWaredfax304(i).id_UpdateUser




                cmd.ExecuteNonQuery()
                sqlconnection.DisposeConnection()
            Next
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function DeleteWaredFax304Data(_lstofWaredfax304 As List(Of Waredfax304)) As Boolean Implements IWaredFax304Manager.DeleteWaredFax304Data
        Throw New NotImplementedException()
    End Function
End Class
