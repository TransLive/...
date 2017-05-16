namespace SDKU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.start = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.start.Location = new System.Drawing.Point(879, 198);
            this.start.Margin = new System.Windows.Forms.Padding(2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(301, 110);
            this.start.TabIndex = 1;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(879, 376);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(301, 110);
            this.button2.TabIndex = 1;
            this.button2.Text = "提示";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // restart
            // 
            this.restart.Enabled = false;
            this.restart.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.restart.Location = new System.Drawing.Point(879, 376);
            this.restart.Margin = new System.Windows.Forms.Padding(2);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(301, 110);
            this.restart.TabIndex = 1;
            this.restart.Text = "New";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(876, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 53);
            this.label1.TabIndex = 3;
            this.label1.Text = "Left:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 684);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sudoku-Jue";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }



        #endregion
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Label label1;
    }
}

