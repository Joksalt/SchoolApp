using SchoolManagementApp.Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApp.Project.Services
{
    public class SchoolService
    {
        private int ModuleId = 1;

        List<Module> _modules = new List<Module>();
        List<Class> _classes = new List<Class>();

        ModuleFileService moduleFileService = new ModuleFileService();
        ClassFileService classFileService = new ClassFileService();
        public SchoolService()
        {
            _modules = moduleFileService.ReadFile();
            _classes = classFileService.ReadFile();
        }

        internal void AddModule(string name, string text)
        {
            var selectedModule = _modules.FirstOrDefault(m => m.Name == name);

            if(selectedModule != null)
            {
                Console.WriteLine($"Module with name {selectedModule.Name} already exists!");
                return;
            }

            if(selectedModule == null)
            {
                Module module = new Module()
                {
                    Id = GenerateModuleId(),
                    Name = name,
                    Description = text,
                    CreatedDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                };

                _modules.Add(module);
            }

            moduleFileService.WriteFile(_modules);
        }

        private int GenerateModuleId()
        {
            return ModuleId++;
        }
    }
}
