namespace OOP_Csharp
{
    internal class Program
    {
        enum Weekdagen { Maandag, Dinsdag, Woensdag, Donderdag, Vrijdag, Zaterdag, Zondag };

        static void Main(string[] args)
        {

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



            Console.Write(
                "Welcome in my Car genrator app Lets start !\n" 
                + "How many car's you want to create ?: "
                );

            int amount = Convert.ToInt32(Console.ReadLine());

            Auto[] carsArray = new Auto[amount];
            Auto.Huidigenorm = MilieuNormen.Euro6;

            for (int i = 0; i < amount; i++)
            {
                Auto newCar = new Auto();

                Console.Write($"Auto - {i + 1} Wat is de kilometer stand ?: ");
                newCar.KilometerStand = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Auto - {i + 1} Wat is de benzinde stand ?: ");
                newCar.Benzine = Convert.ToInt32(Console.ReadLine());


                Console.Write($"Auto - {i + 1} Wat is de datum van laatsteonderhoud (JJJ/M/D) ?: ");
                newCar.LaatsteOnderhoud = DateTime.Parse(Console.ReadLine());


                carsArray[i] = newCar;

            }


            for (int i = 0; i < carsArray.Length; i++)
            {
                Auto.PrintOnderhoudsrapport(carsArray[i], i);
            }







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
    }
}
