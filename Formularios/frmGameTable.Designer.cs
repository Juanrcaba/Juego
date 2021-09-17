namespace Juego.Formularios
{
    partial class frmGameTable
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
            this.container = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_progreso = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_intentos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.container.Location = new System.Drawing.Point(12, 38);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(356, 246);
            this.container.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Progreso: ";
            // 
            // lbl_progreso
            // 
            this.lbl_progreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_progreso.AutoSize = true;
            this.lbl_progreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_progreso.Location = new System.Drawing.Point(331, 10);
            this.lbl_progreso.Name = "lbl_progreso";
            this.lbl_progreso.Size = new System.Drawing.Size(37, 13);
            this.lbl_progreso.TabIndex = 3;
            this.lbl_progreso.Text = "100%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Intentos: ";
            // 
            // lbl_intentos
            // 
            this.lbl_intentos.AutoSize = true;
            this.lbl_intentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intentos.Location = new System.Drawing.Point(68, 10);
            this.lbl_intentos.Name = "lbl_intentos";
            this.lbl_intentos.Size = new System.Drawing.Size(14, 13);
            this.lbl_intentos.TabIndex = 3;
            this.lbl_intentos.Text = "3";
            // 
            // frmGameTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 296);
            this.Controls.Add(this.lbl_intentos);
            this.Controls.Add(this.lbl_progreso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.container);
            this.Name = "frmGameTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Table";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGameTable_FormClosing);
            this.Load += new System.EventHandler(this.frmGameTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel container;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_progreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_intentos;
    }
}