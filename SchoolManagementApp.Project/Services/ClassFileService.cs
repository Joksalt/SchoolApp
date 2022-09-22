using SchoolManagementApp.Project.Base;
using SchoolManagementApp.Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApp.Project.Services
{
    public class ClassFileService : FileManagementBase<Class>
    {
        public ClassFileService() : base("ClassData.json")
        {

        }
    }
}
