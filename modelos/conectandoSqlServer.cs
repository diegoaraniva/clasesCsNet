public class conexion
    {
        public static SqlConnection conectando() {
            SqlConnection sqlConnection = new SqlConnection("server=SERVIDOR ; database=BASEDATOS ; integrated security = true");
            sqlConnection.Open();
            return sqlConnection;
        }
    }