
namespace carauto
{
    partial class mainPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CarList = new System.Windows.Forms.Button();
            this.Leave = new System.Windows.Forms.Button();
            this.Sales = new System.Windows.Forms.Button();
            this.Agreement = new System.Windows.Forms.Button();
            this.CarReg = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.CarList);
            this.panel1.Controls.Add(this.Leave);
            this.panel1.Controls.Add(this.Sales);
            this.panel1.Controls.Add(this.Agreement);
            this.panel1.Controls.Add(this.CarReg);
            this.panel1.Controls.Add(this.List);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 114);
            this.panel1.TabIndex = 0;
            // 
            // CarList
            // 
            this.CarList.Location = new System.Drawing.Point(336, 28);
            this.CarList.Name = "CarList";
            this.CarList.Size = new System.Drawing.Size(102, 59);
            this.CarList.TabIndex = 0;
            this.CarList.Text = "Car List";
            this.CarList.UseVisualStyleBackColor = true;
            this.CarList.Click += new System.EventHandler(this.CarList_Click);
            // 
            // Leave
            // 
            this.Leave.Location = new System.Drawing.Point(660, 28);
            this.Leave.Name = "Leave";
            this.Leave.Size = new System.Drawing.Size(102, 59);
            this.Leave.TabIndex = 0;
            this.Leave.Text = "Leave";
            this.Leave.UseVisualStyleBackColor = true;
            this.Leave.Click += new System.EventHandler(this.button7_Click);
            // 
            // Sales
            // 
            this.Sales.Location = new System.Drawing.Point(552, 28);
            this.Sales.Name = "Sales";
            this.Sales.Size = new System.Drawing.Size(102, 59);
            this.Sales.TabIndex = 0;
            this.Sales.Text = "Sales";
            this.Sales.UseVisualStyleBackColor = true;
            this.Sales.Click += new System.EventHandler(this.Sales_Click);
            // 
            // Agreement
            // 
            this.Agreement.Location = new System.Drawing.Point(444, 28);
            this.Agreement.Name = "Agreement";
            this.Agreement.Size = new System.Drawing.Size(102, 59);
            this.Agreement.TabIndex = 0;
            this.Agreement.Text = "Agreement";
            this.Agreement.UseVisualStyleBackColor = true;
            this.Agreement.Click += new System.EventHandler(this.Agreement_Click);
            // 
            // CarReg
            // 
            this.CarReg.Location = new System.Drawing.Point(228, 28);
            this.CarReg.Name = "CarReg";
            this.CarReg.Size = new System.Drawing.Size(102, 59);
            this.CarReg.TabIndex = 0;
            this.CarReg.Text = "Car Reg.";
            this.CarReg.UseVisualStyleBackColor = true;
            this.CarReg.Click += new System.EventHandler(this.CarReg_Click);
            // 
            // List
            // 
            this.List.Location = new System.Drawing.Point(120, 28);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(102, 59);
            this.List.TabIndex = 0;
            this.List.Text = "List";
            this.List.UseVisualStyleBackColor = true;
            this.List.Click += new System.EventHandler(this.List_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(12, 28);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(102, 59);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(777, 456);
            this.Controls.Add(this.panel1);
            this.Name = "mainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CarList;
        private System.Windows.Forms.Button Leave;
        private System.Windows.Forms.Button Sales;
        private System.Windows.Forms.Button Agreement;
        private System.Windows.Forms.Button CarReg;
        private System.Windows.Forms.Button List;
        private System.Windows.Forms.Button Add;
    }
}

