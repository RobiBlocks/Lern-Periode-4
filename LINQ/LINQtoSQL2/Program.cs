using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Xml.Linq;

namespace LINQtoSQL
{
    [Table(Name = "iPhone")]
    public class iPhone
    {
        private string _name;
        [Column(IsPrimaryKey = true, Storage = "_name")]
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

            db.Log = Console.Out;

            IQueryable<iPhone> ShowiPhones =
                from phone in iPhone
                orderby phone.release
                select phone;

            Console.Write("Was möchten Sie tun?");
            Console.Write("(1) Hinzufügen");
            Console.Write("(2) Verändern");
            Console.Write("(3) Löschen");

            int input = Convert.ToInt16(Console.ReadLine());

            if (input == 1)
            {
                iPhone newPhone = new iPhone();
                Console.WriteLine("Wie soll das neue iPhone heissen?");
                newPhone.name = Console.ReadLine();
                Console.WriteLine("Wann soll das neue iPhone auf den Markt kommen? (day-month-year)");
                newPhone.release = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Welcher Prozessor besitzt das neue iPhone?");
                newPhone.processor = Console.ReadLine();

                db.GetTable<iPhone>().InsertOnSubmit(newPhone);
            }

            if (input == 2)
            {
                Console.WriteLine("Welches iPhone möchtest du bearbeiten?");
                string phoneNameToEdit = Console.ReadLine();

                var existingiPhone =
                (from p in db.GetTable<iPhone>()
                 where p.name == phoneNameToEdit
                 select p)
                 .First();

                Console.WriteLine("Was möchten Sie verändern?");
                Console.WriteLine("(1)release");
                Console.WriteLine("(2)processor");

                int inputV = Convert.ToInt16(Console.ReadLine());
                
                if (inputV == 2)
                {
                    Console.WriteLine("Welchen Prozessor beitzt das iPhone nun?");
                    existingiPhone.processor = Console.ReadLine();
                }
            }

            foreach (iPhone phone in ShowiPhones)
            {
                Console.WriteLine(phone.name);
                Console.WriteLine(phone.release);
                Console.WriteLine(phone.processor);
                Console.WriteLine("");
            }
            db.SubmitChanges();
            Console.ReadLine();
        }
    }
}

