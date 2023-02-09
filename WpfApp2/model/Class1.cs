using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WpfApp2;
namespace WpfApp2.model
{
    public class Class1
    {
        Person person = new Person();

        public string sd()
        {
            string a = File.ReadAllText(@"C:\Users\19662\Desktop\数据库连接字符串.txt");
            person.Name = a;
            return person.Name;
        }

    }
}
