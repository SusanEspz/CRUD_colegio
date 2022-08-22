using CRUDColegio.Data_source;

namespace CRUDColegio.Models
{
    public class cAlumno : cPersona
    {
        
        public int ID  = 0;
        

        // private string sNombArchivo;
        // private StreamWriter swArchivo ;

        public cAlumno(string sNom, string sApells, string sGnero, DateTime dFecha)
        {
            SNombre = sNom;
            SApellidos = sApells;
            SGenero = sGnero;
            DFechaNacimiento= dFecha;

        }

        public override bool agregar()
        {
           
            bool bAgrego = conexionBD.agregarAlumno(SNombre, SApellidos, SGenero, DFechaNacimiento);
            

            // string sPath = System.IO.Path.Combine(_enviroment.ContentRootPath, "App_Data", "datos.txt");
            // StreamWriter swArchivo = new StreamWriter(sPath, true );
            // string sLine = ID + SNombre + "_" + SApellidos + "_"  + SGenero + "_" + SFechaNacimiento;
            return bAgrego;
        }


    }
}
