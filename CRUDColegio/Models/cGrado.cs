

namespace CRUDColegio.Models
{
    public class cGrado
    {
        public string sNombre {get;set;}
        public int idProfesor {get;set;}
        public cGrado( )
        {

        }

        public bool registrarGrado(string sGrado, int idProfesor)
        {
            return false;
        }
    }

}