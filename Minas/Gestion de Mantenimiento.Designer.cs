namespace Minas
{
    partial class Gestion_Mantenimiento
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
            this.button1 = new System.Windows.Forms.Button();
            this.datat = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.datat1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datat1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Listar Solicitudes de Mantenimiento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datat
            // 
            this.datat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datat.Location = new System.Drawing.Point(31, 12);
            this.datat.Name = "datat";
            this.datat.Size = new System.Drawing.Size(632, 154);
            this.datat.TabIndex = 1;
            this.datat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datat_CellClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(517, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Agendar Mantenimiento";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // datat1
            // 
            this.datat1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datat1.Location = new System.Drawing.Point(239, 172);
            this.datat1.Name = "datat1";
            this.datat1.Size = new System.Drawing.Size(424, 113);
            this.datat1.TabIndex = 3;
            this.datat1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datat1_CellClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Listar Tecnicos de Mantenimiento";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 361);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.datat1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.datat);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Gestion de Mantenimiento";
            ((System.ComponentModel.ISupportInitialize)(this.datat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datat1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView datat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView datat1;
        private System.Windows.Forms.Button button3;
    }
}

