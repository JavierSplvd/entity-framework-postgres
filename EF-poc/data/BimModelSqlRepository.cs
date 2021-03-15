using System;
using System.Collections.Generic;
using System.Linq;

namespace EF_poc.data
{
    public class BimModelSqlRepository : BimModelRepository
    {
        private DBContext dataContext = new DBContext();
        public void Add(BimModel model)
        {
            Console.WriteLine("Add");
            BimModel temp = new BimModel("id", "001", "name", "discipline", "description", "bim_parameters");
            dataContext.BimModel.Add(temp);
            dataContext.SaveChanges();
        }

        public List<BimModel> FindAll()
        {
            var result = dataContext.BimModel.ToList();
            Console.WriteLine(result.Count);
            return result;
        }
    }
}
