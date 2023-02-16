Public Class FrmInicio
    Private Sub BtnBBDD_Click(sender As Object, e As EventArgs) Handles BtnBBDD.Click
        Datos()

    End Sub

    Private Sub BtnGenerarConsulta_Click(sender As Object, e As EventArgs) Handles BtnGenerarConsulta.Click
        consultas()
    End Sub

    Private Sub MnuBaseDeDatos_Click(sender As Object, e As EventArgs) Handles MnuBaseDeDatos.Click
        Datos()
    End Sub
    Public Sub Datos()
        NaveBBDDFrm = New FrmNaveBBDD
        NaveBBDDFrm.MdiParent = InicioFrm
        NaveBBDDFrm.Show()
        BtnBBDD.Enabled = False
    End Sub
    Public Sub consultas()
        ConsultasFrm = New FrmConsultas
        ConsultasFrm.MdiParent = InicioFrm
        ConsultasFrm.Show()
        BtnGenerarConsulta.Enabled = False
    End Sub

    Private Sub MnuGenerarConsulta_Click(sender As Object, e As EventArgs) Handles MnuGenerarConsulta.Click
        consultas()
    End Sub

    'Private Sub BtnBBDDBarra_Click(sender As Object, e As EventArgs) Handles BtnBBDDBarra.Click
    '    Datos()
    'End Sub

    Private Sub DatorPerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatorPerToolStripMenuItem.Click
        Datos()
    End Sub

    Private Sub PepeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PepeToolStripMenuItem.Click
        Datos()
    End Sub
End Class