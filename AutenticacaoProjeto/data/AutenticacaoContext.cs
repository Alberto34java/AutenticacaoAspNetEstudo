using System;
using Microsoft.EntityFrameworkCore;

namespace AutenticacaoProjeto.data
{
    public class AutenticacaoContext : DbContext 
    {
        public AutenticacaoContext(DbContextOptions<AutenticacaoContext> options)
        : base(options)
        {
            
        }
        
    }
}