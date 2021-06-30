
namespace ListaTutores
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID_TUTOR = new System.Windows.Forms.TextBox();
            this.txtNOMBRES = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAPELLIDOS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDIRECCION = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTITULO_ACADEMICO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFNACIMIENTO = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgLista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTA DE TUTORES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID_TUTOR";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtID_TUTOR
            // 
            this.txtID_TUTOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtID_TUTOR.Location = new System.Drawing.Point(210, 12);
            this.txtID_TUTOR.Name = "txtID_TUTOR";
            this.txtID_TUTOR.Size = new System.Drawing.Size(215, 26);
            this.txtID_TUTOR.TabIndex = 2;
            // 
            // txtNOMBRES
            // 
            this.txtNOMBRES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNOMBRES.Location = new System.Drawing.Point(210, 44);
            this.txtNOMBRES.Name = "txtNOMBRES";
            this.txtNOMBRES.Size = new System.Drawing.Size(215, 26);
            this.txtNOMBRES.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "NOMBRES";
            // 
            // txtAPELLIDOS
            // 
            this.txtAPELLIDOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAPELLIDOS.Location = new System.Drawing.Point(210, 76);
            this.txtAPELLIDOS.Name = "txtAPELLIDOS";
            this.txtAPELLIDOS.Size = new System.Drawing.Size(215, 26);
            this.txtAPELLIDOS.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "APELLIDOS";
            // 
            // txtDIRECCION
            // 
            this.txtDIRECCION.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDIRECCION.Location = new System.Drawing.Point(210, 140);
            this.txtDIRECCION.Name = "txtDIRECCION";
            this.txtDIRECCION.Size = new System.Drawing.Size(215, 26);
            this.txtDIRECCION.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "DIRECCION";
            // 
            // txtTITULO_ACADEMICO
            // 
            this.txtTITULO_ACADEMICO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTITULO_ACADEMICO.Location = new System.Drawing.Point(210, 108);
            this.txtTITULO_ACADEMICO.Name = "txtTITULO_ACADEMICO";
            this.txtTITULO_ACADEMICO.Size = new System.Drawing.Size(215, 26);
            this.txtTITULO_ACADEMICO.TabIndex = 10;
            this.txtTITULO_ACADEMICO.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "TITULO_ACADEMICO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "F.NACIMIENTO";
            // 
            // txtFNACIMIENTO
            // 
            this.txtFNACIMIENTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFNACIMIENTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFNACIMIENTO.Location = new System.Drawing.Point(210, 172);
            this.txtFNACIMIENTO.Name = "txtFNACIMIENTO";
            this.txtFNACIMIENTO.Size = new System.Drawing.Size(215, 26);
            this.txtFNACIMIENTO.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(459, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 26);
            this.button1.TabIndex = 13;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(459, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 29);
            this.button2.TabIndex = 14;
            this.button2.Text = "CONSULTAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(459, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 29);
            this.button3.TabIndex = 15;
            this.button3.Text = "ACTUALIZAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Location = new System.Drawing.Point(459, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 26);
            this.button4.TabIndex = 16;
            this.button4.Text = "ELIMINAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgLista
            // 
            this.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLista.Location = new System.Drawing.Point(12, 245);
            this.dgLista.Name = "dgLista";
            this.dgLista.Size = new System.Drawing.Size(592, 152);
            this.dgLista.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 407);
            this.Controls.Add(this.dgLista);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFNACIMIENTO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTITULO_ACADEMICO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDIRECCION);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAPELLIDOS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNOMBRES);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID_TUTOR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID_TUTOR;
        private System.Windows.Forms.TextBox txtNOMBRES;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAPELLIDOS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDIRECCION;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTITULO_ACADEMICO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtFNACIMIENTO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgLista;
    }
}

