using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IDGS904CONBASE.Models
{
    public class MaestroContext : DbContext
    {



        private const string ConnectionString = "DefaultConnection";


        public MaestroContext() : base(ConnectionString)
        {

        }

        public DbSet<Maestro> Maestros { get; set; }

    }

}
