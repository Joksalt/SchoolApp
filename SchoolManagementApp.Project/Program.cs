
using SchoolManagementApp.Project.Models;
using SchoolManagementApp.Project.Services;

bool endProgram = false;
MainService mainService = new MainService();

while (!endProgram)
{
    string command = Console.ReadLine();

    mainService.ExecuteCommand(command, out endProgram);

}