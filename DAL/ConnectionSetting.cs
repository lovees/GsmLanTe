using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace DAL
{
    public class ConnectionSetting
    {
        //具体配置在App.config里
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["MySqlConStr"].ConnectionString;
    }
    public class SQLiteConSetting
    {
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["SqliteConStr"].ConnectionString;
        //conn.SetPassword("123456");//数据库密码   
    }
}