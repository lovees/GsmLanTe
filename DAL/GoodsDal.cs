using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class GoodsDal
    {
        public DataSet GetGoodsAll()
        {
            //string sql = "SELECT * FROM `gsm_goods` ORDER BY `gsm_goods`.`goods_name` ASC, `gsm_goods`.`goods_sn` ASC";
            string sql = "SELECT gsm_goods.goods_id, gsm_goods.goods_sn, gsm_goods.goods_name, gsm_goods.goods_number, gsm_goods.tienda_number, gsm_goods.shop_price, gsm_member_price.user_price, gsm_goods.goods_img FROM `gsm_goods`,`gsm_member_price` order by gsm_goods.goods_id asc";
            //string sql = "SELECT gsm_goods.goods_id, gsm_goods.goods_sn, gsm_goods.goods_name, gsm_goods.goods_number, gsm_goods.tienda_number, gsm_goods.shop_price, gsm_member_price.user_price, gsm_goods.goods_img FROM `gsm_goods`,`gsm_member_price` WHERE gsm_goods.goods_id=gsm_member_price.goods_id order by gsm_goods.goods_id asc LIMIT 24";
            //string sql = "SELECT * FROM `gsm_category` ORDER BY `gsm_category`.`cat_id` ASC";
            return MySqlHelper.ExecuteDataset(ConnectionSetting.ConnectionString, sql);
        }
        //public DataSet Getlogin()
        //{
        //string sql = "SELECT * FROM `gsm_goods` ORDER BY `gsm_goods`.`goods_name` ASC, `gsm_goods`.`goods_sn` ASC";
        //string sql = "SELECT gsm_goods.goods_id, gsm_goods.goods_sn, gsm_goods.goods_name, gsm_goods.goods_number, gsm_goods.tienda_number, gsm_goods.shop_price, gsm_member_price.user_price, gsm_goods.goods_img FROM `gsm_goods`,`gsm_member_price` WHERE gsm_goods.goods_id=gsm_member_price.goods_id order by gsm_goods.goods_id asc LIMIT 20";
        //string sql = "select * from person where 用户名 = '" + textBox1.Text + "' and  密码= '" + textBox2.Text + "'";
        // return MySqlHelper.ExecuteDataset(ConnectionSetting.ConnectionString, sql);
        //}
        // public DataSet Getsearch()
        //{
        //string sql = "SELECT gsm_goods.goods_id, gsm_goods.goods_sn, gsm_goods.goods_name, gsm_goods.goods_number, gsm_goods.tienda_number, gsm_goods.shop_price, gsm_member_price.user_price, gsm_goods.goods_img FROM `gsm_goods`where `goods_name`like  '%" + Form1.sechs.Text + "'%";
        // return MySqlHelper.ExecuteDataset(ConnectionSetting.ConnectionString, sql);
        //}
    }
}