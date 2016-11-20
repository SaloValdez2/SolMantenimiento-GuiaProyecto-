<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProducto))
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.TsbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.TsbModificar = New System.Windows.Forms.ToolStripButton()
        Me.TsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.TsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.TsbBuscar = New System.Windows.Forms.ToolStripButton()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvVentas
        '
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Location = New System.Drawing.Point(20, 114)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.Size = New System.Drawing.Size(442, 202)
        Me.dgvVentas.TabIndex = 0
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsbNuevo, Me.TsbModificar, Me.TsbGrabar, Me.TsbCancelar, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.TsbBuscar})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(477, 25)
        Me.ToolStrip3.TabIndex = 1
        Me.ToolStrip3.Text = "ToolStrip1"
        '
        'TsbNuevo
        '
        Me.TsbNuevo.Image = Global.PjMantenimiento.My.Resources.Resources.mime_ascii
        Me.TsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbNuevo.Name = "TsbNuevo"
        Me.TsbNuevo.Size = New System.Drawing.Size(62, 22)
        Me.TsbNuevo.Text = "Nuevo"
        '
        'TsbModificar
        '
        Me.TsbModificar.Image = CType(resources.GetObject("TsbModificar.Image"), System.Drawing.Image)
        Me.TsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbModificar.Name = "TsbModificar"
        Me.TsbModificar.Size = New System.Drawing.Size(78, 22)
        Me.TsbModificar.Text = "Modificar"
        '
        'TsbGrabar
        '
        Me.TsbGrabar.Image = CType(resources.GetObject("TsbGrabar.Image"), System.Drawing.Image)
        Me.TsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbGrabar.Name = "TsbGrabar"
        Me.TsbGrabar.Size = New System.Drawing.Size(62, 22)
        Me.TsbGrabar.Text = "Grabar"
        '
        'TsbCancelar
        '
        Me.TsbCancelar.Image = CType(resources.GetObject("TsbCancelar.Image"), System.Drawing.Image)
        Me.TsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbCancelar.Name = "TsbCancelar"
        Me.TsbCancelar.Size = New System.Drawing.Size(73, 22)
        Me.TsbCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        Me.ToolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TsbBuscar
        '
        Me.TsbBuscar.Image = CType(resources.GetObject("TsbBuscar.Image"), System.Drawing.Image)
        Me.TsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbBuscar.Name = "TsbBuscar"
        Me.TsbBuscar.Size = New System.Drawing.Size(62, 22)
        Me.TsbBuscar.Text = "Buscar"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(91, 43)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(123, 20)
        Me.TxtCodigo.TabIndex = 2
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(91, 69)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(123, 20)
        Me.TxtDescripcion.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Código:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descripción:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(311, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Id_Producto"
        '
        'FrmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 344)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.dgvVentas)
        Me.Name = "FrmProducto"
        Me.Text = "FrmProducto"
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvVentas As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents TsbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents TsbModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TsbGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TsbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
End Class
