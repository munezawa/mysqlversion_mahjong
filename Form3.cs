using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mysqlversion_mahjong
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            ColumnHeader ch = new ColumnHeader();

            ch.Text = "序号";   //设置列标题

            ch.Width = 120;    //设置列宽度

            ch.TextAlign = HorizontalAlignment.Left;   //设置列的对齐方式

            this.listView1.Columns.Add(ch);    //将列头添加到ListView控件。
            this.listView1.Columns.Add("主要", 120, HorizontalAlignment.Left); //一步添加
            this.listView1.Columns.Add("次要", 120, HorizontalAlignment.Left); //一步添加
            this.listView1.Columns.Add("大小", 120, HorizontalAlignment.Left); //一步添加
            this.listView1.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度

            string connStr = "server=localhost;user=root;database=test;port=3306;password=2333";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                // Perform database operations
            }
            catch (Exception ex)
            {
            }
            MySqlCommand cmd = new MySqlCommand("select * from 记录", conn);
            //执行语句
            MySqlDataReader msqlReader = cmd.ExecuteReader();
            while (msqlReader.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = msqlReader.GetInt32("序号").ToString();
                lvi.SubItems.Add(msqlReader.GetString("主要"));
                lvi.SubItems.Add(msqlReader.GetString("次要"));
                lvi.SubItems.Add(msqlReader.GetString("大小"));
                this.listView1.Items.Add(lvi);

            }

            this.listView1.EndUpdate();  //结束数据处理，UI界面一次性绘制。
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        static bool Mahjong_GetSqlCmd(string CmdStr)
        {
            string connStr = "server=localhost;user=root;database=test;port=3306;password=2333";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                // Perform database operations
            }
            catch (Exception ex)
            {
            }
            MySqlCommand cmd = new MySqlCommand(CmdStr, conn);
            //执行语句
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }
    }
}
