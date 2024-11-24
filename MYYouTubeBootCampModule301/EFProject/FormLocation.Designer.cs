namespace EFProject
{
    partial class FormLocation
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
            this.buttonGetById = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDayNight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownCapacity = new System.Windows.Forms.NumericUpDown();
            this.comboBoxGuide = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(282, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 446);
            this.dataGridView1.TabIndex = 23;
            // 
            // buttonGetById
            // 
            this.buttonGetById.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonGetById.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetById.ForeColor = System.Drawing.Color.Maroon;
            this.buttonGetById.Location = new System.Drawing.Point(114, 438);
            this.buttonGetById.Name = "buttonGetById";
            this.buttonGetById.Size = new System.Drawing.Size(140, 34);
            this.buttonGetById.TabIndex = 22;
            this.buttonGetById.Text = "ID\'ye Göre Getir";
            this.buttonGetById.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.Maroon;
            this.buttonUpdate.Location = new System.Drawing.Point(114, 401);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(140, 34);
            this.buttonUpdate.TabIndex = 21;
            this.buttonUpdate.Text = "Güncelle";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Maroon;
            this.buttonDelete.Location = new System.Drawing.Point(114, 364);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(140, 34);
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.Text = "Sil";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Maroon;
            this.buttonAdd.Location = new System.Drawing.Point(114, 327);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(140, 34);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Ekle";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ülke :";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(114, 100);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(141, 20);
            this.textBoxCountry.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Şehir : ";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(114, 63);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(141, 20);
            this.textBoxCity.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lokasyon ID :";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(114, 26);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(141, 20);
            this.textBoxId.TabIndex = 13;
            // 
            // buttonList
            // 
            this.buttonList.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonList.ForeColor = System.Drawing.Color.Maroon;
            this.buttonList.Location = new System.Drawing.Point(114, 290);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(140, 34);
            this.buttonList.TabIndex = 12;
            this.buttonList.Text = "Listele";
            this.buttonList.UseVisualStyleBackColor = false;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Kapasite :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Fiyat :";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(114, 174);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(141, 20);
            this.textBoxPrice.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Gün / Gece :";
            // 
            // textBoxDayNight
            // 
            this.textBoxDayNight.Location = new System.Drawing.Point(114, 211);
            this.textBoxDayNight.Name = "textBoxDayNight";
            this.textBoxDayNight.Size = new System.Drawing.Size(141, 20);
            this.textBoxDayNight.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Rehber :";
            // 
            // numericUpDownCapacity
            // 
            this.numericUpDownCapacity.Location = new System.Drawing.Point(114, 137);
            this.numericUpDownCapacity.Name = "numericUpDownCapacity";
            this.numericUpDownCapacity.Size = new System.Drawing.Size(141, 20);
            this.numericUpDownCapacity.TabIndex = 32;
            // 
            // comboBoxGuide
            // 
            this.comboBoxGuide.FormattingEnabled = true;
            this.comboBoxGuide.Location = new System.Drawing.Point(114, 248);
            this.comboBoxGuide.Name = "comboBoxGuide";
            this.comboBoxGuide.Size = new System.Drawing.Size(141, 21);
            this.comboBoxGuide.TabIndex = 33;
            // 
            // FormLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.comboBoxGuide);
            this.Controls.Add(this.numericUpDownCapacity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDayNight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonGetById);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lokasyon İşlemleri";
            this.Load += new System.EventHandler(this.FormLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonGetById;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDayNight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownCapacity;
        private System.Windows.Forms.ComboBox comboBoxGuide;
    }
}