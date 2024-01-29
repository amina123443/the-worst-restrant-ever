namespace the_worst_restrant_ever
{
    partial class page1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(390, 14);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "chips pages";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 58);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "chips-£2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 78);
            label3.Name = "label3";
            label3.Size = new Size(100, 80);
            label3.TabIndex = 2;
            label3.Text = "size:\r\nsmall- -£0.50\r\nmedium- +£0\r\nlarge- +£1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(415, 103);
            label4.Name = "label4";
            label4.Size = new Size(292, 20);
            label4.TabIndex = 3;
            label4.Text = "MEAL DEAL: CHIPS LARGE WITH COD = £7";
            // 
            // page1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "page1";
            Size = new Size(914, 188);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
