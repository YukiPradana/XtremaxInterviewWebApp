using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using XtremaxInterviewWebApp.Data.DataModels;

namespace XtremaxInterviewWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Status> Statuses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

    }
}
