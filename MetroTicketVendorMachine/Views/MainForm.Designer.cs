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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnRecharge = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
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
            this.date.Value = new System.DateTime(2023, 3, 30, 0, 0, 0, 0);
            // 
            // btnBuy
            // 
            this.btnBuy.AutoSize = true;
            this.btnBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(168)))));
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Nexa Text-Trial Heavy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.btnBuy.Location = new System.Drawing.Point(419, 668);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(271, 50);
            this.btnBuy.TabIndex = 5;
            this.btnBuy.Text = "BUY NEW CARD ";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnRecharge
            // 
            this.btnRecharge.AutoSize = true;
            this.btnRecharge.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRecharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(168)))));
            this.btnRecharge.Font = new System.Drawing.Font("Nexa Text-Trial Heavy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRecharge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.btnRecharge.Location = new System.Drawing.Point(791, 668);
            this.btnRecharge.Name = "btnRecharge";
            this.btnRecharge.Size = new System.Drawing.Size(410, 52);
            this.btnRecharge.TabIndex = 6;
            this.btnRecharge.Text = "RECHARGE YOUR CARD";
            this.btnRecharge.UseVisualStyleBackColor = false;
            this.btnRecharge.Click += new System.EventHandler(this.btnRecharge_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Nexa Text-Trial Book", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(87)))));
            this.time.Location = new System.Drawing.Point(703, 355);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 42);
            this.time.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 943);
            this.Controls.Add(this.time);
            this.Controls.Add(this.btnRecharge);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private DateTimePicker date;
        private Button btnBuy;
        private Button btnRecharge;
        private System.Windows.Forms.Timer timer1;
        private Label time;
    }
}