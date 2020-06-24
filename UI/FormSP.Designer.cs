namespace UI
{
    partial class FormSP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIDclient = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxTEL = new System.Windows.Forms.TextBox();
            this.textBoxMAIL = new System.Windows.Forms.TextBox();
            this.dtvgClientes = new System.Windows.Forms.DataGridView();
            this.btnModifCliente = new System.Windows.Forms.Button();
            this.btnRemovClient = new System.Windows.Forms.Button();
            this.btnAltaClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.ClienteChica;
            this.pictureBox1.Location = new System.Drawing.Point(25, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(95, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "REGISTRO CLIENTES";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(31, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(31, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(95, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID_Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(31, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(31, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tel";
            // 
            // textBoxIDclient
            // 
            this.textBoxIDclient.Location = new System.Drawing.Point(200, 63);
            this.textBoxIDclient.Name = "textBoxIDclient";
            this.textBoxIDclient.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDclient.TabIndex = 16;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(119, 105);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(180, 20);
            this.textBoxNombre.TabIndex = 17;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(120, 148);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(180, 20);
            this.textBoxApellido.TabIndex = 18;
            // 
            // textBoxTEL
            // 
            this.textBoxTEL.Location = new System.Drawing.Point(92, 187);
            this.textBoxTEL.Name = "textBoxTEL";
            this.textBoxTEL.Size = new System.Drawing.Size(208, 20);
            this.textBoxTEL.TabIndex = 19;
            // 
            // textBoxMAIL
            // 
            this.textBoxMAIL.Location = new System.Drawing.Point(91, 224);
            this.textBoxMAIL.Name = "textBoxMAIL";
            this.textBoxMAIL.Size = new System.Drawing.Size(208, 20);
            this.textBoxMAIL.TabIndex = 20;
            // 
            // dtvgClientes
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtvgClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtvgClientes.Location = new System.Drawing.Point(363, 29);
            this.dtvgClientes.Name = "dtvgClientes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvgClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtvgClientes.RowTemplate.Height = 28;
            this.dtvgClientes.Size = new System.Drawing.Size(456, 150);
            this.dtvgClientes.TabIndex = 21;
            // 
            // btnModifCliente
            // 
            this.btnModifCliente.BackColor = System.Drawing.Color.White;
            this.btnModifCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifCliente.ForeColor = System.Drawing.Color.Black;
            this.btnModifCliente.Image = global::UI.Properties.Resources.updatechica;
            this.btnModifCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifCliente.Location = new System.Drawing.Point(659, 204);
            this.btnModifCliente.Name = "btnModifCliente";
            this.btnModifCliente.Size = new System.Drawing.Size(133, 46);
            this.btnModifCliente.TabIndex = 24;
            this.btnModifCliente.Text = "Modifica Cliente";
            this.btnModifCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifCliente.UseVisualStyleBackColor = false;
            this.btnModifCliente.Click += new System.EventHandler(this.btnModifCliente_Click);
            // 
            // btnRemovClient
            // 
            this.btnRemovClient.BackColor = System.Drawing.Color.White;
            this.btnRemovClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovClient.ForeColor = System.Drawing.Color.Black;
            this.btnRemovClient.Image = global::UI.Properties.Resources.removechica;
            this.btnRemovClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemovClient.Location = new System.Drawing.Point(524, 204);
            this.btnRemovClient.Name = "btnRemovClient";
            this.btnRemovClient.Size = new System.Drawing.Size(117, 46);
            this.btnRemovClient.TabIndex = 23;
            this.btnRemovClient.Text = "Borrar Cliente";
            this.btnRemovClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemovClient.UseVisualStyleBackColor = false;
            this.btnRemovClient.Click += new System.EventHandler(this.btnRemovClient_Click);
            // 
            // btnAltaClient
            // 
            this.btnAltaClient.BackColor = System.Drawing.Color.White;
            this.btnAltaClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaClient.ForeColor = System.Drawing.Color.Black;
            this.btnAltaClient.Image = global::UI.Properties.Resources.addchica;
            this.btnAltaClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaClient.Location = new System.Drawing.Point(388, 204);
            this.btnAltaClient.Name = "btnAltaClient";
            this.btnAltaClient.Size = new System.Drawing.Size(107, 46);
            this.btnAltaClient.TabIndex = 22;
            this.btnAltaClient.Text = "Alta Cliente";
            this.btnAltaClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAltaClient.UseVisualStyleBackColor = false;
            this.btnAltaClient.Click += new System.EventHandler(this.btnAltaClient_Click);
            // 
            // FormSP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(868, 276);
            this.Controls.Add(this.btnModifCliente);
            this.Controls.Add(this.btnRemovClient);
            this.Controls.Add(this.btnAltaClient);
            this.Controls.Add(this.dtvgClientes);
            this.Controls.Add(this.textBoxMAIL);
            this.Controls.Add(this.textBoxTEL);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxIDclient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(32, 280);
            this.Name = "FormSP";
            this.ShowIcon = false;
            this.Text = "Registro de Clientes";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxIDclient;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxTEL;
        private System.Windows.Forms.TextBox textBoxMAIL;
        private System.Windows.Forms.DataGridView dtvgClientes;
        private System.Windows.Forms.Button btnModifCliente;
        private System.Windows.Forms.Button btnRemovClient;
        private System.Windows.Forms.Button btnAltaClient;
    }
}