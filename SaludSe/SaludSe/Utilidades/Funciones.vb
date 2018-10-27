Option Explicit On
Imports System.Data.Odbc

Module Funciones

    Public cnn As OdbcConnection
    Public cmd As OdbcCommand
    Public rs, rsEntrega As OdbcDataReader
    Public idEmpleado, idUsuario As Integer
    Public sql As String
    Public ds As New DataSet
    Public adp As OdbcDataAdapter


    Public Sub conexion()
        Try
            cnn = New OdbcConnection("DSN=SaludSe")
            cnn.Open()
        Catch ex As Exception
            MsgBox("Error")
        End Try

    End Sub

    'CARGA (ENTREGAS)
    Public Function carga(ByVal sql As String, ByVal secun As Boolean) As OdbcDataReader
        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        If secun = False Then
            rs = cmd.ExecuteReader()
        Else
            rsEntrega = cmd.ExecuteReader
        End If
        cmd.Dispose()
        Return rs
    End Function

    'DATAGRIDVIEW (ENTREGAS)
    Public Sub data(ByVal tabla As Object, ByVal checkBox As Boolean)
        tabla.Columns.Clear()
        If checkBox = True Then
            Dim col As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn
            col.HeaderText = "Seleccionar"
            tabla.Columns.add(col)
        End If
        tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ds.Tables.Clear()
        ds.Tables.Add("XX")
        adp = New OdbcDataAdapter(sql, cnn)
        adp.Fill(ds.Tables("XX"))
        tabla.DataSource = ds.Tables("XX")
        tabla.ClearSelection()
    End Sub


    'Esta función sirve para devolver el resultado de una consulta'
    'Ejemplo: Dim rs As OdbcDataReader = consulta("select * from tabla")'
    Public Function consulta(ByVal sql As String) As OdbcDataReader
        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        rs = cmd.ExecuteReader
        cmd.Dispose()

        Return rs

    End Function

    'Esta función sirve para devolver un valor de una consulta que solo tenga campo y devuelva una sola fila.'
    'Ejemplo: Dim variable As [Tipo] = consultaCampo("select max(id) from tabla")'
    Public Function consultaCampo(ByVal sql As String) As OdbcDataReader

        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        rs = cmd.ExecuteReader
        cmd.Dispose()

        If rs.Read = True Then

            Return rs

        End If

        Return Nothing

    End Function

    'Esta función sirve para llenar una grilla.'
    'Ejemplo: [NombreGrilla].DataSource = llenarGrilla("select * from tabla")'
    Public Function llenarGrilla(ByVal sql As String) As DataTable
        Dim ds As DataSet
        Dim adp As OdbcDataAdapter

        ds = New DataSet("Tabla")
        ds.Tables.Add("Tabla")
        adp = New OdbcDataAdapter(sql, cnn)
        adp.Fill(ds.Tables("Tabla"))

        Return ds.Tables("Tabla")

    End Function

    'Esta función sirve para saber si hay registros en una tabla.'
    'Ejemplo: Dim existe As Boolean = consultaExiste("select count(*) from tabla")'
    'Siempre usar count en la consulta'
    Public Function consultaExiste(ByVal sql)

        Dim result As Integer
        Dim exists As Boolean

        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        rs = cmd.ExecuteReader()
        cmd.Dispose()

        If rs.Read = True Then
            result = rs(0)
        End If

        If result = 0 Then
            exists = False
        Else
            exists = True
        End If

        Return exists

    End Function

    'Esta función sirve para verificar si lo que esta ingresando el usuario son solamente numeros.'
    'Ejemplo: '
    'Private Sub [Nombre TextBox]_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles [Nombre TextBox].KeyPress
    ' OnlyNum(e)'
    ' End Sub'
    Public Sub OnlyNum(ByVal e)

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Module
