namespace EventProjectLastVersion
{
    partial class Home
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
            this.cmBtn = new System.Windows.Forms.Button();
            this.makeBtn = new System.Windows.Forms.Button();
            this.chBtn = new System.Windows.Forms.Button();
            this.summBtn = new System.Windows.Forms.Button();
            this.findBtn = new System.Windows.Forms.Button();
            this.rervBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmBtn
            // 
            this.cmBtn.Location = new System.Drawing.Point(311, 370);
            this.cmBtn.Name = "cmBtn";
            this.cmBtn.Size = new System.Drawing.Size(179, 62);
            this.cmBtn.TabIndex = 11;
            this.cmBtn.Text = "Companies";
            this.cmBtn.UseVisualStyleBackColor = true;
            this.cmBtn.Click += new System.EventHandler(this.cmBtn_Click);
            // 
            // makeBtn
            // 
            this.makeBtn.Location = new System.Drawing.Point(311, 97);
            this.makeBtn.Name = "makeBtn";
            this.makeBtn.Size = new System.Drawing.Size(179, 62);
            this.makeBtn.TabIndex = 10;
            this.makeBtn.Text = "Make a Reservation";
            this.makeBtn.UseVisualStyleBackColor = true;
            this.makeBtn.Click += new System.EventHandler(this.makeBtn_Click);
            // 
            // chBtn
            // 
            this.chBtn.Location = new System.Drawing.Point(311, 301);
            this.chBtn.Name = "chBtn";
            this.chBtn.Size = new System.Drawing.Size(179, 62);
            this.chBtn.TabIndex = 9;
            this.chBtn.Text = "Change or Add new";
            this.chBtn.UseVisualStyleBackColor = true;
            this.chBtn.Click += new System.EventHandler(this.chBtn_Click);
            // 
            // summBtn
            // 
            this.summBtn.Location = new System.Drawing.Point(311, 233);
            this.summBtn.Name = "summBtn";
            this.summBtn.Size = new System.Drawing.Size(179, 62);
            this.summBtn.TabIndex = 8;
            this.summBtn.Text = "Sammary";
            this.summBtn.UseVisualStyleBackColor = true;
            this.summBtn.Click += new System.EventHandler(this.summBtn_Click);
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(311, 165);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(179, 62);
            this.findBtn.TabIndex = 7;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // rervBtn
            // 
            this.rervBtn.Location = new System.Drawing.Point(311, 18);
            this.rervBtn.Name = "rervBtn";
            this.rervBtn.Size = new System.Drawing.Size(179, 65);
            this.rervBtn.TabIndex = 6;
            this.rervBtn.Text = "Resrvations";
            this.rervBtn.UseVisualStyleBackColor = true;
            this.rervBtn.Click += new System.EventHandler(this.rervBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmBtn);
            this.Controls.Add(this.makeBtn);
            this.Controls.Add(this.chBtn);
            this.Controls.Add(this.summBtn);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.rervBtn);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmBtn;
        private System.Windows.Forms.Button makeBtn;
        private System.Windows.Forms.Button chBtn;
        private System.Windows.Forms.Button summBtn;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Button rervBtn;
    }
}