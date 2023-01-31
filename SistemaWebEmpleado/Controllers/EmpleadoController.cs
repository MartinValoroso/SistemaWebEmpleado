using Microsoft.AspNetCore.Mvc;
using SistemaWebEmpleado.Data;
using SistemaWebEmpleado.Models;
using System.ComponentModel.Design.Serialization;
using System.Linq;

namespace SistemaWebEmpleado.Controllers
{
    public class EmpleadoController : Controller
    {

        private readonly DbEmpleadosContext context;

        public EmpleadoController(DbEmpleadosContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var empleados = context.Empleados.ToList();
            return View(empleados);
        }

        [HttpGet]
        public ActionResult Create()
        {
            Empleado empleado = new Empleado();
            return View("Create", empleado);

        }

        [HttpPost]
        public ActionResult Create (Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                context.Empleados.Add(empleado);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empleado);
        }

        [HttpGet]
        public ActionResult Details(int titulo )
        {
            var empleado = ObtenerUno(titulo);
            if (empleado == null)

                return NotFound();
            else
                return View("Details", titulo);
            

        }

        private Empleado ObtenerUno(int titulo)
        {
            return context.Empleados.Find(titulo);
        }
    }
}
