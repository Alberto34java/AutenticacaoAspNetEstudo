using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutenticacaoProjetoSeries.data
{
    public class AutenticaContext : DbContext
    {
        public AutenticaContext(DbContextOptions<AutenticaContext> options)
             : base(options)
        {

        }
    }
}
