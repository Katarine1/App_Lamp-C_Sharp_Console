using System;
using App1_Lamp.Model;

namespace App1_Lamp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("\t\tQuantity : ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("\n\t\tNumber " + (i + 1) + " :\n");
                Console.Write("\t\tEnter Lamp Status (On, Off, or Half-light): ");
                string status = Console.ReadLine();

                Lamp lamp = new Lamp(status);
                string adjustment = lamp.AdjustmentLamp();

                Console.WriteLine("\t\tLamp : " + status + "\n\t\t" + adjustment);
            }                
        }
    }
}
