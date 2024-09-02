namespace InventoryApp
{
    partial class AddNewItemForm
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
            additembtn = new Button();
            sellItembtn = new Button();
            SuspendLayout();
            // 
            // additembtn
            // 
            additembtn.Location = new Point(355, 197);
            additembtn.Name = "additembtn";
            additembtn.Size = new Size(112, 34);
            additembtn.TabIndex = 0;
            additembtn.Text = "Add New Item";
            additembtn.UseVisualStyleBackColor = true;
            additembtn.Click += additembtn_Click;
            // 
            // sellItembtn
            // 
            sellItembtn.Location = new Point(358, 270);
            sellItembtn.Name = "sellItembtn";
            sellItembtn.Size = new Size(112, 34);
            sellItembtn.TabIndex = 1;
            sellItembtn.Text = "Sell Item";
            sellItembtn.UseVisualStyleBackColor = true;
            sellItembtn.Click += sellItembtn_Click;
            // 
            // AddNewItemForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sellItembtn);
            Controls.Add(additembtn);
            Name = "AddNewItemForm";
            Text = "AddNewItemForm";
            Load += AddNewItemForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button additembtn;
        private Button sellItembtn;
    }
}