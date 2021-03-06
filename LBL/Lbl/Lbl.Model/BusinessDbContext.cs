﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lbl.Model
{
    using System.Data.Entity;

    public class BusinessDbContext : DbContext
    {
        public BusinessDbContext() : base("DefaultBusinessConnection")
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }
    }
}
