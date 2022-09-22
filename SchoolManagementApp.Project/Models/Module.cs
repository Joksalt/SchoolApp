using SchoolManagementApp.Project.Base;
using SchoolManagementApp.Project.Extensions;

namespace SchoolManagementApp.Project.Models
{
    public class Module : EntityBase
    {
        public DateTime UpdateDate { get; set; }
        public List<int> ClassIds { get; set; } = new List<int>();

        public Module() : base()
        {
        }

        public override string ToString()
        {
            return string.Format($"[Id: {Id}], Name: {Name},\nDesription: {Description}\nCreated: {DateTimeExtension.ToFormatString(CreatedDate)}");
        }
    }
}
