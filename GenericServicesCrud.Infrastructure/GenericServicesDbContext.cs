// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using GenericServicesCrud.Infrastructure.Models.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace GenericServicesCrud.Infrastructure
{
    public partial class GenericServicesDbContext : IdentityDbContext<User, Role, Guid>
    {
        public GenericServicesDbContext()
        {
        }

        public GenericServicesDbContext(DbContextOptions<GenericServicesDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Local
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseSqlServer("Server=.\\;Database=GenericServicesDb;user id=sa;password=open;",
            //        x => x.MigrationsHistoryTable("__GSMigrationsHistory"));
            //}
        }
    }
}
