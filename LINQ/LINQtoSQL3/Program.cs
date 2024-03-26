using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;

namespace LINQtoSQL
{
    [Table(Name = "iPhone")]
    public class iPhone
    {
        private int _id;
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Storage = "_id")]
        public int iphone_id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        private string _name;
        [Column(Storage = "_name")]
        public string name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        private DateTime _release;
        [Column(Storage = "_release")]
        public DateTime release
        {
            get { return this._release; }
            set { this._release = value; }
        }

        private string _processor;
        [Column(Storage = "_processor")]
        public string processor
        {
            get { return this._processor; }
            set { this._processor = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DataContext db = new DataContext
                (@"Data Source=.\MYSQLSERVER;AttachDbFilename=""C:\Program Files\Microsoft SQL Server\MSSQL15.MYSQLSERVER\MSSQL\DATA\Apple.mdf"";Integrated Security=True;Connect Timeout=30;User Instance=False;Context Connection=False");
            Table<iPhone> iPhone = db.GetTable<iPhone>();

            IQueryable<iPhone> ShowiPhones =
                from phone in iPhone
                orderby phone.release
                select phone;

            string phoneNameToEdit = null;
            bool shuttdown = false;

            var showiPhoneToEdit =
                    from p in iPhone
                    where p.name == phoneNameToEdit
                    select p;
            do
            {
                Console.WriteLine("Was möchten Sie tun?");
                Console.WriteLine("(1) Hinzufügen");
                Console.WriteLine("(2) Verändern");
                Console.WriteLine("(3) Löschen");
                Console.WriteLine("(4) Alle Anzeigen");
                Console.WriteLine("(5) Programm beenden");

                ConsoleKeyInfo key = Console.ReadKey(true);
                string input = Convert.ToString(key.KeyChar);

                Console.Clear();

                if (input == "1")
                {
                    iPhone newPhone = new iPhone();
                    Console.WriteLine("Wie soll das neue iPhone heissen?");
                    newPhone.name = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("Wann soll das neue iPhone auf den Markt kommen? (day-month-year)");
                    newPhone.release = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("Welcher Prozessor besitzt das neue iPhone?");
                    newPhone.processor = Console.ReadLine();

                    db.GetTable<iPhone>().InsertOnSubmit(newPhone);
                }
                if (input == "2")
                {
                    Console.WriteLine("Welches iPhone möchten Sie bearbeiten?");
                    phoneNameToEdit = Console.ReadLine();
                    Console.Clear();

                    foreach (iPhone phone in showiPhoneToEdit)
                    {
                        Console.WriteLine(phone.iphone_id);
                        Console.WriteLine(phone.name);
                        Console.WriteLine(phone.release);
                        Console.WriteLine(phone.processor);
                        Console.WriteLine("");
                    }

                    Console.WriteLine("Was möchten Sie verändern?");
                    Console.WriteLine("(1) Name");
                    Console.WriteLine("(2) Release");
                    Console.WriteLine("(3) Processor");

                    ConsoleKeyInfo keyChange = Console.ReadKey(true);
                    string inputChange = Convert.ToString(keyChange.KeyChar);

                    Console.Clear();

                    var existingiPhone =
                    (from p in db.GetTable<iPhone>()
                     where p.name == phoneNameToEdit
                     select p)
                    .First();

                    switch (inputChange)
                    {
                        case "1":
                            {
                                Console.WriteLine("Welchen Namen hat das iPhone nun?");
                                existingiPhone.name = Console.ReadLine();
                                break;
                            }
                        case "2":
                            {
                                Console.WriteLine("Welchen Release hat das iPhone nun?");
                                existingiPhone.release = Convert.ToDateTime(Console.ReadLine());
                                break;
                            }
                        case "3":
                            {
                                Console.WriteLine("Welchen Prozessor beitzt das iPhone nun?");
                                existingiPhone.processor = Console.ReadLine();
                                break;
                            }
                    }
                    Console.WriteLine("");
                    foreach (iPhone phone in showiPhoneToEdit)
                    {
                        Console.WriteLine(phone.name);
                        Console.WriteLine(phone.release);
                        Console.WriteLine(phone.processor);
                        Console.WriteLine("");
                    }
                }
                if (input == "3")
                {
                    string phoneNameToDelete = null;

                    var deleteiPhone =
                        from p in db.GetTable<iPhone>()
                        where p.name == phoneNameToDelete
                        select p;

                    Console.WriteLine("Welches iPhone möchtest du löschen?");
                    phoneNameToDelete = Console.ReadLine();

                    foreach (iPhone phone in deleteiPhone)
                    {
                        db.GetTable<iPhone>().DeleteOnSubmit(phone);
                    }
                }
                if (input == "4")
                {
                    foreach (iPhone phone in ShowiPhones)
                    {
                        Console.WriteLine(phone.name);
                        Console.WriteLine(phone.release);
                        Console.WriteLine(phone.processor);
                        Console.WriteLine("");
                    }
                }
                if (input == "5")
                {
                    shuttdown = true;
                }
                if (input == "1"||input == "2"||input == "3"||input == "4")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Drücken Sie [enter]");
                    Console.ReadLine();
                    Console.Clear();
                    db.SubmitChanges();
                }
            }while(shuttdown == false);
        }
    }
}