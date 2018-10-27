Imports System.Data.Odbc

Public Class Form1
    Public ds As New DataSet
    Dim sql As String
    Public adp As New OdbcDataAdapter

   

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        btnImprimir.Visible = False
       


        PrintForm1.Print()

        btnImprimir.Visible = True


    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class