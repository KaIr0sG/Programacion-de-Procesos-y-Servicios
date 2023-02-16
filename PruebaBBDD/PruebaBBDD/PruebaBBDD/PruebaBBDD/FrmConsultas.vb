Imports System.Data.OleDb
Public Class FrmConsultas
    Dim oDataAdapter As OleDbDataAdapter
    Dim oDataSet As New DataSet
    Dim oConexion As New OleDbConnection
    Dim oCommandBuilder As OleDbCommandBuilder
    Dim i As Integer
    Dim MiTablas As DataTable
    Dim DatosCol As DataColumn
    Dim CadenaSelect As String
    Dim cadenaSelect1 As String
    Dim cadenaselect2 As String
    Dim Sw As Byte


    'oCommandBuilder = New OleDbCommandBuilder(oDataAdapter)

    'oDataAdapter = New OleDbDataAdapter("select * from datos order by dni", oConexion)


    '


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oConexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=DatosPer.mdb"
        oConexion.Open()
        oDataAdapter = New OleDbDataAdapter("select * from Datos", oConexion)
        oCommandBuilder = New OleDbCommandBuilder(oDataAdapter)
        oDataAdapter.Fill(oDataSet, "Datos")
        oConexion.Close()
        For i = 0 To oDataSet.Tables.Count - 1
            CmbTablas.Items.Add(oDataSet.Tables.Item(i))
        Next
    End Sub

    Private Sub CmbTablas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbTablas.SelectedIndexChanged
        CmbCampos.Items.Clear()
        Dim oDataRow As DataRow
        oDataRow = oDataSet.Tables(CmbTablas.Text).Rows(0)
        'Dim MiTablas As DataTable
        MiTablas = oDataRow.Table


        For Each DatosCol In MiTablas.Columns
            CmbCampos.Items.Add(DatosCol.ColumnName)
        Next
        CadenaSelect = "select * from " + CmbTablas.Text
        TxtSelect.Text = CadenaSelect
    End Sub

    Private Sub CmbCampos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCampos.SelectedIndexChanged
        TxtSelect.Text = CadenaSelect + " Where " + CmbCampos.Text
        cadenaSelect1 = TxtSelect.Text
        Dim TypoDatoString As String = "System.String"
        Dim TypoDatoInt As String = "System.Int32"
        For Each DatosCol In MiTablas.Columns
            If DatosCol.ColumnName = CmbCampos.Text Then

                Select Case DatosCol.DataType.FullName
                    Case TypoDatoString
                        OptIgual.Enabled = True
                        OptMayor.Enabled = False
                        OptMenor.Enabled = False
                        Sw = 0
                        Exit For
                    Case TypoDatoInt
                        OptIgual.Enabled = True
                        OptMayor.Enabled = True
                        OptMenor.Enabled = True
                        Sw = 1
                        Exit For
                End Select

            End If


        Next


    End Sub

    Private Sub OptIgual_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptIgual.Click
        If OptIgual.Checked = True Then
            ActivarDato(OptIgual.Text)
        End If
    End Sub
    Private Sub ActivarDato(ByVal Operador As String)
        CambiarEstado(True)
        cadenaselect2 = cadenaSelect1 + " " + Operador
        TxtSelect.Text = cadenaselect2
    End Sub

    Private Sub OptMayor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptMayor.Click
        If OptMayor.Checked = True Then
            ActivarDato(OptMayor.Text)
        End If
    End Sub

    Private Sub OptMenor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptMenor.Click
        If OptMenor.Checked = True Then
            ActivarDato(OptMenor.Text)
        End If
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        BtnAceptar.Enabled = False
        Select Case Sw
            Case 0
                TxtSelect.Text = TxtSelect.Text + " '"
                TxtSelect.Text = TxtSelect.Text + TxtDatoBuscar.Text
                TxtSelect.Text = TxtSelect.Text + "'"
            Case 1
                TxtSelect.Text = TxtSelect.Text + " " + TxtDatoBuscar.Text

        End Select
        oConexion.Open()
        oDataAdapter = Nothing
        oDataAdapter = New OleDbDataAdapter(TxtSelect.Text, oConexion)
        oDataSet.Tables("Datos").Clear()
        oDataAdapter.Fill(oDataSet, "Datos")
        oConexion.Close()
        If oDataSet.Tables("Datos").Rows.Count > 0 Then
            LblNoDatos.Visible = False
            DtgDatos.DataSource = oDataSet
            DtgDatos.DataMember = "Datos"
        Else
            LblNoDatos.Visible = True
        End If
        CambiarEstado(False)
    End Sub
    Private Sub CambiarEstado(ByVal Valor As Boolean)
        LblDatoBuscar.Enabled = Valor
        TxtDatoBuscar.Enabled = Valor
        BtnAceptar.Enabled = Valor
    End Sub

    Private Sub FrmConsultas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        InicioFrm.BtnGenerarConsulta.Enabled = True
    End Sub
End Class