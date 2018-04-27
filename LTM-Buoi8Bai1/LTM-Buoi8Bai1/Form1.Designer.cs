namespace LTM_Buoi8Bai1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsender = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtto = new System.Windows.Forms.TextBox();
            this.txtsub = new System.Windows.Forms.TextBox();
            this.txtbody = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Body";
            // 
            // txtsender
            // 
            this.txtsender.Location = new System.Drawing.Point(179, 51);
            this.txtsender.Name = "txtsender";
            this.txtsender.Size = new System.Drawing.Size(331, 22);
            this.txtsender.TabIndex = 5;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(179, 106);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(331, 22);
            this.txtpass.TabIndex = 6;
            // 
            // txtto
            // 
            this.txtto.Location = new System.Drawing.Point(179, 169);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(331, 22);
            this.txtto.TabIndex = 7;
            // 
            // txtsub
            // 
            this.txtsub.Location = new System.Drawing.Point(179, 219);
            this.txtsub.Name = "txtsub";
            this.txtsub.Size = new System.Drawing.Size(331, 22);
            this.txtsub.TabIndex = 8;
            // 
            // txtbody
            // 
            this.txtbody.Location = new System.Drawing.Point(179, 266);
            this.txtbody.Multiline = true;
            this.txtbody.Name = "txtbody";
            this.txtbody.Size = new System.Drawing.Size(331, 111);
            this.txtbody.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbody);
            this.Controls.Add(this.txtsub);
            this.Controls.Add(this.txtto);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtsender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Send Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsender;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtto;
        private System.Windows.Forms.TextBox txtsub;
        private System.Windows.Forms.TextBox txtbody;
        private System.Windows.Forms.Button button1;
    }
}

