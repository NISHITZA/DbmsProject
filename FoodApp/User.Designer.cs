namespace FoodApp
{
    partial class User
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.nonveg = new System.Windows.Forms.Button();
            this.desert = new System.Windows.Forms.Button();
            this.veg = new System.Windows.Forms.Button();
            this.All = new System.Windows.Forms.Button();
            this.paneldo = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.paneldo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.nonveg);
            this.panel1.Controls.Add(this.desert);
            this.panel1.Controls.Add(this.veg);
            this.panel1.Controls.Add(this.All);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 847);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(0, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 67);
            this.button1.TabIndex = 4;
            this.button1.Text = "Checkout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nonveg
            // 
            this.nonveg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nonveg.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonveg.ForeColor = System.Drawing.SystemColors.Control;
            this.nonveg.Location = new System.Drawing.Point(0, 339);
            this.nonveg.Name = "nonveg";
            this.nonveg.Size = new System.Drawing.Size(279, 67);
            this.nonveg.TabIndex = 3;
            this.nonveg.Text = "Non Veg";
            this.nonveg.UseVisualStyleBackColor = true;
            this.nonveg.Click += new System.EventHandler(this.nonveg_Click);
            // 
            // desert
            // 
            this.desert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.desert.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desert.ForeColor = System.Drawing.SystemColors.Control;
            this.desert.Location = new System.Drawing.Point(0, 412);
            this.desert.Name = "desert";
            this.desert.Size = new System.Drawing.Size(279, 67);
            this.desert.TabIndex = 2;
            this.desert.Text = "Desert";
            this.desert.UseVisualStyleBackColor = true;
            this.desert.Click += new System.EventHandler(this.desert_Click);
            // 
            // veg
            // 
            this.veg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.veg.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veg.ForeColor = System.Drawing.SystemColors.Control;
            this.veg.Location = new System.Drawing.Point(0, 266);
            this.veg.Name = "veg";
            this.veg.Size = new System.Drawing.Size(279, 67);
            this.veg.TabIndex = 1;
            this.veg.Text = "Veg";
            this.veg.UseVisualStyleBackColor = true;
            this.veg.Click += new System.EventHandler(this.veg_Click);
            // 
            // All
            // 
            this.All.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.All.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All.ForeColor = System.Drawing.SystemColors.Control;
            this.All.Location = new System.Drawing.Point(0, 193);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(279, 67);
            this.All.TabIndex = 0;
            this.All.Text = "Home";
            this.All.UseVisualStyleBackColor = true;
            this.All.Click += new System.EventHandler(this.All_Click);
            // 
            // paneldo
            // 
            this.paneldo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.paneldo.Controls.Add(this.panel3);
            this.paneldo.Dock = System.Windows.Forms.DockStyle.Right;
            this.paneldo.Location = new System.Drawing.Point(277, 0);
            this.paneldo.Name = "paneldo";
            this.paneldo.Size = new System.Drawing.Size(1035, 847);
            this.paneldo.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1035, 20);
            this.panel3.TabIndex = 0;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 847);
            this.Controls.Add(this.paneldo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.panel1.ResumeLayout(false);
            this.paneldo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button desert;
        private System.Windows.Forms.Button veg;
        private System.Windows.Forms.Button All;
        private System.Windows.Forms.Panel paneldo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button nonveg;
        private System.Windows.Forms.Button button1;
    }
}