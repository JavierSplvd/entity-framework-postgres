using EF_poc.data;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_poc
{
    interface BimModelRepository
    {
        List<BimModel> FindAll();
        void Add(BimModel model);
    }
}
