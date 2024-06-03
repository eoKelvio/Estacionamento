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
        List<string> vehicle = new List<string>();
        string option;
        bool viewMenu = true;

        public void VehicleAdd()
        {
            Console.Clear();
            Console.WriteLine("Insira a placa do seu veículo: \n");
            string plate = Console.ReadLine();
            vehicle.Add(plate);
        }

        public void VehicleRemove()
        {
            Console.Clear();
            Console.WriteLine("Insira a placa do seu veículo: \n");
            string plate = Console.ReadLine();
            bool vehicleFound = false;

            for (int i = 0; i < vehicle.Count; i++)
            {
                if (vehicle[i] == plate)
                {
                    Console.WriteLine("Insira o número de horas permanecidas no estacionamento: \n");
                    int hour = int.Parse(Console.ReadLine());
                    decimal price = hour * priceHour + initialPrice;
                    Console.WriteLine($"O valor a ser pago é R${price} \n");
                    vehicle.RemoveAt(i);
                    vehicleFound = true;
                    break;
                }
            }

            if (!vehicleFound)
            {
                Console.WriteLine("Veículo não encontrado. \n");
            }
        }

        public void VehicleList()
        {
            Console.Clear();
            int count = 0;
            if (vehicle.Count > count)
            {
                while (count < vehicle.Count)
                {
                    Console.WriteLine($"{count} - Placa - {vehicle[count]}\n");
                    count++;
                }
            }else
            {
                Console.WriteLine("Não há veículos estacionados \n");
            }


        }
        
        public void Menu()
        {
            Console.Clear();
            while (viewMenu)
            {
                Console.WriteLine("Bem vindo ao atendimento do estacionamento!");
                Console.WriteLine("Por favor selecione uma das opções:");
                Console.WriteLine("1 - Cadastrar Veículo");
                Console.WriteLine("2 - Remover Veículo");
                Console.WriteLine("3 - Listar Veículos");
                Console.WriteLine("4 - Encerrar\n");

                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Cadastrar Veículo");
                        VehicleAdd();
                        break;

                    case "2":
                        Console.WriteLine("Remover Veículo");
                        VehicleRemove();
                        break;

                    case "3":
                        Console.WriteLine("Listar Veículos");
                        VehicleList();
                        break;

                    case "4":
                        Console.WriteLine("Obrigado por usar nosso sistema!");
                        viewMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
            }
        }
    }
    
}

