using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prod.Entities
{
    internal class Menu
    {
        public void menu()
        {
            Personas person = new Personas();
            Services services = new Services();

            person.setData();
            person.printData();

            services.setProducts();
        }
    }
}
