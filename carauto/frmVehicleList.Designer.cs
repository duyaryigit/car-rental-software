
namespace carauto
{
    partial class frmVehicleList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboVehicles = new System.Windows.Forms.ComboBox();
            this.btnPic = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RPtxt = new System.Windows.Forms.TextBox();
            this.Fuelcombo = new System.Windows.Forms.ComboBox();
            this.Kmtxt = new System.Windows.Forms.TextBox();
            this.Colortxt = new System.Windows.Forms.TextBox();
            this.Yeartxt = new System.Windows.Forms.TextBox();
            this.Seriescombo = new System.Windows.Forms.ComboBox();
            this.Brandcombo = new System.Windows.Forms.ComboBox();
            this.Nptxt = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(564, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 484);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // comboVehicles
            // 
            this.comboVehicles.FormattingEnabled = true;
            this.comboVehicles.Items.AddRange(new object[] {
            "All",
            "Not Rented",
            "Rented"});
            this.comboVehicles.Location = new System.Drawing.Point(1128, 44);
            this.comboVehicles.Name = "comboVehicles";
            this.comboVehicles.Size = new System.Drawing.Size(192, 21);
            this.comboVehicles.TabIndex = 1;
            this.comboVehicles.SelectedIndexChanged += new System.EventHandler(this.comboVehicles_SelectedIndexChanged);
            // 
            // btnPic
            // 
            this.btnPic.Location = new System.Drawing.Point(359, 254);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(102, 49);
            this.btnPic.TabIndex = 39;
            this.btnPic.Text = "Update Picture";
            this.btnPic.UseVisualStyleBackColor = true;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(189, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 47);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(89, 391);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 47);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Rent Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Fuel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Km";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Model (Year)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Series";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Brand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Number Plate";
            // 
            // RPtxt
            // 
            this.RPtxt.Location = new System.Drawing.Point(89, 346);
            this.RPtxt.Name = "RPtxt";
            this.RPtxt.Size = new System.Drawing.Size(175, 20);
            this.RPtxt.TabIndex = 27;
            // 
            // Fuelcombo
            // 
            this.Fuelcombo.FormattingEnabled = true;
            this.Fuelcombo.Items.AddRange(new object[] {
            "Diesel Fuel",
            "Gasoline",
            "Gasoline + LPG"});
            this.Fuelcombo.Location = new System.Drawing.Point(89, 307);
            this.Fuelcombo.Name = "Fuelcombo";
            this.Fuelcombo.Size = new System.Drawing.Size(175, 21);
            this.Fuelcombo.TabIndex = 26;
            // 
            // Kmtxt
            // 
            this.Kmtxt.Location = new System.Drawing.Point(89, 269);
            this.Kmtxt.Name = "Kmtxt";
            this.Kmtxt.Size = new System.Drawing.Size(175, 20);
            this.Kmtxt.TabIndex = 25;
            // 
            // Colortxt
            // 
            this.Colortxt.Location = new System.Drawing.Point(89, 231);
            this.Colortxt.Name = "Colortxt";
            this.Colortxt.Size = new System.Drawing.Size(175, 20);
            this.Colortxt.TabIndex = 24;
            // 
            // Yeartxt
            // 
            this.Yeartxt.Location = new System.Drawing.Point(89, 193);
            this.Yeartxt.Name = "Yeartxt";
            this.Yeartxt.Size = new System.Drawing.Size(175, 20);
            this.Yeartxt.TabIndex = 23;
            // 
            // Seriescombo
            // 
            this.Seriescombo.FormattingEnabled = true;
            this.Seriescombo.Location = new System.Drawing.Point(89, 154);
            this.Seriescombo.Name = "Seriescombo";
            this.Seriescombo.Size = new System.Drawing.Size(175, 21);
            this.Seriescombo.TabIndex = 22;
            this.Seriescombo.SelectedIndexChanged += new System.EventHandler(this.Seriescombo_SelectedIndexChanged);
            // 
            // Brandcombo
            // 
            this.Brandcombo.FormattingEnabled = true;
            this.Brandcombo.Items.AddRange(new object[] {
            "Mercedes",
            "BMW",
            "Opel",
            "Volkswagen"});
            this.Brandcombo.Location = new System.Drawing.Point(89, 115);
            this.Brandcombo.Name = "Brandcombo";
            this.Brandcombo.Size = new System.Drawing.Size(175, 21);
            this.Brandcombo.TabIndex = 21;
            this.Brandcombo.SelectedIndexChanged += new System.EventHandler(this.Brandcombo_SelectedIndexChanged);
            // 
            // Nptxt
            // 
            this.Nptxt.Location = new System.Drawing.Point(89, 77);
            this.Nptxt.Name = "Nptxt";
            this.Nptxt.Size = new System.Drawing.Size(175, 20);
            this.Nptxt.TabIndex = 20;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1344, 83);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 48);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(283, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(264, 157);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmVehicleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1458, 640);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPic);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
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
            this.Controls.Add(this.comboVehicles);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmVehicleList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle List Form";
            this.Load += new System.EventHandler(this.frmVehicleList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboVehicles;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RPtxt;
        private System.Windows.Forms.ComboBox Fuelcombo;
        private System.Windows.Forms.TextBox Kmtxt;
        private System.Windows.Forms.TextBox Colortxt;
        private System.Windows.Forms.TextBox Yeartxt;
        private System.Windows.Forms.ComboBox Seriescombo;
        private System.Windows.Forms.ComboBox Brandcombo;
        private System.Windows.Forms.TextBox Nptxt;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}