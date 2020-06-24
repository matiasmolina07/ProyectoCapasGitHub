namespace UI
{
    partial class FormSQL
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxCat = new System.Windows.Forms.TextBox();
            this.textBoxDESC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtvgProductos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRemovProd = new System.Windows.Forms.Button();
            this.btnAltaProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(152, 75);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(180, 20);
            this.textBoxID.TabIndex = 0;
            // 
            // textBoxCat
            // 
            this.textBoxCat.Location = new System.Drawing.Point(152, 118);
            this.textBoxCat.Name = "textBoxCat";
            this.textBoxCat.Size = new System.Drawing.Size(180, 20);
            this.textBoxCat.TabIndex = 1;
            // 
            // textBoxDESC
            // 
            this.textBoxDESC.Location = new System.Drawing.Point(152, 162);
            this.textBoxDESC.Name = "textBoxDESC";
            this.textBoxDESC.Size = new System.Drawing.Size(180, 20);
            this.textBoxDESC.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(23, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID_Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(23, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(23, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(125, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "STOCK PRODUCTOS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtvgProductos
            // 
            this.dtvgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvgProductos.Location = new System.Drawing.Point(346, 51);
            this.dtvgProductos.Name = "dtvgProductos";
            this.dtvgProductos.RowTemplate.Height = 28;
            this.dtvgProductos.Size = new System.Drawing.Size(456, 150);
            this.dtvgProductos.TabIndex = 11;
            this.dtvgProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvgProductos_CellClick);
            this.dtvgProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvgProductos_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.e_commerce;
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::UI.Properties.Resources.updatechica;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(651, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Modificar Producto";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemovProd
            // 
            this.btnRemovProd.BackColor = System.Drawing.Color.White;
            this.btnRemovProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovProd.ForeColor = System.Drawing.Color.Black;
            this.btnRemovProd.Image = global::UI.Properties.Resources.removechica;
            this.btnRemovProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemovProd.Location = new System.Drawing.Point(492, 215);
            this.btnRemovProd.Name = "btnRemovProd";
            this.btnRemovProd.Size = new System.Drawing.Size(134, 46);
            this.btnRemovProd.TabIndex = 7;
            this.btnRemovProd.Text = "Borrar Producto";
            this.btnRemovProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemovProd.UseVisualStyleBackColor = false;
            this.btnRemovProd.Click += new System.EventHandler(this.btnRemovProd_Click);
            // 
            // btnAltaProd
            // 
            this.btnAltaProd.BackColor = System.Drawing.Color.White;
            this.btnAltaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaProd.ForeColor = System.Drawing.Color.Black;
            this.btnAltaProd.Image = global::UI.Properties.Resources.addchica;
            this.btnAltaProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaProd.Location = new System.Drawing.Point(353, 215);
            this.btnAltaProd.Name = "btnAltaProd";
            this.btnAltaProd.Size = new System.Drawing.Size(118, 46);
            this.btnAltaProd.TabIndex = 6;
            this.btnAltaProd.Text = "Alta Producto";
            this.btnAltaProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAltaProd.UseVisualStyleBackColor = false;
            this.btnAltaProd.Click += new System.EventHandler(this.btnAltaProd_Click);
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(814, 282);
            this.Controls.Add(this.dtvgProductos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRemovProd);
            this.Controls.Add(this.btnAltaProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDESC);
            this.Controls.Add(this.textBoxCat);
            this.Controls.Add(this.textBoxID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(32, 280);
            this.Name = "FormSQL";
            this.ShowIcon = false;
            this.Text = "Productos - Stock";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormSQL_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtvgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxCat;
        private System.Windows.Forms.TextBox textBoxDESC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAltaProd;
        private System.Windows.Forms.Button btnRemovProd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtvgProductos;
    }
}