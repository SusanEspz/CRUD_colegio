using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDColegio.Controllers;

namespace CRUDColegio.Controllers;
public class AlumnoController:Controller
{
    private readonly ILogger<AlumnoController> _logger;
    public AlumnoController(ILogger<AlumnoController> logger)
     {
         _logger = logger;
     }
     
}

