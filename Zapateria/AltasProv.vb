﻿Public Class AltasProv

    Private Sub ProveedoresBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub AltasProv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.ZapateriaDataSet.Localidad)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.ZapateriaDataSet.Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.ZapateriaDataSet.Localidad)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.ZapateriaDataSet.Proveedores)
        Me.ProveedoresBindingSource.AddNew()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

        Me.ProveedoresBindingSource.Current("ID_Localidad") = CmbLocalidad.SelectedValue
        Me.ProveedoresBindingSource.Current("Razon_Social") = Razon_SocialTextBox.Text
        Me.ProveedoresBindingSource.Current("CUIT") = Val(CUITTextBox.Text)
        Me.ProveedoresBindingSource.Current("Direccion") = DireccionTextBox.Text
        Me.ProveedoresBindingSource.Current("Nro") = Val(NroTextBox.Text)
        Me.ProveedoresBindingSource.Current("Telefono") = Val(TelefonoTextBox.Text)
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet) 'guardar disco
        Me.ProveedoresTableAdapter.Fill(Me.ZapateriaDataSet.Proveedores) 'actualizo en altas
        Prov.ProveedoresTableAdapter.Fill(Prov.ZapateriaDataSet.Proveedores) 'actualizo en principal para que muestre el cod del art
        Alta_Producto.ProveedoresTableAdapter.Fill(Alta_Producto.ZapateriaDataSet.Proveedores)
        Me.ProveedoresBindingSource.MoveLast() 'muestra el ultimo agregado
        MsgBox("El codigo de proveedor es:" + Me.ProveedoresBindingSource.Current("ID_Proveedor").ToString)
        Me.ProveedoresBindingSource.AddNew()



    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Close()

    End Sub

    Private Sub AltasProv_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call BtnGuardar_Click(sender, e)
        End If
        If e.KeyCode = Keys.Escape Then
            Call BtnVolver_Click(sender, e)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AltaLoc.Show()
    End Sub

    Private Sub ProveedoresBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub CUITTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUITTextBox.TextChanged

    End Sub
End Class