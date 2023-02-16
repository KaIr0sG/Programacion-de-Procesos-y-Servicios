<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNaveBBDD
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtDni = New System.Windows.Forms.TextBox()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GrpNavegacion = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        Me.BtnPrimero = New System.Windows.Forms.Button()
        Me.GrpDatos = New System.Windows.Forms.GroupBox()
        Me.BtnLimpiarCampos = New System.Windows.Forms.Button()
        Me.LblMarcador = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnVaciarDatos = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.GrbBusqueda = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtDNIBuscar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DtgDatos = New System.Windows.Forms.DataGridView()
        Me.GrpNavegacion.SuspendLayout()
        Me.GrpDatos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GrbBusqueda.SuspendLayout()
        CType(Me.DtgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtDni
        '
        Me.TxtDni.Location = New System.Drawing.Point(197, 33)
        Me.TxtDni.Name = "TxtDni"
        Me.TxtDni.Size = New System.Drawing.Size(100, 22)
        Me.TxtDni.TabIndex = 0
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(198, 212)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(100, 22)
        Me.TxtFecha.TabIndex = 1
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Location = New System.Drawing.Point(198, 161)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(100, 22)
        Me.TxtApellidos.TabIndex = 2
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(197, 94)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(100, 22)
        Me.TxtNombre.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "DNI:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha Nacimiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Apellidos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nombre:"
        '
        'GrpNavegacion
        '
        Me.GrpNavegacion.Controls.Add(Me.Button5)
        Me.GrpNavegacion.Controls.Add(Me.BtnAnterior)
        Me.GrpNavegacion.Controls.Add(Me.BtnSiguiente)
        Me.GrpNavegacion.Controls.Add(Me.BtnPrimero)
        Me.GrpNavegacion.Location = New System.Drawing.Point(433, 64)
        Me.GrpNavegacion.Name = "GrpNavegacion"
        Me.GrpNavegacion.Size = New System.Drawing.Size(365, 90)
        Me.GrpNavegacion.TabIndex = 12
        Me.GrpNavegacion.TabStop = False
        Me.GrpNavegacion.Text = "Navegación"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(280, 46)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = ">>"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'BtnAnterior
        '
        Me.BtnAnterior.Enabled = False
        Me.BtnAnterior.Location = New System.Drawing.Point(122, 46)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(75, 23)
        Me.BtnAnterior.TabIndex = 14
        Me.BtnAnterior.Text = "<"
        Me.BtnAnterior.UseVisualStyleBackColor = True
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.Location = New System.Drawing.Point(203, 46)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.BtnSiguiente.TabIndex = 13
        Me.BtnSiguiente.Text = ">"
        Me.BtnSiguiente.UseVisualStyleBackColor = True
        '
        'BtnPrimero
        '
        Me.BtnPrimero.Location = New System.Drawing.Point(41, 46)
        Me.BtnPrimero.Name = "BtnPrimero"
        Me.BtnPrimero.Size = New System.Drawing.Size(75, 23)
        Me.BtnPrimero.TabIndex = 12
        Me.BtnPrimero.Text = "<<"
        Me.BtnPrimero.UseVisualStyleBackColor = True
        '
        'GrpDatos
        '
        Me.GrpDatos.Controls.Add(Me.BtnLimpiarCampos)
        Me.GrpDatos.Controls.Add(Me.TxtDni)
        Me.GrpDatos.Controls.Add(Me.TxtFecha)
        Me.GrpDatos.Controls.Add(Me.Label4)
        Me.GrpDatos.Controls.Add(Me.TxtApellidos)
        Me.GrpDatos.Controls.Add(Me.Label3)
        Me.GrpDatos.Controls.Add(Me.TxtNombre)
        Me.GrpDatos.Controls.Add(Me.Label2)
        Me.GrpDatos.Controls.Add(Me.Label1)
        Me.GrpDatos.Location = New System.Drawing.Point(12, 12)
        Me.GrpDatos.Name = "GrpDatos"
        Me.GrpDatos.Size = New System.Drawing.Size(415, 308)
        Me.GrpDatos.TabIndex = 13
        Me.GrpDatos.TabStop = False
        Me.GrpDatos.Text = "Datos Personales"
        Me.GrpDatos.Visible = False
        '
        'BtnLimpiarCampos
        '
        Me.BtnLimpiarCampos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiarCampos.Location = New System.Drawing.Point(6, 262)
        Me.BtnLimpiarCampos.Name = "BtnLimpiarCampos"
        Me.BtnLimpiarCampos.Size = New System.Drawing.Size(387, 40)
        Me.BtnLimpiarCampos.TabIndex = 16
        Me.BtnLimpiarCampos.Text = "Borrar Campos"
        Me.BtnLimpiarCampos.UseVisualStyleBackColor = True
        '
        'LblMarcador
        '
        Me.LblMarcador.AutoSize = True
        Me.LblMarcador.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMarcador.Location = New System.Drawing.Point(230, 323)
        Me.LblMarcador.Name = "LblMarcador"
        Me.LblMarcador.Size = New System.Drawing.Size(102, 32)
        Me.LblMarcador.TabIndex = 14
        Me.LblMarcador.Text = "Label5"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnVaciarDatos)
        Me.GroupBox1.Controls.Add(Me.BtnActualizar)
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.BtnModificar)
        Me.GroupBox1.Controls.Add(Me.BtnInsertar)
        Me.GroupBox1.Location = New System.Drawing.Point(433, 177)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 137)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'BtnVaciarDatos
        '
        Me.BtnVaciarDatos.Location = New System.Drawing.Point(84, 75)
        Me.BtnVaciarDatos.Name = "BtnVaciarDatos"
        Me.BtnVaciarDatos.Size = New System.Drawing.Size(237, 23)
        Me.BtnVaciarDatos.TabIndex = 16
        Me.BtnVaciarDatos.Text = "Eliminar todas las filas"
        Me.BtnVaciarDatos.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(280, 46)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 15
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(122, 46)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 14
        Me.BtnEliminar.Text = "Borrar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(203, 46)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 13
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Location = New System.Drawing.Point(41, 46)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(75, 23)
        Me.BtnInsertar.TabIndex = 12
        Me.BtnInsertar.Text = "Insertar"
        Me.BtnInsertar.UseVisualStyleBackColor = True
        '
        'GrbBusqueda
        '
        Me.GrbBusqueda.Controls.Add(Me.BtnBuscar)
        Me.GrbBusqueda.Controls.Add(Me.TxtDNIBuscar)
        Me.GrbBusqueda.Controls.Add(Me.Label5)
        Me.GrbBusqueda.Location = New System.Drawing.Point(210, 375)
        Me.GrbBusqueda.Name = "GrbBusqueda"
        Me.GrbBusqueda.Size = New System.Drawing.Size(360, 63)
        Me.GrbBusqueda.TabIndex = 16
        Me.GrbBusqueda.TabStop = False
        Me.GrbBusqueda.Text = "Busqueda"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(247, 24)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 13
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtDNIBuscar
        '
        Me.TxtDNIBuscar.Location = New System.Drawing.Point(97, 25)
        Me.TxtDNIBuscar.Name = "TxtDNIBuscar"
        Me.TxtDNIBuscar.Size = New System.Drawing.Size(100, 22)
        Me.TxtDNIBuscar.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Codigo postal:"
        '
        'DtgDatos
        '
        Me.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgDatos.Location = New System.Drawing.Point(42, 488)
        Me.DtgDatos.Name = "DtgDatos"
        Me.DtgDatos.RowHeadersWidth = 51
        Me.DtgDatos.RowTemplate.Height = 24
        Me.DtgDatos.Size = New System.Drawing.Size(782, 150)
        Me.DtgDatos.TabIndex = 17
        '
        'FrmNaveBBDD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 662)
        Me.Controls.Add(Me.DtgDatos)
        Me.Controls.Add(Me.GrbBusqueda)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblMarcador)
        Me.Controls.Add(Me.GrpDatos)
        Me.Controls.Add(Me.GrpNavegacion)
        Me.Name = "FrmNaveBBDD"
        Me.Text = "Navegación BBDD"
        Me.GrpNavegacion.ResumeLayout(False)
        Me.GrpDatos.ResumeLayout(False)
        Me.GrpDatos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GrbBusqueda.ResumeLayout(False)
        Me.GrbBusqueda.PerformLayout()
        CType(Me.DtgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtDni As TextBox
    Friend WithEvents TxtFecha As TextBox
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GrpNavegacion As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents BtnAnterior As Button
    Friend WithEvents BtnSiguiente As Button
    Friend WithEvents BtnPrimero As Button
    Friend WithEvents GrpDatos As GroupBox
    Friend WithEvents LblMarcador As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents BtnLimpiarCampos As Button
    Friend WithEvents BtnVaciarDatos As Button
    Friend WithEvents GrbBusqueda As GroupBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtDNIBuscar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DtgDatos As DataGridView
End Class
