using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prod.Entities
{
    internal class Services
    {
        public void validateOption(int quantity)
        {
            double discount = 0.9;
            if(quantity >= 10000)
            {
                Console.WriteLine("Debido la cantidad de tu compra mayor a $10,000 tienes una promoción a meses sin intereses");
                Console.WriteLine("Dame una opción para meses sin intereses");
                Console.WriteLine("Opción 1: 6 meses sin intereses");
                Console.WriteLine("Opción 2: 12 meses sin intereses");
                int option = int.Parse(Console.ReadLine());
                if(option == 1)
                {
                    Console.WriteLine("Se difiere a 6 meses por una cantidad al mes de " + (quantity/6));
                } else if(option == 2) {
                    Console.WriteLine("Se difiere a 12 meses por una cantidad al mes de " + (quantity / 12));
                }

            } else if(quantity >= 8000)
            {
                Console.WriteLine("Debido la cantidad de tu compra mayor a $8,000 tienes una promoción a meses sin intereses");
                Console.WriteLine("Tu compra puede ser diferida a 3 meses sin intereses por la cantidad de: " + (quantity / 3));
            } else if(quantity >= 5000)
            {
                Console.WriteLine("Debido la cantidad de tu compra mayor a $5,000 tienes un  descuento");
                Console.WriteLine("Has obtenido un descuento de 10%, por lo que pagarás: " + (quantity * discount));
            }
        }
        public void setProducts()
        {
            int cost = 0;
            int quantityArticles = 5;
            int totalCost = 0;
            Console.WriteLine("Ingresa el costo de cada artículo:");
            for(int i = 0; i < quantityArticles; i++)
            {
                Console.WriteLine("Dame el artículo " + (i + 1));
                cost = int.Parse(Console.ReadLine());
                totalCost += cost;
            }
            Console.WriteLine("El costo total es de: " + totalCost);
            validateOption(totalCost);

        }
    }
}
