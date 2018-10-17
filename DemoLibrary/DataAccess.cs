using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public abstract class DataAccess
    {
        // lets make this an optional method that can be overrided by adding the virtual keyword
        public virtual string LoadConnectionString(string name)
        {
            Console.WriteLine("Load connection string");
            return "testConnectionString";
        }

        // now this is where these classes share a commonality with Interfaces
        public abstract void LoadData(string sql);

        public abstract void SaveData(string sql);
    }
}
