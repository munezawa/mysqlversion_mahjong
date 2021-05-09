using System.Data.SqlClient;
namespace MahJong
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.一家 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton34 = new System.Windows.Forms.RadioButton();
            this.radioButton33 = new System.Windows.Forms.RadioButton();
            this.radioButton31 = new System.Windows.Forms.RadioButton();
            this.radioButton32 = new System.Windows.Forms.RadioButton();
            this.radioButton19 = new System.Windows.Forms.RadioButton();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.radioButton21 = new System.Windows.Forms.RadioButton();
            this.radioButton22 = new System.Windows.Forms.RadioButton();
            this.radioButton23 = new System.Windows.Forms.RadioButton();
            this.radioButton24 = new System.Windows.Forms.RadioButton();
            this.radioButton25 = new System.Windows.Forms.RadioButton();
            this.radioButton26 = new System.Windows.Forms.RadioButton();
            this.radioButton27 = new System.Windows.Forms.RadioButton();
            this.radioButton28 = new System.Windows.Forms.RadioButton();
            this.radioButton29 = new System.Windows.Forms.RadioButton();
            this.radioButton30 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton35 = new System.Windows.Forms.RadioButton();
            this.radioButton36 = new System.Windows.Forms.RadioButton();
            this.radioButton37 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButton41 = new System.Windows.Forms.RadioButton();
            this.radioButton42 = new System.Windows.Forms.RadioButton();
            this.radioButton43 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // 一家
            // 
            this.一家.AutoSize = true;
            this.一家.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.一家.Location = new System.Drawing.Point(6, 20);
            this.一家.Name = "一家";
            this.一家.Size = new System.Drawing.Size(79, 33);
            this.一家.TabIndex = 1;
            this.一家.Text = "一家";
            this.一家.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton1.Location = new System.Drawing.Point(95, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 33);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "听牌";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton4.Location = new System.Drawing.Point(190, 20);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(89, 33);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.Text = "未听";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.一家);
            this.groupBox1.Location = new System.Drawing.Point(616, 417);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 73);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(616, 496);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 73);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton7.Location = new System.Drawing.Point(95, 20);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(89, 33);
            this.radioButton7.TabIndex = 5;
            this.radioButton7.Text = "听牌";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton8.Location = new System.Drawing.Point(190, 20);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(89, 33);
            this.radioButton8.TabIndex = 8;
            this.radioButton8.Text = "未听";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "二家";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(616, 575);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 73);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton2.Location = new System.Drawing.Point(95, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 33);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "听牌";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton3.Location = new System.Drawing.Point(190, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(89, 33);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.Text = "未听";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "三家";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("楷体", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(113, 796);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 107);
            this.button1.TabIndex = 14;
            this.button1.Text = "自摸";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(158, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 64);
            this.label3.TabIndex = 15;
            this.label3.Text = "符数";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(288, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 50);
            this.textBox1.TabIndex = 16;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton6.Location = new System.Drawing.Point(285, 3);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(61, 33);
            this.radioButton6.TabIndex = 18;
            this.radioButton6.Text = "40";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton9.Location = new System.Drawing.Point(169, 3);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(61, 33);
            this.radioButton9.TabIndex = 19;
            this.radioButton9.Text = "30";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton10.Location = new System.Drawing.Point(53, 3);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(61, 33);
            this.radioButton10.TabIndex = 20;
            this.radioButton10.Text = "20";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton15);
            this.panel1.Controls.Add(this.radioButton16);
            this.panel1.Controls.Add(this.radioButton17);
            this.panel1.Controls.Add(this.radioButton18);
            this.panel1.Controls.Add(this.radioButton11);
            this.panel1.Controls.Add(this.radioButton12);
            this.panel1.Controls.Add(this.radioButton13);
            this.panel1.Controls.Add(this.radioButton14);
            this.panel1.Controls.Add(this.radioButton10);
            this.panel1.Controls.Add(this.radioButton9);
            this.panel1.Controls.Add(this.radioButton6);
            this.panel1.Location = new System.Drawing.Point(113, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 142);
            this.panel1.TabIndex = 29;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton5.Location = new System.Drawing.Point(401, 100);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(76, 33);
            this.radioButton5.TabIndex = 29;
            this.radioButton5.Text = "130";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton15.Location = new System.Drawing.Point(53, 100);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(76, 33);
            this.radioButton15.TabIndex = 28;
            this.radioButton15.Text = "100";
            this.radioButton15.UseVisualStyleBackColor = true;
            this.radioButton15.CheckedChanged += new System.EventHandler(this.radioButton15_CheckedChanged);
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton16.Location = new System.Drawing.Point(169, 100);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(76, 33);
            this.radioButton16.TabIndex = 27;
            this.radioButton16.Text = "110";
            this.radioButton16.UseVisualStyleBackColor = true;
            this.radioButton16.CheckedChanged += new System.EventHandler(this.radioButton16_CheckedChanged);
            // 
            // radioButton17
            // 
            this.radioButton17.AutoSize = true;
            this.radioButton17.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton17.Location = new System.Drawing.Point(285, 100);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(76, 33);
            this.radioButton17.TabIndex = 26;
            this.radioButton17.Text = "120";
            this.radioButton17.UseVisualStyleBackColor = true;
            this.radioButton17.CheckedChanged += new System.EventHandler(this.radioButton17_CheckedChanged);
            // 
            // radioButton18
            // 
            this.radioButton18.AutoSize = true;
            this.radioButton18.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton18.Location = new System.Drawing.Point(401, 51);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(61, 33);
            this.radioButton18.TabIndex = 25;
            this.radioButton18.Text = "90";
            this.radioButton18.UseVisualStyleBackColor = true;
            this.radioButton18.CheckedChanged += new System.EventHandler(this.radioButton18_CheckedChanged);
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton11.Location = new System.Drawing.Point(53, 51);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(61, 33);
            this.radioButton11.TabIndex = 24;
            this.radioButton11.Text = "60";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton12.Location = new System.Drawing.Point(169, 51);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(61, 33);
            this.radioButton12.TabIndex = 23;
            this.radioButton12.Text = "70";
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.CheckedChanged += new System.EventHandler(this.radioButton12_CheckedChanged);
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton13.Location = new System.Drawing.Point(285, 51);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(61, 33);
            this.radioButton13.TabIndex = 22;
            this.radioButton13.Text = "80";
            this.radioButton13.UseVisualStyleBackColor = true;
            this.radioButton13.CheckedChanged += new System.EventHandler(this.radioButton13_CheckedChanged);
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton14.Location = new System.Drawing.Point(401, 3);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(61, 33);
            this.radioButton14.TabIndex = 21;
            this.radioButton14.Text = "50";
            this.radioButton14.UseVisualStyleBackColor = true;
            this.radioButton14.CheckedChanged += new System.EventHandler(this.radioButton14_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.radioButton34);
            this.panel2.Controls.Add(this.radioButton33);
            this.panel2.Controls.Add(this.radioButton31);
            this.panel2.Controls.Add(this.radioButton32);
            this.panel2.Controls.Add(this.radioButton19);
            this.panel2.Controls.Add(this.radioButton20);
            this.panel2.Controls.Add(this.radioButton21);
            this.panel2.Controls.Add(this.radioButton22);
            this.panel2.Controls.Add(this.radioButton23);
            this.panel2.Controls.Add(this.radioButton24);
            this.panel2.Controls.Add(this.radioButton25);
            this.panel2.Controls.Add(this.radioButton26);
            this.panel2.Controls.Add(this.radioButton27);
            this.panel2.Controls.Add(this.radioButton28);
            this.panel2.Controls.Add(this.radioButton29);
            this.panel2.Controls.Add(this.radioButton30);
            this.panel2.Location = new System.Drawing.Point(113, 392);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 185);
            this.panel2.TabIndex = 32;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // radioButton34
            // 
            this.radioButton34.AutoSize = true;
            this.radioButton34.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton34.Location = new System.Drawing.Point(401, 149);
            this.radioButton34.Name = "radioButton34";
            this.radioButton34.Size = new System.Drawing.Size(61, 33);
            this.radioButton34.TabIndex = 32;
            this.radioButton34.Text = "52";
            this.radioButton34.UseVisualStyleBackColor = true;
            this.radioButton34.CheckedChanged += new System.EventHandler(this.radioButton34_CheckedChanged);
            // 
            // radioButton33
            // 
            this.radioButton33.AutoSize = true;
            this.radioButton33.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton33.Location = new System.Drawing.Point(285, 149);
            this.radioButton33.Name = "radioButton33";
            this.radioButton33.Size = new System.Drawing.Size(61, 33);
            this.radioButton33.TabIndex = 31;
            this.radioButton33.Text = "39";
            this.radioButton33.UseVisualStyleBackColor = true;
            this.radioButton33.CheckedChanged += new System.EventHandler(this.radioButton33_CheckedChanged);
            // 
            // radioButton31
            // 
            this.radioButton31.AutoSize = true;
            this.radioButton31.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton31.Location = new System.Drawing.Point(169, 149);
            this.radioButton31.Name = "radioButton31";
            this.radioButton31.Size = new System.Drawing.Size(61, 33);
            this.radioButton31.TabIndex = 30;
            this.radioButton31.Text = "26";
            this.radioButton31.UseVisualStyleBackColor = true;
            this.radioButton31.CheckedChanged += new System.EventHandler(this.radioButton31_CheckedChanged);
            // 
            // radioButton32
            // 
            this.radioButton32.AutoSize = true;
            this.radioButton32.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton32.Location = new System.Drawing.Point(53, 149);
            this.radioButton32.Name = "radioButton32";
            this.radioButton32.Size = new System.Drawing.Size(61, 33);
            this.radioButton32.TabIndex = 29;
            this.radioButton32.Text = "13";
            this.radioButton32.UseVisualStyleBackColor = true;
            this.radioButton32.CheckedChanged += new System.EventHandler(this.radioButton32_CheckedChanged);
            // 
            // radioButton19
            // 
            this.radioButton19.AutoSize = true;
            this.radioButton19.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton19.Location = new System.Drawing.Point(169, 100);
            this.radioButton19.Name = "radioButton19";
            this.radioButton19.Size = new System.Drawing.Size(61, 33);
            this.radioButton19.TabIndex = 28;
            this.radioButton19.Text = "10";
            this.radioButton19.UseVisualStyleBackColor = true;
            this.radioButton19.CheckedChanged += new System.EventHandler(this.radioButton19_CheckedChanged);
            // 
            // radioButton20
            // 
            this.radioButton20.AutoSize = true;
            this.radioButton20.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton20.Location = new System.Drawing.Point(285, 100);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new System.Drawing.Size(61, 33);
            this.radioButton20.TabIndex = 27;
            this.radioButton20.Text = "11";
            this.radioButton20.UseVisualStyleBackColor = true;
            this.radioButton20.CheckedChanged += new System.EventHandler(this.radioButton20_CheckedChanged);
            // 
            // radioButton21
            // 
            this.radioButton21.AutoSize = true;
            this.radioButton21.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton21.Location = new System.Drawing.Point(401, 100);
            this.radioButton21.Name = "radioButton21";
            this.radioButton21.Size = new System.Drawing.Size(61, 33);
            this.radioButton21.TabIndex = 26;
            this.radioButton21.Text = "12";
            this.radioButton21.UseVisualStyleBackColor = true;
            this.radioButton21.CheckedChanged += new System.EventHandler(this.radioButton21_CheckedChanged);
            // 
            // radioButton22
            // 
            this.radioButton22.AutoSize = true;
            this.radioButton22.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton22.Location = new System.Drawing.Point(53, 100);
            this.radioButton22.Name = "radioButton22";
            this.radioButton22.Size = new System.Drawing.Size(46, 33);
            this.radioButton22.TabIndex = 25;
            this.radioButton22.Text = "9";
            this.radioButton22.UseVisualStyleBackColor = true;
            this.radioButton22.CheckedChanged += new System.EventHandler(this.radioButton22_CheckedChanged);
            // 
            // radioButton23
            // 
            this.radioButton23.AutoSize = true;
            this.radioButton23.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton23.Location = new System.Drawing.Point(169, 52);
            this.radioButton23.Name = "radioButton23";
            this.radioButton23.Size = new System.Drawing.Size(46, 33);
            this.radioButton23.TabIndex = 24;
            this.radioButton23.Text = "6";
            this.radioButton23.UseVisualStyleBackColor = true;
            this.radioButton23.CheckedChanged += new System.EventHandler(this.radioButton23_CheckedChanged);
            // 
            // radioButton24
            // 
            this.radioButton24.AutoSize = true;
            this.radioButton24.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton24.Location = new System.Drawing.Point(285, 52);
            this.radioButton24.Name = "radioButton24";
            this.radioButton24.Size = new System.Drawing.Size(46, 33);
            this.radioButton24.TabIndex = 23;
            this.radioButton24.Text = "7";
            this.radioButton24.UseVisualStyleBackColor = true;
            this.radioButton24.CheckedChanged += new System.EventHandler(this.radioButton24_CheckedChanged);
            // 
            // radioButton25
            // 
            this.radioButton25.AutoSize = true;
            this.radioButton25.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton25.Location = new System.Drawing.Point(401, 52);
            this.radioButton25.Name = "radioButton25";
            this.radioButton25.Size = new System.Drawing.Size(46, 33);
            this.radioButton25.TabIndex = 22;
            this.radioButton25.Text = "8";
            this.radioButton25.UseVisualStyleBackColor = true;
            this.radioButton25.CheckedChanged += new System.EventHandler(this.radioButton25_CheckedChanged);
            // 
            // radioButton26
            // 
            this.radioButton26.AutoSize = true;
            this.radioButton26.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton26.Location = new System.Drawing.Point(53, 52);
            this.radioButton26.Name = "radioButton26";
            this.radioButton26.Size = new System.Drawing.Size(46, 33);
            this.radioButton26.TabIndex = 21;
            this.radioButton26.Text = "5";
            this.radioButton26.UseVisualStyleBackColor = true;
            this.radioButton26.CheckedChanged += new System.EventHandler(this.radioButton26_CheckedChanged);
            // 
            // radioButton27
            // 
            this.radioButton27.AutoSize = true;
            this.radioButton27.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton27.Location = new System.Drawing.Point(169, 3);
            this.radioButton27.Name = "radioButton27";
            this.radioButton27.Size = new System.Drawing.Size(46, 33);
            this.radioButton27.TabIndex = 20;
            this.radioButton27.Text = "2";
            this.radioButton27.UseVisualStyleBackColor = true;
            this.radioButton27.CheckedChanged += new System.EventHandler(this.radioButton27_CheckedChanged);
            // 
            // radioButton28
            // 
            this.radioButton28.AutoSize = true;
            this.radioButton28.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton28.Location = new System.Drawing.Point(285, 3);
            this.radioButton28.Name = "radioButton28";
            this.radioButton28.Size = new System.Drawing.Size(46, 33);
            this.radioButton28.TabIndex = 19;
            this.radioButton28.Text = "3";
            this.radioButton28.UseVisualStyleBackColor = true;
            this.radioButton28.CheckedChanged += new System.EventHandler(this.radioButton28_CheckedChanged);
            // 
            // radioButton29
            // 
            this.radioButton29.AutoSize = true;
            this.radioButton29.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton29.Location = new System.Drawing.Point(401, 3);
            this.radioButton29.Name = "radioButton29";
            this.radioButton29.Size = new System.Drawing.Size(46, 33);
            this.radioButton29.TabIndex = 18;
            this.radioButton29.Text = "4";
            this.radioButton29.UseVisualStyleBackColor = true;
            this.radioButton29.CheckedChanged += new System.EventHandler(this.radioButton29_CheckedChanged);
            // 
            // radioButton30
            // 
            this.radioButton30.AutoSize = true;
            this.radioButton30.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton30.Location = new System.Drawing.Point(53, 3);
            this.radioButton30.Name = "radioButton30";
            this.radioButton30.Size = new System.Drawing.Size(46, 33);
            this.radioButton30.TabIndex = 17;
            this.radioButton30.Text = "1";
            this.radioButton30.UseVisualStyleBackColor = true;
            this.radioButton30.CheckedChanged += new System.EventHandler(this.radioButton30_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(288, 335);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(242, 50);
            this.textBox2.TabIndex = 31;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(158, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 64);
            this.label4.TabIndex = 30;
            this.label4.Text = "番数";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(157, 612);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 50);
            this.label5.TabIndex = 36;
            this.label5.Text = "胡牌";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Font = new System.Drawing.Font("楷体", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(375, 796);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 107);
            this.button2.TabIndex = 41;
            this.button2.Text = "荣和";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton35
            // 
            this.radioButton35.AutoSize = true;
            this.radioButton35.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton35.Location = new System.Drawing.Point(220, 19);
            this.radioButton35.Name = "radioButton35";
            this.radioButton35.Size = new System.Drawing.Size(89, 33);
            this.radioButton35.TabIndex = 44;
            this.radioButton35.Text = "三家";
            this.radioButton35.UseVisualStyleBackColor = true;
            // 
            // radioButton36
            // 
            this.radioButton36.AutoSize = true;
            this.radioButton36.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton36.Location = new System.Drawing.Point(113, 19);
            this.radioButton36.Name = "radioButton36";
            this.radioButton36.Size = new System.Drawing.Size(89, 33);
            this.radioButton36.TabIndex = 43;
            this.radioButton36.Text = "二家";
            this.radioButton36.UseVisualStyleBackColor = true;
            // 
            // radioButton37
            // 
            this.radioButton37.AutoSize = true;
            this.radioButton37.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton37.Location = new System.Drawing.Point(6, 19);
            this.radioButton37.Name = "radioButton37";
            this.radioButton37.Size = new System.Drawing.Size(89, 33);
            this.radioButton37.TabIndex = 42;
            this.radioButton37.Text = "一家";
            this.radioButton37.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton35);
            this.panel3.Controls.Add(this.radioButton36);
            this.panel3.Controls.Add(this.radioButton37);
            this.panel3.Location = new System.Drawing.Point(253, 604);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 66);
            this.panel3.TabIndex = 45;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radioButton41);
            this.panel4.Controls.Add(this.radioButton42);
            this.panel4.Controls.Add(this.radioButton43);
            this.panel4.Location = new System.Drawing.Point(253, 676);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(307, 66);
            this.panel4.TabIndex = 47;
            // 
            // radioButton41
            // 
            this.radioButton41.AutoSize = true;
            this.radioButton41.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton41.Location = new System.Drawing.Point(220, 19);
            this.radioButton41.Name = "radioButton41";
            this.radioButton41.Size = new System.Drawing.Size(89, 33);
            this.radioButton41.TabIndex = 44;
            this.radioButton41.Text = "三家";
            this.radioButton41.UseVisualStyleBackColor = true;
            // 
            // radioButton42
            // 
            this.radioButton42.AutoSize = true;
            this.radioButton42.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton42.Location = new System.Drawing.Point(113, 19);
            this.radioButton42.Name = "radioButton42";
            this.radioButton42.Size = new System.Drawing.Size(89, 33);
            this.radioButton42.TabIndex = 43;
            this.radioButton42.Text = "二家";
            this.radioButton42.UseVisualStyleBackColor = true;
            // 
            // radioButton43
            // 
            this.radioButton43.AutoSize = true;
            this.radioButton43.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton43.Location = new System.Drawing.Point(6, 19);
            this.radioButton43.Name = "radioButton43";
            this.radioButton43.Size = new System.Drawing.Size(89, 33);
            this.radioButton43.TabIndex = 42;
            this.radioButton43.Text = "一家";
            this.radioButton43.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(157, 684);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 50);
            this.label7.TabIndex = 46;
            this.label7.Text = "放铳";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("楷体", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(1451, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(430, 97);
            this.label6.TabIndex = 48;
            this.label6.Text = "比赛场次";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Font = new System.Drawing.Font("楷体", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(637, 796);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 107);
            this.button3.TabIndex = 49;
            this.button3.Text = "流局";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(1116, 769);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 48);
            this.label8.TabIndex = 50;
            this.label8.Text = "剩余点数";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(1116, 857);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 48);
            this.label9.TabIndex = 51;
            this.label9.Text = "胡牌次数";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(1903, 604);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 48);
            this.label11.TabIndex = 53;
            this.label11.Text = "三家";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(1657, 604);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 48);
            this.label12.TabIndex = 54;
            this.label12.Text = "二家";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(1411, 604);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 48);
            this.label13.TabIndex = 55;
            this.label13.Text = "一家";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(1411, 769);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 48);
            this.label10.TabIndex = 56;
            this.label10.Text = "点数";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(1657, 769);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 48);
            this.label14.TabIndex = 57;
            this.label14.Text = "点数";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(1903, 769);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 48);
            this.label15.TabIndex = 58;
            this.label15.Text = "点数";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(1411, 857);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 48);
            this.label16.TabIndex = 59;
            this.label16.Text = "次数";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(1657, 857);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 48);
            this.label17.TabIndex = 60;
            this.label17.Text = "次数";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(1903, 857);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(116, 48);
            this.label18.TabIndex = 61;
            this.label18.Text = "次数";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(668, -61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(777, 489);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1613, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(246, 253);
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(568, 683);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 50);
            this.label19.TabIndex = 64;
            this.label19.Text = "立直";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(682, 697);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 33);
            this.checkBox1.TabIndex = 65;
            this.checkBox1.Text = "一家";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox2.Location = new System.Drawing.Point(778, 697);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(90, 33);
            this.checkBox2.TabIndex = 66;
            this.checkBox2.Text = "二家";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox3.Location = new System.Drawing.Point(874, 697);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(90, 33);
            this.checkBox3.TabIndex = 67;
            this.checkBox3.Text = "三家";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(1411, 681);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 48);
            this.label20.TabIndex = 68;
            this.label20.Text = "+0";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(1657, 681);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 48);
            this.label21.TabIndex = 69;
            this.label21.Text = "+0";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(1903, 683);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 48);
            this.label22.TabIndex = 70;
            this.label22.Text = "+0";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(1116, 681);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(212, 48);
            this.label23.TabIndex = 71;
            this.label23.Text = "点数变化";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(2100, 984);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Apple-MahJong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label 一家;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton16;
        private System.Windows.Forms.RadioButton radioButton17;
        private System.Windows.Forms.RadioButton radioButton18;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton19;
        private System.Windows.Forms.RadioButton radioButton20;
        private System.Windows.Forms.RadioButton radioButton21;
        private System.Windows.Forms.RadioButton radioButton22;
        private System.Windows.Forms.RadioButton radioButton23;
        private System.Windows.Forms.RadioButton radioButton24;
        private System.Windows.Forms.RadioButton radioButton25;
        private System.Windows.Forms.RadioButton radioButton26;
        private System.Windows.Forms.RadioButton radioButton27;
        private System.Windows.Forms.RadioButton radioButton28;
        private System.Windows.Forms.RadioButton radioButton29;
        private System.Windows.Forms.RadioButton radioButton30;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton33;
        private System.Windows.Forms.RadioButton radioButton31;
        private System.Windows.Forms.RadioButton radioButton32;
        private System.Windows.Forms.RadioButton radioButton34;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton35;
        private System.Windows.Forms.RadioButton radioButton36;
        private System.Windows.Forms.RadioButton radioButton37;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioButton41;
        private System.Windows.Forms.RadioButton radioButton42;
        private System.Windows.Forms.RadioButton radioButton43;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
    }
}

