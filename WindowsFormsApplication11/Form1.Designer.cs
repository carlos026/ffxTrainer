namespace WindowsFormsApplication11
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.killAll = new System.Windows.Forms.Button();
            this.enemyAGroup = new System.Windows.Forms.Panel();
            this.killEnemy1 = new System.Windows.Forms.Button();
            this.hpMaxLabel = new System.Windows.Forms.Label();
            this.separator1 = new System.Windows.Forms.Label();
            this.hpLabel = new System.Windows.Forms.Label();
            this.hpBar = new System.Windows.Forms.ProgressBar();
            this.hpDescLabel1 = new System.Windows.Forms.Label();
            this.enemyBGroup = new System.Windows.Forms.Panel();
            this.killEnemy2 = new System.Windows.Forms.Button();
            this.hpMaxLabel2 = new System.Windows.Forms.Label();
            this.separator2 = new System.Windows.Forms.Label();
            this.hpLabel2 = new System.Windows.Forms.Label();
            this.hpBar2 = new System.Windows.Forms.ProgressBar();
            this.hpDescLabel2 = new System.Windows.Forms.Label();
            this.enemyCGroup = new System.Windows.Forms.Panel();
            this.killEnemy3 = new System.Windows.Forms.Button();
            this.hpMaxLabel3 = new System.Windows.Forms.Label();
            this.separator3 = new System.Windows.Forms.Label();
            this.hpLabel3 = new System.Windows.Forms.Label();
            this.hpBar3 = new System.Windows.Forms.ProgressBar();
            this.hpDescLabel3 = new System.Windows.Forms.Label();
            this.enemyDGroup = new System.Windows.Forms.Panel();
            this.killEnemy4 = new System.Windows.Forms.Button();
            this.hpMaxLabel4 = new System.Windows.Forms.Label();
            this.separator4 = new System.Windows.Forms.Label();
            this.hpLabel4 = new System.Windows.Forms.Label();
            this.hpBar4 = new System.Windows.Forms.ProgressBar();
            this.hpDescLabel4 = new System.Windows.Forms.Label();
            this.enemyAGroup.SuspendLayout();
            this.enemyBGroup.SuspendLayout();
            this.enemyCGroup.SuspendLayout();
            this.enemyDGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "By CarlosCondeJr";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // killAll
            // 
            this.killAll.BackColor = System.Drawing.Color.Red;
            this.killAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.killAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killAll.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.killAll.Location = new System.Drawing.Point(445, 186);
            this.killAll.Name = "killAll";
            this.killAll.Size = new System.Drawing.Size(113, 42);
            this.killAll.TabIndex = 59;
            this.killAll.Text = "Kill All";
            this.killAll.UseVisualStyleBackColor = false;
            this.killAll.Visible = false;
            this.killAll.Click += new System.EventHandler(this.killAll_Click);
            // 
            // enemyAGroup
            // 
            this.enemyAGroup.Controls.Add(this.killEnemy1);
            this.enemyAGroup.Controls.Add(this.hpMaxLabel);
            this.enemyAGroup.Controls.Add(this.separator1);
            this.enemyAGroup.Controls.Add(this.hpLabel);
            this.enemyAGroup.Controls.Add(this.hpBar);
            this.enemyAGroup.Controls.Add(this.hpDescLabel1);
            this.enemyAGroup.Location = new System.Drawing.Point(15, 4);
            this.enemyAGroup.Name = "enemyAGroup";
            this.enemyAGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.enemyAGroup.Size = new System.Drawing.Size(549, 44);
            this.enemyAGroup.TabIndex = 64;
            this.enemyAGroup.Visible = false;
            // 
            // killEnemy1
            // 
            this.killEnemy1.Cursor = System.Windows.Forms.Cursors.Default;
            this.killEnemy1.Location = new System.Drawing.Point(430, 8);
            this.killEnemy1.Name = "killEnemy1";
            this.killEnemy1.Size = new System.Drawing.Size(113, 32);
            this.killEnemy1.TabIndex = 69;
            this.killEnemy1.Text = "Kill Enemy A";
            this.killEnemy1.UseVisualStyleBackColor = true;
            this.killEnemy1.Click += new System.EventHandler(this.killEnemy1_Click);
            // 
            // hpMaxLabel
            // 
            this.hpMaxLabel.AutoSize = true;
            this.hpMaxLabel.BackColor = System.Drawing.Color.White;
            this.hpMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpMaxLabel.Location = new System.Drawing.Point(111, 0);
            this.hpMaxLabel.Name = "hpMaxLabel";
            this.hpMaxLabel.Size = new System.Drawing.Size(17, 17);
            this.hpMaxLabel.TabIndex = 68;
            this.hpMaxLabel.Text = "0";
            // 
            // separator1
            // 
            this.separator1.AutoSize = true;
            this.separator1.BackColor = System.Drawing.Color.Transparent;
            this.separator1.Location = new System.Drawing.Point(95, 0);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(12, 17);
            this.separator1.TabIndex = 67;
            this.separator1.Text = "/";
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.BackColor = System.Drawing.Color.White;
            this.hpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hpLabel.Location = new System.Drawing.Point(39, 0);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(17, 17);
            this.hpLabel.TabIndex = 66;
            this.hpLabel.Text = "0";
            // 
            // hpBar
            // 
            this.hpBar.BackColor = System.Drawing.SystemColors.Control;
            this.hpBar.Location = new System.Drawing.Point(37, 16);
            this.hpBar.Name = "hpBar";
            this.hpBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hpBar.Size = new System.Drawing.Size(374, 18);
            this.hpBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.hpBar.TabIndex = 65;
            // 
            // hpDescLabel1
            // 
            this.hpDescLabel1.AutoSize = true;
            this.hpDescLabel1.BackColor = System.Drawing.Color.White;
            this.hpDescLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpDescLabel1.Location = new System.Drawing.Point(5, 0);
            this.hpDescLabel1.Name = "hpDescLabel1";
            this.hpDescLabel1.Size = new System.Drawing.Size(36, 18);
            this.hpDescLabel1.TabIndex = 64;
            this.hpDescLabel1.Text = "HP:";
            // 
            // enemyBGroup
            // 
            this.enemyBGroup.Controls.Add(this.killEnemy2);
            this.enemyBGroup.Controls.Add(this.hpMaxLabel2);
            this.enemyBGroup.Controls.Add(this.separator2);
            this.enemyBGroup.Controls.Add(this.hpLabel2);
            this.enemyBGroup.Controls.Add(this.hpBar2);
            this.enemyBGroup.Controls.Add(this.hpDescLabel2);
            this.enemyBGroup.Location = new System.Drawing.Point(15, 50);
            this.enemyBGroup.Name = "enemyBGroup";
            this.enemyBGroup.Size = new System.Drawing.Size(549, 44);
            this.enemyBGroup.TabIndex = 65;
            this.enemyBGroup.Visible = false;
            // 
            // killEnemy2
            // 
            this.killEnemy2.Location = new System.Drawing.Point(430, 9);
            this.killEnemy2.Name = "killEnemy2";
            this.killEnemy2.Size = new System.Drawing.Size(113, 32);
            this.killEnemy2.TabIndex = 62;
            this.killEnemy2.Text = "Kill Enemy B";
            this.killEnemy2.UseVisualStyleBackColor = true;
            this.killEnemy2.Click += new System.EventHandler(this.killEnemy2_Click);
            // 
            // hpMaxLabel2
            // 
            this.hpMaxLabel2.AutoSize = true;
            this.hpMaxLabel2.BackColor = System.Drawing.Color.White;
            this.hpMaxLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpMaxLabel2.Location = new System.Drawing.Point(112, 1);
            this.hpMaxLabel2.Name = "hpMaxLabel2";
            this.hpMaxLabel2.Size = new System.Drawing.Size(17, 17);
            this.hpMaxLabel2.TabIndex = 61;
            this.hpMaxLabel2.Text = "0";
            // 
            // separator2
            // 
            this.separator2.AutoSize = true;
            this.separator2.BackColor = System.Drawing.Color.Transparent;
            this.separator2.Location = new System.Drawing.Point(96, 1);
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(12, 17);
            this.separator2.TabIndex = 60;
            this.separator2.Text = "/";
            // 
            // hpLabel2
            // 
            this.hpLabel2.AutoSize = true;
            this.hpLabel2.BackColor = System.Drawing.Color.White;
            this.hpLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpLabel2.Location = new System.Drawing.Point(40, 1);
            this.hpLabel2.Name = "hpLabel2";
            this.hpLabel2.Size = new System.Drawing.Size(17, 17);
            this.hpLabel2.TabIndex = 59;
            this.hpLabel2.Text = "0";
            // 
            // hpBar2
            // 
            this.hpBar2.ForeColor = System.Drawing.Color.Green;
            this.hpBar2.Location = new System.Drawing.Point(38, 17);
            this.hpBar2.Name = "hpBar2";
            this.hpBar2.Size = new System.Drawing.Size(374, 18);
            this.hpBar2.TabIndex = 58;
            // 
            // hpDescLabel2
            // 
            this.hpDescLabel2.AutoSize = true;
            this.hpDescLabel2.BackColor = System.Drawing.Color.White;
            this.hpDescLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpDescLabel2.Location = new System.Drawing.Point(4, -1);
            this.hpDescLabel2.Name = "hpDescLabel2";
            this.hpDescLabel2.Size = new System.Drawing.Size(36, 18);
            this.hpDescLabel2.TabIndex = 57;
            this.hpDescLabel2.Text = "HP:";
            // 
            // enemyCGroup
            // 
            this.enemyCGroup.Controls.Add(this.killEnemy3);
            this.enemyCGroup.Controls.Add(this.hpMaxLabel3);
            this.enemyCGroup.Controls.Add(this.separator3);
            this.enemyCGroup.Controls.Add(this.hpLabel3);
            this.enemyCGroup.Controls.Add(this.hpBar3);
            this.enemyCGroup.Controls.Add(this.hpDescLabel3);
            this.enemyCGroup.Location = new System.Drawing.Point(15, 96);
            this.enemyCGroup.Name = "enemyCGroup";
            this.enemyCGroup.Size = new System.Drawing.Size(549, 44);
            this.enemyCGroup.TabIndex = 66;
            this.enemyCGroup.Visible = false;
            // 
            // killEnemy3
            // 
            this.killEnemy3.Location = new System.Drawing.Point(430, 9);
            this.killEnemy3.Name = "killEnemy3";
            this.killEnemy3.Size = new System.Drawing.Size(113, 32);
            this.killEnemy3.TabIndex = 63;
            this.killEnemy3.Text = "Kill Enemy C";
            this.killEnemy3.UseVisualStyleBackColor = true;
            this.killEnemy3.Click += new System.EventHandler(this.killEnemy3_Click);
            // 
            // hpMaxLabel3
            // 
            this.hpMaxLabel3.AutoSize = true;
            this.hpMaxLabel3.BackColor = System.Drawing.Color.White;
            this.hpMaxLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpMaxLabel3.Location = new System.Drawing.Point(112, 4);
            this.hpMaxLabel3.Name = "hpMaxLabel3";
            this.hpMaxLabel3.Size = new System.Drawing.Size(17, 17);
            this.hpMaxLabel3.TabIndex = 62;
            this.hpMaxLabel3.Text = "0";
            // 
            // separator3
            // 
            this.separator3.AutoSize = true;
            this.separator3.BackColor = System.Drawing.Color.Transparent;
            this.separator3.Location = new System.Drawing.Point(96, 4);
            this.separator3.Name = "separator3";
            this.separator3.Size = new System.Drawing.Size(12, 17);
            this.separator3.TabIndex = 61;
            this.separator3.Text = "/";
            // 
            // hpLabel3
            // 
            this.hpLabel3.AutoSize = true;
            this.hpLabel3.BackColor = System.Drawing.Color.White;
            this.hpLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpLabel3.Location = new System.Drawing.Point(40, 4);
            this.hpLabel3.Name = "hpLabel3";
            this.hpLabel3.Size = new System.Drawing.Size(17, 17);
            this.hpLabel3.TabIndex = 60;
            this.hpLabel3.Text = "0";
            // 
            // hpBar3
            // 
            this.hpBar3.ForeColor = System.Drawing.Color.Green;
            this.hpBar3.Location = new System.Drawing.Point(38, 20);
            this.hpBar3.Name = "hpBar3";
            this.hpBar3.Size = new System.Drawing.Size(374, 18);
            this.hpBar3.TabIndex = 59;
            // 
            // hpDescLabel3
            // 
            this.hpDescLabel3.AutoSize = true;
            this.hpDescLabel3.BackColor = System.Drawing.Color.White;
            this.hpDescLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpDescLabel3.Location = new System.Drawing.Point(4, 2);
            this.hpDescLabel3.Name = "hpDescLabel3";
            this.hpDescLabel3.Size = new System.Drawing.Size(36, 18);
            this.hpDescLabel3.TabIndex = 58;
            this.hpDescLabel3.Text = "HP:";
            // 
            // enemyDGroup
            // 
            this.enemyDGroup.Controls.Add(this.killEnemy4);
            this.enemyDGroup.Controls.Add(this.hpMaxLabel4);
            this.enemyDGroup.Controls.Add(this.separator4);
            this.enemyDGroup.Controls.Add(this.hpLabel4);
            this.enemyDGroup.Controls.Add(this.hpBar4);
            this.enemyDGroup.Controls.Add(this.hpDescLabel4);
            this.enemyDGroup.Location = new System.Drawing.Point(15, 142);
            this.enemyDGroup.Name = "enemyDGroup";
            this.enemyDGroup.Size = new System.Drawing.Size(549, 44);
            this.enemyDGroup.TabIndex = 67;
            this.enemyDGroup.Visible = false;
            // 
            // killEnemy4
            // 
            this.killEnemy4.Location = new System.Drawing.Point(430, 6);
            this.killEnemy4.Name = "killEnemy4";
            this.killEnemy4.Size = new System.Drawing.Size(113, 32);
            this.killEnemy4.TabIndex = 64;
            this.killEnemy4.Text = "Kill Enemy D";
            this.killEnemy4.UseVisualStyleBackColor = true;
            this.killEnemy4.Click += new System.EventHandler(this.killEnemy4_Click);
            // 
            // hpMaxLabel4
            // 
            this.hpMaxLabel4.AutoSize = true;
            this.hpMaxLabel4.BackColor = System.Drawing.Color.White;
            this.hpMaxLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpMaxLabel4.Location = new System.Drawing.Point(112, 4);
            this.hpMaxLabel4.Name = "hpMaxLabel4";
            this.hpMaxLabel4.Size = new System.Drawing.Size(17, 17);
            this.hpMaxLabel4.TabIndex = 63;
            this.hpMaxLabel4.Text = "0";
            // 
            // separator4
            // 
            this.separator4.AutoSize = true;
            this.separator4.BackColor = System.Drawing.Color.Transparent;
            this.separator4.Location = new System.Drawing.Point(96, 4);
            this.separator4.Name = "separator4";
            this.separator4.Size = new System.Drawing.Size(12, 17);
            this.separator4.TabIndex = 62;
            this.separator4.Text = "/";
            // 
            // hpLabel4
            // 
            this.hpLabel4.AutoSize = true;
            this.hpLabel4.BackColor = System.Drawing.Color.White;
            this.hpLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpLabel4.Location = new System.Drawing.Point(40, 4);
            this.hpLabel4.Name = "hpLabel4";
            this.hpLabel4.Size = new System.Drawing.Size(17, 17);
            this.hpLabel4.TabIndex = 61;
            this.hpLabel4.Text = "0";
            // 
            // hpBar4
            // 
            this.hpBar4.ForeColor = System.Drawing.Color.Green;
            this.hpBar4.Location = new System.Drawing.Point(38, 20);
            this.hpBar4.Name = "hpBar4";
            this.hpBar4.Size = new System.Drawing.Size(374, 18);
            this.hpBar4.TabIndex = 60;
            // 
            // hpDescLabel4
            // 
            this.hpDescLabel4.AutoSize = true;
            this.hpDescLabel4.BackColor = System.Drawing.Color.White;
            this.hpDescLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpDescLabel4.Location = new System.Drawing.Point(4, 2);
            this.hpDescLabel4.Name = "hpDescLabel4";
            this.hpDescLabel4.Size = new System.Drawing.Size(36, 18);
            this.hpDescLabel4.TabIndex = 59;
            this.hpDescLabel4.Text = "HP:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 231);
            this.Controls.Add(this.enemyAGroup);
            this.Controls.Add(this.killAll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enemyBGroup);
            this.Controls.Add(this.enemyCGroup);
            this.Controls.Add(this.enemyDGroup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Hp Scan FFX";
            this.enemyAGroup.ResumeLayout(false);
            this.enemyAGroup.PerformLayout();
            this.enemyBGroup.ResumeLayout(false);
            this.enemyBGroup.PerformLayout();
            this.enemyCGroup.ResumeLayout(false);
            this.enemyCGroup.PerformLayout();
            this.enemyDGroup.ResumeLayout(false);
            this.enemyDGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button killAll;
        private System.Windows.Forms.Panel enemyAGroup;
        private System.Windows.Forms.Button killEnemy1;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.ProgressBar hpBar;
        private System.Windows.Forms.Label hpDescLabel1;
        private System.Windows.Forms.Label hpMaxLabel;
        private System.Windows.Forms.Label separator1;
        private System.Windows.Forms.Panel enemyBGroup;
        private System.Windows.Forms.Button killEnemy2;
        private System.Windows.Forms.Label hpMaxLabel2;
        private System.Windows.Forms.Label separator2;
        private System.Windows.Forms.Label hpLabel2;
        private System.Windows.Forms.ProgressBar hpBar2;
        private System.Windows.Forms.Label hpDescLabel2;
        private System.Windows.Forms.Panel enemyCGroup;
        private System.Windows.Forms.Button killEnemy3;
        private System.Windows.Forms.Label hpMaxLabel3;
        private System.Windows.Forms.Label separator3;
        private System.Windows.Forms.Label hpLabel3;
        private System.Windows.Forms.ProgressBar hpBar3;
        private System.Windows.Forms.Label hpDescLabel3;
        private System.Windows.Forms.Panel enemyDGroup;
        private System.Windows.Forms.Button killEnemy4;
        private System.Windows.Forms.Label hpMaxLabel4;
        private System.Windows.Forms.Label separator4;
        private System.Windows.Forms.Label hpLabel4;
        private System.Windows.Forms.ProgressBar hpBar4;
        private System.Windows.Forms.Label hpDescLabel4;
    }
}

