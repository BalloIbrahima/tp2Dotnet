using Microsoft.AspNetCore.Mvc;
namespace NomDuProjet.Controllers;
public class AccueilController:Controller{
    public IActionResult Index(){
        return View();
    }
}