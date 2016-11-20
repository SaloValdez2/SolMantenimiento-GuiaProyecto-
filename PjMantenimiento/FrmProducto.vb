Public Class FrmProducto
    Dim obj As New ABDMantenimiento.ClsProducto
    Dim estado As String
    Public strFalg As String = "0"
    Private Sub FrmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Deshabilitar()
        Call listar()
        Call habilitar()

        dgvVentas.Columns(0).Visible = False
    End Sub
    Sub limpiar()
        Me.TxtCodigo.Text = ""
        Me.TxtDescripcion.Text = ""
        Me.TxtCodigo.Focus()
    End Sub
    Sub listar()
        dgvVentas.DataSource = obj.pus_Listar_Producto.Tables(0)
        dgvVentas.Columns(0).Visible = False
    End Sub

    Sub habilitar()
        Me.TxtCodigo.Enabled = True
        Me.TxtDescripcion.Enabled = True
    End Sub
    Sub Deshabilitar()
        Me.TxtCodigo.Enabled = False
        Me.TxtDescripcion.Enabled = False
        TsbModificar.Enabled = False
        TsbGrabar.Enabled = False
        TsbCancelar.Enabled = False
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles TsbGrabar.Click
        Dim iret As String
        If strFalg = "1" Then
            Dim resp As DialogResult = New DialogResult
            resp = MessageBox.Show("Desea agregar un servicio?", "MANTENIMIENTO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (resp = DialogResult.Yes) Then
                iret = obj.pus_i_producto(Me.TxtCodigo.Text, Me.TxtDescripcion.Text)
                If iret > 0 Then
                    MessageBox.Show("Se grabo la informacion", "GRABAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call listar()
                    Call limpiar()
                    Call Deshabilitar()
                    TsbGrabar.Enabled = False
                    TsbNuevo.Enabled = True
                End If
            End If
        End If

        If strFalg = "2" Then
            iret = obj.pus_u_producto(Me.TxtCodigo.Text, Me.TxtDescripcion.Text, Me.Label3.Text)
            If iret = "1" Then
                MessageBox.Show("Semodificó Correctamente", "Modificar",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.TsbGrabar.Enabled = False
                Me.TsbNuevo.Enabled = True
                Call Deshabilitar()
                Call listar()
            Else
                MessageBox.Show("Comuniquese con el administrador")
            End If
        End If

    End Sub

    Private Sub dgvVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentas.CellContentClick
        Try
            Me.Label3.Text = dgvVentas.CurrentRow.Cells(0).Value
            Me.TxtCodigo.Text = dgvVentas.CurrentRow.Cells(1).Value
            Me.TxtDescripcion.Text = dgvVentas.CurrentRow.Cells(2).Value
            TsbModificar.Enabled = True
            TsbNuevo.Enabled = True
            TsbCancelar.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TsbNuevo_Click(sender As Object, e As EventArgs) Handles TsbNuevo.Click
        strFalg = "1"
        TsbNuevo.Enabled = False
        TsbGrabar.Enabled = True
        TsbCancelar.Enabled = True
        Call limpiar()
        Call habilitar()
        Me.TxtCodigo.Focus()
    End Sub

    Private Sub TsbModificar_Click(sender As Object, e As EventArgs) Handles TsbModificar.Click
        strFalg = "2"
        habilitar()
        TsbModificar.Enabled = False
        TsbGrabar.Enabled = True

        Me.TxtCodigo.Focus()
    End Sub

    Private Sub TsbCancelar_Click(sender As Object, e As EventArgs) Handles TsbCancelar.Click
        Deshabilitar()
        TsbNuevo.Enabled = True
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        'ESC
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        'DELETE
        If keyData = Keys.Delete Then
            Dim message As String = "Eliminar Registro?"
            Dim caption As String = "Eliminar"
            Dim buttons As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim result As DialogResult
            'Displays the MessageBox
            result = MessageBox.Show(message, caption, buttons)
            'Gets the result of the MessageBox display.
            If result = System.Windows.Forms.DialogResult.Yes Then
                'Closes the parents form
                Dim objeliminar As New ABDMantenimiento.ClsProducto
                obj.pus_eliminar_producto(dgvVentas.Rows(dgvVentas.CurrentRow.Index).Cells(0).Value)
                Call listar()
            End If
        End If
        'devolver la tecla presionada de vuelta al formulario
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class