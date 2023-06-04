namespace projectDemo
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sifreUzunluguLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.ABCcheckBox = new System.Windows.Forms.CheckBox();
            this._123checkBox = new System.Windows.Forms.CheckBox();
            this.abc_checkBox = new System.Windows.Forms.CheckBox();
            this.operators_checkBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(73, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Şifreyi oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(90, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şifre Uzunluğu: ";
            // 
            // sifreUzunluguLabel
            // 
            this.sifreUzunluguLabel.AutoSize = true;
            this.sifreUzunluguLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreUzunluguLabel.Location = new System.Drawing.Point(239, 48);
            this.sifreUzunluguLabel.Name = "sifreUzunluguLabel";
            this.sifreUzunluguLabel.Size = new System.Drawing.Size(23, 25);
            this.sifreUzunluguLabel.TabIndex = 2;
            this.sifreUzunluguLabel.Text = "8";
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar1.Location = new System.Drawing.Point(70, 96);
            this.trackBar1.Maximum = 18;
            this.trackBar1.Minimum = 8;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(219, 56);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(65, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hangi karakterleri içersin?";
            // 
            // ABCcheckBox
            // 
            this.ABCcheckBox.AutoSize = true;
            this.ABCcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ABCcheckBox.Location = new System.Drawing.Point(84, 221);
            this.ABCcheckBox.Name = "ABCcheckBox";
            this.ABCcheckBox.Size = new System.Drawing.Size(76, 29);
            this.ABCcheckBox.TabIndex = 5;
            this.ABCcheckBox.Text = "ABC";
            this.ABCcheckBox.UseVisualStyleBackColor = true;
            this.ABCcheckBox.CheckedChanged += new System.EventHandler(this.ABCcheckBox_CheckedChanged);
            // 
            // _123checkBox
            // 
            this._123checkBox.AutoSize = true;
            this._123checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this._123checkBox.Location = new System.Drawing.Point(220, 221);
            this._123checkBox.Name = "_123checkBox";
            this._123checkBox.Size = new System.Drawing.Size(67, 29);
            this._123checkBox.TabIndex = 6;
            this._123checkBox.Text = "123";
            this._123checkBox.UseVisualStyleBackColor = true;
            this._123checkBox.CheckedChanged += new System.EventHandler(this._123checkBox_CheckedChanged);
            // 
            // abc_checkBox
            // 
            this.abc_checkBox.AutoSize = true;
            this.abc_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.abc_checkBox.Location = new System.Drawing.Point(84, 271);
            this.abc_checkBox.Name = "abc_checkBox";
            this.abc_checkBox.Size = new System.Drawing.Size(66, 29);
            this.abc_checkBox.TabIndex = 7;
            this.abc_checkBox.Text = "abc";
            this.abc_checkBox.UseVisualStyleBackColor = true;
            this.abc_checkBox.CheckedChanged += new System.EventHandler(this.abc_checkBox_CheckedChanged);
            // 
            // operators_checkBox
            // 
            this.operators_checkBox.AutoSize = true;
            this.operators_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.operators_checkBox.Location = new System.Drawing.Point(218, 271);
            this.operators_checkBox.Name = "operators_checkBox";
            this.operators_checkBox.Size = new System.Drawing.Size(63, 29);
            this.operators_checkBox.TabIndex = 8;
            this.operators_checkBox.Text = "}?#";
            this.operators_checkBox.UseVisualStyleBackColor = true;
            this.operators_checkBox.CheckedChanged += new System.EventHandler(this.operators_checkBox_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(28, 333);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 30);
            this.textBox1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(73, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 44);
            this.button2.TabIndex = 10;
            this.button2.Text = "Kopyala";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 528);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.operators_checkBox);
            this.Controls.Add(this.abc_checkBox);
            this.Controls.Add(this._123checkBox);
            this.Controls.Add(this.ABCcheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.sifreUzunluguLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Oluşturucu";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sifreUzunluguLabel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ABCcheckBox;
        private System.Windows.Forms.CheckBox _123checkBox;
        private System.Windows.Forms.CheckBox abc_checkBox;
        private System.Windows.Forms.CheckBox operators_checkBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}