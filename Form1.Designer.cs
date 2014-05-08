namespace Tp3_Math
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBL_PIMIN = new System.Windows.Forms.Label();
            this.LBL_PIMAX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL_PIMIN
            // 
            this.LBL_PIMIN.AutoSize = true;
            this.LBL_PIMIN.Location = new System.Drawing.Point(107, 63);
            this.LBL_PIMIN.Name = "LBL_PIMIN";
            this.LBL_PIMIN.Size = new System.Drawing.Size(35, 13);
            this.LBL_PIMIN.TabIndex = 0;
            this.LBL_PIMIN.Text = "label1";
            // 
            // LBL_PIMAX
            // 
            this.LBL_PIMAX.AutoSize = true;
            this.LBL_PIMAX.Location = new System.Drawing.Point(107, 88);
            this.LBL_PIMAX.Name = "LBL_PIMAX";
            this.LBL_PIMAX.Size = new System.Drawing.Size(35, 13);
            this.LBL_PIMAX.TabIndex = 1;
            this.LBL_PIMAX.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.LBL_PIMAX);
            this.Controls.Add(this.LBL_PIMIN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_PIMIN;
        private System.Windows.Forms.Label LBL_PIMAX;
    }
}

