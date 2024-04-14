using ClassLibrary.Data;
using System.Runtime.CompilerServices;
using System.Security.Principal;

class Program { 

    static void Main(string[] args) {

        int qty = 0;
        /*if (args.Length != 2)
        {
            Console.WriteLine("Hiba a bemeneti paramétrekben! " +
                "Add meg őket helyesen, elsőként a Kölcsönzőkhöz tartozó csv pontos elérési útját, másodszor pedig a Kölcsönzések csv fájl elérési útját!");
            System.Environment.Exit(0);
        }
        else
        {
            if (!File.Exists(args[0]) || !File.Exists(args[1]))
            {
                Console.WriteLine("A megadott elérési utak nem mindegyike érvényes, kérlek eszerint add meg őket: " +
                    "elsőként a Kölcsönzőkhöz tartozó csv pontos elérési útját add meg, másodszor pedig a Kölcsönzések csv fájlét!");
                System.Environment.Exit(0);
            }
            
        }*/
        LibraryContext db = new LibraryContext();

        if (!db.Kolcsonzo.Any())
        {
            var sorok = File.ReadAllLines(@args[0]).Skip(1);
            foreach (var sor in sorok)
            {
                db.Kolcsonzo.Add(new ClassLibrary.Model.Kolcsonzo(sor));
                qty++;
            }
            db.SaveChanges();
            Console.WriteLine("Importálás kész! Beimportált sorok száma: " + qty);
            qty = 0;
        }

        if (!db.Kolcsonzes.Any())
        {
            var sorok = File.ReadAllLines(@args[1]).Skip(1);
            foreach (var sor in sorok)
            {
                db.Kolcsonzes.Add(new ClassLibrary.Model.Kolcsonzes(sor));
                qty++;
            }
            db.SaveChanges();
            Console.WriteLine("Importálás kész! Beimportált sorok száma: " + qty);
        }
        
    }

}