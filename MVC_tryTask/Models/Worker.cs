using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_tryTask.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public DateTime Birthday { get; set; }
    }
}