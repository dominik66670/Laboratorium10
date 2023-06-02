using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Laboratorium10.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "To jest domyślna akcja";
        }
        public string Welcome(string name, int ID = 1) 
        {
            return HtmlEncoder.Default.Encode($"Witaj {name}, ID: {ID}");
        }
    }
}
