using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class sqlDataAccess : DataAccess
    {
        //public string LoadConnectionString(string name)
        //{
        //    Console.WriteLine("Load connection string");
        //    return "testConnectionString";
        //}

        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading MS SQL Data");
        }

        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving MS SQL Data to SQL server");
        }
    }
}
