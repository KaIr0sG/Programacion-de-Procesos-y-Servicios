Imports System.Data.OleDb
Public Class FrmNaveBBDD
    Dim oConexion As New OleDbConnection
    Dim oDataAdapter As New OleDbDataAdapter("Select * from Datos", oConexion) ' Me crea la consulta
    'Dim oDataAdapter As OleDbDataAdapter
    Dim oCommandBuilder = New OleDbCommandBuilder(oDataAdapter)
    Dim oDataSet As New DataSet

    Dim Posicion As Integer

    Private Sub FrmNaveBBDD_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Res As Integer
        ' oDataAdapter = New OleDbDataAdapter("Select * from Datos", oConexion)
        Res = MessageBox.Show("¿Mostrar Datos Personales?", "Datos Personales", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Res = vbYes Then GrpDatos.Visible = True
        ' Comineza el proceso de acceso a BBDD
        oConexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=DatosPer.mdb"
        '"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\tere\visualnet\BBDD\DatosPer.accdb"
        oConexion.Open()
        oDataAdapter.Fill(oDataSet, "Datos")
        'oDataAdapter = Nothing
        'oDataAdapter = New OleDbDataAdapter("Select * from Notas", oConexion)
        'oDataAdapter.Fill(oDataSet, "Notas")
        'oDataAdapter = Nothing
        'oDataAdapter = New OleDbDataAdapter("Select * from Cursos", oConexion)
        'oDataAdapter.Fill(oDataSet, "Curso")
        'oDataAdapter = Nothing

        oConexion.Close()

        Posicion = 0

        Cargar()





        'If Res = 6 Then GrpDatos.Visible = True
        'MessageBox.Show(Res)
        ' MessageBox.Show("Esto es el comienzo de unas estupendas clases", "Convocatoria Extraordinaria", MessageBoxButtons.OK)
    End Sub
    Private Sub Cargar()


        If oDataSet.Tables("Datos").Rows.Count = 0 Then
            MessageBox.Show(“No hay ningun registro”, “AVISO”)
        Else
            Dim odatarow As DataRow
            odatarow = oDataSet.Tables("Datos").Rows(Posicion)
            TxtDni.Text = odatarow("Dni")
            TxtNombre.Text = odatarow("Nombre")
            TxtApellidos.Text = odatarow("Apellidos")
            TxtFecha.Text = odatarow("Fecha")
            LblMarcador.Text = "Registro " & Posicion + 1 & " de " &
           oDataSet.Tables("Datos").Rows.Count
        End If

    End Sub

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click
        Posicion += 1 'Posicion=Posicion +1 
        BtnAnterior.Enabled = True
        If oDataSet.Tables("Datos").Rows.Count - 1 = Posicion Then CambioBotones(False, True)
        Cargar()

    End Sub
    Private Sub CambioBotones(valor1 As Boolean, valor2 As Boolean)
        BtnSiguiente.Enabled = valor1
        BtnAnterior.Enabled = valor2
    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        Posicion -= 1
        BtnSiguiente.Enabled = True
        If Posicion = 0 Then CambioBotones(True, False)
        Cargar()
    End Sub

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        Dim oDataRow As DataRow
        oDataRow = oDataSet.Tables("Datos").NewRow()
        oDataRow("Dni") = TxtDni.Text
        oDataRow("Nombre") = TxtNombre.Text
        oDataRow("Apellidos") = TxtApellidos.Text
        oDataRow("Fecha") = TxtFecha.Text
        oDataSet.Tables("Datos").Rows.Add(oDataRow)
        ' BtnLimpiarCampos.PerformClick()
        ' Posicion = oDataSet.Tables("Datos").Rows.Count - 1
        Posicion = 0
        Cargar()
    End Sub

    Private Sub BtnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles BtnLimpiarCampos.Click
        TxtDni.Text = ""
        TxtNombre.Text = ""
        TxtApellidos.Text = ""
        TxtFecha.Text = ""
        LblMarcador.Text = ""
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        '  oDataAdapter = New OleDbDataAdapter("Select * from Datos", oConexion)
        oDataAdapter.Update(oDataSet, "Datos")
    End Sub
    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        Dim odataRow As DataRow
        odataRow = oDataSet.Tables("Datos").Rows(Posicion)
        odataRow("Dni") = TxtDni.Text
        odataRow("Nombre") = TxtNombre.Text
        odataRow("Apellidos") = TxtApellidos.Text
        odataRow("Fecha") = TxtFecha.Text

    End Sub
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Dim oDataRow As DataRow
        oDataRow = oDataSet.Tables("Datos").Rows(Posicion)
        oDataRow.Delete()

        Dim oTablaBorrada As DataTable

        oTablaBorrada = oDataSet.Tables("Datos").GetChanges(DataRowState.Deleted)
        oDataAdapter = New OleDbDataAdapter("Select * from Datos", oConexion)

        oDataAdapter.Update(oTablaBorrada)
        oDataAdapter = Nothing
        oDataSet.Tables("Datos").AcceptChanges()
        BtnPrimero.PerformClick()


    End Sub


    Private Sub BtnPrimero_Click(sender As Object, e As EventArgs) Handles BtnPrimero.Click
        Posicion = 0
        Cargar()
    End Sub

    Private Sub BtnVaciarDatos_Click(sender As Object, e As EventArgs) Handles BtnVaciarDatos.Click
        Dim oDataRow As DataRow
        For Each oDataRow In oDataSet.Tables("Datos").Rows
            oDataRow.Delete()
        Next
        Dim oTablaBorrada As DataTable
        oTablaBorrada = oDataSet.Tables("Datos").GetChanges(DataRowState.Deleted)
        'oDataAdapter.Update(oTablaBorrada)
        oDataSet.Tables("Datos").AcceptChanges()
        BtnLimpiarCampos.PerformClick()
        LblMarcador.Text = "No existen filas"
        ' BtnPrimero.PerformClick()


    End Sub

    Private Sub FrmNaveBBDD_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        InicioFrm.BtnBBDD.Enabled = True
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim oDataRow As DataRow()
        'Dim expression = "Dni = '" & TxtDNIBuscar.Text & "'"
        Dim expression = "Codpostal >" & TxtDNIBuscar.Text
        Dim expresion1 = "Nombre = '" & TxtNombre.Text & "'"
        oDataRow = oDataSet.Tables("Datos").Select(expression)
        'TxtDni.Text = oDataRow(0).Item(0)
        'TxtNombre.Text = oDataRow(0).Item(1)
        'TxtApellidos.Text = oDataRow(0).Item(2)
        'TxtFecha.Text = oDataRow(0).Item(7)

        Dim oTabla As New DataTable


        oTabla = oDataRow.CopyToDataTable

        DtgDatos.DataSource = oTabla


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Posicion = oDataSet.Tables("Datos").Rows.Count - 1
        Cargar()
    End Sub
End Class
