using Microsoft.EntityFrameworkCore;
using projetoFinall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoFinall.Data
{
    public class BancoContextcs : DbContext
    {
        public BancoContextcs(DbContextOptions<BancoContextcs> options) : base (options)

        {

        }
        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
