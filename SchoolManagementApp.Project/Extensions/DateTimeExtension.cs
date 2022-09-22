using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApp.Project.Extensions
{
    public static class DateTimeExtension
    {
        public static string ToFormatString(this DateTime dateTime)
        {
            return dateTime.ToString("dd/yyyy/mm, hh");
        }
    }
}
