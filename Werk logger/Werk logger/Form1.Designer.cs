namespace Werk_logger
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
            this.txtGlans = new System.Windows.Forms.ComboBox();
            this.txtActie = new System.Windows.Forms.TextBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.orderLabel = new System.Windows.Forms.Label();
            this.watGedaan = new System.Windows.Forms.Label();
            this.glansGraad = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.uur = new System.Windows.Forms.Label();
            this.dateUur = new System.Windows.Forms.DateTimePicker();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGlans
            // 
            this.txtGlans.FormattingEnabled = true;
            this.txtGlans.Items.AddRange(new object[] {
            "Niet Van Toepassing",
            "HighGloss",
            "Satijn",
            "Matt",
            "DeadMatt",
            "Structuur",
            "Structuur D30",
            "Structuur D50"});
            this.txtGlans.Location = new System.Drawing.Point(343, 85);
            this.txtGlans.Name = "txtGlans";
            this.txtGlans.Size = new System.Drawing.Size(134, 21);
            this.txtGlans.TabIndex = 1;
            this.txtGlans.SelectedIndexChanged += new System.EventHandler(this.txtGlans_SelectedIndexChanged);
            // 
            // txtActie
            // 
            this.txtActie.Location = new System.Drawing.Point(343, 37);
            this.txtActie.Name = "txtActie";
            this.txtActie.Size = new System.Drawing.Size(239, 20);
            this.txtActie.TabIndex = 2;
            this.txtActie.TextChanged += new System.EventHandler(this.txtActie_TextChanged);
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(136, 86);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(152, 20);
            this.txtOrder.TabIndex = 3;
            this.txtOrder.TextChanged += new System.EventHandler(this.txtOrder_TextChanged);
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(133, 70);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(50, 13);
            this.orderLabel.TabIndex = 4;
            this.orderLabel.Text = "Order Nr.";
            // 
            // watGedaan
            // 
            this.watGedaan.AutoSize = true;
            this.watGedaan.Location = new System.Drawing.Point(340, 21);
            this.watGedaan.Name = "watGedaan";
            this.watGedaan.Size = new System.Drawing.Size(104, 13);
            this.watGedaan.TabIndex = 5;
            this.watGedaan.Text = "Wat heb je gedaan?";
            // 
            // glansGraad
            // 
            this.glansGraad.AutoSize = true;
            this.glansGraad.Location = new System.Drawing.Point(340, 70);
            this.glansGraad.Name = "glansGraad";
            this.glansGraad.Size = new System.Drawing.Size(64, 13);
            this.glansGraad.TabIndex = 6;
            this.glansGraad.Text = "Glans graad";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 85);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // uur
            // 
            this.uur.AutoSize = true;
            this.uur.Location = new System.Drawing.Point(133, 21);
            this.uur.Name = "uur";
            this.uur.Size = new System.Drawing.Size(24, 13);
            this.uur.TabIndex = 10;
            this.uur.Text = "Uur";
            // 
            // dateUur
            // 
            this.dateUur.CustomFormat = "dd-MM-yyyy | hh:mm ";
            this.dateUur.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateUur.Location = new System.Drawing.Point(136, 37);
            this.dateUur.Name = "dateUur";
            this.dateUur.Size = new System.Drawing.Size(152, 20);
            this.dateUur.TabIndex = 11;
            this.dateUur.ValueChanged += new System.EventHandler(this.dateUur_ValueChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 112);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(102, 46);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 170);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.dateUur);
            this.Controls.Add(this.uur);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.glansGraad);
            this.Controls.Add(this.watGedaan);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.txtActie);
            this.Controls.Add(this.txtGlans);
            this.Name = "Form1";
            this.Text = "Werk Logger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.DateTimePicker dateDatum;
        private System.Windows.Forms.ComboBox txtGlans;
        private System.Windows.Forms.TextBox txtActie;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label watGedaan;
        private System.Windows.Forms.Label glansGraad;
        private System.Windows.Forms.Button btnSave;
        //private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label uur;
        private System.Windows.Forms.DateTimePicker dateUur;
        private System.Windows.Forms.Button btnLogin;
    }
}

