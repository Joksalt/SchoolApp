using SchoolManagementApp.Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApp.Project.Services
{
    public class SchoolService
    {
        List<Module> _modules = new List<Module>();
        List<Class> _classes = new List<Class>();

        ModuleFileService _moduleFileService = new ModuleFileService();
        ClassFileService _classFileService = new ClassFileService();

        public SchoolService()
        {
            _modules = _moduleFileService.ReadFile();
            _classes = _classFileService.ReadFile();
        }

        public  void AddModule(string name, string text)
        {
            var selectedModule = _modules.FirstOrDefault(m => m.Name == name);

            if(selectedModule != null)
            {
                Console.WriteLine($"Module with name {selectedModule.Name} already exists!");
                return;
            }
            else
            {
                Module module = new Module()
                {
                    Id = _modules.Count > 0 ? _modules.Select(x => x.Id).Max() + 1 : 1,
                    Name = name,
                    Description = text,
                    CreatedDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                };

                _modules.Add(module);

                _moduleFileService.WriteFile(_modules);
            }            
        }

        public void AddClass(string name, string text, string location)
        {
            var selectedClasses = _classes.FirstOrDefault(m => m.Name == name);

            if (selectedClasses != null)
            {
                Console.WriteLine($"Class with name {selectedClasses.Name} already exists!");
                return;
            }
            else
            {
                Class newClass= new Class()
                {
                    Id = _classes.Count > 0 ? _classes.Select(x => x.Id).Max() + 1 : 1,
                    Name = name,
                    Description = text,
                    CreatedDate = DateTime.Now,
                    Location = location,
                };

                _classes.Add(newClass);

                _classFileService.WriteFile(_classes);
            }
        }
    }
}
