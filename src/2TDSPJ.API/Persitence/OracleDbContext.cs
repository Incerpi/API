using _2TDSPJ.API.Persitence.Models;
using Microsoft.EntityFrameworkCore;

namespace _2TDSPJ.API.Persitence
{
    public class OracleDbContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Turma> Turmas { get; set; }

        public OracleDbContext(DbContextOptions<OracleDbContext> options) : base(options)
            { 
}

    }
}
