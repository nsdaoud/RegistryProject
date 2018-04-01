Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class UserTransactions
    Private idUserTransactions As Integer
    Public Property id_UserTransactions() As Integer
        Get
            Return idUserTransactions
        End Get
        Set(ByVal value As Integer)
            idUserTransactions = value
        End Set
    End Property


    Private _UserTransactions As String
    Public Property UserTransactions() As String
        Get
            Return _UserTransactions
        End Get
        Set(ByVal value As String)
            _UserTransactions = value
        End Set
    End Property
End Class
