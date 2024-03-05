namespace Vokabeltrainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> keyGerman = new Dictionary<int, string>();
            keyGerman.Add(1, "kostenlos, gratis");
            keyGerman.Add(2, "ein Musiker/eine Musikerin");
            keyGerman.Add(3, "Amateur-, Hobby-");
            keyGerman.Add(4, "fahren");
            keyGerman.Add(5, "aussergewöhnlich");
            keyGerman.Add(6, "ausnahmsweise");
            keyGerman.Add(7, "neu sein");
            keyGerman.Add(8, "nur, erst");
            keyGerman.Add(9, "schlecht");
            keyGerman.Add(10, "glücklich");
            keyGerman.Add(11, "glücklicherweise");
            keyGerman.Add(12, "zu Ende gehen, enden");
            keyGerman.Add(13, "gut/schlecht ausgehen");
            keyGerman.Add(14, "eine Probe, eine Wiederholung");
            keyGerman.Add(15, "immer noch nicht");
            keyGerman.Add(16, "normal");
            keyGerman.Add(17, "normalerweise");
            keyGerman.Add(18, "fünf Minuten Verspätung haben");
            keyGerman.Add(19, "komplett/vollständig");
            keyGerman.Add(20, "völlig");
            keyGerman.Add(21, "jdm./etw. glaube");
            keyGerman.Add(22, "wirklich");
            keyGerman.Add(23, "die Diva spielen");
            keyGerman.Add(24, "auftauchen");

            Dictionary<int, string> germanFrench = new Dictionary<int, string>();
            germanFrench.Add(1, "gratuit/gratuite");
            germanFrench.Add(2, "un musicien/une musicienne");
            germanFrench.Add(3, "amateur");
            germanFrench.Add(4, "rouler");
            germanFrench.Add(5, "exceptionnel/exceptionnelle");
            germanFrench.Add(6, "exceptionellement");
            germanFrench.Add(7, "être récent/récente");
            germanFrench.Add(8, "seulement");
            germanFrench.Add(9, "mal");
            germanFrench.Add(10, "heureux/heureuse");
            germanFrench.Add(11, "heureusement");
            germanFrench.Add(12, "se terminer");
            germanFrench.Add(13, "se terminer bien/mal");
            germanFrench.Add(14, "une répétition");
            germanFrench.Add(15, "ne...toujours pas");
            germanFrench.Add(16, "normal/normale");
            germanFrench.Add(17, "normalement");
            germanFrench.Add(18, "avoir cinq minutes de retard");
            germanFrench.Add(19, "complet/complète");
            germanFrench.Add(20, "complètement");
            germanFrench.Add(21, "croire qn/qc");
            germanFrench.Add(22, "vraiment");
            germanFrench.Add(23, "faire sa diva");
            germanFrench.Add(24, "rappliquer");

            do
            {
                Random dice = new Random();
                int number = dice.Next(1, 25);

                Console.Write(keyGerman[number] + " = ");

                string eingabe = Console.ReadLine();

                if (eingabe == germanFrench[number])
                {
                    Console.WriteLine("Richtig!");
                }
                else
                {
                    Console.WriteLine("Falsch!");
                }
                Console.ReadLine();
            }while(true);
        }
    }
}