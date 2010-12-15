namespace Converter
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
            this.txInt64 = new System.Windows.Forms.TextBox();
            this.txHex64 = new System.Windows.Forms.TextBox();
            this.txDouble = new System.Windows.Forms.TextBox();
            this.txAscii = new System.Windows.Forms.TextBox();
            this.txUnicode = new System.Windows.Forms.TextBox();
            this.txFloat = new System.Windows.Forms.TextBox();
            this.bitControl1 = new BitControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txUnixtime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txInt64
            // 
            this.txInt64.BackColor = System.Drawing.Color.White;
            this.txInt64.ForeColor = System.Drawing.Color.Black;
            this.txInt64.Location = new System.Drawing.Point(68, 15);
            this.txInt64.Name = "txInt64";
            this.txInt64.Size = new System.Drawing.Size(157, 20);
            this.txInt64.TabIndex = 0;
            this.txInt64.Text = "0";
            this.txInt64.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txHex64
            // 
            this.txHex64.BackColor = System.Drawing.Color.White;
            this.txHex64.ForeColor = System.Drawing.Color.Black;
            this.txHex64.Location = new System.Drawing.Point(68, 42);
            this.txHex64.Name = "txHex64";
            this.txHex64.Size = new System.Drawing.Size(157, 20);
            this.txHex64.TabIndex = 0;
            this.txHex64.Text = "0";
            this.txHex64.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txDouble
            // 
            this.txDouble.BackColor = System.Drawing.Color.White;
            this.txDouble.ForeColor = System.Drawing.Color.Black;
            this.txDouble.Location = new System.Drawing.Point(68, 94);
            this.txDouble.Name = "txDouble";
            this.txDouble.Size = new System.Drawing.Size(157, 20);
            this.txDouble.TabIndex = 0;
            this.txDouble.Tag = "0";
            this.txDouble.Text = "0";
            this.txDouble.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txAscii
            // 
            this.txAscii.BackColor = System.Drawing.Color.White;
            this.txAscii.ForeColor = System.Drawing.Color.Black;
            this.txAscii.Location = new System.Drawing.Point(68, 120);
            this.txAscii.Name = "txAscii";
            this.txAscii.Size = new System.Drawing.Size(157, 20);
            this.txAscii.TabIndex = 0;
            this.txAscii.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txUnicode
            // 
            this.txUnicode.BackColor = System.Drawing.Color.White;
            this.txUnicode.ForeColor = System.Drawing.Color.Black;
            this.txUnicode.Location = new System.Drawing.Point(68, 146);
            this.txUnicode.Name = "txUnicode";
            this.txUnicode.Size = new System.Drawing.Size(157, 20);
            this.txUnicode.TabIndex = 0;
            this.txUnicode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txFloat
            // 
            this.txFloat.BackColor = System.Drawing.Color.White;
            this.txFloat.ForeColor = System.Drawing.Color.Black;
            this.txFloat.Location = new System.Drawing.Point(68, 68);
            this.txFloat.Name = "txFloat";
            this.txFloat.Size = new System.Drawing.Size(157, 20);
            this.txFloat.TabIndex = 0;
            this.txFloat.Tag = "0";
            this.txFloat.Text = "0";
            this.txFloat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bitControl1
            // 
            this.bitControl1.Location = new System.Drawing.Point(240, 12);
            this.bitControl1.Name = "bitControl1";
            this.bitControl1.Size = new System.Drawing.Size(357, 154);
            this.bitControl1.TabIndex = 2;
            this.bitControl1.Value = ((ulong)(0ul));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Int64";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hex64";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Float";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Double";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ascii";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Unicode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Unix time";
            // 
            // txUnixtime
            // 
            this.txUnixtime.BackColor = System.Drawing.Color.White;
            this.txUnixtime.ForeColor = System.Drawing.Color.Black;
            this.txUnixtime.Location = new System.Drawing.Point(68, 172);
            this.txUnixtime.Name = "txUnixtime";
            this.txUnixtime.Size = new System.Drawing.Size(157, 20);
            this.txUnixtime.TabIndex = 3;
            this.txUnixtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 201);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txUnixtime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txInt64);
            this.Controls.Add(this.txHex64);
            this.Controls.Add(this.txFloat);
            this.Controls.Add(this.txDouble);
            this.Controls.Add(this.txAscii);
            this.Controls.Add(this.txUnicode);
            this.Controls.Add(this.bitControl1);
            this.Name = "Form1";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txInt64;
        private System.Windows.Forms.TextBox txHex64;
        private System.Windows.Forms.TextBox txDouble;
        private System.Windows.Forms.TextBox txAscii;
        private System.Windows.Forms.TextBox txUnicode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txFloat;
        private BitControl bitControl1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txUnixtime;

    }
}

