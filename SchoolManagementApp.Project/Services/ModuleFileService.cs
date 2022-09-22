using SchoolManagementApp.Project.Base;
using SchoolManagementApp.Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApp.Project.Services
{
    public class ModuleFileService : FileManagementBase<Module>
    {
        public ModuleFileService() : base("ModuleData.json")
        {

        }
    }
}
