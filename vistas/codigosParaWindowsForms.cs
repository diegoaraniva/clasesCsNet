//Cerrar formulario o aplicacion completa respectivamente
this.Close();
Application.Exit();

//Formulario padre e hijo (Boton)
FHijo hijo = new FHijo();
hijo.MdiParent = this;
hijo.Show();

//Limpiar una TextBox
TextBoxName.Clear();

//Ocultar TextBox (Se coloca al cargar el formulario)
this.TextBoxName.Visible = false;

//Metodo para mostrar datos en un DataGrid
public void refrescarPantalla()
{
    DataGridNombre.DataSource = seleccionar.leyendo();
}

//En boton agregar
getterSetterConstructores datos = new getterSetterConstructores();
datos.valor = valorTextBox.Text;

int resultado = agregar.agregando(datos); //Debe retornar 1

if (resultado > 0) {
    MessageBox.Show("Tarea guardada exitosamente");
}

refrescarPantalla()

//Agregando datos del DataGrid a TextBox (En evento "SelectedChanged")
TextBoxName.Text = Convert.ToString(DataGridName.CurrentRow.Cells["nombreColumna"].Value);

//En boton modificar
getterSetterConstructores datos = new getterSetterConstructores();
datos.id = valorTextBoxId.Text;
datos.valor = valorTextBox.Text;

int resultado = modificar.modificando(datos); //Debe retornar 1

if (resultado > 0) {
    MessageBox.Show("Tarea modificada exitosamente");
}

refrescarPantalla()

//En boton eliminar
if(DataGridName.SelectedRows.Count == 1){ //Para ver si esta seleccionado una fila
    int id = convert.toInt32(DataGridName.CurrentRowCells["id"].Value);

    int resultado = eliminar.eliminando(id); //Debe retornar 1

    if (resultado > 0) {
        MessageBox.Show("Tarea eliminada exitosamente");
    }  
}

refrescarPantalla()
