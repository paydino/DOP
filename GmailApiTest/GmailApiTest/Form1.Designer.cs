
namespace GmailApiTest
{
    partial class Form1
    {


        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxCC = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxAttachment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "To :";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(134, 266);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(406, 164);
            this.textBoxMessage.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send email";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(359, 231);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(70, 29);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add Attach";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "CC :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Subject :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Message";
            // 
            // textBoxTo
            // 
            this.textBoxTo.AccessibleName = "textBoxTo";
            this.textBoxTo.Location = new System.Drawing.Point(359, 119);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(181, 27);
            this.textBoxTo.TabIndex = 7;
            // 
            // textBoxCC
            // 
            this.textBoxCC.AccessibleName = "textBoxCc";
            this.textBoxCC.Location = new System.Drawing.Point(359, 155);
            this.textBoxCC.Name = "textBoxCC";
            this.textBoxCC.Size = new System.Drawing.Size(181, 27);
            this.textBoxCC.TabIndex = 8;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.AccessibleName = "textBoxSubject";
            this.textBoxSubject.Location = new System.Drawing.Point(359, 195);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(181, 27);
            this.textBoxSubject.TabIndex = 9;
            // 
            // textBoxAttachment
            // 
            this.textBoxAttachment.AccessibleName = "textBoxAttachment";
            this.textBoxAttachment.Location = new System.Drawing.Point(446, 231);
            this.textBoxAttachment.Name = "textBoxAttachment";
            this.textBoxAttachment.Size = new System.Drawing.Size(94, 27);
            this.textBoxAttachment.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 482);
            this.Controls.Add(this.textBoxAttachment);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.textBoxCC);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxCC;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxAttachment;
        private System.Windows.Forms.TextBox textBoxTo;
    }
}

