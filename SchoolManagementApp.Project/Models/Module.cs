using SchoolManagementApp.Project.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApp.Project.Models
{
    public class Module : EntityBase
    {
        public DateTime UpdateDate { get; set; }

        public Module() : base()
        {
        }
    }
}
