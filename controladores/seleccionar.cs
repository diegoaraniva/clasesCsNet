public class seleccionar(){
    public static List<getterSetterConstructores> leyendo() {
        List<getterSetterConstructores> lista = new List<getterSetterConstructores>();
        using (SqlConnection conectando = conexion.conectando()){
            string consulta = "SELECT * fecha FROM tabla";
            SqlCommand comando = new SqlCommand(consulta, conectando);

            SqlDataReader leyendo = comando.ExecuteReader(); //Objeto para leer datos desde la consulta establecida

            while (leyendo.Read()){ //Bucle termina hasta que las filas terminen
                getterSetterConstructores datos = new getterSetterConstructores();
                datos.valor = leyendo.GetString(0); //Numero de columna asignandose a los constructores
            }
            conectando.Close();
            return lista;
        }
    }
}