using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_tryTask.Models
{
    public class WorkerContext : DbContext
    {
        public DbSet<Worker> Workers { get; set; }
    }
}