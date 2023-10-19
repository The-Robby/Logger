namespace Werk_logger
{
    partial class Form2login
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
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.voornaam = new System.Windows.Forms.Label();
            this.achternaam = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Werk_logger.Properties.Settings.Default, "s_Voornaam", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtVoornaam.Location = new System.Drawing.Point(15, 25);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(100, 20);
            this.txtVoornaam.TabIndex = 0;
            this.txtVoornaam.Text = global::Werk_logger.Properties.Settings.Default.s_Voornaam;
            this.txtVoornaam.TextChanged += new System.EventHandler(this.txtVoornaam_TextChanged);
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Werk_logger.Properties.Settings.Default, "s_Achternaam", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtAchternaam.Location = new System.Drawing.Point(15, 64);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(100, 20);
            this.txtAchternaam.TabIndex = 1;
            this.txtAchternaam.Text = global::Werk_logger.Properties.Settings.Default.s_Achternaam;
            this.txtAchternaam.TextChanged += new System.EventHandler(this.txtAchternaam_TextChanged);
            // 
            // voornaam
            // 
            this.voornaam.AutoSize = true;
            this.voornaam.Location = new System.Drawing.Point(12, 9);
            this.voornaam.Name = "voornaam";
            this.voornaam.Size = new System.Drawing.Size(55, 13);
            this.voornaam.TabIndex = 2;
            this.voornaam.Text = "Voornaam";
            // 
            // achternaam
            // 
            this.achternaam.AutoSize = true;
            this.achternaam.Location = new System.Drawing.Point(12, 48);
            this.achternaam.Name = "achternaam";
            this.achternaam.Size = new System.Drawing.Size(64, 13);
            this.achternaam.TabIndex = 3;
            this.achternaam.Text = "Achternaam";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(122, 25);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(56, 59);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form2login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 104);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.achternaam);
            this.Controls.Add(this.voornaam);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.txtVoornaam);
            this.Name = "Form2login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.Label voornaam;
        private System.Windows.Forms.Label achternaam;
        private System.Windows.Forms.Button btnLogin;
    }
}