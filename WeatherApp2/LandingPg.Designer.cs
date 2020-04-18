namespace WeatherApp2
{
    partial class LandingPg
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
            this.Cbox1 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LvDirection = new System.Windows.Forms.ListView();
            this.LvSpeed = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LvSunset = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LvHumidity = new System.Windows.Forms.ListView();
            this.LvSunrise = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.LvPressure = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cbox1
            // 
            this.Cbox1.FormattingEnabled = true;
            this.Cbox1.Location = new System.Drawing.Point(25, 44);
            this.Cbox1.Name = "Cbox1";
            this.Cbox1.Size = new System.Drawing.Size(164, 21);
            this.Cbox1.TabIndex = 0;
            this.Cbox1.SelectedIndexChanged += new System.EventHandler(this.Cbox1_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(205, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(164, 155);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temperature Reading";
            // 
            // LvDirection
            // 
            this.LvDirection.HideSelection = false;
            this.LvDirection.Location = new System.Drawing.Point(569, 44);
            this.LvDirection.Name = "LvDirection";
            this.LvDirection.Size = new System.Drawing.Size(164, 155);
            this.LvDirection.TabIndex = 4;
            this.LvDirection.UseCompatibleStateImageBehavior = false;
            // 
            // LvSpeed
            // 
            this.LvSpeed.HideSelection = false;
            this.LvSpeed.Location = new System.Drawing.Point(386, 44);
            this.LvSpeed.Name = "LvSpeed";
            this.LvSpeed.Size = new System.Drawing.Size(164, 155);
            this.LvSpeed.TabIndex = 5;
            this.LvSpeed.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wind Direction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wind Speed";
            // 
            // LvSunset
            // 
            this.LvSunset.HideSelection = false;
            this.LvSunset.Location = new System.Drawing.Point(569, 260);
            this.LvSunset.Name = "LvSunset";
            this.LvSunset.Size = new System.Drawing.Size(164, 155);
            this.LvSunset.TabIndex = 8;
            this.LvSunset.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Humidity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(566, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sunset Time";
            // 
            // LvHumidity
            // 
            this.LvHumidity.HideSelection = false;
            this.LvHumidity.Location = new System.Drawing.Point(205, 260);
            this.LvHumidity.Name = "LvHumidity";
            this.LvHumidity.Size = new System.Drawing.Size(164, 155);
            this.LvHumidity.TabIndex = 11;
            this.LvHumidity.UseCompatibleStateImageBehavior = false;
            // 
            // LvSunrise
            // 
            this.LvSunrise.HideSelection = false;
            this.LvSunrise.Location = new System.Drawing.Point(386, 260);
            this.LvSunrise.Name = "LvSunrise";
            this.LvSunrise.Size = new System.Drawing.Size(164, 155);
            this.LvSunrise.TabIndex = 12;
            this.LvSunrise.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sunrise Time";
            // 
            // LvPressure
            // 
            this.LvPressure.HideSelection = false;
            this.LvPressure.Location = new System.Drawing.Point(25, 260);
            this.LvPressure.Name = "LvPressure";
            this.LvPressure.Size = new System.Drawing.Size(164, 155);
            this.LvPressure.TabIndex = 14;
            this.LvPressure.UseCompatibleStateImageBehavior = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Pressure";
            // 
            // LandingPg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 443);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LvPressure);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LvSunrise);
            this.Controls.Add(this.LvHumidity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LvSunset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LvSpeed);
            this.Controls.Add(this.LvDirection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Cbox1);
            this.Name = "LandingPg";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView LvDirection;
        private System.Windows.Forms.ListView LvSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView LvSunset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView LvHumidity;
        private System.Windows.Forms.ListView LvSunrise;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView LvPressure;
        private System.Windows.Forms.Label label8;
    }
}

