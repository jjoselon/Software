using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using System.Text.Encodings.Web;

namespace MVCapplicacion.Controllers
{
    public class ItemsController : Controller
    {
        // GET: /Items/
        public string Index()
        {
            return "index";
        }

        // 
        // GET: /Items/Welcome/ 

        public string Welcome(string language, int any = 8)
        {
            return HtmlEncoder.Default.Encode($"{language} {any}");
        }
    }
}