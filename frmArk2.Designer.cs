﻿namespace pryGDI_Marconi_LabSemestre3
{
    partial class frmArk2
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
            this.contenedor = new System.Windows.Forms.PictureBox();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picNave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contenedor)).BeginInit();
            this.SuspendLayout();
            // 
            // picNave
            // 
            this.picNave.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picNave.Location = new System.Drawing.Point(365, 375);
            this.picNave.Name = "picNave";
            this.picNave.Size = new System.Drawing.Size(100, 26);
            this.picNave.TabIndex = 7;
            this.picNave.TabStop = false;
            // 
            // contenedor
            // 
            this.contenedor.Location = new System.Drawing.Point(-2, 0);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(805, 451);
            this.contenedor.TabIndex = 6;
            this.contenedor.TabStop = false;
            // 
            // temporizador
            // 
            this.temporizador.Tick += new System.EventHandler(this.temporizador_Tick);
            // 
            // frmArk2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picNave);
            this.Controls.Add(this.contenedor);
            this.Name = "frmArk2";
            this.Text = "ARK 2";
            this.Load += new System.EventHandler(this.frmArk2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contenedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picNave;
        private System.Windows.Forms.PictureBox contenedor;
        private System.Windows.Forms.Timer temporizador;
    }
}