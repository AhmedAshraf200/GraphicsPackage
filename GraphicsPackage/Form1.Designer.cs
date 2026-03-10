namespace GraphicsPackage
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
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2D_Transformation = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonDrawLine = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Cyan;
            this.panelDesktop.Controls.Add(this.label4);
            this.panelDesktop.Controls.Add(this.label3);
            this.panelDesktop.Controls.Add(this.panel2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(868, 423);
            this.panelDesktop.TabIndex = 0;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(328, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 69);
            this.label4.TabIndex = 2;
            this.label4.Text = "Algorithms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(238, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(533, 69);
            this.label3.TabIndex = 1;
            this.label3.Text = "Graphics Package";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.button2D_Transformation);
            this.panel2.Controls.Add(this.buttonEllipse);
            this.panel2.Controls.Add(this.buttonCircle);
            this.panel2.Controls.Add(this.buttonDrawLine);
            this.panel2.Controls.Add(this.panelLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 423);
            this.panel2.TabIndex = 0;
            // 
            // button2D_Transformation
            // 
            this.button2D_Transformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2D_Transformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2D_Transformation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2D_Transformation.Location = new System.Drawing.Point(3, 343);
            this.button2D_Transformation.Name = "button2D_Transformation";
            this.button2D_Transformation.Size = new System.Drawing.Size(194, 75);
            this.button2D_Transformation.TabIndex = 4;
            this.button2D_Transformation.Text = "2D Transformation";
            this.button2D_Transformation.UseVisualStyleBackColor = true;
            this.button2D_Transformation.Click += new System.EventHandler(this.button2D_Transformation_Click);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEllipse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEllipse.Location = new System.Drawing.Point(3, 261);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(194, 76);
            this.buttonEllipse.TabIndex = 3;
            this.buttonEllipse.Text = "Ellipse";
            this.buttonEllipse.UseVisualStyleBackColor = true;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCircle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCircle.Location = new System.Drawing.Point(3, 182);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(194, 73);
            this.buttonCircle.TabIndex = 2;
            this.buttonCircle.Text = "Circle";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // buttonDrawLine
            // 
            this.buttonDrawLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDrawLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDrawLine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDrawLine.Location = new System.Drawing.Point(3, 106);
            this.buttonDrawLine.Name = "buttonDrawLine";
            this.buttonDrawLine.Size = new System.Drawing.Size(194, 70);
            this.buttonDrawLine.TabIndex = 1;
            this.buttonDrawLine.Text = "Draw Line";
            this.buttonDrawLine.UseVisualStyleBackColor = true;
            this.buttonDrawLine.Click += new System.EventHandler(this.buttonDrawLine_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Algorithms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Package";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 423);
            this.Controls.Add(this.panelDesktop);
            this.Name = "Form1";
            this.Text = "Graphics Package";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2D_Transformation;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonDrawLine;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

