namespace GraphicsPackage
{
    partial class Form3
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
            this.buttonClearCircle = new System.Windows.Forms.Button();
            this.buttonPrintCircleTable = new System.Windows.Forms.Button();
            this.buttonDrawCircle = new System.Windows.Forms.Button();
            this.buttonClearInputs = new System.Windows.Forms.Button();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.panelCircle = new System.Windows.Forms.Panel();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelBackground.Controls.Add(this.buttonClearCircle);
            this.panelBackground.Controls.Add(this.buttonPrintCircleTable);
            this.panelBackground.Controls.Add(this.buttonDrawCircle);
            this.panelBackground.Controls.Add(this.buttonClearInputs);
            this.panelBackground.Controls.Add(this.textBoxRadius);
            this.panelBackground.Controls.Add(this.label4);
            this.panelBackground.Controls.Add(this.textBoxY);
            this.panelBackground.Controls.Add(this.label2);
            this.panelBackground.Controls.Add(this.label1);
            this.panelBackground.Controls.Add(this.textBoxX);
            this.panelBackground.Controls.Add(this.panelCircle);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(929, 551);
            this.panelBackground.TabIndex = 0;
            this.panelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBackground_Paint);
            // 
            // buttonClearCircle
            // 
            this.buttonClearCircle.BackColor = System.Drawing.Color.White;
            this.buttonClearCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearCircle.Location = new System.Drawing.Point(61, 385);
            this.buttonClearCircle.Name = "buttonClearCircle";
            this.buttonClearCircle.Size = new System.Drawing.Size(168, 48);
            this.buttonClearCircle.TabIndex = 13;
            this.buttonClearCircle.Text = "Clear Circle";
            this.buttonClearCircle.UseVisualStyleBackColor = false;
            this.buttonClearCircle.Click += new System.EventHandler(this.buttonClearCircle_Click);
            // 
            // buttonPrintCircleTable
            // 
            this.buttonPrintCircleTable.BackColor = System.Drawing.Color.White;
            this.buttonPrintCircleTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintCircleTable.Location = new System.Drawing.Point(12, 300);
            this.buttonPrintCircleTable.Name = "buttonPrintCircleTable";
            this.buttonPrintCircleTable.Size = new System.Drawing.Size(237, 52);
            this.buttonPrintCircleTable.TabIndex = 12;
            this.buttonPrintCircleTable.Text = "Print Circle Table";
            this.buttonPrintCircleTable.UseVisualStyleBackColor = false;
            this.buttonPrintCircleTable.Click += new System.EventHandler(this.buttonPrintTable_Click);
            // 
            // buttonDrawCircle
            // 
            this.buttonDrawCircle.BackColor = System.Drawing.Color.White;
            this.buttonDrawCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDrawCircle.Location = new System.Drawing.Point(12, 244);
            this.buttonDrawCircle.Name = "buttonDrawCircle";
            this.buttonDrawCircle.Size = new System.Drawing.Size(237, 50);
            this.buttonDrawCircle.TabIndex = 10;
            this.buttonDrawCircle.Text = "Draw Circle";
            this.buttonDrawCircle.UseVisualStyleBackColor = false;
            this.buttonDrawCircle.Click += new System.EventHandler(this.buttonDrawCircle_Click);
            // 
            // buttonClearInputs
            // 
            this.buttonClearInputs.BackColor = System.Drawing.Color.White;
            this.buttonClearInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearInputs.Location = new System.Drawing.Point(94, 177);
            this.buttonClearInputs.Name = "buttonClearInputs";
            this.buttonClearInputs.Size = new System.Drawing.Size(169, 42);
            this.buttonClearInputs.TabIndex = 9;
            this.buttonClearInputs.Text = "Clear Inputs";
            this.buttonClearInputs.UseVisualStyleBackColor = false;
            this.buttonClearInputs.Click += new System.EventHandler(this.buttonClearInputs_Click);
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Location = new System.Drawing.Point(113, 137);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(116, 22);
            this.textBoxRadius.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(14, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Radius";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(113, 97);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(116, 22);
            this.textBoxY.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(14, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y center";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "X center";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(113, 58);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(116, 22);
            this.textBoxX.TabIndex = 1;
            // 
            // panelCircle
            // 
            this.panelCircle.BackColor = System.Drawing.Color.Cyan;
            this.panelCircle.Location = new System.Drawing.Point(269, 12);
            this.panelCircle.Name = "panelCircle";
            this.panelCircle.Size = new System.Drawing.Size(648, 527);
            this.panelCircle.TabIndex = 0;
            this.panelCircle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCircle_Paint);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 551);
            this.Controls.Add(this.panelBackground);
            this.Name = "Form3";
            this.Text = "Circle Generating Algorithms";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Panel panelCircle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonClearInputs;
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDrawCircle;
        private System.Windows.Forms.Button buttonPrintCircleTable;
        private System.Windows.Forms.Button buttonClearCircle;
    }
}