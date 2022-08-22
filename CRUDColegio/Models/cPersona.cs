namespace CRUDColegio.Models
{

    public class cPersona
    {
        public int iID {get;set;}
        public string SNombre {get; set;} 
        public string SApellidos {get; set;}
        public string SGenero{get; set;} 
        public DateTime DFechaNacimiento {get; set;} //Formato dd/mm/yyyy

        public virtual bool agregar()
        {
            return true;
        }
        public virtual cPersona obtener(string sNombre,  string sApellidos)
        {
            return this;
        }
    }
}