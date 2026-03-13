namespace AufgabeSimonSays
{
    partial class HafnerSays
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
            this.bt_red = new System.Windows.Forms.Button();
            this.bt_yellow = new System.Windows.Forms.Button();
            this.bt_green = new System.Windows.Forms.Button();
            this.bt_blue = new System.Windows.Forms.Button();
            this.bt_start = new System.Windows.Forms.Button();
            this.lb_hafnersays = new System.Windows.Forms.Label();
            this.lb_combo = new System.Windows.Forms.Label();
            this.lb_input = new System.Windows.Forms.Label();
            this.lb_yousay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_red
            // 
            this.bt_red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_red.Location = new System.Drawing.Point(14, 61);
            this.bt_red.Name = "bt_red";
            this.bt_red.Size = new System.Drawing.Size(192, 86);
            this.bt_red.TabIndex = 0;
            this.bt_red.UseVisualStyleBackColor = false;
            // 
            // bt_yellow
            // 
            this.bt_yellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_yellow.Location = new System.Drawing.Point(212, 61);
            this.bt_yellow.Name = "bt_yellow";
            this.bt_yellow.Size = new System.Drawing.Size(192, 86);
            this.bt_yellow.TabIndex = 1;
            this.bt_yellow.UseVisualStyleBackColor = false;
            // 
            // bt_green
            // 
            this.bt_green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_green.Location = new System.Drawing.Point(14, 166);
            this.bt_green.Name = "bt_green";
            this.bt_green.Size = new System.Drawing.Size(192, 86);
            this.bt_green.TabIndex = 2;
            this.bt_green.UseVisualStyleBackColor = false;
            // 
            // bt_blue
            // 
            this.bt_blue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_blue.Location = new System.Drawing.Point(212, 166);
            this.bt_blue.Name = "bt_blue";
            this.bt_blue.Size = new System.Drawing.Size(192, 86);
            this.bt_blue.TabIndex = 3;
            this.bt_blue.UseVisualStyleBackColor = false;
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(13, 13);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(93, 46);
            this.bt_start.TabIndex = 4;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            // 
            // lb_hafnersays
            // 
            this.lb_hafnersays.AutoSize = true;
            this.lb_hafnersays.Location = new System.Drawing.Point(176, 150);
            this.lb_hafnersays.Name = "lb_hafnersays";
            this.lb_hafnersays.Size = new System.Drawing.Size(65, 13);
            this.lb_hafnersays.TabIndex = 5;
            this.lb_hafnersays.Text = "Hafner Says";
            // 
            // lb_combo
            // 
            this.lb_combo.AutoSize = true;
            this.lb_combo.Location = new System.Drawing.Point(333, 13);
            this.lb_combo.Name = "lb_combo";
            this.lb_combo.Size = new System.Drawing.Size(43, 13);
            this.lb_combo.TabIndex = 6;
            this.lb_combo.Text = "Combo:";
            // 
            // lb_input
            // 
            this.lb_input.AutoSize = true;
            this.lb_input.Location = new System.Drawing.Point(333, 30);
            this.lb_input.Name = "lb_input";
            this.lb_input.Size = new System.Drawing.Size(34, 13);
            this.lb_input.TabIndex = 7;
            this.lb_input.Text = "Input:";
            // 
            // lb_yousay
            // 
            this.lb_yousay.AutoSize = true;
            this.lb_yousay.Location = new System.Drawing.Point(185, 150);
            this.lb_yousay.Name = "lb_yousay";
            this.lb_yousay.Size = new System.Drawing.Size(47, 13);
            this.lb_yousay.TabIndex = 8;
            this.lb_yousay.Text = "You Say";
            // 
            // HafnerSays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 262);
            this.Controls.Add(this.lb_yousay);
            this.Controls.Add(this.lb_input);
            this.Controls.Add(this.lb_combo);
            this.Controls.Add(this.lb_hafnersays);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.bt_blue);
            this.Controls.Add(this.bt_green);
            this.Controls.Add(this.bt_yellow);
            this.Controls.Add(this.bt_red);
            this.Name = "HafnerSays";
            this.Text = "Hafner Says";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_red;
        private System.Windows.Forms.Button bt_yellow;
        private System.Windows.Forms.Button bt_green;
        private System.Windows.Forms.Button bt_blue;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Label lb_hafnersays;
        private System.Windows.Forms.Label lb_combo;
        private System.Windows.Forms.Label lb_input;
        private System.Windows.Forms.Label lb_yousay;
    }
}

