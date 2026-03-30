namespace Uppgift3
{
    partial class Start
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
            this.strt = new System.Windows.Forms.Button();
            this.avsluta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // strt
            // 
            this.strt.Location = new System.Drawing.Point(125, 116);
            this.strt.Name = "strt";
            this.strt.Size = new System.Drawing.Size(152, 30);
            this.strt.TabIndex = 0;
            this.strt.Text = "Lägg till personnummer";
            this.strt.UseVisualStyleBackColor = true;
            this.strt.Click += new System.EventHandler(this.strt_Click);
            // 
            // avsluta
            // 
            this.avsluta.Location = new System.Drawing.Point(168, 186);
            this.avsluta.Name = "avsluta";
            this.avsluta.Size = new System.Drawing.Size(75, 28);
            this.avsluta.TabIndex = 1;
            this.avsluta.Text = "Avsluta";
            this.avsluta.UseVisualStyleBackColor = true;
            this.avsluta.Click += new System.EventHandler(this.avsluta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hej! Vad vill du göra?";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.avsluta);
            this.Controls.Add(this.strt);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button strt;
        private System.Windows.Forms.Button avsluta;
        private System.Windows.Forms.Label label1;
    }
}