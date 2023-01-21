namespace ParserTgBot
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
            this.laber1 = new System.Windows.Forms.Label();
            this.StartNumber = new System.Windows.Forms.NumericUpDown();
            this.StartButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EndNumber = new System.Windows.Forms.NumericUpDown();
            this.AbortButton = new System.Windows.Forms.Button();
            this.ListTitles = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.StartNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // laber1
            // 
            this.laber1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.laber1.AutoSize = true;
            this.laber1.Location = new System.Drawing.Point(338, 12);
            this.laber1.Name = "laber1";
            this.laber1.Size = new System.Drawing.Size(78, 15);
            this.laber1.TabIndex = 1;
            this.laber1.Text = "Start Number";
            // 
            // StartNumber
            // 
            this.StartNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartNumber.Location = new System.Drawing.Point(338, 30);
            this.StartNumber.Name = "StartNumber";
            this.StartNumber.Size = new System.Drawing.Size(116, 23);
            this.StartNumber.TabIndex = 2;
            this.StartNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Location = new System.Drawing.Point(338, 111);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(116, 30);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Number";
            // 
            // EndNumber
            // 
            this.EndNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EndNumber.Location = new System.Drawing.Point(338, 82);
            this.EndNumber.Name = "EndNumber";
            this.EndNumber.Size = new System.Drawing.Size(116, 23);
            this.EndNumber.TabIndex = 2;
            this.EndNumber.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // AbortButton
            // 
            this.AbortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AbortButton.Location = new System.Drawing.Point(338, 147);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(116, 30);
            this.AbortButton.TabIndex = 3;
            this.AbortButton.Text = "Abort";
            this.AbortButton.UseVisualStyleBackColor = true;
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // ListTitles
            // 
            this.ListTitles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListTitles.FormattingEnabled = true;
            this.ListTitles.ItemHeight = 15;
            this.ListTitles.Location = new System.Drawing.Point(12, 12);
            this.ListTitles.Name = "ListTitles";
            this.ListTitles.Size = new System.Drawing.Size(320, 439);
            this.ListTitles.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.ListTitles);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.EndNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartNumber);
            this.Controls.Add(this.laber1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.StartNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label laber1;
        private NumericUpDown StartNumber;
        private Button StartButton;
        private Label label2;
        private NumericUpDown EndNumber;
        private Button AbortButton;
        private ListBox ListTitles;
    }
}