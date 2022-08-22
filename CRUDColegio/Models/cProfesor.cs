using CRUDColegio.Data_source;
using System.Data;


using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web;

namespace CRUDColegio.Models
{
    public class cProfesor :cPersona
    {
        List<string> lstProfesores = new List<string>();
        public cProfesor(){

        }
        public cProfesor(string sNom, string sApells, string sGenero)
        {
            SNombre = sNom;
            SApellidos = sApells;
            SGenero = sGenero;

        }

        public override bool agregar()
        {
           
            bool bAgrego = conexionBD.agregarProfesor(SNombre, SApellidos, SGenero);
            

            // string sPath = System.IO.Path.Combine(_enviroment.ContentRootPath, "App_Data", "datos.txt");
            // StreamWriter swArchivo = new StreamWriter(sPath, true );
            // string sLine = ID + SNombre + "_" + SApellidos + "_"  + SGenero + "_" + SFechaNacimiento;
            return bAgrego;
        }
        public DataTable obtener()
        {
            DataTable dt = conexionBD.obtenerProfesores();
            return dt;
            //  {

            // if(dt != null && dt.Rows.Count>0)
            // {
            //     foreach(DataRow dr in dt.Rows){
            //         lstProfesores.Add(dr["nombre"].ToString() + dr["apellidos"].ToString());
            //     }
            //     // this.iID = Convert.ToInt32( dt.Rows[0]["idProfesor"]);
            //     // this.SNombre = dt.Rows[0]["nombre"].ToString();
            //     // this.SApellidos = dt.Rows[0]["apellidos"].ToString();
            //     // this.SGenero = dt.Rows[0]["genero"].ToString();
            // }
            // return lstProfesores;
        }

    }
}

