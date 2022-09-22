using SchoolManagementApp.Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApp.Project.Services
{
    public class MainService
    {
        private readonly SchoolService schoolservice = new ();

        internal void ExecuteCommand(string input, out bool endProgram)
        {           
            endProgram = false;

            if (input.StartsWith("add module"))
            {
                string name = input.Split(" ")[2];
                string text = input.Split(" ")[3];
                
                schoolservice.AddModule(name, text);

                Console.WriteLine($"\nModule {name} added!");
            }
            else if (input.StartsWith("add class"))
            {
                string name = input.Split(" ")[2];
                string text = input.Split(" ")[3];
                string location = input.Split(" ")[4];

                schoolservice.AddClass(name, text, location);

                Console.WriteLine($"\nClass {name} added!");
            }
            else if (input.StartsWith("assign class"))
            {
                string className = input.Split(" ")[2];
                string moduleName = input.Split(" ")[3];

                schoolservice.AssignClassToModule(className, moduleName);

                Console.WriteLine($"\nAssigned {className} to {moduleName}!");
            }
            else if(input.StartsWith("print module"))
            {
                string moduleName = input.Split(" ")[2];

                schoolservice.PrintModule(moduleName);
            }
            else if (input.StartsWith("exit"))
            {
                endProgram = true;
                Console.WriteLine("Exiting program...");
                return;
            }
        }
    }
}
