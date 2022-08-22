using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;


namespace CRUDColegio.Data_source
{
    public class conexionBD
   {
        private static MySqlConnection? mysqlCon;
        public static void abrirDB()
        {
            string sConexion =  "server=localhost;database=crud_cole;uid=root;pwd=usr_susi;";//"server=localhost; port=3306; user= usr_susi; password=usr_susi; database=crud_cole;";
            
            mysqlCon = new MySqlConnection(sConexion);
            try
            {
                mysqlCon.Open();

                Console.WriteLine("Connection Successful");

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message + mysqlCon);
            }

        }
        public static void cerrarDB()
        {
            
            mysqlCon.Close();
            
        }

        // public static DataTable obtenerAlumnos()
        // {
            
        // }

        public static bool agregarAlumno(string sNombre, string SApellidos, string sGenero, DateTime fechaN)
        {
            string sQuery = "INSERT INTO ALUMNOS VALUES(NULL, ";
            sQuery += "'"+sNombre +"', '"+ SApellidos+ "', '"+ sGenero + "', '"+ fechaN.Date.ToString("yyyy-MM-dd") +"')";
            try
            {
                abrirDB();
                MySqlCommand comm = mysqlCon.CreateCommand();
                comm.CommandText = sQuery;
                var result = comm.ExecuteNonQuery();
                if (result != null) {
                    cerrarDB();
                    return true;
                }

            }catch (MySqlException e)
            {
                Console.WriteLine(e.Message + mysqlCon);
                cerrarDB();
            }

            return false;
        }

        public static bool agregarProfesor(string sNombre, string SApellidos, string sGenero)
        {
            string sQuery = "INSERT INTO PROFESORES VALUES(NULL, ";
            sQuery += "'"+sNombre +"', '"+ SApellidos+ "', '"+ sGenero + "')";
            try
            {
                abrirDB();
                MySqlCommand comm = mysqlCon.CreateCommand();
                comm.CommandText = sQuery;
                var result = comm.ExecuteNonQuery();
                if (result != null) {
                    cerrarDB();
                    return true;
                }
            }catch (MySqlException e)
            {
                Console.WriteLine(e.Message + mysqlCon);
                cerrarDB();
            }

            return false;
        }


        public static DataTable obtenerProfesores()
        {
            string sQuery = "SELECT * FROM PROFESORES ";//WHERE NOMBRE = '"+sNombre +"' AND APELLIDOS = '"+ SApellidos+ "''";
            try
            {
                abrirDB();
                MySqlCommand comm = mysqlCon.CreateCommand();
                comm.CommandText = sQuery;
                var result = comm.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(result);

                if (dt != null) {
                    cerrarDB();
                    return dt;
                }
            }catch (MySqlException e)
            {
                Console.WriteLine(e.Message + mysqlCon);
                cerrarDB();
            }

            return null;
        }

   }

}