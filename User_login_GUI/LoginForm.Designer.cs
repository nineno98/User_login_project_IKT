namespace User_login_GUI
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.felhasznev = new System.Windows.Forms.TextBox();
            this.jelszo = new System.Windows.Forms.TextBox();
            this.belepes_gomb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználónév";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jelszó";
            // 
            // felhasznev
            // 
            this.felhasznev.Location = new System.Drawing.Point(134, 60);
            this.felhasznev.Name = "felhasznev";
            this.felhasznev.Size = new System.Drawing.Size(100, 20);
            this.felhasznev.TabIndex = 2;
            // 
            // jelszo
            // 
            this.jelszo.Location = new System.Drawing.Point(134, 95);
            this.jelszo.Name = "jelszo";
            this.jelszo.Size = new System.Drawing.Size(100, 20);
            this.jelszo.TabIndex = 3;
            // 
            // belepes_gomb
            // 
            this.belepes_gomb.Location = new System.Drawing.Point(134, 132);
            this.belepes_gomb.Name = "belepes_gomb";
            this.belepes_gomb.Size = new System.Drawing.Size(100, 35);
            this.belepes_gomb.TabIndex = 4;
            this.belepes_gomb.Text = "Belépés";
            this.belepes_gomb.UseVisualStyleBackColor = true;
            this.belepes_gomb.Click += new System.EventHandler(this.belepes_gomb_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 198);
            this.Controls.Add(this.belepes_gomb);
            this.Controls.Add(this.jelszo);
            this.Controls.Add(this.felhasznev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Bejelentkezés";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox felhasznev;
        private System.Windows.Forms.TextBox jelszo;
        private System.Windows.Forms.Button belepes_gomb;
    }
}