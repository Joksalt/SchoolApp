using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApp.Project.Base
{
    public abstract class FileManagementBase<T>
    {
        private string _fileName;

        public FileManagementBase(string fileName)
        {
            _fileName = fileName;
        }

        public List<T> ReadFile()
        {
            string fileContent = File.ReadAllText(_fileName);
            return JsonConvert.DeserializeObject<List<T>>(fileContent);

        }

        public void WriteFile(List<T> list)
        {
            string jsonData = JsonConvert.SerializeObject(list);
            File.WriteAllText(_fileName, jsonData);
        }
    }
}
