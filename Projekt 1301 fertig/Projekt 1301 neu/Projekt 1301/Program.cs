namespace Projekt_1301
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            Person newPerson;
            newPerson = new Person("Paul Müller", 33, new DateTime(1990, 2, 11), "paul.mueller@beispiel1.com", "076 440 56 84", "Zürich");
            list.Add(newPerson);
            newPerson = new Person("Sarah Helger", 30, new DateTime(1993, 4, 25), "sarah.helger@beispiel2.com", "079 256 82 03", "Aarau");
            list.Add(newPerson);
            newPerson = new Person("Max Kaufmann", 29, new DateTime(1994, 6, 8), "max.kaufmann@beispiel3.com", "078 625 07 98", "Bern");
            list.Add(newPerson);
            newPerson = new Person("Heinrich Ackermann", 28, new DateTime(1995, 8, 24), "heinrich.ackermann@beispiel4.com", "076 339 52 91", "Basel");
            list.Add(newPerson);
            newPerson = new Person("Melanie Gerber", 26, new DateTime(1997, 10, 20), "melanie.gerber@beispiel5.com", "079 124 61 35", "Genf");
            list.Add(newPerson);
            newPerson = new Person("Elena Bender", 24, new DateTime(1998, 12, 14), "elena.bender@beispiel6.com", "078 884 06 63", "Lugano");
            list.Add(newPerson);


            while (true)
            {
                
                Console.WriteLine("Hallo, Wählen Sie 1-6 für aufrufen einzelne Kontaktdaten, 7 für alle Kontaktdaten, 8 zum Beenden von Programm.");
                int zahl;

                while (!int.TryParse(Console.ReadLine(), out zahl) || (zahl != 1 && zahl != 2 && zahl != 3 && zahl != 4 && zahl != 5 && zahl != 6 && zahl != 7 && zahl != 8))
                {
                    Console.WriteLine("Bitte wählen Sie eine Nummer von 1-8. Wählen Sie 1-6 für aufrufen einzelne Kontaktdaten, 7 für alle Kontaktdaten, 8 zum Beenden von Programm.");
                }
                

                Console.Clear();

                switch (zahl)
                {
                    case 1:
                        Console.WriteLine(list[0].PersonalData);
                        break;
                    case 2:
                        Console.WriteLine(list[1].PersonalData);
                        break;
                    case 3:
                        Console.WriteLine(list[2].PersonalData);
                        break;
                    case 4:
                        Console.WriteLine(list[3].PersonalData);
                        break;
                    case 5:
                        Console.WriteLine(list[4].PersonalData);
                        break;
                    case 6:
                        Console.WriteLine(list[5].PersonalData);
                        break;
                    case 7:
                        Console.WriteLine($"{list[0].PersonalData}\n {list[1].PersonalData}\n {list[2].PersonalData}\n {list[3].PersonalData}\n {list[4].PersonalData}\n {list[5].PersonalData}");
                        break;
                    case 8:
                        Console.WriteLine("Danke für die Benutzung. Auf Wiedersehen!");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Es gibt keine Kontaktdaten unter dieser Nummer");
                        break;
                }
            }
        }
    }
}
