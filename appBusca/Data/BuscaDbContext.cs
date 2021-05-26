using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using appBusca.Models;
namespace appBusca.Data
{
    public class BuscaDbContext : IdentityDbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public BuscaDbContext(DbContextOptions dco ) : base(dco)
        {
        }
    }
}
