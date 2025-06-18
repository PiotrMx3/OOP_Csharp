namespace OOP_Csharp
{
    internal class Program
    {
        enum Weekdagen { Maandag, Dinsdag, Woensdag, Donderdag, Vrijdag, Zaterdag, Zondag };

        static void Main(string[] args)
        {
            /*
           ATTRIBUTEN


            text from hier



           */








            /*
             DATE TIME 

            DateTimeOefeningen.CurrentTime();
            DateTimeOefeningen.CreateTime();
            DateTimeOefeningen.AddTime();
            DateTimeOefeningen.ReadTime();
            DateTimeOefeningen.FormattedTime();
            DateTimeOefeningen.ParsedTime();
            DateTimeOefeningen.DiffTime();



            Weekdagen dagKeuze;
            Weekdagen andereKeuze;

            dagKeuze = Weekdagen.Donderdag;

            Console.WriteLine(dagKeuze);


            Weekdagen keuze;
            Console.WriteLine("Welke dag is het vandaag?");
            Console.WriteLine($"{(int)Weekdagen.Maandag}. {Weekdagen.Maandag}");
            Console.WriteLine($"{(int)Weekdagen.Dinsdag}. {Weekdagen.Dinsdag}");

            keuze = (Weekdagen)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(keuze);
             
             
          */
        }
    }
}
