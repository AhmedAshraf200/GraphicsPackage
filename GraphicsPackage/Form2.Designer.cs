namespace GraphicsPackage
{
    partial class Form2
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
            this.buttonClearLine = new System.Windows.Forms.Button();
            this.buttonClearPoints = new System.Windows.Forms.Button();
            this.buttonBresenham_Table = new System.Windows.Forms.Button();
            this.buttonBresenham = new System.Windows.Forms.Button();
            this.buttonDDA_Table = new System.Windows.Forms.Button();
            this.buttonDDA = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.panelLine = new System.Windows.Forms.Panel();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelBackground.Controls.Add(this.buttonClearLine);
            this.panelBackground.Controls.Add(this.buttonClearPoints);
            this.panelBackground.Controls.Add(this.buttonBresenham_Table);
            this.panelBackground.Controls.Add(this.buttonBresenham);
            this.panelBackground.Controls.Add(this.buttonDDA_Table);
            this.panelBackground.Controls.Add(this.buttonDDA);
            this.panelBackground.Controls.Add(this.label6);
            this.panelBackground.Controls.Add(this.label5);
            this.panelBackground.Controls.Add(this.label4);
            this.panelBackground.Controls.Add(this.label3);
            this.panelBackground.Controls.Add(this.label2);
            this.panelBackground.Controls.Add(this.label1);
            this.panelBackground.Controls.Add(this.textBoxY2);
            this.panelBackground.Controls.Add(this.textBoxX2);
            this.panelBackground.Controls.Add(this.textBoxY1);
            this.panelBackground.Controls.Add(this.textBoxX1);
            this.panelBackground.Controls.Add(this.panelLine);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1051, 568);
            this.panelBackground.TabIndex = 0;
            // 
            // buttonClearLine
            // 
            this.buttonClearLine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClearLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonClearLine.Location = new System.Drawing.Point(74, 364);
            this.buttonClearLine.Name = "buttonClearLine";
            this.buttonClearLine.Size = new System.Drawing.Size(147, 47);
            this.buttonClearLine.TabIndex = 14;
            this.buttonClearLine.Text = "Clear Line";
            this.buttonClearLine.UseVisualStyleBackColor = false;
            this.buttonClearLine.Click += new System.EventHandler(this.buttonClearLine_Click);
            // 
            // buttonClearPoints
            // 
            this.buttonClearPoints.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClearPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonClearPoints.Location = new System.Drawing.Point(145, 169);
            this.buttonClearPoints.Name = "buttonClearPoints";
            this.buttonClearPoints.Size = new System.Drawing.Size(168, 38);
            this.buttonClearPoints.TabIndex = 13;
            this.buttonClearPoints.Text = "Clear Points";
            this.buttonClearPoints.UseVisualStyleBackColor = false;
            this.buttonClearPoints.Click += new System.EventHandler(this.buttonClearPoints_Click);
            // 
            // buttonBresenham_Table
            // 
            this.buttonBresenham_Table.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBresenham_Table.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBresenham_Table.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonBresenham_Table.Location = new System.Drawing.Point(153, 290);
            this.buttonBresenham_Table.Name = "buttonBresenham_Table";
            this.buttonBresenham_Table.Size = new System.Drawing.Size(169, 58);
            this.buttonBresenham_Table.TabIndex = 12;
            this.buttonBresenham_Table.Text = "Print Bresenham Table";
            this.buttonBresenham_Table.UseVisualStyleBackColor = false;
            this.buttonBresenham_Table.Click += new System.EventHandler(this.buttonBresenham_Table_Click);
            // 
            // buttonBresenham
            // 
            this.buttonBresenham.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBresenham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBresenham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonBresenham.Location = new System.Drawing.Point(4, 290);
            this.buttonBresenham.Name = "buttonBresenham";
            this.buttonBresenham.Size = new System.Drawing.Size(143, 58);
            this.buttonBresenham.TabIndex = 12;
            this.buttonBresenham.Text = "Draw Line Bresenham";
            this.buttonBresenham.UseVisualStyleBackColor = false;
            this.buttonBresenham.Click += new System.EventHandler(this.buttonBresenham_Click);
            // 
            // buttonDDA_Table
            // 
            this.buttonDDA_Table.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDDA_Table.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDDA_Table.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonDDA_Table.Location = new System.Drawing.Point(153, 227);
            this.buttonDDA_Table.Name = "buttonDDA_Table";
            this.buttonDDA_Table.Size = new System.Drawing.Size(169, 57);
            this.buttonDDA_Table.TabIndex = 11;
            this.buttonDDA_Table.Text = "Print DDA Table";
            this.buttonDDA_Table.UseVisualStyleBackColor = false;
            this.buttonDDA_Table.Click += new System.EventHandler(this.buttonDDA_Table_Click);
            // 
            // buttonDDA
            // 
            this.buttonDDA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDDA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonDDA.Location = new System.Drawing.Point(4, 227);
            this.buttonDDA.Name = "buttonDDA";
            this.buttonDDA.Size = new System.Drawing.Size(143, 57);
            this.buttonDDA.TabIndex = 10;
            this.buttonDDA.Text = "Draw Line DDA";
            this.buttonDDA.UseVisualStyleBackColor = false;
            this.buttonDDA.Click += new System.EventHandler(this.buttonDDA_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(163, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Y1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(163, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Y2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(69, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "X1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(69, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "X2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(27, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "P2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(27, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "P1";
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(153, 141);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(47, 22);
            this.textBoxY2.TabIndex = 2;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(69, 141);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(47, 22);
            this.textBoxX2.TabIndex = 3;
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(153, 73);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(47, 22);
            this.textBoxY1.TabIndex = 2;
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(69, 73);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(47, 22);
            this.textBoxX1.TabIndex = 1;
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.Yellow;
            this.panelLine.Location = new System.Drawing.Point(327, 12);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(712, 544);
            this.panelLine.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 568);
            this.Controls.Add(this.panelBackground);
            this.Name = "Form2";
            this.Text = "Line Drawing Algorithm";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Button buttonBresenham_Table;
        private System.Windows.Forms.Button buttonBresenham;
        private System.Windows.Forms.Button buttonDDA_Table;
        private System.Windows.Forms.Button buttonDDA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.Button buttonClearLine;
        private System.Windows.Forms.Button buttonClearPoints;
    }
}