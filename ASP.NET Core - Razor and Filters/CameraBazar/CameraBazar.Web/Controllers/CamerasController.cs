using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CameraBazar.Web.Controllers
{
    public class CamerasController : Controller
    {
        [Authorize]
        public IActionResult Add() => this.View();
    }
}
