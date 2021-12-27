
namespace carauto
{
    partial class frmVehicleRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nptxt = new System.Windows.Forms.TextBox();
            this.Brandcombo = new System.Windows.Forms.ComboBox();
            this.Seriescombo = new System.Windows.Forms.ComboBox();
            this.Yeartxt = new System.Windows.Forms.TextBox();
            this.Colortxt = new System.Windows.Forms.TextBox();
            this.Kmtxt = new System.Windows.Forms.TextBox();
            this.Fuelcombo = new System.Windows.Forms.ComboBox();
            this.RPtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPic = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nptxt
            // 
            this.Nptxt.Location = new System.Drawing.Point(109, 39);
            this.Nptxt.Name = "Nptxt";
            this.Nptxt.Size = new System.Drawing.Size(175, 20);
            this.Nptxt.TabIndex = 0;
            // 
            // Brandcombo
            // 
            this.Brandcombo.FormattingEnabled = true;
            this.Brandcombo.Items.AddRange(new object[] {
            "Mercedes",
            "BMW",
            "Opel",
            "Volkswagen"});
            this.Brandcombo.Location = new System.Drawing.Point(109, 77);
            this.Brandcombo.Name = "Brandcombo";
            this.Brandcombo.Size = new System.Drawing.Size(175, 21);
            this.Brandcombo.TabIndex = 1;
            this.Brandcombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Seriescombo
            // 
            this.Seriescombo.FormattingEnabled = true;
            this.Seriescombo.Location = new System.Drawing.Point(109, 116);
            this.Seriescombo.Name = "Seriescombo";
            this.Seriescombo.Size = new System.Drawing.Size(175, 21);
            this.Seriescombo.TabIndex = 2;
            // 
            // Yeartxt
            // 
            this.Yeartxt.Location = new System.Drawing.Point(109, 155);
            this.Yeartxt.Name = "Yeartxt";
            this.Yeartxt.Size = new System.Drawing.Size(175, 20);
            this.Yeartxt.TabIndex = 3;
            // 
            // Colortxt
            // 
            this.Colortxt.Location = new System.Drawing.Point(109, 193);
            this.Colortxt.Name = "Colortxt";
            this.Colortxt.Size = new System.Drawing.Size(175, 20);
            this.Colortxt.TabIndex = 4;
            // 
            // Kmtxt
            // 
            this.Kmtxt.Location = new System.Drawing.Point(109, 231);
            this.Kmtxt.Name = "Kmtxt";
            this.Kmtxt.Size = new System.Drawing.Size(175, 20);
            this.Kmtxt.TabIndex = 5;
            // 
            // Fuelcombo
            // 
            this.Fuelcombo.FormattingEnabled = true;
            this.Fuelcombo.Items.AddRange(new object[] {
            "Diesel Fuel",
            "Gasoline",
            "Gasoline + LPG"});
            this.Fuelcombo.Location = new System.Drawing.Point(109, 269);
            this.Fuelcombo.Name = "Fuelcombo";
            this.Fuelcombo.Size = new System.Drawing.Size(175, 21);
            this.Fuelcombo.TabIndex = 6;
            // 
            // RPtxt
            // 
            this.RPtxt.Location = new System.Drawing.Point(109, 308);
            this.RPtxt.Name = "RPtxt";
            this.RPtxt.Size = new System.Drawing.Size(175, 20);
            this.RPtxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number Plate";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Brand";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Series";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Model (Year)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Color";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Km";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fuel";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Rent Price";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(336, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 17;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 47);
            this.button2.TabIndex = 18;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPic
            // 
            this.btnPic.Location = new System.Drawing.Point(379, 216);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(102, 49);
            this.btnPic.TabIndex = 19;
            this.btnPic.Text = "Add Picture";
            this.btnPic.UseVisualStyleBackColor = true;
            this.btnPic.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmVehicleRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btnPic);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RPtxt);
            this.Controls.Add(this.Fuelcombo);
            this.Controls.Add(this.Kmtxt);
            this.Controls.Add(this.Colortxt);
            this.Controls.Add(this.Yeartxt);
            this.Controls.Add(this.Seriescombo);
            this.Controls.Add(this.Brandcombo);
            this.Controls.Add(this.Nptxt);
            this.Name = "frmVehicleRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Registration Form";
            this.Load += new System.EventHandler(this.frmVehicleRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nptxt;
        private System.Windows.Forms.ComboBox Brandcombo;
        private System.Windows.Forms.ComboBox Seriescombo;
        private System.Windows.Forms.TextBox Yeartxt;
        private System.Windows.Forms.TextBox Colortxt;
        private System.Windows.Forms.TextBox Kmtxt;
        private System.Windows.Forms.ComboBox Fuelcombo;
        private System.Windows.Forms.TextBox RPtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}