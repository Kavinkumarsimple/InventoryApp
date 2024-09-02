namespace InventoryApp
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
            button1 = new Button();
            loginbtn = new Button();
            usernametxt = new TextBox();
            passwordtxt = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 404);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // loginbtn
            // 
            loginbtn.Location = new Point(345, 303);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(112, 34);
            loginbtn.TabIndex = 1;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // usernametxt
            // 
            usernametxt.Location = new Point(328, 170);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(150, 31);
            usernametxt.TabIndex = 2;
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(328, 231);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(150, 31);
            passwordtxt.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(passwordtxt);
            Controls.Add(usernametxt);
            Controls.Add(loginbtn);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button loginbtn;
        private TextBox usernametxt;
        private TextBox passwordtxt;
    }
}
