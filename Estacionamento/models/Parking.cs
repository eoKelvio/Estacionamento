using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace ParkingChalleng.models
{
    public class Parking
    {   
        int initialPrice = 10;
        int priceHour = 5;
        string plate = "default";
        List<string> vehicle = new List<string>();

        public void VehicleAdd()
        {
            Console.WriteLine("Insira a placa do seu veículo: ");
            string plate = Console.ReadLine();
            vehicle.Add(plate);
        }
        
        public void VehicleRemove()
        {
            Console.WriteLine("Insira a placa do seu veículo: ");
            string plate = Console.ReadLine();
            vehicle.Find(plate);
            //for (int i = 0; i < vehicle.Count; i++)
            //{
            //    if (vehicle[i] == plate)
            //    {
            //        Console.WriteLine("Insira o número de horas permanecidas no estacionamento: ");
            //        int hour = int.Parse(Console.ReadLine());
            //        int price = hour * priceHour + initialPrice;
            //        Console.WriteLine($"")
            //    }


                vehicle.Remove(plate);
            }
        }

        public void VehicleList()
        {
            int count = 0;
            if (vehicle.Count > 0)
            {
                while (count < vehicle.Count)
                {
                    Console.WriteLine($"{count} - Placa - {vehicle[count]}");
                }
            }else
            {
                Console.WriteLine("Não há veículos estacionados");
            }


        }
    }
}
