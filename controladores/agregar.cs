public class agregar(){
    public static int agregando(getterSetterConstructores datos) {
        int retorna;
        using (SqlConnection nuevaConexion = conectandoSqlServer.conectando()) {
            string consulta = "INSERT INTO tareas (valor) VALUES (@valor)";
            SqlCommand comando = new SqlCommand(consulta, nuevaConexion);

            //Preparando consultas
            comando.Parameters.AddWithValue("@valor", datos.valor);

            //Ejercutando la consulta y la conexión
            retorna = comando.ExecuteNonQuery();
            nuevaConexion.Close();
        }
        return retorna;
    }
}