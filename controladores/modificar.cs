public class modificar(){
    public static int modificando(getterSetterConstructores datos) {
        int retorna;
        using (SqlConnection nuevaConexion = conectandoSqlServer.conectando()){
            string consulta = "UPDATE tabla SET valor = @valor WHERE id = @id";
            SqlCommand comando = new SqlCommand(consulta, nuevaConexion);

            //Preparando consultas
            comando.Parameters.AddWithValue("@id", datos.id;
            comando.Parameters.AddWithValue("@valor", datos.valor);

            //Ejercutando la consulta y la conexión
            retorna = comando.ExecuteNonQuery();
            nuevaConexion.Close();
        }
        return retorna;
    }
}