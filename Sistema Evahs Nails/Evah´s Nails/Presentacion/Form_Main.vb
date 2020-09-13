Public Class Form_Main
    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clientes.MdiParent = Me
        productos.MdiParent = Me
        servicios.MdiParent = Me

        SplitContainer1.Panel2.Controls.Add(clientes)
        SplitContainer1.Panel2.Controls.Add(productos)
        SplitContainer1.Panel2.Controls.Add(servicios)
    End Sub

    Private Sub btn_Clientes_Click(sender As Object, e As EventArgs) Handles btn_Clientes.Click
        clientes.Show()
        productos.Hide()
        servicios.Hide()
    End Sub

    Private Sub btn_Productos_Click(sender As Object, e As EventArgs) Handles btn_Productos.Click
        clientes.Hide()
        productos.Show()
        servicios.Hide()
    End Sub

    Private Sub btn_Servicios_Click(sender As Object, e As EventArgs) Handles btn_Servicios.Click
        clientes.Hide()
        productos.Hide()
        servicios.Show()
    End Sub
End Class