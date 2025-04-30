*{
  padding: 0%;
  margin: 0%;
  background-color: rgb(243, 204, 240);
  
}


html {
  font-size: 14px;
  min-height: 100%;
}

@media (min-width: 768px) {
  html {
    font-size: 16px;
  }
}


body {
  margin: 10px;
  padding: 10px;
}


footer {
  clear:both;
  margin-top: 10px;
  padding: 10px;
  background-color: #f8f9fa;
  border-top: 1px solid #e9ecef;
  text-align: center;
}
img{
  width: 25%;
  height: auto;
  border: 8px solid rgb(255, 0, 234);
  padding: .15%;
 
}
header{
  
  clear:both;
  text-align: center;
  font-size: 50px;
  text-decoration: underline;
  font-family:fantasy;
}
section h2{
  
  text-align: center;
  padding-top: 1%;
  font-size: 25px;
 font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
}
div p{
  
  font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
}
/*div{
  height: auto;
  width: 25% ;
  
}*/

div{
  
  width: 45%;
  margin-top: 1%;
  float:left;
  box-sizing: border-box;
}
section div{
  
  width: 70%;
  margin-left: 15%;
  margin-right: 15%;
}









<p> Nombre: @ViewBag.Disco.Nombre</p>
<p> Artista: @ViewBag.Disco.Artista</p>
<p> Productor: @ViewBag.Disco.Productor</p>
<p> Género: @ViewBag.Disco.Genero</p>
<ul>
<p>Canciones</p>
@{  
    foreach(string tema in @ViewBag.Disco.Temas)
    {
        
        <li>@tema</li>
    }
}
</ul>
<img src = /@ViewBag.Disco.Foto alt = @ViewBag.Disco.Nombre>
<p><a href='@Url.Action("Index","Home")'>Volver a la pagina principal </p>






@{
    ViewData["Title"] = "Music Store";
}
<section>
<h2>-  Bienvenidos al sitio web oficial  -</h2>
<div>  
    @{
    foreach(Disco disco in @ViewBag.Lista.Discos)
    {
        <p>Nombre del disco: @disco.Nombre</p>
        <img src = @disco.Foto alt = @disco.Nombre>
        <a href='@Url.Action("InfoDisco", "Home", new { ID = disco.ID })'>Ver más info del disco</a>
    }
}
</div>
</section>



using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03.Models;

namespace TP03.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private static ListaDiscos miLista;
    private static Disco miDisco;
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        miLista = new ListaDiscos();
        ViewBag.Lista = miLista;
        return View();
    }
     public IActionResult InfoDisco(int ID)
    {
        ViewData["ID"] = ID;
        miDisco = miLista.Discos[ID];
        ViewBag.Disco = miDisco;
        return View("InfoDisco");
    }
}
