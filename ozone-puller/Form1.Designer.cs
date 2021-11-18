namespace ozone_puller
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.ConsoleList = new System.Windows.Forms.CheckedListBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ozone Game Puller";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose a platform";
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(144, 97);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 94);
            this.Confirm.TabIndex = 2;
            this.Confirm.Text = "Pull Games";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // ConsoleList
            // 
            this.ConsoleList.FormattingEnabled = true;
            this.ConsoleList.Items.AddRange(new object[] {
            "PS5",
            "PS4",
            "PC",
            "Xbox One",
            "Nintendo Switch"});
            this.ConsoleList.Location = new System.Drawing.Point(18, 97);
            this.ConsoleList.Name = "ConsoleList";
            this.ConsoleList.Size = new System.Drawing.Size(120, 94);
            this.ConsoleList.TabIndex = 3;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(18, 197);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Result.Size = new System.Drawing.Size(237, 241);
            this.Result.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.ConsoleList);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Ozone Game Puller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.CheckedListBox ConsoleList;
        private System.Windows.Forms.TextBox Result;
    }
}
