namespace InventoryApp
{
    partial class SellItemForm
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
            currentStockTbl = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            sellItem = new Button();
            ((System.ComponentModel.ISupportInitialize)currentStockTbl).BeginInit();
            SuspendLayout();
            // 
            // currentStockTbl
            // 
            currentStockTbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            currentStockTbl.Location = new Point(12, 27);
            currentStockTbl.Name = "currentStockTbl";
            currentStockTbl.RowHeadersWidth = 62;
            currentStockTbl.Size = new Size(776, 166);
            currentStockTbl.TabIndex = 0;
            currentStockTbl.CellContentClick += currentStockTbl_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(203, 234);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 237);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 2;
            label1.Text = "itemid";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(203, 287);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 290);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 4;
            label2.Text = "quantityToSell";
            label2.Click += label2_Click;
            // 
            // sellItem
            // 
            sellItem.Location = new Point(414, 252);
            sellItem.Name = "sellItem";
            sellItem.Size = new Size(112, 34);
            sellItem.TabIndex = 5;
            sellItem.Text = "Sell Items";
            sellItem.UseVisualStyleBackColor = true;
            sellItem.Click += sellItem_Click;
            // 
            // SellItemForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sellItem);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(currentStockTbl);
            Name = "SellItemForm";
            Text = "SellItemForm";
            ((System.ComponentModel.ISupportInitialize)currentStockTbl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView currentStockTbl;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Button sellItem;
    }
}