using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;

namespace LINQtoSQL
{
    [Table(Name = "iPhones")]
    public class iPhone
    {
        private string _name;
        [Column(Storage = "_name")]
        public string name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        private string _release;
        [Column(Storage = "_release")]
        public string release
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
                (@"C:\LINQtoSQLdata\Apple.mdf");
            Table<iPhone> iPhones = db.GetTable<iPhone>();

            db.Log = Console.Out;
            IQueryable<iPhone> ShowiPhones =
                from phone in iPhones
                where phone.processor == "A14 Bionic"
                select phone;

            foreach (iPhone phone in ShowiPhones)
            {
                Console.WriteLine(phone.name, phone.release, phone.processor);
            }
            Console.ReadLine();

        }
    }
}

