using EF_poc.data;
using System;
using System.Configuration;

namespace EF_poc
{
    class Program
    {
        static void Main(string[] args)
        {
            BimModelRepository repository = new BimModelSqlRepository();
            repository.Add(null);
            repository.FindAll();
        }
    }
}
