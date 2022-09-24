using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CuidadoEquino.App.Dominio;
using CuidadoEquino.App.Persistencia;
using Microsoft.AspNetCore.Authorization;
//librerias

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuidadoEquino.App.Frontend.Pages
{
    public class listasModel : PageModel
    {


        private readonly INRepositorioEquino repositorioEquino;

        public listasModel()
        {
            this.repositorioEquino = new RepositorioEquino(new
            CuidadoEquino.App.Persistencia.AppContext());
        }

        [BindProperty]

        public Equino Equino{set;get;}


        public IActionResult OnPost()
        {
            repositorioEquino.AddEquino(Equino);
            return RedirectToPage("./listasequino");
        }



    }
}

