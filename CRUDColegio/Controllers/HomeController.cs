using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDColegio.Models;
using System.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRUDColegio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    List < SelectListItem > lstProfesores;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public ActionResult FormularioAlumnos()
    {
        return View();
    }

    public ActionResult agregarAlumno()
    {
        string sNombre = Request.Form["nombre"].ToString();
        string sApellidos = Request.Form["apellidos"].ToString();
        string sgenero = Request.Form["genero"].ToString();
        string dFechaNacimiento = Request.Form["fechaN"].ToString();

        cAlumno cAlumno =  new cAlumno(sNombre, sApellidos, sgenero, DateTime.Now);
        cAlumno.agregar();

        return View();
    }
    public ActionResult FormularioProfesores()
    {
        return View();
    }
    public ActionResult agregarProfesor()
    {
        string sNombre = Request.Form["nombre"].ToString();
        string sApellidos = Request.Form["apellidos"].ToString();
        string sgenero = Request.Form["genero"].ToString();

        cProfesor cProf =  new cProfesor(sNombre, sApellidos, sgenero);
        cProf.agregar();
        

        return View();
    }
    [HttpPost]
    public ActionResult FormularioGrados()
    {
        cProfesor cProf = new cProfesor();
        DataTable dt = cProf.obtener();
        
        List < SelectListItem > lstProfesores = new List < SelectListItem > () ;
        
         foreach(DataRow dr in dt.Rows)
         {
            lstProfesores.Add( new SelectListItem{
                Text = dr["nombre"].ToString() + dr["apellidos"].ToString(), 
            Value = dr["idprofesor"].ToString()});
        }
        ViewBag.TeaType = lstProfesores.ToString();

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
