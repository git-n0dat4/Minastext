namespace Minas
{
    partial class Informe_Mantenimiento
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataSolicitudes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Atender";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(666, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Finalizado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataSolicitudes
            // 
            this.dataSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSolicitudes.Location = new System.Drawing.Point(12, 12);
            this.dataSolicitudes.Name = "dataSolicitudes";
            this.dataSolicitudes.Size = new System.Drawing.Size(581, 184);
            this.dataSolicitudes.TabIndex = 2;
            this.dataSolicitudes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSolicitudes_CellClick);
            this.dataSolicitudes.MouseEnter += new System.EventHandler(this.dataSolicitudes_MouseEnter);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 222);
            this.Controls.Add(this.dataSolicitudes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Informe Mantenimiento";
            ((System.ComponentModel.ISupportInitialize)(this.dataSolicitudes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataSolicitudes;
    }
}