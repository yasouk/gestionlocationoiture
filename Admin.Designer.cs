
namespace gestionlocationoiture
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.managerDGV = new System.Windows.Forms.DataGridView();
            this.ManId = new System.Windows.Forms.TextBox();
            this.useridad = new System.Windows.Forms.Label();
            this.ManPwd = new System.Windows.Forms.TextBox();
            this.userpwdad = new System.Windows.Forms.Label();
            this.MId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.managerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(255, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(369, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Highlight;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(483, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 34);
            this.button4.TabIndex = 4;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(341, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "MANAGERS LIST:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(744, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 34);
            this.button2.TabIndex = 12;
            this.button2.Text = "return";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // managerDGV
            // 
            this.managerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managerDGV.Location = new System.Drawing.Point(12, 241);
            this.managerDGV.Name = "managerDGV";
            this.managerDGV.RowTemplate.Height = 25;
            this.managerDGV.Size = new System.Drawing.Size(840, 243);
            this.managerDGV.TabIndex = 31;
            // 
            // ManId
            // 
            this.ManId.Location = new System.Drawing.Point(275, 112);
            this.ManId.Name = "ManId";
            this.ManId.Size = new System.Drawing.Size(134, 23);
            this.ManId.TabIndex = 60;
            // 
            // useridad
            // 
            this.useridad.AutoSize = true;
            this.useridad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.useridad.Location = new System.Drawing.Point(312, 92);
            this.useridad.Name = "useridad";
            this.useridad.Size = new System.Drawing.Size(83, 17);
            this.useridad.TabIndex = 59;
            this.useridad.Text = "USER NAME:";
            // 
            // ManPwd
            // 
            this.ManPwd.Location = new System.Drawing.Point(438, 112);
            this.ManPwd.Name = "ManPwd";
            this.ManPwd.Size = new System.Drawing.Size(134, 23);
            this.ManPwd.TabIndex = 56;
            // 
            // userpwdad
            // 
            this.userpwdad.AutoSize = true;
            this.userpwdad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.userpwdad.Location = new System.Drawing.Point(469, 92);
            this.userpwdad.Name = "userpwdad";
            this.userpwdad.Size = new System.Drawing.Size(77, 17);
            this.userpwdad.TabIndex = 53;
            this.userpwdad.Text = "USER PWD:";
            // 
            // MId
            // 
            this.MId.Location = new System.Drawing.Point(106, 112);
            this.MId.Name = "MId";
            this.MId.Size = new System.Drawing.Size(134, 23);
            this.MId.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(143, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "USER ID:";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 496);
            this.Controls.Add(this.MId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ManId);
            this.Controls.Add(this.useridad);
            this.Controls.Add(this.ManPwd);
            this.Controls.Add(this.userpwdad);
            this.Controls.Add(this.managerDGV);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.managerDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView managerDGV;
        private System.Windows.Forms.TextBox ManId;
        private System.Windows.Forms.Label useridad;
        private System.Windows.Forms.TextBox ManPwd;
        private System.Windows.Forms.Label userpwdad;
        private System.Windows.Forms.TextBox MId;
        private System.Windows.Forms.Label label2;
    }
}