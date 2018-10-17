using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // the best way to describe an abstract class is that it sits between a full base class, and an interface

            DataAccess da = new SqliteDataAccess();

            // we can change IDataAccess to DataAccess

            List<DataAccess> databases = new List<DataAccess>()
            {
                new sqlDataAccess(),
                new SqliteDataAccess()
            };

            foreach (var db in databases)
            {
                Console.WriteLine(db.LoadConnectionString("demo"));
                //db.LoadConnectionString("demo");
                db.LoadData("select * from table");
                db.SaveData("insert into table");
                Console.WriteLine();
            }

            Console.ReadLine();

            // the caveat is that inheritance can be messy, a car a good example, meaning trucks are not truely related to cars and their types.
            // if we need shared unrelated code, consider a helper class that everything can access
        }
    }
}
