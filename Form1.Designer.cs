namespace RPGSchoolV1
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
            this.rtbFeed = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHealth = new System.Windows.Forms.TextBox();
            this.tbGold = new System.Windows.Forms.TextBox();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.rtbInvItems = new System.Windows.Forms.RichTextBox();
            this.rtbInvQuants = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbMonsters = new System.Windows.Forms.RichTextBox();
            this.cbEnemy = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbWeapon = new System.Windows.Forms.ComboBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbFeed
            // 
            this.rtbFeed.Location = new System.Drawing.Point(252, 12);
            this.rtbFeed.Name = "rtbFeed";
            this.rtbFeed.ReadOnly = true;
            this.rtbFeed.Size = new System.Drawing.Size(200, 137);
            this.rtbFeed.TabIndex = 0;
            this.rtbFeed.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Health:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gold:";
            // 
            // tbHealth
            // 
            this.tbHealth.Location = new System.Drawing.Point(61, 18);
            this.tbHealth.Name = "tbHealth";
            this.tbHealth.ReadOnly = true;
            this.tbHealth.Size = new System.Drawing.Size(100, 20);
            this.tbHealth.TabIndex = 3;
            // 
            // tbGold
            // 
            this.tbGold.Location = new System.Drawing.Point(61, 48);
            this.tbGold.Name = "tbGold";
            this.tbGold.ReadOnly = true;
            this.tbGold.Size = new System.Drawing.Size(100, 20);
            this.tbGold.TabIndex = 4;
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(320, 268);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(75, 23);
            this.btnNorth.TabIndex = 5;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(263, 297);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(75, 23);
            this.btnWest.TabIndex = 6;
            this.btnWest.Text = "West";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(377, 297);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(75, 23);
            this.btnEast.TabIndex = 7;
            this.btnEast.Text = "East";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(320, 326);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(75, 23);
            this.btnSouth.TabIndex = 8;
            this.btnSouth.Text = "South";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // rtbInvItems
            // 
            this.rtbInvItems.Location = new System.Drawing.Point(15, 149);
            this.rtbInvItems.Name = "rtbInvItems";
            this.rtbInvItems.ReadOnly = true;
            this.rtbInvItems.Size = new System.Drawing.Size(99, 200);
            this.rtbInvItems.TabIndex = 9;
            this.rtbInvItems.Text = "";
            // 
            // rtbInvQuants
            // 
            this.rtbInvQuants.Location = new System.Drawing.Point(120, 149);
            this.rtbInvQuants.Name = "rtbInvQuants";
            this.rtbInvQuants.ReadOnly = true;
            this.rtbInvQuants.Size = new System.Drawing.Size(55, 200);
            this.rtbInvQuants.TabIndex = 10;
            this.rtbInvQuants.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Inventory Items";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantity";
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(61, 74);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.ReadOnly = true;
            this.tbLocation.Size = new System.Drawing.Size(100, 20);
            this.tbLocation.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Location";
            // 
            // rtbMonsters
            // 
            this.rtbMonsters.Enabled = false;
            this.rtbMonsters.Location = new System.Drawing.Point(252, 166);
            this.rtbMonsters.Name = "rtbMonsters";
            this.rtbMonsters.ReadOnly = true;
            this.rtbMonsters.Size = new System.Drawing.Size(200, 96);
            this.rtbMonsters.TabIndex = 15;
            this.rtbMonsters.Text = "";
            // 
            // cbEnemy
            // 
            this.cbEnemy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEnemy.FormattingEnabled = true;
            this.cbEnemy.Location = new System.Drawing.Point(108, 381);
            this.cbEnemy.Name = "cbEnemy";
            this.cbEnemy.Size = new System.Drawing.Size(121, 21);
            this.cbEnemy.TabIndex = 16;
            this.cbEnemy.TextUpdate += new System.EventHandler(this.cbEnemy_TextUpdate);
            this.cbEnemy.TextChanged += new System.EventHandler(this.cbEnemy_TextUpdate);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Enemy Chosen:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Weapon Chosen:";
            // 
            // cbWeapon
            // 
            this.cbWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWeapon.FormattingEnabled = true;
            this.cbWeapon.Location = new System.Drawing.Point(108, 408);
            this.cbWeapon.Name = "cbWeapon";
            this.cbWeapon.Size = new System.Drawing.Size(121, 21);
            this.cbWeapon.TabIndex = 18;
            this.cbWeapon.TextUpdate += new System.EventHandler(this.cbEnemy_TextUpdate);
            this.cbWeapon.TextChanged += new System.EventHandler(this.cbEnemy_TextUpdate);
            // 
            // btnAttack
            // 
            this.btnAttack.Enabled = false;
            this.btnAttack.Location = new System.Drawing.Point(108, 446);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(121, 23);
            this.btnAttack.TabIndex = 20;
            this.btnAttack.Text = "Attack!";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Visible = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 481);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbWeapon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbEnemy);
            this.Controls.Add(this.rtbMonsters);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbInvQuants);
            this.Controls.Add(this.rtbInvItems);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.tbGold);
            this.Controls.Add(this.tbHealth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbFeed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbFeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHealth;
        private System.Windows.Forms.TextBox tbGold;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.RichTextBox rtbInvItems;
        private System.Windows.Forms.RichTextBox rtbInvQuants;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbMonsters;
        private System.Windows.Forms.ComboBox cbEnemy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbWeapon;
        private System.Windows.Forms.Button btnAttack;
    }
}

