namespace the_worst_restrant_ever
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PressentMenu = new Button();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox1 = new GroupBox();
            label4 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // PressentMenu
            // 
            PressentMenu.Location = new Point(73, 236);
            PressentMenu.Name = "PressentMenu";
            PressentMenu.Size = new Size(113, 83);
            PressentMenu.TabIndex = 0;
            PressentMenu.Text = "click to show the menu";
            PressentMenu.UseVisualStyleBackColor = true;
            PressentMenu.MouseClick += ShowMenu;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 36);
            label1.Name = "label1";
            label1.Size = new Size(323, 15);
            label1.TabIndex = 1;
            label1.Text = "your order (maximen of 5, and no repeats of the same food)";
            // 
            // button1
            // 
            button1.Location = new Point(78, 207);
            button1.Name = "button1";
            button1.Size = new Size(113, 23);
            button1.TabIndex = 2;
            button1.Text = "add new order";
            button1.UseVisualStyleBackColor = true;
            button1.MouseClick += new_order;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(96, 40);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 43);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 4;
            label2.Text = "food/drink";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 68);
            label3.Name = "label3";
            label3.Size = new Size(195, 30);
            label3.TabIndex = 5;
            label3.Text = "size\r\n(ignore if food does not have a size)";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(5, 16);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(53, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "small";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(5, 38);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(70, 19);
            radioButton2.TabIndex = 7;
            radioButton2.Text = "medium";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(5, 61);
            radioButton3.Margin = new Padding(3, 2, 3, 2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(51, 19);
            radioButton3.TabIndex = 8;
            radioButton3.Text = "large";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(78, 100);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(112, 101);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "options";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(443, 249);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 10;
            label4.Text = "total price: £0";
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(403, 266);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(155, 22);
            button2.TabIndex = 11;
            button2.Text = "end ordering";
            button2.UseVisualStyleBackColor = true;
            button2.MouseClick += end_ordering;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 330);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(PressentMenu);
            Name = "Form1";
            Text = "ordering";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PressentMenu;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox groupBox1;
        private Label label4;
        private Button button2;
    }
}