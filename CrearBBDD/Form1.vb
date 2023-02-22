Imports System.Data.OleDb
Imports System.IO

Public Class Form1
    ' Creo las variables de conexion 
    Dim oConexion As New OleDbConnection
    Dim oDataAdapter As New OleDbDataAdapter("Select * from Notas", oConexion)
    Dim oCommandBuilder = New OleDbCommandBuilder(oDataAdapter)
    Dim oDataSet As New DataSet


    ' Creo las variables que van a ser usadas en el la base de datos 
    Dim cat As New ADOX.Catalog
    Dim Cn As ADODB.Connection
    Dim CarLeido As Integer
    Dim Ciclo As String
    Dim Curso As String
    Dim Apelidos As String
    Dim Nombre As String
    Dim Nota1 As String
    Dim Nota2 As String
    Dim Nota3 As String
    Dim Nota4 As String
    Dim Nota5 As String
    Dim Nota6 As String
    Dim Nota7 As String
    Dim Nota8 As String
    Dim Nota9 As String
    Dim Posi As Integer
    Private Sub BtnCrearBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCrearBBDD.Click
        Try
            Dim direccion As String = ""
            Dim oCarpetas As New SaveFileDialog

            oCarpetas.AddExtension = True
            oCarpetas.DefaultExt = ".accdb"
            oCarpetas.ShowDialog()
            direccion = oCarpetas.FileName
            MessageBox.Show(direccion)

            ' Generamos una nueva base de datos Access 
            cat.Create("Provider = Microsoft.Jet.OLEDB.4.0;" &
                        "Data Source= " & direccion)

            ' Cerramos el objeto ADODB.Connection que ímplicitamente se ha originado al crear el archivo de información.
            CType(cat.ActiveConnection, ADODB.Connection).Close()

            ' Nos sale un Mensaje que nos confirma que se ha creado con exito la BBDD cpn su boton
            MessageBox.Show("Se ha creado con éxito la base de datos.",
                            "Crear base de datos",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message,
                            "Crear base de datos",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        Finally
            ' Quitamos las referencias a las instancias de los objetos creados.
            '  cat.ActiveConnection = Nothing
            '  cat = Nothing

            ' Desactivamos la opcion de crear una base de datos
        End Try
        BtnCrearBBDD.Enabled = False

    End Sub

    Private Sub BtnCrearTabla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCrearTabla.Click
        'Se crea conexion y catalogo..... y la tabla nueva
        Dim direccion As String = ""
        Dim oCarpetas As New OpenFileDialog
        oCarpetas.ShowDialog()
        direccion = oCarpetas.FileName
        MessageBox.Show(direccion)
        Dim tabla1 As ADOX.Table

        Cn = New ADODB.Connection
        ' Creamos la tabla
        tabla1 = New ADOX.Table

        'Se abre la conexion
        Cn.Open("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\vbnet\BBDD\Nuevo.accdb") ' "Ruta basicamente el codigo de tere"
        cat.ActiveConnection = Cn
        tabla1.Name = "Datos"


        'Se agregan columnas con sus nombres y tipos de datos
        tabla1.Columns.Append("Nmat", ADOX.DataTypeEnum.adInteger)
        'tabla1.Columns.Append("NomApel", ADOX.DataTypeEnum.adChar)
        tabla1.Columns.Append("Nom", ADOX.DataTypeEnum.adWChar)
        tabla1.Columns.Append("Fecha", ADOX.DataTypeEnum.adDate)

        'Se agrega la tabla a la base de datos
        cat.Tables.Append(tabla1)

        'Se limpian los objetos
        tabla1 = Nothing
        cat = Nothing
        Cn.Close()
        Cn = Nothing
    End Sub
End Class