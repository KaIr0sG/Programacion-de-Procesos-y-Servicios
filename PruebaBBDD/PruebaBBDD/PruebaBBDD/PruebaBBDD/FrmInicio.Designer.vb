<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInicio))
        Me.BtnBBDD = New System.Windows.Forms.Button()
        Me.BtnGenerarConsulta = New System.Windows.Forms.Button()
        Me.MnuMenu = New System.Windows.Forms.MenuStrip()
        Me.MnuBBDD = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuBaseDeDatos = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatorPerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PepeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuGenerarConsulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnBBDDBarra = New System.Windows.Forms.ToolStripButton()
        Me.MnuMenu.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnBBDD
        '
        Me.BtnBBDD.Location = New System.Drawing.Point(824, 561)
        Me.BtnBBDD.Name = "BtnBBDD"
        Me.BtnBBDD.Size = New System.Drawing.Size(169, 46)
        Me.BtnBBDD.TabIndex = 0
        Me.BtnBBDD.Text = "Base de Datos"
        Me.BtnBBDD.UseVisualStyleBackColor = True
        Me.BtnBBDD.Visible = False
        '
        'BtnGenerarConsulta
        '
        Me.BtnGenerarConsulta.Location = New System.Drawing.Point(26, 575)
        Me.BtnGenerarConsulta.Name = "BtnGenerarConsulta"
        Me.BtnGenerarConsulta.Size = New System.Drawing.Size(169, 42)
        Me.BtnGenerarConsulta.TabIndex = 1
        Me.BtnGenerarConsulta.Text = "Generar consulta"
        Me.BtnGenerarConsulta.UseVisualStyleBackColor = True
        Me.BtnGenerarConsulta.Visible = False
        '
        'MnuMenu
        '
        Me.MnuMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuBBDD, Me.MnuSalir})
        Me.MnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.MnuMenu.Name = "MnuMenu"
        Me.MnuMenu.Size = New System.Drawing.Size(1023, 28)
        Me.MnuMenu.TabIndex = 3
        Me.MnuMenu.Text = "MenuStrip1"
        '
        'MnuBBDD
        '
        Me.MnuBBDD.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuBaseDeDatos, Me.MnuGenerarConsulta})
        Me.MnuBBDD.Name = "MnuBBDD"
        Me.MnuBBDD.Size = New System.Drawing.Size(63, 24)
        Me.MnuBBDD.Text = "BBDD"
        '
        'MnuBaseDeDatos
        '
        Me.MnuBaseDeDatos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatorPerToolStripMenuItem, Me.PepeToolStripMenuItem})
        Me.MnuBaseDeDatos.Name = "MnuBaseDeDatos"
        Me.MnuBaseDeDatos.Size = New System.Drawing.Size(224, 26)
        Me.MnuBaseDeDatos.Text = "Base de Datos"
        '
        'DatorPerToolStripMenuItem
        '
        Me.DatorPerToolStripMenuItem.Name = "DatorPerToolStripMenuItem"
        Me.DatorPerToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DatorPerToolStripMenuItem.Text = "DatorPer"
        '
        'PepeToolStripMenuItem
        '
        Me.PepeToolStripMenuItem.Name = "PepeToolStripMenuItem"
        Me.PepeToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.PepeToolStripMenuItem.Text = "Pepe"
        '
        'MnuGenerarConsulta
        '
        Me.MnuGenerarConsulta.Name = "MnuGenerarConsulta"
        Me.MnuGenerarConsulta.Size = New System.Drawing.Size(224, 26)
        Me.MnuGenerarConsulta.Text = "Generar Consulta"
        '
        'MnuSalir
        '
        Me.MnuSalir.Name = "MnuSalir"
        Me.MnuSalir.Size = New System.Drawing.Size(52, 24)
        Me.MnuSalir.Text = "Salir"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnBBDDBarra})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1023, 27)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnBBDDBarra
        '
        Me.BtnBBDDBarra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnBBDDBarra.Image = CType(resources.GetObject("BtnBBDDBarra.Image"), System.Drawing.Image)
        Me.BtnBBDDBarra.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnBBDDBarra.Name = "BtnBBDDBarra"
        Me.BtnBBDDBarra.Size = New System.Drawing.Size(29, 24)
        Me.BtnBBDDBarra.Text = "ToolStripButton1"
        '
        'FrmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 669)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.BtnGenerarConsulta)
        Me.Controls.Add(Me.BtnBBDD)
        Me.Controls.Add(Me.MnuMenu)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MnuMenu
        Me.Name = "FrmInicio"
        Me.Text = "Inicio Aplicación"
        Me.MnuMenu.ResumeLayout(False)
        Me.MnuMenu.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBBDD As Button
    Friend WithEvents BtnGenerarConsulta As Button
    Friend WithEvents MnuMenu As MenuStrip
    Friend WithEvents MnuBBDD As ToolStripMenuItem
    Friend WithEvents MnuBaseDeDatos As ToolStripMenuItem
    Friend WithEvents MnuGenerarConsulta As ToolStripMenuItem
    Friend WithEvents MnuSalir As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnBBDDBarra As ToolStripButton
    Friend WithEvents DatorPerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PepeToolStripMenuItem As ToolStripMenuItem
End Class
