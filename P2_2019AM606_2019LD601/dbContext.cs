﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using P2_2019AM606_2019LD601.Models;

namespace P2_2019AM606_2019LD601
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options)
        {

        }

        public DbSet<CasosReportados> casosReportados { get; set; }
        public DbSet<Departamentos> departamentos { get; set; }
        public DbSet<Generos> generos { get; set; }
    }
}
