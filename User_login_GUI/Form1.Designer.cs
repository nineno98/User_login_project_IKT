namespace User_login_GUI
{
    partial class Form1
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
            this.lista_listbox = new System.Windows.Forms.ListBox();
            this.list_button = new System.Windows.Forms.Button();
            this.kilepes_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista_listbox
            // 
            this.lista_listbox.FormattingEnabled = true;
            this.lista_listbox.Location = new System.Drawing.Point(36, 37);
            this.lista_listbox.Name = "lista_listbox";
            this.lista_listbox.Size = new System.Drawing.Size(231, 342);
            this.lista_listbox.TabIndex = 0;
            this.lista_listbox.SelectedIndexChanged += new System.EventHandler(this.lista_listbox_SelectedIndexChanged);
            // 
            // list_button
            // 
            this.list_button.Location = new System.Drawing.Point(334, 37);
            this.list_button.Name = "list_button";
            this.list_button.Size = new System.Drawing.Size(95, 32);
            this.list_button.TabIndex = 1;
            this.list_button.Text = "Lista";
            this.list_button.UseVisualStyleBackColor = true;
            this.list_button.Click += new System.EventHandler(this.list_button_Click);
            // 
            // kilepes_button
            // 
            this.kilepes_button.Location = new System.Drawing.Point(334, 107);
            this.kilepes_button.Name = "kilepes_button";
            this.kilepes_button.Size = new System.Drawing.Size(95, 32);
            this.kilepes_button.TabIndex = 2;
            this.kilepes_button.Text = "Kilépés";
            this.kilepes_button.UseVisualStyleBackColor = true;
            this.kilepes_button.Click += new System.EventHandler(this.kilepes_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.kilepes_button);
            this.Controls.Add(this.list_button);
            this.Controls.Add(this.lista_listbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lista_listbox;
        private System.Windows.Forms.Button list_button;
        private System.Windows.Forms.Button kilepes_button;
    }
}

