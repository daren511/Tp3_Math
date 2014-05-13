namespace Tp3_Math
{
    partial class PI
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
            this.LBL_Min = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Calc = new System.Windows.Forms.TextBox();
            this.LBL_E = new System.Windows.Forms.Label();
            this.TB_Rep = new System.Windows.Forms.TextBox();
            this.BTN_Calculer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_REPMAX = new System.Windows.Forms.Label();
            this.LBL_REPMIN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL_PIMIN
            // 
            this.LBL_PIMIN.AutoSize = true;
            this.LBL_PIMIN.Location = new System.Drawing.Point(73, 19);
            this.LBL_PIMIN.Name = "LBL_PIMIN";
            this.LBL_PIMIN.Size = new System.Drawing.Size(35, 13);
            this.LBL_PIMIN.TabIndex = 0;
            this.LBL_PIMIN.Text = "label1";
            // 
            // LBL_PIMAX
            // 
            this.LBL_PIMAX.AutoSize = true;
            this.LBL_PIMAX.Location = new System.Drawing.Point(73, 42);
            this.LBL_PIMAX.Name = "LBL_PIMAX";
            this.LBL_PIMAX.Size = new System.Drawing.Size(35, 13);
            this.LBL_PIMAX.TabIndex = 1;
            this.LBL_PIMAX.Text = "label1";
            // 
            // LBL_Min
            // 
            this.LBL_Min.AutoSize = true;
            this.LBL_Min.Location = new System.Drawing.Point(12, 19);
            this.LBL_Min.Name = "LBL_Min";
            this.LBL_Min.Size = new System.Drawing.Size(55, 13);
            this.LBL_Min.TabIndex = 2;
            this.LBL_Min.Text = "Borne Min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Borne Max";
            // 
            // TB_Calc
            // 
            this.TB_Calc.Location = new System.Drawing.Point(88, 75);
            this.TB_Calc.Name = "TB_Calc";
            this.TB_Calc.Size = new System.Drawing.Size(100, 20);
            this.TB_Calc.TabIndex = 4;
            this.TB_Calc.TextChanged += new System.EventHandler(this.TB_Calc_TextChanged);
            // 
            // LBL_E
            // 
            this.LBL_E.AutoSize = true;
            this.LBL_E.Location = new System.Drawing.Point(47, 78);
            this.LBL_E.Name = "LBL_E";
            this.LBL_E.Size = new System.Drawing.Size(20, 13);
            this.LBL_E.TabIndex = 5;
            this.LBL_E.Text = "E?";
            // 
            // TB_Rep
            // 
            this.TB_Rep.Location = new System.Drawing.Point(88, 101);
            this.TB_Rep.Name = "TB_Rep";
            this.TB_Rep.ReadOnly = true;
            this.TB_Rep.Size = new System.Drawing.Size(100, 20);
            this.TB_Rep.TabIndex = 6;
            // 
            // BTN_Calculer
            // 
            this.BTN_Calculer.Location = new System.Drawing.Point(194, 75);
            this.BTN_Calculer.Name = "BTN_Calculer";
            this.BTN_Calculer.Size = new System.Drawing.Size(75, 23);
            this.BTN_Calculer.TabIndex = 7;
            this.BTN_Calculer.Text = "Calculer";
            this.BTN_Calculer.UseVisualStyleBackColor = true;
            this.BTN_Calculer.Click += new System.EventHandler(this.BTN_Calculer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Borne Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Borne Min";
            // 
            // LBL_REPMAX
            // 
            this.LBL_REPMAX.AutoSize = true;
            this.LBL_REPMAX.Location = new System.Drawing.Point(85, 167);
            this.LBL_REPMAX.Name = "LBL_REPMAX";
            this.LBL_REPMAX.Size = new System.Drawing.Size(0, 13);
            this.LBL_REPMAX.TabIndex = 9;
            // 
            // LBL_REPMIN
            // 
            this.LBL_REPMIN.AutoSize = true;
            this.LBL_REPMIN.Location = new System.Drawing.Point(85, 144);
            this.LBL_REPMIN.Name = "LBL_REPMIN";
            this.LBL_REPMIN.Size = new System.Drawing.Size(0, 13);
            this.LBL_REPMIN.TabIndex = 8;
            // 
            // PI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LBL_REPMAX);
            this.Controls.Add(this.LBL_REPMIN);
            this.Controls.Add(this.BTN_Calculer);
            this.Controls.Add(this.TB_Rep);
            this.Controls.Add(this.LBL_E);
            this.Controls.Add(this.TB_Calc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_Min);
            this.Controls.Add(this.LBL_PIMAX);
            this.Controls.Add(this.LBL_PIMIN);
            this.Name = "PI";
            this.Text = "Tp3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_PIMIN;
        private System.Windows.Forms.Label LBL_PIMAX;
        private System.Windows.Forms.Label LBL_Min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Calc;
        private System.Windows.Forms.Label LBL_E;
        private System.Windows.Forms.TextBox TB_Rep;
        private System.Windows.Forms.Button BTN_Calculer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_REPMAX;
        private System.Windows.Forms.Label LBL_REPMIN;
    }
}

