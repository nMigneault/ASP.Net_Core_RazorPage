using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EvalFinale_Natacha.Modeles;

namespace EvalFinale_Natacha.Data
{
    public class EvalFinale_NatachaContext : DbContext
    {
        public EvalFinale_NatachaContext (DbContextOptions<EvalFinale_NatachaContext> options)
            : base(options)
        {
        }

        public DbSet<EvalFinale_Natacha.Modeles.CommandesFaitesPar> CommandesFaitesPar { get; set; } = default!;
    }
}
