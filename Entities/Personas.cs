using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prod.Entities
{
    internal class Personas
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public void setData()
        {
            Console.WriteLine("Ingresa tus datos");
            Console.WriteLine("Dame tu nombre");
            this.Name = Console.ReadLine();
            Console.WriteLine("Dame tu email");
            this.Email = Console.ReadLine();
            Console.WriteLine("Dame tu número teléfonico");
            this.Phone = Console.ReadLine();

            Console.Clear();
        }

        public void printData()
        {
            Console.WriteLine("Tus datos son:");
            Console.WriteLine("Nombre: " + this.Name);
            Console.WriteLine("Email: " + this.Email);
            Console.WriteLine("Teléfono: " + this.Phone);

        }
    }


}
