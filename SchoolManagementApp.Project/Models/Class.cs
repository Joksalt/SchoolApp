using SchoolManagementApp.Project.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApp.Project.Models
{
    public class Class : EntityBase
    {
        public string Location { get; set; }

        public override string ToString()
        {
            return String.Format($"[Id: {Id}] Name: {Name}");
        }
    }
}
