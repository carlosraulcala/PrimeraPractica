﻿using Microsoft.EntityFrameworkCore;
using ProyectoWebApp.Models;

namespace ProyectoWebApp.Context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto
            (DbContextOptions<AplicacionContexto> options)
            : base(options) { }

        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Docente> Docente { get; set; }
        public DbSet<Universidad> Universidad { get; set; }
    }
}
