namespace pryGDI_Marconi_LabSemestre3
{
    partial class frmArk
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
            this.components = new System.ComponentModel.Container();
            this.picNave = new System.Windows.Forms.PictureBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.contenedor = new System.Windows.Forms.PictureBox();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picNave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contenedor)).BeginInit();
            this.SuspendLayout();
            // 
            // picNave
            // 
            this.picNave.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picNave.Location = new System.Drawing.Point(269, 377);
            this.picNave.Name = "picNave";
            this.picNave.Size = new System.Drawing.Size(100, 26);
            this.picNave.TabIndex = 5;
            this.picNave.TabStop = false;
            this.picNave.Click += new System.EventHandler(this.picNave_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(212, 147);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(204, 133);
            this.btnJugar.TabIndex = 4;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // contenedor
            // 
            this.contenedor.Location = new System.Drawing.Point(-1, -1);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(611, 457);
            this.contenedor.TabIndex = 3;
            this.contenedor.TabStop = false;
            // 
            // temporizador
            // 
            this.temporizador.Tick += new System.EventHandler(this.temporizador_Tick);
            // 
            // frmArk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 457);
            this.Controls.Add(this.picNave);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.contenedor);
            this.Name = "frmArk";
            this.Text = "ARK";
            this.Load += new System.EventHandler(this.frmArk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contenedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picNave;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.PictureBox contenedor;
        private System.Windows.Forms.Timer temporizador;
    }
}