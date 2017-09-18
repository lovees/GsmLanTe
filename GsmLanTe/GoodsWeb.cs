using Mysqlcon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GsmLanTe
{
    public partial class GoodsWeb : Form
    {
        public GoodsWeb()
        {
            InitializeComponent();
        }
        private GoodsService service = new GoodsService();
        
        private void GoodsWeb_Load(object sender, EventArgs e)
        {
          var ds = service.GetGoodsAll();
            WebGoods.DataSource = ds.Tables[0];
            WebGoods.Columns[0].HeaderCell.Value = "ID";
            WebGoods.Columns[1].HeaderCell.Value = "编号";
            WebGoods.Columns[2].HeaderCell.Value = "商品名称";
            WebGoods.Columns[3].HeaderCell.Value = "库存";
            WebGoods.Columns[4].HeaderCell.Value = "店存";
            WebGoods.Columns[5].HeaderCell.Value = "单价";
            WebGoods.Columns[6].HeaderCell.Value = "VIP价";
            WebGoods.Columns[7].HeaderCell.Value = "批发价";
            WebGoods.Columns[8].HeaderCell.Value = "图片";
            WebGoods.Columns[0].ReadOnly = true;
            WebGoods.Columns[1].ReadOnly = true;
            WebGoods.Columns[2].ReadOnly = true;
            WebGoods.Columns[0].Width = 39;
            WebGoods.Columns[1].Width = 85;
            WebGoods.Columns[2].Width = 225;
            WebGoods.Columns[3].Width = 55;
            WebGoods.Columns[4].Width = 55;
            WebGoods.Columns[5].Width = 55;
            WebGoods.Columns[6].Width = 60;
            WebGoods.Columns[7].Width = 65;
            //int index = dataGridView1.CurrentRow.Index;
            //this.dataGridView1.Rows[index].Cells[7].Value = "http://www.gsmsofia.com/" + dataGridView1.Rows[index].Cells[7].Value.ToString();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reseta_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear(); //清除表数据
            DataTable dt = (DataTable)WebGoods.DataSource;
            dt.Rows.Clear();
            WebGoods.DataSource = dt;
            textsn.Text = "";
            textname.Text = "";
            textnum.Text = "";
            texttien.Text = "";
            textpreci.Text = "";
            textvip.Text = "";
            if (pictureBox1.Image != null)
            {
                //有图片
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
            else
            {
                //无图片
            }
            var ds = service.GetGoodsAll();
            WebGoods.DataSource = ds.Tables[0];
        }

        private void searc_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear(); //清除表数据
            DataTable dt = (DataTable)WebGoods.DataSource;
            dt.Rows.Clear();
            WebGoods.DataSource = dt;
            textsn.Text = "";
            textname.Text = "";
            textnum.Text = "";
            texttien.Text = "";
            textpreci.Text = "";
            textvip.Text = "";
            if (pictureBox1.Image != null)
            {
                //有图片
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
            else
            {
                //无图片
            }
            //var ds = service.Getsearch();
            //dataGridView1.DataSource = ds.Tables[0];
        }

        private void WebGoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = WebGoods.CurrentRow.Index;   // i表示选中行的行号（如选中第3行，则 i =2）
            textsn.Text = WebGoods.Rows[i].Cells[1].Value.ToString();  //选中行的第2列放入文本框中
            textname.Text = WebGoods.Rows[i].Cells[2].Value.ToString();  //选中行的第3列放入文本框中
            textnum.Text = WebGoods.Rows[i].Cells[3].Value.ToString();  //选中行的第4列放入文本框中
            texttien.Text = WebGoods.Rows[i].Cells[4].Value.ToString();  //选中行的第5列放入文本框中
            textpreci.Text = WebGoods.Rows[i].Cells[5].Value.ToString();  //选中行的第6列放入文本框中
            textvip.Text = WebGoods.Rows[i].Cells[6].Value.ToString();  //选中行的第7列放入文本框中
            pictureBox1.ImageLocation = "http://www.gsmsofia.com/" + WebGoods.Rows[i].Cells[8].Value.ToString();  //选中行的第8列放入图片框中
        }

        

    }
}
