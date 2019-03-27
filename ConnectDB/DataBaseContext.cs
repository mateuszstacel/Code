using FieldMapsConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_interviewer_maps.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
           : base("name=InterviewerEntities")
        {
        }
        public DbSet<FieldInterviewerMaps> Field_Interviewer_Maps { get; set; }
    }
}
