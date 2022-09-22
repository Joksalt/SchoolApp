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

            if(input.StartsWith("add module"))
            {
                string name = input.Split(" ")[2];
                string text = input.Split(" ")[3];
                
                schoolservice.AddModule(name, text);
                Console.WriteLine($"Module {name} added!");
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
