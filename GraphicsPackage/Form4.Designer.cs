namespace GraphicsPackage
{
    partial class Form4
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
            this.panelBackground = new System.Windows.Forms.Panel();
            this.panelEllipse = new System.Windows.Forms.Panel();
            this.textBoxRadiusY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPrintEllipseTable = new System.Windows.Forms.Button();
            this.textBoxRadiusX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxYcenter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxXcenter = new System.Windows.Forms.TextBox();
            this.buttonClearEllipse = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDrawEllipse = new System.Windows.Forms.Button();
            this.buttonClearInputs = new System.Windows.Forms.Button();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.Lime;
            this.panelBackground.Controls.Add(this.panelEllipse);
            this.panelBackground.Controls.Add(this.textBoxRadiusY);
            this.panelBackground.Controls.Add(this.label1);
            this.panelBackground.Controls.Add(this.buttonPrintEllipseTable);
            this.panelBackground.Controls.Add(this.textBoxRadiusX);
            this.panelBackground.Controls.Add(this.label5);
            this.panelBackground.Controls.Add(this.textBoxYcenter);
            this.panelBackground.Controls.Add(this.label6);
            this.panelBackground.Controls.Add(this.textBoxXcenter);
            this.panelBackground.Controls.Add(this.buttonClearEllipse);
            this.panelBackground.Controls.Add(this.label7);
            this.panelBackground.Controls.Add(this.buttonDrawEllipse);
            this.panelBackground.Controls.Add(this.buttonClearInputs);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(932, 562);
            this.panelBackground.TabIndex = 0;
            // 
            // panelEllipse
            // 
            this.panelEllipse.BackColor = System.Drawing.Color.Magenta;
            this.panelEllipse.Location = new System.Drawing.Point(272, 12);
            this.panelEllipse.Name = "panelEllipse";
            this.panelEllipse.Size = new System.Drawing.Size(648, 538);
            this.panelEllipse.TabIndex = 39;
            // 
            // textBoxRadiusY
            // 
            this.textBoxRadiusY.Location = new System.Drawing.Point(147, 152);
            this.textBoxRadiusY.Name = "textBoxRadiusY";
            this.textBoxRadiusY.Size = new System.Drawing.Size(86, 22);
            this.textBoxRadiusY.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(148, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "RadiusY";
            // 
            // buttonPrintEllipseTable
            // 
            this.buttonPrintEllipseTable.BackColor = System.Drawing.Color.White;
            this.buttonPrintEllipseTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintEllipseTable.Location = new System.Drawing.Point(19, 311);
            this.buttonPrintEllipseTable.Name = "buttonPrintEllipseTable";
            this.buttonPrintEllipseTable.Size = new System.Drawing.Size(237, 52);
            this.buttonPrintEllipseTable.TabIndex = 37;
            this.buttonPrintEllipseTable.Text = "Print Ellipse Table";
            this.buttonPrintEllipseTable.UseVisualStyleBackColor = false;
            this.buttonPrintEllipseTable.Click += new System.EventHandler(this.buttonPrintEllipseTable_Click);
            // 
            // textBoxRadiusX
            // 
            this.textBoxRadiusX.Location = new System.Drawing.Point(31, 152);
            this.textBoxRadiusX.Name = "textBoxRadiusX";
            this.textBoxRadiusX.Size = new System.Drawing.Size(80, 22);
            this.textBoxRadiusX.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(26, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "RadiusX";
            // 
            // textBoxYcenter
            // 
            this.textBoxYcenter.Location = new System.Drawing.Point(147, 78);
            this.textBoxYcenter.Name = "textBoxYcenter";
            this.textBoxYcenter.Size = new System.Drawing.Size(86, 22);
            this.textBoxYcenter.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(149, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Ycenter";
            // 
            // textBoxXcenter
            // 
            this.textBoxXcenter.Location = new System.Drawing.Point(31, 78);
            this.textBoxXcenter.Name = "textBoxXcenter";
            this.textBoxXcenter.Size = new System.Drawing.Size(80, 22);
            this.textBoxXcenter.TabIndex = 27;
            // 
            // buttonClearEllipse
            // 
            this.buttonClearEllipse.BackColor = System.Drawing.Color.White;
            this.buttonClearEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearEllipse.Location = new System.Drawing.Point(88, 407);
            this.buttonClearEllipse.Name = "buttonClearEllipse";
            this.buttonClearEllipse.Size = new System.Drawing.Size(168, 48);
            this.buttonClearEllipse.TabIndex = 36;
            this.buttonClearEllipse.Text = "Clear Ellipse";
            this.buttonClearEllipse.UseVisualStyleBackColor = false;
            this.buttonClearEllipse.Click += new System.EventHandler(this.buttonClearEllipse_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Lime;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(26, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Xcenter";
            // 
            // buttonDrawEllipse
            // 
            this.buttonDrawEllipse.BackColor = System.Drawing.Color.White;
            this.buttonDrawEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDrawEllipse.Location = new System.Drawing.Point(19, 255);
            this.buttonDrawEllipse.Name = "buttonDrawEllipse";
            this.buttonDrawEllipse.Size = new System.Drawing.Size(237, 50);
            this.buttonDrawEllipse.TabIndex = 35;
            this.buttonDrawEllipse.Text = "Draw Ellipse";
            this.buttonDrawEllipse.UseVisualStyleBackColor = false;
            this.buttonDrawEllipse.Click += new System.EventHandler(this.buttonDrawEllipse_Click);
            // 
            // buttonClearInputs
            // 
            this.buttonClearInputs.BackColor = System.Drawing.Color.White;
            this.buttonClearInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearInputs.Location = new System.Drawing.Point(97, 185);
            this.buttonClearInputs.Name = "buttonClearInputs";
            this.buttonClearInputs.Size = new System.Drawing.Size(169, 42);
            this.buttonClearInputs.TabIndex = 34;
            this.buttonClearInputs.Text = "Clear Inputs";
            this.buttonClearInputs.UseVisualStyleBackColor = false;
            this.buttonClearInputs.Click += new System.EventHandler(this.buttonClearInputs_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 562);
            this.Controls.Add(this.panelBackground);
            this.Name = "Form4";
            this.Text = "Ellipse Generating Algorithms";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.TextBox textBoxRadiusY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPrintEllipseTable;
        private System.Windows.Forms.TextBox textBoxRadiusX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxYcenter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxXcenter;
        private System.Windows.Forms.Button buttonClearEllipse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonDrawEllipse;
        private System.Windows.Forms.Button buttonClearInputs;
        private System.Windows.Forms.Panel panelEllipse;
    }
}