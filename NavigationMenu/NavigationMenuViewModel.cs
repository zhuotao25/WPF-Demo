using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDataService;

namespace NavigationMenu
{
    public class NavigationMenuViewModel
    {
        public NavigationMenuViewModel()
        {
            // use cmd to create files
            // C:\Windows\Microsoft.NET\Framework64\v4.0.30319>datasvcutil.exe /language:Csharp /out:c:\hp\DataService.cs /uri:http://localhost:54944/WcfDataService1.svc/
            TestEntities context = new TestEntities(new Uri("http://localhost:54944/WcfDataService1.svc/"));

            List<Student> students = context.Students.ToList();

        }
    }
}
