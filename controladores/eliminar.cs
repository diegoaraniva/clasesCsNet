public class eliminar(){
    public static int eliminando(int id) {
        int retorna;
        using (SqlConnection nuevaConexion = conectandoSqlServer.conectando()){
            string consulta = "DELETE FROM tabla WHERE id = @id";
            SqlCommand comando = new SqlCommand(consulta, nuevaConexion);

            //Preparando consultas
            comando.Parameters.AddWithValue("@id", id;)

            //Ejercutando la consulta y la conexión
            retorna = comando.ExecuteNonQuery();
            nuevaConexion.Close();
        }
        return retorna;
    }    
}