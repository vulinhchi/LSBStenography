namespace Again_LSB
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1_chonanh = new System.Windows.Forms.Button();
            this.Btn_Encode = new System.Windows.Forms.Button();
            this.Btn_Decode = new System.Windows.Forms.Button();
            this.text_Mess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(93, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 238);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            //this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1_chonanh
            // 
            this.button1_chonanh.Location = new System.Drawing.Point(12, 12);
            this.button1_chonanh.Name = "button1_chonanh";
            this.button1_chonanh.Size = new System.Drawing.Size(75, 23);
            this.button1_chonanh.TabIndex = 1;
            this.button1_chonanh.Text = "Chọn ảnh";
            this.button1_chonanh.UseVisualStyleBackColor = true;
            this.button1_chonanh.Click += new System.EventHandler(this.button1_chonanh_Click);
            // 
            // Btn_Encode
            // 
            this.Btn_Encode.Location = new System.Drawing.Point(12, 59);
            this.Btn_Encode.Name = "Btn_Encode";
            this.Btn_Encode.Size = new System.Drawing.Size(75, 23);
            this.Btn_Encode.TabIndex = 2;
            this.Btn_Encode.Text = "Encode";
            this.Btn_Encode.UseVisualStyleBackColor = true;
            this.Btn_Encode.Click += new System.EventHandler(this.Btn_Encode_Click);
            // 
            // Btn_Decode
            // 
            this.Btn_Decode.Location = new System.Drawing.Point(12, 110);
            this.Btn_Decode.Name = "Btn_Decode";
            this.Btn_Decode.Size = new System.Drawing.Size(75, 23);
            this.Btn_Decode.TabIndex = 3;
            this.Btn_Decode.Text = "Decode";
            this.Btn_Decode.UseVisualStyleBackColor = true;
            this.Btn_Decode.Click += new System.EventHandler(this.Btn_Decode_Click);
            // 
            // text_Mess
            // 
            this.text_Mess.Location = new System.Drawing.Point(93, 265);
            this.text_Mess.Name = "text_Mess";
            this.text_Mess.Size = new System.Drawing.Size(291, 20);
            this.text_Mess.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 306);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_Mess);
            this.Controls.Add(this.Btn_Decode);
            this.Controls.Add(this.Btn_Encode);
            this.Controls.Add(this.button1_chonanh);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1_chonanh;
        private System.Windows.Forms.Button Btn_Encode;
        private System.Windows.Forms.Button Btn_Decode;
        private System.Windows.Forms.TextBox text_Mess;
        private System.Windows.Forms.Label label1;
    }
}

