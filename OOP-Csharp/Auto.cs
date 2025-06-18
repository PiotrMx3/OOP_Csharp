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
        public double Benzine = 10;
        public DateTime LaatsteOnderhoud = DateTime.Now;
        public static MilieuNormen Huidigenorm;



        public static void VerklaarNorm(MilieuNormen norm)
        {
            int jaar;
            double co2;

            switch (norm)
            {
                case MilieuNormen.Euro3:
                    jaar = 1992;
                    co2 = 1.0;
                    break;
                case MilieuNormen.Euro4:
                    jaar = 1996;
                    co2 = 1.0;
                    break;
                case MilieuNormen.Euro5:
                    jaar = 2000;
                    co2 = 0.64;
                    break;
                case MilieuNormen.Euro6:
                    jaar = 2020;
                    co2 = 0.15;
                    break;
                default:
                    jaar = -1;
                    co2 = -1;
                    break;
            }

            Console.WriteLine($"Huidige norm is: {norm}.");
            Console.WriteLine($"Geintroduceerd in {jaar} jaar.");
            Console.WriteLine($"{co2} gram CO per km.");


        }




        public double Verkoopsprijs()
        {
            double prijs = 10000.0;

            prijs -= this.KilometerStand * 0.10;

            if (this.Benzine > 40) prijs += 200;

            if (prijs < 1000) prijs = 1000;

            return prijs;
        }

        public void Onderhouden()
        {
            Console.WriteLine($"Laatste onderhoud vond plaats op {this.LaatsteOnderhoud:d}");
            this.LaatsteOnderhoud = DateTime.Now;
            Console.WriteLine($"Auto is goedgekeurd op {this.LaatsteOnderhoud:d}");
        }



        public void Voltanken()
        {

            double maxBrandstof = 50.0;
            Console.WriteLine($"Auto wordt getankt aantal liters in de tank: {this.Benzine:F1} L");

            double diffrrence = maxBrandstof - this.Benzine; 
            this.Benzine = maxBrandstof;
            Console.WriteLine($"Auto is vol getankt aantal getankt liters: {diffrrence:F1} L total inhoud van tank {maxBrandstof:F1} L");
        }

        public void Rijden(int aantalKm)
        {
            this.KilometerStand += aantalKm;
            this.Benzine -= 5.0 * (aantalKm / 100.0);
        }


        public static void PrintOnderhoudsrapport(Auto auto, int i)
        {
            TimeSpan aantalDagenOnderhoud = DateTime.Today - auto.LaatsteOnderhoud;


              Console.WriteLine($"Gegevens Auto nr {i + 1}:\n" +
                   $"Kilometerstand: {auto.KilometerStand} km\n" +
                   $"Benzine: {auto.Benzine:F1} L\n" +
                   $"Laatste onderhoud: {auto.LaatsteOnderhoud:d}\n" +
                   $"Milieunorm: {Huidigenorm}\n");

            if (aantalDagenOnderhoud.Days > 180)
            {
                Console.WriteLine($"Auto nr {i + 1} heeft nood aan onderhoudsbeurt!");
                Console.WriteLine($"Dagen sinds laatste onderhoud: {aantalDagenOnderhoud.Days}");

            }
        }

    }


}
