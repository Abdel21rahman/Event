namespace EventProjectLastVersion
{
    partial class login
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label passwordLabel;
            this.logBtn = new System.Windows.Forms.Button();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empolyeeDataSet = new EventProjectLastVersion.empolyeeDataSet();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.employeeTableAdapter = new EventProjectLastVersion.empolyeeDataSetTableAdapters.employeeTableAdapter();
            this.tableAdapterManager = new EventProjectLastVersion.empolyeeDataSetTableAdapters.TableAdapterManager();
            nameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empolyeeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(254, 166);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(47, 16);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Name:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(254, 194);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(69, 16);
            passwordLabel.TabIndex = 13;
            passwordLabel.Text = "password:";
            // 
            // logBtn
            // 
            this.logBtn.Location = new System.Drawing.Point(358, 245);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(75, 25);
            this.logBtn.TabIndex = 10;
            this.logBtn.Text = "Log in";
            this.logBtn.UseVisualStyleBackColor = true;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.empolyeeDataSet;
            // 
            // empolyeeDataSet
            // 
            this.empolyeeDataSet.DataSetName = "empolyeeDataSet";
            this.empolyeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(329, 163);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(220, 22);
            this.nameTextBox.TabIndex = 12;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(329, 191);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(220, 22);
            this.passwordTextBox.TabIndex = 14;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.employeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.UpdateOrder = EventProjectLastVersion.empolyeeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.logBtn);
            this.Name = "login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empolyeeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logBtn;
        private empolyeeDataSet empolyeeDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private empolyeeDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private empolyeeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}

