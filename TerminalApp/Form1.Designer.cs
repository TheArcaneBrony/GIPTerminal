namespace TerminalApp
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
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.Ws1CBox = new System.Windows.Forms.ComboBox();
            this.NameTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LastNameTBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ws2CBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnSubmit.Location = new System.Drawing.Point(152, 374);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(391, 58);
            this.BtnSubmit.TabIndex = 0;
            this.BtnSubmit.Text = "Inschrijven";
            this.BtnSubmit.UseVisualStyleBackColor = false;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // Ws1CBox
            // 
            this.Ws1CBox.BackColor = System.Drawing.SystemColors.Control;
            this.Ws1CBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ws1CBox.FormattingEnabled = true;
            this.Ws1CBox.Items.AddRange(new object[] {
            "Geen",
            "Workshop VR (18:00 - 19:00)",
            "Game development (18:00 - 19:00)",
            "Programmeren (18:15 - 19:15)",
            "PC-building (18:15 - 19:15)"});
            this.Ws1CBox.Location = new System.Drawing.Point(366, 213);
            this.Ws1CBox.Name = "Ws1CBox";
            this.Ws1CBox.Size = new System.Drawing.Size(240, 37);
            this.Ws1CBox.TabIndex = 2;
            // 
            // NameTBox
            // 
            this.NameTBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameTBox.BackColor = System.Drawing.SystemColors.Control;
            this.NameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTBox.Location = new System.Drawing.Point(366, 85);
            this.NameTBox.Name = "NameTBox";
            this.NameTBox.Size = new System.Drawing.Size(240, 35);
            this.NameTBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(98, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Naam:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(98, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Achternaam:";
            // 
            // LastNameTBox
            // 
            this.LastNameTBox.BackColor = System.Drawing.SystemColors.Control;
            this.LastNameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTBox.Location = new System.Drawing.Point(366, 147);
            this.LastNameTBox.Name = "LastNameTBox";
            this.LastNameTBox.Size = new System.Drawing.Size(240, 35);
            this.LastNameTBox.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::TerminalApp.Properties.Resources.panel;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Ws2CBox);
            this.panel1.Controls.Add(this.BtnSubmit);
            this.panel1.Controls.Add(this.LastNameTBox);
            this.panel1.Controls.Add(this.Ws1CBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NameTBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(329, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 494);
            this.panel1.TabIndex = 9;
            // 
            // Ws2CBox
            // 
            this.Ws2CBox.BackColor = System.Drawing.SystemColors.Control;
            this.Ws2CBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ws2CBox.FormattingEnabled = true;
            this.Ws2CBox.Items.AddRange(new object[] {
            "Geen",
            "Workshop VR (18:00 - 19:00)",
            "Game development (18:00 - 19:00)",
            "Programmeren (18:15 - 19:15)",
            "PC-building (18:15 - 19:15)"});
            this.Ws2CBox.Location = new System.Drawing.Point(366, 282);
            this.Ws2CBox.Name = "Ws2CBox";
            this.Ws2CBox.Size = new System.Drawing.Size(240, 37);
            this.Ws2CBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(98, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tweede workshop:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(98, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Eerste workshop:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::TerminalApp.Properties.Resources.TheBigLebowski7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.ComboBox Ws1CBox;
        private System.Windows.Forms.TextBox NameTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LastNameTBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Ws2CBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

