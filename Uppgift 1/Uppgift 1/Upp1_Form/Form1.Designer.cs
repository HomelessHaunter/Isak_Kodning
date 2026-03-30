namespace Upp1_Form
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
            this.change = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.cost = new System.Windows.Forms.TextBox();
            this.money = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(351, 238);
            this.change.Margin = new System.Windows.Forms.Padding(4);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(100, 28);
            this.change.TabIndex = 0;
            this.change.Text = "Växel";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(77, 238);
            this.quit.Margin = new System.Windows.Forms.Padding(4);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(100, 28);
            this.quit.TabIndex = 1;
            this.quit.Text = "Avsluta";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(59, 92);
            this.cost.Margin = new System.Windows.Forms.Padding(4);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(132, 22);
            this.cost.TabIndex = 2;
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(59, 180);
            this.money.Margin = new System.Windows.Forms.Padding(4);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(132, 22);
            this.money.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F);
            this.label1.Location = new System.Drawing.Point(43, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hur mycket kostar det?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F);
            this.label2.Location = new System.Drawing.Point(43, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hur mycket pengar har du?";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(334, 12);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(138, 213);
            this.result.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 311);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.money);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.change);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Hur mycket Växel?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result;
    }
}

