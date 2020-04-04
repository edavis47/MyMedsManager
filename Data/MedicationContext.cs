using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMedsManager.Models;

namespace MyMedsManager.Data
{
    public class MedicationContext : DbContext
    {
        public MedicationContext(DbContextOptions<MedicationContext> options)
            : base(options) 
        {
        }
        public DbSet<Medication> Medication { get; set; }
    }
}
