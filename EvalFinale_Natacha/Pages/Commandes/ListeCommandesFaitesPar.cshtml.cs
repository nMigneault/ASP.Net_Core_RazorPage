using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EvalFinale_Natacha.Data;
using EvalFinale_Natacha.Modeles;

namespace EvalFinale_Natacha.Pages.Commandes
{
    public class ListeCommandesFaitesParModel : PageModel
    {
        private readonly EvalFinale_Natacha.Data.EvalFinale_NatachaContext _context;

        public ListeCommandesFaitesParModel(EvalFinale_Natacha.Data.EvalFinale_NatachaContext context)
        {
            _context = context;
        }

        public IList<CommandesFaitesPar> CommandesFaitesPar { get;set; }

        public async Task OnGetAsync()
        {
            CommandesFaitesPar = await _context.CommandesFaitesPar.ToListAsync();
        }
    }
}
