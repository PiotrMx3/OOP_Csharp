namespace OOP_Csharp
{
    internal class Program
    {
        enum Weekdagen { Maandag, Dinsdag, Woensdag, Donderdag, Vrijdag, Zaterdag, Zondag };

        static void Main(string[] args)
        {


            /*

             Methoden

            */


            DemonstreerGedrag();


            //Console.Write(
            //    "Welcome in my Car genrator app Lets start !\n"
            //    + "How many car's you want to create ?: "
            //    );

            //int amount = Convert.ToInt32(Console.ReadLine());

            //Auto[] autos = new Auto[amount];
            //Auto.Huidigenorm = MilieuNormen.Euro6;

            //for (int i = 0; i < amount; i++)
            //{
            //    Auto nieuwAuto = new Auto();

            //    Console.Write($"Auto - {i + 1} Wat is de kilometer stand ?: ");
            //    nieuwAuto.KilometerStand = Convert.ToInt32(Console.ReadLine());

            //    Console.Write($"Auto - {i + 1} Wat is de benzinde stand ?: ");
            //    nieuwAuto.Benzine = Convert.ToInt32(Console.ReadLine());


            //    Console.Write($"Auto - {i + 1} Wat is de datum van laatsteonderhoud (JJJ/M/D) ?: ");
            //    nieuwAuto.LaatsteOnderhoud = DateTime.Parse(Console.ReadLine());


            //    autos[i] = nieuwAuto;

            //}


            //autos[0].Rijden(50);
            //autos[0].Rijden(5);
            //autos[0].Rijden(45);



            //for (int i = 0; i < autos.Length; i++)
            //{
            //    Auto.PrintOnderhoudsrapport(autos[i], i);
            //}

            //autos[0].Voltanken();

            //autos[0].Onderhouden();











            /*

            ATTRIBUTEN

            */

            //Auto nieuweAuto1 = new Auto();
            //Auto nieuweAuto2 = new Auto();

            //nieuweAuto1.KilometerStand = 100;
            //nieuweAuto1.Benzine = 50;
            //nieuweAuto1.LaatsteOnderhoud = DateTime.Now;

            //nieuweAuto2.LaatsteOnderhoud = new DateTime(2024, 1, 11, 20, 00, 00);

            //Console.WriteLine($"Kilometerstand: {nieuweAuto1.KilometerStand}");
            //Console.WriteLine($"Benzine: {nieuweAuto1.Benzine}");
            //Console.WriteLine($"Laatste onderhoud: {nieuweAuto1.LaatsteOnderhoud}");

            //Console.WriteLine();

            //Console.WriteLine($"Kilometerstand: {nieuweAuto2.KilometerStand}");
            //Console.WriteLine($"Benzine: {nieuweAuto2.Benzine}");
            //Console.WriteLine($"Laatste onderhoud: {nieuweAuto2.LaatsteOnderhoud}");



            //Console.Write(
            //    "Welcome in my Car genrator app Lets start !\n"
            //    + "How many car's you want to create ?: "
            //    );

            //int aantalAutos = Convert.ToInt32(Console.ReadLine());

            //Auto[] autos = new Auto[aantalAutos];
            //Auto.Huidigenorm = MilieuNormen.Euro6;

            //for (int i = 0; i < aantalAutos; i++)
            //{
            //    Auto nieuweAuto = new Auto();

            //    Console.Write($"Auto - {i + 1} Wat is de kilometer stand ?: ");
            //    nieuweAuto.KilometerStand = Convert.ToInt32(Console.ReadLine());

            //    Console.Write($"Auto - {i + 1} Wat is de benzinde stand ?: ");
            //    nieuweAuto.Benzine = Convert.ToInt32(Console.ReadLine());


            //    Console.Write($"Auto - {i + 1} Wat is de datum van laatsteonderhoud (JJJ/M/D) ?: ");
            //    nieuweAuto.LaatsteOnderhoud = DateTime.Parse(Console.ReadLine());


            //    autos[i] = nieuweAuto;

            //}


            //for (int i = 0; i < autos.Length; i++)
            //{
            //    Auto.PrintOnderhoudsrapport(autos[i], i);
            //}







            /*

            DATE TIME 

            */



            //DateTimeOefeningen.CurrentTime();
            //DateTimeOefeningen.CreateTime();
            //DateTimeOefeningen.AddTime();
            //DateTimeOefeningen.ReadTime();
            //DateTimeOefeningen.FormattedTime();
            //DateTimeOefeningen.ParsedTime();
            //DateTimeOefeningen.DiffTime();



            //Weekdagen dagKeuze;
            //Weekdagen andereKeuze;

            //dagKeuze = Weekdagen.Donderdag;

            //Console.WriteLine(dagKeuze);


            //Weekdagen keuze;
            //Console.WriteLine("Welke dag is het vandaag?");
            //Console.WriteLine($"{(int)Weekdagen.Maandag}. {Weekdagen.Maandag}");
            //Console.WriteLine($"{(int)Weekdagen.Dinsdag}. {Weekdagen.Dinsdag}");

            //keuze = (Weekdagen)Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(keuze);

        }


        public static void DemonstreerGedrag()
        {

            Auto auto1 = new Auto();
            Auto auto2 = new Auto();

            auto1.Voltanken();
            auto1.Rijden(10);
            auto1.Rijden(20);


            Auto.PrintOnderhoudsrapport(auto1, 1);
            Console.WriteLine($"Waarde van wagen is: {auto1.Verkoopsprijs():F2} Euro\n");

            Auto.PrintOnderhoudsrapport(auto2, 2);
            Console.WriteLine($"Waarde van wagen is: {auto2.Verkoopsprijs():F2} Euro\n");


            Auto.VerklaarNorm(MilieuNormen.Euro5);
        }

    }
}
