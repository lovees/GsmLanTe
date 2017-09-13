using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAL
{
    public class ConnectionSetting
    {
        //具体配置在App.config里
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["MySqlConStr"].ConnectionString;
    }
}