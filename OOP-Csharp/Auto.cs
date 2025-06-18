using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Csharp
{

 enum MilieuNormen {Euro3, Euro4, Euro5, Euro6};

internal class Auto
    {
        public int KilometerStand = 5;
        public int Benzine = 10;
        public DateTime LaatsteOnderhoud = DateTime.Now;
        public static MilieuNormen Huidigenorm;


        public static void PrintOnderhoudsrapport(Auto auto, int i)
        {
            TimeSpan service = DateTime.Today - auto.LaatsteOnderhoud;


              Console.WriteLine($"Gegevens Auto nr {i + 1}:\n" +
                   $"Kilometerstand: {auto.KilometerStand} km\n" +
                   $"Benzine: {auto.Benzine} L\n" +
                   $"Laatste onderhoud: {auto.LaatsteOnderhoud:d}\n" +
                   $"Milieunorm: {Huidigenorm}\n");

            if (service.Days > 180)
            {
                Console.WriteLine($"Auto nr {i + 1} heeft nood aan onderhoudsbeurt!");
                Console.WriteLine($"Dagen sinds laatste onderhoud: {service.Days}");

            }
        }

    }


}
