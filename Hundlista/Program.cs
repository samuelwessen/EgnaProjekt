using Hundlista.models;
using System;
using System.Collections.Generic;

namespace Hundlista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hund> hundLista = new List<Hund>();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("[1] Lägg till en ny Hund" +
                    "\n[2] Visa alla hundar" +
                    "\n[3] Avsluta programmet");
                Int32.TryParse(Console.ReadLine(), out int menyval);
                switch (menyval)
                {
                    case 1:
                        Console.WriteLine("Var god skriv hundens namn:");
                        string namn = Console.ReadLine();
                        Console.WriteLine("Var god skriv vilken hundras den har:");
                        string hundras = Console.ReadLine();
                        Console.WriteLine("Var god skriv hur gammal den är:");
                        Int32.TryParse(Console.ReadLine(), out int ålder);
                        Console.WriteLine("Tack! Hunden är sparad i hundlistan!");
                        Hund nyHund = new Hund(namn, hundras, ålder);
                        hundLista.Add(nyHund);
                        break;
                    case 2:
                        foreach (Hund vovve in hundLista)
                        {
                            Console.WriteLine(vovve.Namn + " -" + vovve.Hundras + " (" + vovve.Ålder + " år)");
                        }
                            break;

                    case 3:
                        isRunning = false;
                        break;                    
                    default:
                        break;
                    



                }
               


            }
        }
            

        
    }
}
