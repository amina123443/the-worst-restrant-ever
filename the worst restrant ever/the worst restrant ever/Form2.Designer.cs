namespace the_worst_restrant_ever
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
            previous = new Button();
            next = new Button();
            page11 = new page1();
            page21 = new page2();
            page31 = new page3();
            SuspendLayout();
            // 
            // previous
            // 
            previous.Location = new Point(88, 287);
            previous.Margin = new Padding(3, 4, 3, 4);
            previous.Name = "previous";
            previous.Size = new Size(86, 31);
            previous.TabIndex = 1;
            previous.Text = "previous";
            previous.UseVisualStyleBackColor = true;
            previous.MouseClick += LastPage;
            // 
            // next
            // 
            next.Location = new Point(687, 287);
            next.Margin = new Padding(3, 4, 3, 4);
            next.Name = "next";
            next.Size = new Size(86, 31);
            next.TabIndex = 2;
            next.Text = "next";
            next.UseVisualStyleBackColor = true;
            next.MouseClick += next_MouseClick;
            // 
            // page11
            // 
            page11.Location = new Point(0, 0);
            page11.Name = "page11";
            page11.Size = new Size(914, 188);
            page11.TabIndex = 3;
            page11.Load += page11_Load;
            // 
            // page21
            // 
            page21.Location = new Point(0, 0);
            page21.Name = "page21";
            page21.Size = new Size(914, 188);
            page21.TabIndex = 4;
            // 
            // page31
            // 
            page31.Location = new Point(0, 0);
            page31.Name = "page31";
            page31.Size = new Size(914, 188);
            page31.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 361);
            Controls.Add(page31);
            Controls.Add(page21);
            Controls.Add(page11);
            Controls.Add(next);
            Controls.Add(previous);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "menu";
            Load += Form2_Load;
            MouseClick += Form2_MouseClick;
            ResumeLayout(false);
        }

        #endregion
        private Button previous;
        private Button next;
        private page1 page11;
        private page2 page21;
        private page3 page31;
    }
}