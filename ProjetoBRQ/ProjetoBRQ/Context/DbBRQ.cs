﻿using ProjetoBRQ.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ProjetoBRQ.Context
{
    public class DbBRQ : DbContext
    {
        
        public DbSet<News> News { get; set; }
        public DbSet<ImgNews> ImgNews { get; set; }

        public DbBRQ() : base("name=DbBRQ")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("RM73879");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}