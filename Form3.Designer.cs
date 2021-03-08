
namespace Lab_2_repaso
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textNIT = new System.Windows.Forms.TextBox();
            this.textLicensePlate = new System.Windows.Forms.TextBox();
            this.textKilometers = new System.Windows.Forms.TextBox();
            this.calendarRental = new System.Windows.Forms.MonthCalendar();
            this.calendarReturn = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.labelKilometers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIT";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(533, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 80);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "License plate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rental date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Return date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 581);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kilometers traveled";
            // 
            // textNIT
            // 
            this.textNIT.Location = new System.Drawing.Point(176, 24);
            this.textNIT.Name = "textNIT";
            this.textNIT.Size = new System.Drawing.Size(262, 22);
            this.textNIT.TabIndex = 6;
            // 
            // textLicensePlate
            // 
            this.textLicensePlate.Location = new System.Drawing.Point(176, 70);
            this.textLicensePlate.Name = "textLicensePlate";
            this.textLicensePlate.Size = new System.Drawing.Size(262, 22);
            this.textLicensePlate.TabIndex = 7;
            // 
            // textKilometers
            // 
            this.textKilometers.Location = new System.Drawing.Point(176, 584);
            this.textKilometers.Name = "textKilometers";
            this.textKilometers.Size = new System.Drawing.Size(262, 22);
            this.textKilometers.TabIndex = 8;
            // 
            // calendarRental
            // 
            this.calendarRental.Location = new System.Drawing.Point(176, 121);
            this.calendarRental.Name = "calendarRental";
            this.calendarRental.TabIndex = 9;
            // 
            // calendarReturn
            // 
            this.calendarReturn.Location = new System.Drawing.Point(176, 355);
            this.calendarReturn.Name = "calendarReturn";
            this.calendarReturn.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(690, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(480, 316);
            this.dataGridView1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(747, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(364, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Car with the most kilometers traveled";
            // 
            // labelKilometers
            // 
            this.labelKilometers.AutoSize = true;
            this.labelKilometers.Location = new System.Drawing.Point(866, 410);
            this.labelKilometers.Name = "labelKilometers";
            this.labelKilometers.Size = new System.Drawing.Size(153, 17);
            this.labelKilometers.TabIndex = 13;
            this.labelKilometers.Text = "-----------------------------";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 627);
            this.Controls.Add(this.labelKilometers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.calendarReturn);
            this.Controls.Add(this.calendarRental);
            this.Controls.Add(this.textKilometers);
            this.Controls.Add(this.textLicensePlate);
            this.Controls.Add(this.textNIT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNIT;
        private System.Windows.Forms.TextBox textLicensePlate;
        private System.Windows.Forms.TextBox textKilometers;
        private System.Windows.Forms.MonthCalendar calendarRental;
        private System.Windows.Forms.MonthCalendar calendarReturn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelKilometers;
    }
}