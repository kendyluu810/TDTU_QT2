namespace Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.btnBuy = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nexa-Trial Heavy", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(389, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(755, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO HCM METRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nexa Text-Trial Book", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(87)))));
            this.label2.Location = new System.Drawing.Point(653, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "12:05:45 AM";
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(681, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 115);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nexa Text-Trial Heavy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(87)))));
            this.label4.Location = new System.Drawing.Point(518, 582);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(476, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "PLEASE MAKE A SELECTION";
            // 
            // date
            // 
            this.date.CalendarFont = new System.Drawing.Font("Nexa Text-Trial Book", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(87)))));
            this.date.Location = new System.Drawing.Point(656, 311);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 23);
            this.date.TabIndex = 4;
            // 
            // btnBuy
            // 
            this.btnBuy.AutoSize = true;
            this.btnBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(168)))));
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Nexa Text-Trial Heavy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.btnBuy.Location = new System.Drawing.Point(419, 668);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(271, 50);
            this.btnBuy.TabIndex = 5;
            this.btnBuy.Text = "BUY NEW CARD ";
            this.btnBuy.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(168)))));
            this.button2.Font = new System.Drawing.Font("Nexa Text-Trial Heavy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(791, 668);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(410, 52);
            this.button2.TabIndex = 6;
            this.button2.Text = "RECHARGE YOUR CARD";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 943);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker date;
        private Button btnBuy;
        private Button button2;
    }
}