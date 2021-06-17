using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace MahJong
{
    public partial class Form1 : Form
    {
        Form Form2;
        int Fafu;
        int flag1 = 0;
        int flag2 = 0;
        int flag3 = 0;
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        public void FaFu(int a)
        {
            string str1;
            if (checkBox1.Checked)
            {
                str1 = string.Format($"update 选手 set 点数 = 点数-1000 where 座次 = 1");
                Mahjong_GetSqlCmd(str1);
                str1 = string.Format($"update 比赛 set 点棒 = 点棒+1000");
                Mahjong_GetSqlCmd(str1);
            }
            if (checkBox2.Checked)
            {
                str1 = string.Format($"update 选手 set 点数 = 点数-1000 where 座次 = 2");
                Mahjong_GetSqlCmd(str1);
                str1 = string.Format($"update 比赛 set 点棒 = 点棒+1000");
                Mahjong_GetSqlCmd(str1);
            }
            if (checkBox3.Checked)
            {
                str1 = string.Format($"update 选手 set 点数 = 点数-1000 where 座次 = 3");
                Mahjong_GetSqlCmd(str1);
                str1 = string.Format($"update 比赛 set 点棒 = 点棒+1000");
                Mahjong_GetSqlCmd(str1);
            }
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
            MySqlCommand cmd = new MySqlCommand("select * from 比赛", conn);
            //执行语句
            MySqlDataReader msqlReader = cmd.ExecuteReader();
            msqlReader.Read();
            Fafu = msqlReader.GetInt32("点棒");
            conn.Close();
            switch (a)
            {
                case 0: break;
                case 4: label20.Text = "+0"; label21.Text = "+0"; label22.Text = "+0"; break;
                case 1: str1 = string.Format($"update 选手 set 点数 = 点数+'{Fafu}' where 座次 = 1"); Mahjong_GetSqlCmd(str1); str1 = string.Format($"update 比赛 set 点棒 = 0"); Mahjong_GetSqlCmd(str1); Fafu = 0; break;
                case 2: str1 = string.Format($"update 选手 set 点数 = 点数+'{Fafu}' where 座次 = 2"); Mahjong_GetSqlCmd(str1); str1 = string.Format($"update 比赛 set 点棒 = 0"); Mahjong_GetSqlCmd(str1); Fafu = 0; break;
                case 3: str1 = string.Format($"update 选手 set 点数= 点数+'{Fafu}' where 座次 = 3"); Mahjong_GetSqlCmd(str1); str1 = string.Format($"update 比赛 set 点棒 = 0"); Mahjong_GetSqlCmd(str1); Fafu = 0; break;
                default: MessageBox.Show("error"); break;
            }
        }
        public int SuDian()
        {

            int a = Convert.ToInt32(textBox1.Text);//符数
            int b = Convert.ToInt32(textBox2.Text);//番数
            int c = 0;//素点
            switch (b)
            {
                case 52: c = 32000; break;
                case 39: c = 24000; break;
                case 26: c = 16000; break;
                case 13: c = 6000; break;
                case 12: c = 6000; break;
                case 11: c = 6000; break;
                case 10: c = 4000; break;
                case 9: c = 4000; break;
                case 8: c = 4000; break;
                case 7: c = 3000; break;
                case 6: c = 3000; break;
                case 5: c = 2000; break;
                case 4: c = a * (int)Math.Pow(2, 2 + b); if (c > 2000) { c = 2000; } break;
                case 3: c = a * (int)Math.Pow(2, 2 + b); if (c > 2000) { c = 2000; } break;
                case 2: c = a * (int)Math.Pow(2, 2 + b); break;
                case 1: c = a * (int)Math.Pow(2, 2 + b); break;
            }
            return c;
        }
        public int BaiBei(double a)
        {
            int b = (int)a;
            if (b % 100 != 0)
            {
                b = b / 100 * 100 + 100;
            }
            return (int)b;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        public void Reload()
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

            MySqlCommand cmd = new MySqlCommand("select * from 选手", conn);
            //执行语句
            MySqlDataReader msqlReader = cmd.ExecuteReader();
            //执行语句
            msqlReader.Read();
            label10.Text = msqlReader.GetString("点数");
            label16.Text = msqlReader.GetString("胡牌次数");
            msqlReader.Read();
            label14.Text = msqlReader.GetString("点数");
            label17.Text = msqlReader.GetString("胡牌次数");
            msqlReader.Read();
            label15.Text = msqlReader.GetString("点数");
            label18.Text = msqlReader.GetString("胡牌次数");
            conn.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=test;port=3306;password=2333";
            MySqlConnection conn = new MySqlConnection(connStr); try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                // Perform database operations
            }
            catch (Exception ex)
            {
            }
            MySqlCommand cmd = new MySqlCommand("select * from 比赛", conn);
            //执行语句
            MySqlDataReader msqlReader = cmd.ExecuteReader();
            msqlReader.Read();
            this.label6.Text = ToRound(msqlReader.GetInt32("场次"));
            conn.Close();
        }
        public string ToRound(int a)
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
            string str1 = "error", str2 = "error";
            switch (a % 3)
            {
                case 1:
                    str1 = "一场";
                    break;
                case 2:
                    str1 = "二场";
                    break;
                case 0:
                    str1 = "三场";
                    break;
            }
            switch (((a - 1) % 9) / 3)
            {
                case 1:
                    str2 = "南风";
                    break;
                case 2:
                    str2 = "西风";
                    break;
                case 0:
                    str2 = "东风";
                    break;
            }
            return str2 + str1;
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
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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
            MySqlCommand cmd = new MySqlCommand("select * from 比赛", conn);
            //执行语句
            MySqlDataReader msqlReader = cmd.ExecuteReader();
            msqlReader.Read();
            int a = msqlReader.GetInt32("场次");
            int b = msqlReader.GetInt32("局数");
            string str1;
            switch (a % 3)
            {
                case 1:
                    if (radioButton37.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(3 * SuDian())}' where 座次 = 2");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(3 * SuDian())}' where 座次 = 3");
                        this.label21.Text = "-" + BaiBei(3 * SuDian());
                        this.label22.Text = "-" + BaiBei(3 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update test.选手 set 点数 = 点数+'{2 * BaiBei(3 * SuDian())}',胡牌次数 = 胡牌次数+1,胡牌次数=胡牌次数+1 where 座次=1");
                        this.label20.Text = "+" + 2 * BaiBei(3 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox3.Text}', 'NULL','{Convert.ToInt32(label20.Text)}')");
                        Mahjong_GetSqlCmd(str1);

                        FaFu(1);
                    }
                    else if (radioButton36.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(2.5 * SuDian())}' where 座次 = 1");
                        this.label20.Text = "-" + BaiBei(2.5 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(1.5 * SuDian())}'where 座次 = 3");
                        this.label22.Text = "-" + BaiBei(1.5 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+'{BaiBei(2.5 * SuDian()) + BaiBei(1.5 * SuDian())}',胡牌次数 = 胡牌次数+1  where 座次 = 2");
                        this.label21.Text = "+" + (BaiBei(2.5 * SuDian()) + BaiBei(1.5 * SuDian()));
                        Mahjong_GetSqlCmd(str1);
                        FaFu(2);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox4.Text}', 'NULL','{Convert.ToInt32(label21.Text)}')");
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton35.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(2.5 * SuDian())}' where 座次 = 1");
                        this.label20.Text = "-" + BaiBei(2.5 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(1.5 * SuDian())}' where 座次 = 2");
                        this.label21.Text = "-" + BaiBei(1.5 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+'{BaiBei(2.5 * SuDian()) + BaiBei(1.5 * SuDian())}',胡牌次数 = 胡牌次数+1 where 座次 = 3");
                        this.label22.Text = "+" + (BaiBei(2.5 * SuDian()) + BaiBei(1.5 * SuDian()));
                        Mahjong_GetSqlCmd(str1);
                        FaFu(3);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox5.Text}', 'NULL','{Convert.ToInt32(label22.Text)}')");
                        Mahjong_GetSqlCmd(str1);
                    }
                    else
                    {
                        radioButton35.Checked = false;
                        radioButton36.Checked = false;
                        radioButton37.Checked = false;
                        radioButton41.Checked = false;
                        radioButton42.Checked = false;
                        radioButton43.Checked = false;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton7.Checked = false;
                        radioButton8.Checked = false;
                        checkBox1.Checked = false;
                        checkBox2.Checked = false;
                        checkBox3.Checked = false;
                        MessageBox.Show("错误的操作", "error");
                        break;
                    }
                    radioButton35.Checked = false;
                    radioButton36.Checked = false;
                    radioButton37.Checked = false;
                    radioButton41.Checked = false;
                    radioButton42.Checked = false;
                    radioButton43.Checked = false;
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton7.Checked = false;
                    radioButton8.Checked = false;
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    timer1.Enabled = true;
                    Form2 = new Form();
                    MessageBox.Show(Form2, "操作成功!", "Success");
                    timer1.Enabled = false;
                    break;
                case 2:
                    if (radioButton36.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a }',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(3 * SuDian())}' where 座次 = 1");
                        this.label20.Text = "-" + BaiBei(3 * SuDian());
                        this.label22.Text = "-" + BaiBei(3 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(3 * SuDian())}' where 座次 = 3");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+'{2 * BaiBei(3 * SuDian())}',胡牌次数 = 胡牌次数+1  where 座次 = 2");
                        this.label21.Text = "+" + 2 * BaiBei(3 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        FaFu(2);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox4.Text}', 'NULL','{Convert.ToInt32(label21.Text)}')");
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton37.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1 }',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(2.5 * SuDian())}' where 座次 = 2");
                        this.label21.Text = "-" + BaiBei(2.5 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(1.5 * SuDian())}'where 座次 = 3");
                        this.label22.Text = "-" + BaiBei(1.5 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+'{BaiBei(2.5 * SuDian()) + BaiBei(1.5 * SuDian())}',胡牌次数 = 胡牌次数+1  where 座次 = 1");
                        this.label20.Text = "+" + (BaiBei(2.5 * SuDian()) + BaiBei(1.5 * SuDian()));
                        Mahjong_GetSqlCmd(str1);
                        FaFu(1);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox5.Text}', 'NULL','{Convert.ToInt32(label22.Text)}')");
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton35.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(2.5 * SuDian())}' where 座次 = 2");
                        this.label21.Text = "-" + BaiBei(2.5 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(1.5 * SuDian())}' where 座次 = 1");
                        this.label20.Text = "-" + BaiBei(1.5 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+'{BaiBei(2.5 * SuDian()) + BaiBei(1.5 * SuDian())}',胡牌次数 = 胡牌次数+1 where 座次 = 3");
                        this.label22.Text = "+" + (BaiBei(2.5 * SuDian()) + BaiBei(1.5 * SuDian()));
                        Mahjong_GetSqlCmd(str1);
                        FaFu(3);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox3.Text}', 'NULL','{Convert.ToInt32(label20.Text)}')");
                        Mahjong_GetSqlCmd(str1);
                    }
                    else
                    {
                        radioButton35.Checked = false;
                        radioButton36.Checked = false;
                        radioButton37.Checked = false;
                        radioButton41.Checked = false;
                        radioButton42.Checked = false;
                        radioButton43.Checked = false;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton7.Checked = false;
                        radioButton8.Checked = false;
                        checkBox1.Checked = false;
                        checkBox2.Checked = false;
                        checkBox3.Checked = false;
                        MessageBox.Show("错误的操作", "error");
                        break;
                    }
                    radioButton35.Checked = false;
                    radioButton36.Checked = false;
                    radioButton37.Checked = false;
                    radioButton41.Checked = false;
                    radioButton42.Checked = false;
                    radioButton43.Checked = false;
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton7.Checked = false;
                    radioButton8.Checked = false;
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    timer1.Enabled = true;
                    Form2 = new Form();
                    MessageBox.Show(Form2, "操作成功!", "Success");
                    timer1.Enabled = false;
                    break;
                case 0:

                    if (radioButton35.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(3 * SuDian())}' where 座次 = 2");
                        this.label20.Text = "-" + BaiBei(3 * SuDian());
                        this.label21.Text = "-" + BaiBei(3 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(3 * SuDian())}' where 座次 = 1");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+'{2 * BaiBei(3 * SuDian())}',胡牌次数 = 胡牌次数+1 where 座次 = 3");
                        this.label22.Text = "+" + 2 * BaiBei(3 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        FaFu(3);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox3.Text}', 'NULL','{Convert.ToInt32(label20.Text)}')");
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton36.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(2.5 * SuDian())}'where 座次 = 3");
                        this.label22.Text = "-" + BaiBei(2.5 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(1.5 * SuDian())}' where 座次 = 1");
                        this.label20.Text = "-" + BaiBei(1.5 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+'{BaiBei(2.5 * SuDian()) + BaiBei(1.5 * SuDian())}',胡牌次数 = 胡牌次数+1  where 座次 = 2");
                        this.label21.Text = "+" + (BaiBei(2.5 * SuDian()) + BaiBei(1.5 * SuDian()));
                        Mahjong_GetSqlCmd(str1);
                        FaFu(2);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox4.Text}', 'NULL','{Convert.ToInt32(label21.Text)}')");
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton37.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(2.5 * SuDian())}'where 座次 = 3");
                        this.label22.Text = "-" + BaiBei(2.5 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(1.5 * SuDian())}' where 座次 = 2");
                        this.label21.Text = "-" + BaiBei(1.5 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+'{BaiBei(2.5 * SuDian()) + BaiBei(1.5 * SuDian())}',胡牌次数 = 胡牌次数+1  where 座次 = 1");
                        this.label20.Text = "+" + (BaiBei(2.5 * SuDian()) + BaiBei(1.5 * SuDian()));
                        Mahjong_GetSqlCmd(str1);
                        FaFu(1);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox5.Text}', 'NULL','{Convert.ToInt32(label22.Text)}')");
                        Mahjong_GetSqlCmd(str1);
                    }
                    else
                    {
                        radioButton35.Checked = false;
                        radioButton36.Checked = false;
                        radioButton37.Checked = false;
                        radioButton41.Checked = false;
                        radioButton42.Checked = false;
                        radioButton43.Checked = false;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton7.Checked = false;
                        radioButton8.Checked = false;
                        checkBox1.Checked = false;
                        checkBox2.Checked = false;
                        checkBox3.Checked = false;
                        MessageBox.Show("错误的操作", "error");
                        break;
                    }
                    radioButton35.Checked = false;
                    radioButton36.Checked = false;
                    radioButton37.Checked = false;
                    radioButton41.Checked = false;
                    radioButton42.Checked = false;
                    radioButton43.Checked = false;
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton7.Checked = false;
                    radioButton8.Checked = false;
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    timer1.Enabled = true;
                    Form2 = new Form();
                    MessageBox.Show(Form2, "操作成功!", "Success");
                    timer1.Enabled = false;
                    break;
            }
            Reload();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "26";
        }

        private void radioButton37_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "20";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "30";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "40";
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "50";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "60";
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "70";
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "80";
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "90";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "100";
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "110";
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "120";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "130";
        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "1";
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "2";
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "3";
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "4";
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "5";
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "6";
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "7";
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "8";
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "9";
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "10";
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "11";
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "12";
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "13";
        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "39";
        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "52";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string conStr = "server=DESKTOP-VL3JSDS;database=Mahjong;Trusted_Connection=SSPI";
            SqlConnection data = new SqlConnection(conStr);
            data.Open();
            string str = string.Format($"select * from 比赛");
            SqlCommand comm = new SqlCommand(str, data);
            SqlDataReader sdr = comm.ExecuteReader();
            sdr.Read();
            string str1;
            int a = Convert.ToInt32(sdr["场次"].ToString());
            int b = Convert.ToInt32(sdr["局数"].ToString());
            switch (a % 3)
            {
                case 1:
                    if (radioButton1.Checked && radioButton7.Checked && radioButton2.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        radioButton35.Checked = false;
                        radioButton36.Checked = false;
                        radioButton37.Checked = false;
                        radioButton41.Checked = false;
                        radioButton42.Checked = false;
                        radioButton43.Checked = false;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton7.Checked = false;
                        radioButton8.Checked = false;
                        FaFu(4);
                        checkBox1.Checked = false;
                        checkBox2.Checked = false;
                        checkBox3.Checked = false;
                        timer1.Enabled = true;
                        Form2 = new Form();
                        MessageBox.Show(Form2, "操作成功!", "Success");
                        timer1.Enabled = false;
                        break;
                    }
                    else if (radioButton1.Checked && radioButton7.Checked && radioButton3.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+1500 where 座次 = 1");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+1500 where 座次 = 2");
                        Mahjong_GetSqlCmd(str1);
                        this.label20.Text = "+1500";
                        this.label21.Text = "+1500";
                        str1 = string.Format($"update 选手 set 点数 = 点数-3000 where 座次 = 3");
                        this.label22.Text = "-3000";
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton1.Checked && radioButton8.Checked && radioButton2.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+1500 where 座次 = 1");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+1500 where 座次 = 3");
                        Mahjong_GetSqlCmd(str1);
                        this.label20.Text = "+1500";
                        this.label22.Text = "+1500";
                        str1 = string.Format($"update 选手 set 点数 = 点数-3000 where 座次 = 2");
                        this.label21.Text = "-3000";
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton4.Checked && radioButton7.Checked && radioButton2.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+1500 where 座次 = 2");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+1500 where 座次 = 3");
                        this.label21.Text = "+1500";
                        this.label22.Text = "+1500";
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-3000 where 座次 = 1");
                        this.label20.Text = "-3000";
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton1.Checked && radioButton8.Checked && radioButton3.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+3000 where 座次 = 1");
                        this.label20.Text = "+3000";
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-1500 where 座次 = 2");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-1500 where 座次 = 3");
                        this.label21.Text = "-1500";
                        this.label22.Text = "-1500";
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton4.Checked && radioButton7.Checked && radioButton3.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+3000 where 座次 = 2");
                        this.label21.Text = "+3000";
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-1500 where 座次 = 1");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-1500 where 座次 = 3");
                        this.label20.Text = "-1500";
                        this.label22.Text = "-1500";
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton4.Checked && radioButton8.Checked && radioButton2.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+3000 where 座次 = 3");
                        this.label22.Text = "+3000";
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-1500 where 座次 = 1");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-1500 where 座次 = 2");
                        this.label20.Text = "-1500";
                        this.label21.Text = "-1500";
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton4.Checked && radioButton8.Checked && radioButton3.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                    }
                    else
                    {
                        radioButton35.Checked = false;
                        radioButton36.Checked = false;
                        radioButton37.Checked = false;
                        radioButton41.Checked = false;
                        radioButton42.Checked = false;
                        radioButton43.Checked = false;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton7.Checked = false;
                        radioButton8.Checked = false;
                        checkBox1.Checked = false;
                        checkBox2.Checked = false;
                        checkBox3.Checked = false;
                        MessageBox.Show("错误的操作", "error");
                        break;
                    }
                    radioButton35.Checked = false;
                    radioButton36.Checked = false;
                    radioButton37.Checked = false;
                    radioButton41.Checked = false;
                    radioButton42.Checked = false;
                    radioButton43.Checked = false;
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton7.Checked = false;
                    radioButton8.Checked = false;
                    FaFu(0);
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    timer1.Enabled = true;
                    Form2 = new Form();
                    MessageBox.Show(Form2, "操作成功!", "Success");
                    timer1.Enabled = false;
                    break;
                case 2:
                    if (radioButton1.Checked && radioButton7.Checked && radioButton2.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        radioButton35.Checked = false;
                        radioButton36.Checked = false;
                        radioButton37.Checked = false;
                        radioButton41.Checked = false;
                        radioButton42.Checked = false;
                        radioButton43.Checked = false;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton7.Checked = false;
                        radioButton8.Checked = false;
                        FaFu(4);
                        checkBox1.Checked = false;
                        checkBox2.Checked = false;
                        checkBox3.Checked = false;
                        timer1.Enabled = true;
                        Form2 = new Form();
                        MessageBox.Show(Form2, "操作成功!", "Success");
                        timer1.Enabled = false;
                        break;
                    }
                    else if (radioButton1.Checked && radioButton7.Checked && radioButton3.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+1500 where 座次 = 1");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+1500 where 座次 = 2");
                        this.label20.Text = "+1500";
                        this.label21.Text = "+1500";
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-3000 where 座次 = 3");
                        this.label22.Text = "-3000";
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton1.Checked && radioButton8.Checked && radioButton2.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+1500 where 座次 = 1");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+1500 where 座次 = 3");
                        this.label20.Text = "+1500";
                        this.label22.Text = "+1500";
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-3000 where 座次 = 2");
                        this.label21.Text = "-3000";
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton4.Checked && radioButton7.Checked && radioButton2.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+1500 where 座次 = 2");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+1500 where 座次 = 3");
                        this.label21.Text = "+1500";
                        this.label22.Text = "+1500";
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-3000 where 座次 = 1");
                        this.label20.Text = "-3000";
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton1.Checked && radioButton8.Checked && radioButton3.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+3000 where 座次 = 1");
                        this.label20.Text = "+3000";
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-1500 where 座次 = 2");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-1500 where 座次 = 3");
                        this.label21.Text = "-1500";
                        this.label22.Text = "-1500";
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton4.Checked && radioButton7.Checked && radioButton3.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+3000 where 座次 = 2");
                        this.label21.Text = "+3000";
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-1500 where 座次 = 1");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-1500 where 座次 = 3");
                        this.label20.Text = "-1500";
                        this.label22.Text = "-1500";
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton4.Checked && radioButton8.Checked && radioButton2.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+3000 where 座次 = 3");
                        this.label22.Text = "+3000";
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-1500 where 座次 = 1");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-1500 where 座次 = 2");
                        this.label20.Text = "-1500";
                        this.label21.Text = "-1500";
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton4.Checked && radioButton8.Checked && radioButton3.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                    }
                    else
                    {
                        radioButton35.Checked = false;
                        radioButton36.Checked = false;
                        radioButton37.Checked = false;
                        radioButton41.Checked = false;
                        radioButton42.Checked = false;
                        radioButton43.Checked = false;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton7.Checked = false;
                        radioButton8.Checked = false;
                        checkBox1.Checked = false;
                        checkBox2.Checked = false;
                        checkBox3.Checked = false;
                        MessageBox.Show("错误的操作", "error");
                        break;
                    }
                    radioButton35.Checked = false;
                    radioButton36.Checked = false;
                    radioButton37.Checked = false;
                    radioButton41.Checked = false;
                    radioButton42.Checked = false;
                    radioButton43.Checked = false;
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton7.Checked = false;
                    radioButton8.Checked = false;
                    FaFu(0);
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    timer1.Enabled = true;
                    Form2 = new Form();
                    MessageBox.Show(Form2, "操作成功!", "Success");
                    timer1.Enabled = false;
                    break;
                case 0:
                    if (radioButton1.Checked && radioButton7.Checked && radioButton2.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        radioButton35.Checked = false;
                        radioButton36.Checked = false;
                        radioButton37.Checked = false;
                        radioButton41.Checked = false;
                        radioButton42.Checked = false;
                        radioButton43.Checked = false;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton7.Checked = false;
                        radioButton8.Checked = false;
                        FaFu(4);
                        checkBox1.Checked = false;
                        checkBox2.Checked = false;
                        checkBox3.Checked = false;
                        timer1.Enabled = true;
                        Form2 = new Form();
                        MessageBox.Show(Form2, "操作成功!", "Success");
                        timer1.Enabled = false;
                        break;
                    }
                    else if (radioButton1.Checked && radioButton7.Checked && radioButton3.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+1500 where 座次 = 1");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+1500 where 座次 = 2");
                        this.label20.Text = "+1500";
                        this.label21.Text = "+1500";
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-3000 where 座次 = 3");
                        this.label22.Text = "-3000";
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton1.Checked && radioButton8.Checked && radioButton2.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+1500 where 座次 = 1");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+1500 where 座次 = 3");
                        this.label20.Text = "+1500";
                        this.label22.Text = "+1500";
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-3000 where 座次 = 2");
                        this.label21.Text = "-3000";
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton4.Checked && radioButton7.Checked && radioButton2.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+1500 where 座次 = 2");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+1500 where 座次 = 3");
                        this.label21.Text = "+1500";
                        this.label22.Text = "+1500";
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-3000 where 座次 = 1");
                        this.label20.Text = "-3000";
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton1.Checked && radioButton8.Checked && radioButton3.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+3000 where 座次 = 1");
                        this.label20.Text = "+3000";
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-1500 where 座次 = 2");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-1500 where 座次 = 3");
                        this.label21.Text = "-1500";
                        this.label22.Text = "-1500";
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton4.Checked && radioButton7.Checked && radioButton3.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+3000 where 座次 = 2");
                        this.label21.Text = "+3000";
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-1500 where 座次 = 1");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-1500 where 座次 = 3");
                        this.label20.Text = "-1500";
                        this.label22.Text = "-1500";
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton4.Checked && radioButton8.Checked && radioButton2.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+3000 where 座次 = 3");
                        this.label22.Text = "+3000";
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-1500 where 座次 = 1");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-1500 where 座次 = 2");
                        this.label20.Text = "-1500";
                        this.label21.Text = "-1500";
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton4.Checked && radioButton8.Checked && radioButton3.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                    }
                    else
                    {
                        radioButton35.Checked = false;
                        radioButton36.Checked = false;
                        radioButton37.Checked = false;
                        radioButton41.Checked = false;
                        radioButton42.Checked = false;
                        radioButton43.Checked = false;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton7.Checked = false;
                        radioButton8.Checked = false;
                        checkBox1.Checked = false;
                        checkBox2.Checked = false;
                        checkBox3.Checked = false;
                        MessageBox.Show("错误的操作", "error");
                        break;
                    }
                    radioButton35.Checked = false;
                    radioButton36.Checked = false;
                    radioButton37.Checked = false;
                    radioButton41.Checked = false;
                    radioButton42.Checked = false;
                    radioButton43.Checked = false;
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton7.Checked = false;
                    radioButton8.Checked = false;
                    FaFu(0);
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    timer1.Enabled = true;
                    Form2 = new Form();
                    MessageBox.Show(Form2, "操作成功!", "Success");
                    timer1.Enabled = false;
                    break;
            }
            Reload();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form2.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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
            MySqlCommand cmd = new MySqlCommand("select * from 比赛", conn);
            //执行语句
            MySqlDataReader msqlReader = cmd.ExecuteReader();
            msqlReader.Read();
            int a = msqlReader.GetInt32("场次");
            int b = msqlReader.GetInt32("局数");
            string str1;
            switch (a % 3)
            {
                case 1:
                    if (radioButton37.Checked && radioButton42.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+'{BaiBei(6 * SuDian())}',胡牌次数 = 胡牌次数+1 where 座次 = 1");
                        Mahjong_GetSqlCmd(str1);
                        this.label20.Text = "+" + BaiBei(6 * SuDian());
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(6 * SuDian())}',放铳次数 = 放铳次数+1 where 座次 = 2");
                        this.label21.Text = "-" + BaiBei(6 * SuDian());
                        this.label22.Text = "+" + 0;
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox3.Text}', '{textBox4.Text}','{Convert.ToInt32(label20.Text)}')");
                        Mahjong_GetSqlCmd(str1);
                        FaFu(1);
                    }
                    else if (radioButton37.Checked && radioButton41.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+'{BaiBei(6 * SuDian())}',胡牌次数 = 胡牌次数+1 where 座次 = 1");
                        this.label20.Text = "+" + BaiBei(6 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(6 * SuDian())}',放铳次数 = 放铳次数+1 where 座次 = 3");
                        this.label22.Text = "-" + BaiBei(6 * SuDian());
                        this.label21.Text = "+" + 0;
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox3.Text}', '{textBox5.Text}','{Convert.ToInt32(label20.Text)}')");
                        Mahjong_GetSqlCmd(str1);
                        FaFu(1);
                    }
                    else if (radioButton36.Checked && radioButton43.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+'{BaiBei(4 * SuDian())}',胡牌次数 = 胡牌次数+1  where 座次 = 2");
                        this.label21.Text = "+" + BaiBei(4 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(4 * SuDian())}',放铳次数 = 放铳次数+1  where 座次 = 1");
                        this.label20.Text = "-" + BaiBei(4 * SuDian());
                        this.label22.Text = "+" + 0;
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox4.Text}', '{textBox3.Text}','{Convert.ToInt32(label21.Text)}')");
                        Mahjong_GetSqlCmd(str1);
                        FaFu(2);
                    }
                    else if (radioButton36.Checked && radioButton41.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+'{BaiBei(4 * SuDian())}',胡牌次数 = 胡牌次数+1  where 座次 = 2");
                        this.label21.Text = "+" + BaiBei(4 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(4 * SuDian())}',放铳次数 = 放铳次数+1 where 座次 = 3");
                        this.label22.Text = "-" + BaiBei(4 * SuDian());
                        this.label20.Text = "+" + 0;
                        Mahjong_GetSqlCmd(str1);
                        FaFu(2);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox4.Text}', '{textBox5.Text}','{Convert.ToInt32(label21.Text)}')");
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton35.Checked && radioButton43.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+'{BaiBei(4 * SuDian())}',胡牌次数 = 胡牌次数+1 where 座次 = 3");
                        this.label22.Text = "+" + BaiBei(4 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(4 * SuDian())}',放铳次数 = 放铳次数+1  where 座次 = 1");
                        this.label20.Text = "-" + BaiBei(4 * SuDian());
                        this.label21.Text = "+" + 0;
                        Mahjong_GetSqlCmd(str1);
                        FaFu(3);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox5.Text}', '{textBox3.Text}','{Convert.ToInt32(label22.Text)}')");
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton35.Checked && radioButton42.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+'{BaiBei(4 * SuDian())}',胡牌次数 = 胡牌次数+1 where 座次 = 3");
                        this.label22.Text = "+" + BaiBei(4 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(4 * SuDian())}',放铳次数 = 放铳次数+1  where 座次 = 2");
                        this.label21.Text = "-" + BaiBei(4 * SuDian());
                        this.label20.Text = "+" + 0;
                        Mahjong_GetSqlCmd(str1);
                        FaFu(3);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox5.Text}', '{textBox4.Text}','{Convert.ToInt32(label22.Text)}')");
                        Mahjong_GetSqlCmd(str1);
                    }
                    else
                    {
                        radioButton35.Checked = false;
                        radioButton36.Checked = false;
                        radioButton37.Checked = false;
                        radioButton41.Checked = false;
                        radioButton42.Checked = false;
                        radioButton43.Checked = false;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton7.Checked = false;
                        radioButton8.Checked = false;
                        checkBox1.Checked = false;
                        checkBox2.Checked = false;
                        checkBox3.Checked = false;
                        MessageBox.Show("错误的操作", "error");
                        break;
                    }
                    radioButton35.Checked = false;
                    radioButton36.Checked = false;
                    radioButton37.Checked = false;
                    radioButton41.Checked = false;
                    radioButton42.Checked = false;
                    radioButton43.Checked = false;
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton7.Checked = false;
                    radioButton8.Checked = false;
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    timer1.Enabled = true;
                    Form2 = new Form();
                    MessageBox.Show(Form2, "操作成功!", "Success");
                    timer1.Enabled = false;
                    break;
                case 2:
                    if (radioButton37.Checked && radioButton42.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+'{BaiBei(4 * SuDian())}',胡牌次数 = 胡牌次数+1 where 座次 = 1");
                        this.label20.Text = "+" + BaiBei(4 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(4 * SuDian())}',放铳次数 = 放铳次数+1 where 座次 = 2");
                        this.label21.Text = "-" + BaiBei(4 * SuDian());
                        this.label22.Text = "+" + 0;
                        Mahjong_GetSqlCmd(str1);
                        FaFu(1);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox3.Text}', '{textBox4.Text}','{Convert.ToInt32(label20.Text)}')");
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton37.Checked && radioButton41.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+'{BaiBei(4 * SuDian())}',胡牌次数 = 胡牌次数+1 where 座次 = 1");
                        this.label20.Text = "+" + BaiBei(4 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(4 * SuDian())}',放铳次数 = 放铳次数+1 where 座次 = 3");
                        this.label22.Text = "-" + BaiBei(4 * SuDian());
                        this.label21.Text = "+" + 0;
                        Mahjong_GetSqlCmd(str1);
                        FaFu(1);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox3.Text}', '{textBox5.Text}','{Convert.ToInt32(label20.Text)}')");
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton36.Checked && radioButton43.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+'{BaiBei(6 * SuDian())}',胡牌次数 = 胡牌次数+1  where 座次 = 2");
                        this.label21.Text = "+" + BaiBei(6 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(6 * SuDian())}',放铳次数 = 放铳次数+1  where 座次 = 1");
                        this.label20.Text = "-" + BaiBei(6 * SuDian());
                        this.label22.Text = "+" + 0;
                        Mahjong_GetSqlCmd(str1);
                        FaFu(2);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox4.Text}', '{textBox3.Text}','{Convert.ToInt32(label21.Text)}')");
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton36.Checked && radioButton41.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+'{BaiBei(6 * SuDian())}',胡牌次数 = 胡牌次数+1  where 座次 = 2");
                        this.label21.Text = "+" + BaiBei(6 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(6 * SuDian())}',放铳次数 = 放铳次数+1 where 座次 = 3");
                        Mahjong_GetSqlCmd(str1);
                        this.label22.Text = "-" + BaiBei(6 * SuDian());
                        this.label20.Text = "+" + 0;
                        FaFu(2);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox4.Text}', '{textBox5.Text}','{Convert.ToInt32(label21.Text)}')");
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton35.Checked && radioButton43.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+'{BaiBei(4 * SuDian())}',胡牌次数 = 胡牌次数+1 where 座次 = 3");
                        this.label22.Text = "+" + BaiBei(4 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(4 * SuDian())}',放铳次数 = 放铳次数+1  where 座次 = 1");
                        this.label20.Text = "-" + BaiBei(4 * SuDian());
                        this.label21.Text = "+" + 0;
                        Mahjong_GetSqlCmd(str1);
                        FaFu(3);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox5.Text}', '{textBox3.Text}','{Convert.ToInt32(label22.Text)}')");
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton35.Checked && radioButton42.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+'{BaiBei(4 * SuDian())}',胡牌次数 = 胡牌次数+1 where 座次 = 3");
                        this.label22.Text = "+" + BaiBei(4 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(4 * SuDian())}',放铳次数 = 放铳次数+1  where 座次 = 2");
                        this.label21.Text = "-" + BaiBei(4 * SuDian());
                        this.label20.Text = "+" + 0;
                        Mahjong_GetSqlCmd(str1);
                        FaFu(3);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox5.Text}', '{textBox4.Text}','{Convert.ToInt32(label22.Text)}')");
                        Mahjong_GetSqlCmd(str1);
                    }
                    else
                    {
                        radioButton35.Checked = false;
                        radioButton36.Checked = false;
                        radioButton37.Checked = false;
                        radioButton41.Checked = false;
                        radioButton42.Checked = false;
                        radioButton43.Checked = false;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton7.Checked = false;
                        radioButton8.Checked = false;
                        checkBox1.Checked = false;
                        checkBox2.Checked = false;
                        checkBox3.Checked = false;
                        MessageBox.Show("错误的操作", "error");
                        break;
                    }
                    radioButton35.Checked = false;
                    radioButton36.Checked = false;
                    radioButton37.Checked = false;
                    radioButton41.Checked = false;
                    radioButton42.Checked = false;
                    radioButton43.Checked = false;
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton7.Checked = false;
                    radioButton8.Checked = false;
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    timer1.Enabled = true;
                    Form2 = new Form();
                    MessageBox.Show(Form2, "操作成功!", "Success");
                    timer1.Enabled = false;
                    break;
                case 0:
                    if (radioButton37.Checked && radioButton42.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+'{BaiBei(4 * SuDian())}',胡牌次数 = 胡牌次数+1 where 座次 = 1");
                        this.label20.Text = "+" + BaiBei(4 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(4 * SuDian())}',放铳次数 = 放铳次数+1 where 座次 = 2");
                        this.label21.Text = "-" + BaiBei(4 * SuDian());
                        this.label22.Text = "+" + 0;
                        Mahjong_GetSqlCmd(str1);
                        FaFu(1);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox3.Text}', '{textBox4.Text}','{Convert.ToInt32(label20.Text)}')");
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton37.Checked && radioButton41.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+'{BaiBei(4 * SuDian())}',胡牌次数 = 胡牌次数+1 where 座次 = 1");
                        this.label20.Text = "+" + BaiBei(4 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(4 * SuDian())}',放铳次数 = 放铳次数+1 where 座次 = 3");
                        this.label22.Text = "-" + BaiBei(4 * SuDian());
                        this.label21.Text = "+" + 0;
                        Mahjong_GetSqlCmd(str1);
                        FaFu(1);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox3.Text}', '{textBox5.Text}','{Convert.ToInt32(label20.Text)}')");
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton36.Checked && radioButton43.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+'{BaiBei(4 * SuDian())}',胡牌次数 = 胡牌次数+1  where 座次 = 2");
                        this.label21.Text = "+" + BaiBei(4 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(4 * SuDian())}',放铳次数 = 放铳次数+1  where 座次 = 1");
                        this.label20.Text = "-" + BaiBei(4 * SuDian());
                        this.label22.Text = "+" + 0;
                        Mahjong_GetSqlCmd(str1);
                        FaFu(2);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox4.Text}', '{textBox3.Text}','{Convert.ToInt32(label21.Text)}')");
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton36.Checked && radioButton41.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a + 1}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+'{BaiBei(4 * SuDian())}',胡牌次数 = 胡牌次数+1  where 座次 = 2");
                        this.label21.Text = "+" + BaiBei(4 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(4 * SuDian())}',放铳次数 = 放铳次数+1 where 座次 = 3");
                        this.label22.Text = "-" + BaiBei(4 * SuDian());
                        this.label20.Text = "+" + 0;
                        Mahjong_GetSqlCmd(str1);
                        FaFu(2);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox4.Text}', '{textBox5.Text}','{Convert.ToInt32(label21.Text)}')");
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton35.Checked && radioButton43.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+'{BaiBei(6 * SuDian())}',胡牌次数 = 胡牌次数+1 where 座次 = 3");
                        this.label22.Text = "+" + BaiBei(6 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(6 * SuDian())}',放铳次数 = 放铳次数+1  where 座次 = 1");
                        this.label20.Text = "-" + BaiBei(6 * SuDian());
                        this.label21.Text = "+" + 0;
                        Mahjong_GetSqlCmd(str1);
                        FaFu(3);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox5.Text}', '{textBox3.Text}','{Convert.ToInt32(label22.Text)}')");
                        Mahjong_GetSqlCmd(str1);
                    }
                    else if (radioButton35.Checked && radioButton42.Checked)
                    {
                        str1 = string.Format($"update 比赛 set 场次='{a}',局数='{b + 1}'");
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数+'{BaiBei(6 * SuDian())}',胡牌次数 = 胡牌次数+1 where 座次 = 3");
                        this.label22.Text = "+" + BaiBei(6 * SuDian());
                        Mahjong_GetSqlCmd(str1);
                        str1 = string.Format($"update 选手 set 点数 = 点数-'{BaiBei(6 * SuDian())}',放铳次数 = 放铳次数+1  where 座次 = 2");
                        this.label21.Text = "-" + BaiBei(6 * SuDian());
                        this.label20.Text = "+" + 0;
                        Mahjong_GetSqlCmd(str1);
                        FaFu(3);
                        str1 = string.Format($"INSERT INTO 记录 (`主要`, `次要`, `大小`) VALUES('{textBox5.Text}', '{textBox4.Text}','{Convert.ToInt32(label22.Text)}')");
                        Mahjong_GetSqlCmd(str1);
                    }
                    else
                    {
                        MessageBox.Show("错误的操作", "error");
                        radioButton35.Checked = false;
                        radioButton36.Checked = false;
                        radioButton37.Checked = false;
                        radioButton41.Checked = false;
                        radioButton42.Checked = false;
                        radioButton43.Checked = false;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton7.Checked = false;
                        radioButton8.Checked = false;
                        checkBox1.Checked = false;
                        checkBox2.Checked = false;
                        checkBox3.Checked = false;
                        break;
                    }
                    radioButton35.Checked = false;
                    radioButton36.Checked = false;
                    radioButton37.Checked = false;
                    radioButton41.Checked = false;
                    radioButton42.Checked = false;
                    radioButton43.Checked = false;
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton7.Checked = false;
                    radioButton8.Checked = false;
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    timer1.Enabled = true;
                    Form2 = new Form();
                    MessageBox.Show(Form2, "操作成功!", "Success");
                    timer1.Enabled = false;
                    break;
            }
            Reload();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String a = textBox3.Text;
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
            MySqlCommand cmd = new MySqlCommand("select * from 玩家", conn);
            //执行语句
            MySqlDataReader msqlReader = cmd.ExecuteReader();
            int flag = 0;
            while (msqlReader.Read())
            {
                if(textBox3.Text == msqlReader.GetString("昵称"))
                {
                    flag = 1;
                    break;
                }
            }
            if (flag==1)
            {
                flag1 = 1;
                Form2 = new Form();
                MessageBox.Show(Form2, "登录成功!", "Success");
                label10.Text = msqlReader.GetString("点数");
                label16.Text = msqlReader.GetString("胡牌次数");
            }
            else
            {
                flag1=0;
                Form2 = new Form();
                MessageBox.Show(Form2, "登录失败!", "Fall");
                label10.Text = "请登录";
            }
            String str1 = string.Format($"update 选手 set 点数 = '{label10.Text}',胡牌次数= '{label16.Text}' where 座次 = 1");
            Mahjong_GetSqlCmd(str1);

        }

        private void button5_Click(object sender, EventArgs e)
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
            MySqlCommand cmd = new MySqlCommand("select * from 玩家", conn);
            //执行语句
            MySqlDataReader msqlReader = cmd.ExecuteReader();
            int flag = 0;
            while (msqlReader.Read())
            {
                if (textBox4.Text == msqlReader.GetString("昵称"))
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 1)
            {
                flag2 = 1;
                Form2 = new Form();
                MessageBox.Show(Form2, "登录成功!", "Success");
                label14.Text = msqlReader.GetString("点数");
                label17.Text = msqlReader.GetString("胡牌次数");
            }
            else
            {
                flag2 = 0;
                Form2 = new Form();
                MessageBox.Show(Form2, "登录失败!", "Fall");
                label14.Text = "请登录";
            }
            String str1 = string.Format($"update 选手 set 点数 = '{label14.Text}',胡牌次数= '{label17.Text}' where 座次 = 2");
            Mahjong_GetSqlCmd(str1);
        }

        private void button6_Click(object sender, EventArgs e)
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
            MySqlCommand cmd = new MySqlCommand("select * from 玩家", conn);
            //执行语句
            MySqlDataReader msqlReader = cmd.ExecuteReader();
            int flag = 0;
            while (msqlReader.Read())
            {
                if (textBox5.Text == msqlReader.GetString("昵称"))
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 1)
            {
                flag3 = 1;
                Form2 = new Form();
                MessageBox.Show(Form2, "登录成功!", "Success");
                label15.Text = msqlReader.GetString("点数");
                label18.Text = msqlReader.GetString("胡牌次数");
            }
            else
            {
                flag3 = 0;
                Form2 = new Form();
                MessageBox.Show(Form2, "登录失败!", "Fall");
                label15.Text = "请登录";
            }
            String str1 = string.Format($"update 选手 set 点数 = '{label15.Text}',胡牌次数= '{label18.Text}' where 座次 = 3");
            Mahjong_GetSqlCmd(str1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String str1 = string.Format($"update 玩家 set 点数 = '{label10.Text}',胡牌次数= '{label16.Text}'" + $"where 昵称 =  '{textBox3.Text}'");
            Mahjong_GetSqlCmd(str1);
            str1 = string.Format($"update 玩家 set 点数 = '{label14.Text}',胡牌次数= '{label17.Text}'" + $"where 昵称 =  '{textBox4.Text}'");
            Mahjong_GetSqlCmd(str1);
            str1 = string.Format($"update 玩家 set 点数 = '{label15.Text}',胡牌次数= '{label18.Text}'" + $"where 昵称 =  '{textBox5.Text}'");
            Mahjong_GetSqlCmd(str1);

            DialogResult result = MessageBox.Show("你确定要退出程序吗?", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                System.Environment.Exit(0);
            }
            else
            {
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
