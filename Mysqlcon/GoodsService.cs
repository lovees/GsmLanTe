using DAL;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Mysqlcon
{
    public class GoodsService
    {
        GoodsDal dal = new GoodsDal();
        public DataSet GetGoodsAll()
        {
            return dal.GetGoodsAll();
        }
        // public DataSet Getsearch()
        //{
        //  return dal.Getsearch();
        //}
    }
}
