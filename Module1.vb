Imports System.Data.OleDb
Imports System.Data

Module Module1
    Public Conn As OleDbConnection
    Public Sub opendb()
        Conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Asmita\JADHAV DNYANESHWAR\School_Admission_System.accdb")
        Conn.Open()

    End Sub
End Module
