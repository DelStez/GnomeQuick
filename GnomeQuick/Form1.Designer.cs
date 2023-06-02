namespace GnomeQuick
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
               this.components = new System.ComponentModel.Container();
               this.button1 = new System.Windows.Forms.Button();
               this.button2 = new System.Windows.Forms.Button();
               this.tabControl1 = new System.Windows.Forms.TabControl();
               this.tabPage1 = new System.Windows.Forms.TabPage();
               this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
               this.tabPage2 = new System.Windows.Forms.TabPage();
               this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
               this.tabPage3 = new System.Windows.Forms.TabPage();
               this.zedGraphControl3 = new ZedGraph.ZedGraphControl();
               this.label2 = new System.Windows.Forms.Label();
               this.textBox2 = new System.Windows.Forms.TextBox();
               this.textBox3 = new System.Windows.Forms.TextBox();
               this.textBox4 = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.label4 = new System.Windows.Forms.Label();
               this.tabControl1.SuspendLayout();
               this.tabPage1.SuspendLayout();
               this.tabPage2.SuspendLayout();
               this.tabPage3.SuspendLayout();
               this.SuspendLayout();
               // 
               // button1
               // 
               this.button1.Location = new System.Drawing.Point(610, 9);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(75, 23);
               this.button1.TabIndex = 0;
               this.button1.Text = "...";
               this.button1.UseVisualStyleBackColor = true;
               this.button1.Click += new System.EventHandler(this.Load_Click);
               // 
               // button2
               // 
               this.button2.Location = new System.Drawing.Point(546, 121);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(204, 31);
               this.button2.TabIndex = 1;
               this.button2.Text = "START";
               this.button2.UseVisualStyleBackColor = true;
               this.button2.Click += new System.EventHandler(this.start_Click);
               // 
               // tabControl1
               // 
               this.tabControl1.Controls.Add(this.tabPage1);
               this.tabControl1.Controls.Add(this.tabPage2);
               this.tabControl1.Controls.Add(this.tabPage3);
               this.tabControl1.Location = new System.Drawing.Point(5, 13);
               this.tabControl1.Name = "tabControl1";
               this.tabControl1.SelectedIndex = 0;
               this.tabControl1.Size = new System.Drawing.Size(536, 432);
               this.tabControl1.TabIndex = 23;
               // 
               // tabPage1
               // 
               this.tabPage1.Controls.Add(this.zedGraphControl1);
               this.tabPage1.Location = new System.Drawing.Point(4, 22);
               this.tabPage1.Name = "tabPage1";
               this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
               this.tabPage1.Size = new System.Drawing.Size(528, 406);
               this.tabPage1.TabIndex = 0;
               this.tabPage1.Text = "SizeTime";
               this.tabPage1.UseVisualStyleBackColor = true;
               // 
               // zedGraphControl1
               // 
               this.zedGraphControl1.IsPrintScaleAll = false;
               this.zedGraphControl1.Location = new System.Drawing.Point(3, 6);
               this.zedGraphControl1.Name = "zedGraphControl1";
               this.zedGraphControl1.ScrollGrace = 0D;
               this.zedGraphControl1.ScrollMaxX = 0D;
               this.zedGraphControl1.ScrollMaxY = 0D;
               this.zedGraphControl1.ScrollMaxY2 = 0D;
               this.zedGraphControl1.ScrollMinX = 0D;
               this.zedGraphControl1.ScrollMinY = 0D;
               this.zedGraphControl1.ScrollMinY2 = 0D;
               this.zedGraphControl1.Size = new System.Drawing.Size(393, 397);
               this.zedGraphControl1.TabIndex = 0;
               this.zedGraphControl1.UseExtendedPrintDialog = true;
               // 
               // tabPage2
               // 
               this.tabPage2.Controls.Add(this.zedGraphControl2);
               this.tabPage2.Location = new System.Drawing.Point(4, 22);
               this.tabPage2.Name = "tabPage2";
               this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
               this.tabPage2.Size = new System.Drawing.Size(528, 406);
               this.tabPage2.TabIndex = 1;
               this.tabPage2.Text = "TimeSwap";
               this.tabPage2.UseVisualStyleBackColor = true;
               // 
               // zedGraphControl2
               // 
               this.zedGraphControl2.Location = new System.Drawing.Point(6, 9);
               this.zedGraphControl2.Name = "zedGraphControl2";
               this.zedGraphControl2.ScrollGrace = 0D;
               this.zedGraphControl2.ScrollMaxX = 0D;
               this.zedGraphControl2.ScrollMaxY = 0D;
               this.zedGraphControl2.ScrollMaxY2 = 0D;
               this.zedGraphControl2.ScrollMinX = 0D;
               this.zedGraphControl2.ScrollMinY = 0D;
               this.zedGraphControl2.ScrollMinY2 = 0D;
               this.zedGraphControl2.Size = new System.Drawing.Size(397, 388);
               this.zedGraphControl2.TabIndex = 24;
               this.zedGraphControl2.UseExtendedPrintDialog = true;
               // 
               // tabPage3
               // 
               this.tabPage3.Controls.Add(this.zedGraphControl3);
               this.tabPage3.Location = new System.Drawing.Point(4, 22);
               this.tabPage3.Name = "tabPage3";
               this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
               this.tabPage3.Size = new System.Drawing.Size(528, 406);
               this.tabPage3.TabIndex = 2;
               this.tabPage3.Text = "TimeCompr";
               this.tabPage3.UseVisualStyleBackColor = true;
               // 
               // zedGraphControl3
               // 
               this.zedGraphControl3.Location = new System.Drawing.Point(6, 9);
               this.zedGraphControl3.Name = "zedGraphControl3";
               this.zedGraphControl3.ScrollGrace = 0D;
               this.zedGraphControl3.ScrollMaxX = 0D;
               this.zedGraphControl3.ScrollMaxY = 0D;
               this.zedGraphControl3.ScrollMaxY2 = 0D;
               this.zedGraphControl3.ScrollMinX = 0D;
               this.zedGraphControl3.ScrollMinY = 0D;
               this.zedGraphControl3.ScrollMinY2 = 0D;
               this.zedGraphControl3.Size = new System.Drawing.Size(397, 388);
               this.zedGraphControl3.TabIndex = 25;
               this.zedGraphControl3.UseExtendedPrintDialog = true;
               // 
               // label2
               // 
               this.label2.Location = new System.Drawing.Point(546, 9);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(58, 23);
               this.label2.TabIndex = 7;
               this.label2.Text = "Входное";
               // 
               // textBox2
               // 
               this.textBox2.Location = new System.Drawing.Point(547, 41);
               this.textBox2.Multiline = true;
               this.textBox2.Name = "textBox2";
               this.textBox2.ReadOnly = true;
               this.textBox2.Size = new System.Drawing.Size(387, 74);
               this.textBox2.TabIndex = 5;
               // 
               // textBox3
               // 
               this.textBox3.Location = new System.Drawing.Point(716, 196);
               this.textBox3.Multiline = true;
               this.textBox3.Name = "textBox3";
               this.textBox3.ReadOnly = true;
               this.textBox3.Size = new System.Drawing.Size(106, 244);
               this.textBox3.TabIndex = 24;
               // 
               // textBox4
               // 
               this.textBox4.Location = new System.Drawing.Point(828, 197);
               this.textBox4.Multiline = true;
               this.textBox4.Name = "textBox4";
               this.textBox4.ReadOnly = true;
               this.textBox4.Size = new System.Drawing.Size(106, 244);
               this.textBox4.TabIndex = 25;
               // 
               // label1
               // 
               this.label1.Location = new System.Drawing.Point(716, 170);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(58, 23);
               this.label1.TabIndex = 26;
               this.label1.Text = "Gnom";
               // 
               // label3
               // 
               this.label3.Location = new System.Drawing.Point(828, 170);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(86, 23);
               this.label3.TabIndex = 27;
               this.label3.Text = "Trim";
               // 
               // textBox1
               // 
               this.textBox1.Location = new System.Drawing.Point(547, 197);
               this.textBox1.Multiline = true;
               this.textBox1.Name = "textBox1";
               this.textBox1.ReadOnly = true;
               this.textBox1.Size = new System.Drawing.Size(163, 241);
               this.textBox1.TabIndex = 28;
               // 
               // label4
               // 
               this.label4.Location = new System.Drawing.Point(560, 170);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(86, 23);
               this.label4.TabIndex = 29;
               this.label4.Text = "Логи";
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(947, 452);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.textBox4);
               this.Controls.Add(this.textBox3);
               this.Controls.Add(this.tabControl1);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.textBox2);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.button1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
               this.Name = "Form1";
               this.Text = "GnomeTrim";
               this.tabControl1.ResumeLayout(false);
               this.tabPage1.ResumeLayout(false);
               this.tabPage2.ResumeLayout(false);
               this.tabPage3.ResumeLayout(false);
               this.ResumeLayout(false);
               this.PerformLayout();
           }

        private ZedGraph.ZedGraphControl zedGraphControl1;

        private System.Windows.Forms.Label label4;

        private ZedGraph.ZedGraphControl zedGraphControl3;

        private ZedGraph.ZedGraphControl zedGraphControl2;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;

        private System.Windows.Forms.TabPage tabPage3;

        private System.Windows.Forms.TabControl tabControl1;

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;

        #endregion
    }
}