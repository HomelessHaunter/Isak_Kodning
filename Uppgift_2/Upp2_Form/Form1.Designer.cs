namespace Upp2_Form
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
            this.name = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.district = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.finish = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(16, 48);
            this.name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(132, 22);
            this.name.TabIndex = 0;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(16, 118);
            this.number.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(132, 22);
            this.number.TabIndex = 1;
            // 
            // district
            // 
            this.district.Location = new System.Drawing.Point(16, 181);
            this.district.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.district.Name = "district";
            this.district.Size = new System.Drawing.Size(132, 22);
            this.district.TabIndex = 2;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(16, 255);
            this.amount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(132, 22);
            this.amount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Namn:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Personnummer:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Distrikt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Antal Sålda Artiklar:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(241, 141);
            this.finish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(100, 28);
            this.finish.TabIndex = 8;
            this.finish.Text = "Sammanställ";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(241, 212);
            this.quit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(100, 28);
            this.quit.TabIndex = 9;
            this.quit.Text = "Avsluta";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(241, 72);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 28);
            this.add.TabIndex = 10;
            this.add.Text = "Lägg Till";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.add);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.district);
            this.Controls.Add(this.number);
            this.Controls.Add(this.name);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Bonussystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox district;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button add;
    }
}

