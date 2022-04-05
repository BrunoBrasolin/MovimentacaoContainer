#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovimentacaoContainer.Models;

namespace MovimentacaoContainer.Data
{
    public class MovimentacaoContainerContext : DbContext
    {
        public MovimentacaoContainerContext (DbContextOptions<MovimentacaoContainerContext> options)
            : base(options)
        {
        }

        public DbSet<MovimentacaoContainer.Models.Container> Container { get; set; }

        public DbSet<MovimentacaoContainer.Models.Movimentacao> Movimentacao { get; set; }
    }
}
