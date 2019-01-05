namespace HarcosokApplication
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.harcosNeveTextbox = new System.Windows.Forms.TextBox();
            this.harcoscreate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hasznaloComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.leirasTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kepessegCreate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.harcosokListBox = new System.Windows.Forms.ListBox();
            this.kepessegekListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kepessegLeirasaTextBox = new System.Windows.Forms.TextBox();
            this.modosit = new System.Windows.Forms.Button();
            this.torles = new System.Windows.Forms.Button();
            this.kepessegNeveTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.harcoscreate);
            this.groupBox1.Controls.Add(this.harcosNeveTextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Harcos Létrezhozása";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // harcosNeveTextbox
            // 
            this.harcosNeveTextbox.Location = new System.Drawing.Point(43, 17);
            this.harcosNeveTextbox.Name = "harcosNeveTextbox";
            this.harcosNeveTextbox.Size = new System.Drawing.Size(204, 20);
            this.harcosNeveTextbox.TabIndex = 1;
            // 
            // harcoscreate
            // 
            this.harcoscreate.Location = new System.Drawing.Point(283, 15);
            this.harcoscreate.Name = "harcoscreate";
            this.harcoscreate.Size = new System.Drawing.Size(75, 23);
            this.harcoscreate.TabIndex = 2;
            this.harcoscreate.Text = "Létrehozás";
            this.harcoscreate.UseVisualStyleBackColor = true;
            this.harcoscreate.Click += new System.EventHandler(this.harcoscreate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kepessegNeveTextBox);
            this.groupBox2.Controls.Add(this.kepessegCreate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.leirasTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.hasznaloComboBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Képesség Hozzáadása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Használó:";
            // 
            // hasznaloComboBox
            // 
            this.hasznaloComboBox.FormattingEnabled = true;
            this.hasznaloComboBox.Location = new System.Drawing.Point(68, 28);
            this.hasznaloComboBox.Name = "hasznaloComboBox";
            this.hasznaloComboBox.Size = new System.Drawing.Size(179, 21);
            this.hasznaloComboBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Leirás:";
            // 
            // leirasTextBox
            // 
            this.leirasTextBox.Location = new System.Drawing.Point(327, 25);
            this.leirasTextBox.Multiline = true;
            this.leirasTextBox.Name = "leirasTextBox";
            this.leirasTextBox.Size = new System.Drawing.Size(184, 67);
            this.leirasTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Név:";
            // 
            // kepessegCreate
            // 
            this.kepessegCreate.Location = new System.Drawing.Point(7, 107);
            this.kepessegCreate.Name = "kepessegCreate";
            this.kepessegCreate.Size = new System.Drawing.Size(75, 23);
            this.kepessegCreate.TabIndex = 6;
            this.kepessegCreate.Text = "Hozzáad";
            this.kepessegCreate.UseVisualStyleBackColor = true;
            this.kepessegCreate.Click += new System.EventHandler(this.kepessegCreate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.torles);
            this.groupBox3.Controls.Add(this.modosit);
            this.groupBox3.Controls.Add(this.kepessegLeirasaTextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.kepessegekListBox);
            this.groupBox3.Controls.Add(this.harcosokListBox);
            this.groupBox3.Location = new System.Drawing.Point(13, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 216);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Harcosok";
            // 
            // harcosokListBox
            // 
            this.harcosokListBox.FormattingEnabled = true;
            this.harcosokListBox.Location = new System.Drawing.Point(7, 46);
            this.harcosokListBox.Name = "harcosokListBox";
            this.harcosokListBox.Size = new System.Drawing.Size(120, 134);
            this.harcosokListBox.TabIndex = 0;
            this.harcosokListBox.SelectedValueChanged += new System.EventHandler(this.harcosokListBox_SelectedValueChanged);
            // 
            // kepessegekListBox
            // 
            this.kepessegekListBox.FormattingEnabled = true;
            this.kepessegekListBox.Location = new System.Drawing.Point(154, 45);
            this.kepessegekListBox.Name = "kepessegekListBox";
            this.kepessegekListBox.Size = new System.Drawing.Size(120, 134);
            this.kepessegekListBox.TabIndex = 1;
            this.kepessegekListBox.SelectedValueChanged += new System.EventHandler(this.kepessegekListBox_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Harcosok:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Képességei:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Képesség Leirása:";
            // 
            // kepessegLeirasaTextBox
            // 
            this.kepessegLeirasaTextBox.Enabled = false;
            this.kepessegLeirasaTextBox.Location = new System.Drawing.Point(288, 46);
            this.kepessegLeirasaTextBox.Multiline = true;
            this.kepessegLeirasaTextBox.Name = "kepessegLeirasaTextBox";
            this.kepessegLeirasaTextBox.Size = new System.Drawing.Size(184, 67);
            this.kepessegLeirasaTextBox.TabIndex = 7;
            // 
            // modosit
            // 
            this.modosit.Enabled = false;
            this.modosit.Location = new System.Drawing.Point(403, 120);
            this.modosit.Name = "modosit";
            this.modosit.Size = new System.Drawing.Size(75, 23);
            this.modosit.TabIndex = 8;
            this.modosit.Text = "Módosit";
            this.modosit.UseVisualStyleBackColor = true;
            this.modosit.Click += new System.EventHandler(this.modosit_Click);
            // 
            // torles
            // 
            this.torles.Location = new System.Drawing.Point(154, 186);
            this.torles.Name = "torles";
            this.torles.Size = new System.Drawing.Size(75, 23);
            this.torles.TabIndex = 9;
            this.torles.Text = "Töröl";
            this.torles.UseVisualStyleBackColor = true;
            this.torles.Click += new System.EventHandler(this.torles_Click);
            // 
            // kepessegNeveTextBox
            // 
            this.kepessegNeveTextBox.Location = new System.Drawing.Point(68, 76);
            this.kepessegNeveTextBox.Name = "kepessegNeveTextBox";
            this.kepessegNeveTextBox.Size = new System.Drawing.Size(179, 20);
            this.kepessegNeveTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 464);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Harcosok";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button harcoscreate;
        private System.Windows.Forms.TextBox harcosNeveTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button kepessegCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox leirasTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox hasznaloComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button torles;
        private System.Windows.Forms.Button modosit;
        private System.Windows.Forms.TextBox kepessegLeirasaTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox kepessegekListBox;
        private System.Windows.Forms.ListBox harcosokListBox;
        private System.Windows.Forms.TextBox kepessegNeveTextBox;
    }
}

