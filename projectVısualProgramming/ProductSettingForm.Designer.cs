namespace projectVısualProgramming
{
    partial class ProductSettingForm
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            productprice = new TextBox();
            productPriceLabel = new Label();
            productWeightBox = new TextBox();
            productQuantityBox = new TextBox();
            productIdBox = new TextBox();
            productNameBox = new TextBox();
            productweightLabel = new Label();
            productQuantityLabel = new Label();
            productIdLabel = new Label();
            productNameLabel = new Label();
            productDataGrid = new DataGridView();
            clearButton = new Button();
            deleteProductButton = new Button();
            addProductButton = new Button();
            ((System.ComponentModel.ISupportInitialize)productDataGrid).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(613, 398);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(138, 27);
            textBox2.TabIndex = 39;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(613, 347);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 27);
            textBox1.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(613, 324);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 37;
            label3.Text = "Order Confirmation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(480, 398);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 36;
            label2.Text = "Amount Ordered :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(480, 347);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 35;
            label1.Text = "Product Ordered : ";
            // 
            // button1
            // 
            button1.Location = new Point(613, 461);
            button1.Name = "button1";
            button1.Size = new Size(138, 29);
            button1.TabIndex = 34;
            button1.Text = "CONFIRM ORDER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // productprice
            // 
            productprice.Location = new Point(156, 155);
            productprice.Name = "productprice";
            productprice.Size = new Size(125, 27);
            productprice.TabIndex = 33;
            // 
            // productPriceLabel
            // 
            productPriceLabel.AutoSize = true;
            productPriceLabel.Location = new Point(37, 155);
            productPriceLabel.Name = "productPriceLabel";
            productPriceLabel.Size = new Size(103, 20);
            productPriceLabel.TabIndex = 32;
            productPriceLabel.Text = "Product Price :";
            // 
            // productWeightBox
            // 
            productWeightBox.Location = new Point(156, 259);
            productWeightBox.Name = "productWeightBox";
            productWeightBox.Size = new Size(125, 27);
            productWeightBox.TabIndex = 31;
            // 
            // productQuantityBox
            // 
            productQuantityBox.Location = new Point(156, 205);
            productQuantityBox.Name = "productQuantityBox";
            productQuantityBox.Size = new Size(125, 27);
            productQuantityBox.TabIndex = 30;
            // 
            // productIdBox
            // 
            productIdBox.Location = new Point(156, 109);
            productIdBox.Name = "productIdBox";
            productIdBox.Size = new Size(125, 27);
            productIdBox.TabIndex = 29;
            // 
            // productNameBox
            // 
            productNameBox.Location = new Point(156, 61);
            productNameBox.Name = "productNameBox";
            productNameBox.Size = new Size(125, 27);
            productNameBox.TabIndex = 28;
            // 
            // productweightLabel
            // 
            productweightLabel.AutoSize = true;
            productweightLabel.Location = new Point(30, 259);
            productweightLabel.Name = "productweightLabel";
            productweightLabel.Size = new Size(118, 20);
            productweightLabel.TabIndex = 27;
            productweightLabel.Text = "Product Weight :";
            // 
            // productQuantityLabel
            // 
            productQuantityLabel.AutoSize = true;
            productQuantityLabel.Location = new Point(23, 205);
            productQuantityLabel.Name = "productQuantityLabel";
            productQuantityLabel.Size = new Size(127, 20);
            productQuantityLabel.TabIndex = 26;
            productQuantityLabel.Text = "Product Quantity :";
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Location = new Point(37, 109);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new Size(84, 20);
            productIdLabel.TabIndex = 25;
            productIdLabel.Text = "Product Id :";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new Point(37, 61);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(111, 20);
            productNameLabel.TabIndex = 24;
            productNameLabel.Text = "Product Name :";
            // 
            // productDataGrid
            // 
            productDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDataGrid.Location = new Point(318, 21);
            productDataGrid.Name = "productDataGrid";
            productDataGrid.RowHeadersWidth = 51;
            productDataGrid.RowTemplate.Height = 29;
            productDataGrid.Size = new Size(638, 288);
            productDataGrid.TabIndex = 23;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(76, 419);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(146, 29);
            clearButton.TabIndex = 22;
            clearButton.Text = "CLEAR";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click_1;
            // 
            // deleteProductButton
            // 
            deleteProductButton.Location = new Point(76, 368);
            deleteProductButton.Name = "deleteProductButton";
            deleteProductButton.Size = new Size(146, 29);
            deleteProductButton.TabIndex = 21;
            deleteProductButton.Text = "DELETE PRODUCT";
            deleteProductButton.UseVisualStyleBackColor = true;
            deleteProductButton.Click += deleteProductButton_Click_1;
            // 
            // addProductButton
            // 
            addProductButton.Location = new Point(76, 314);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(146, 29);
            addProductButton.TabIndex = 20;
            addProductButton.Text = "&ADD PRODUCT";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += addProductButton_Click_1;
            // 
            // ProductSettingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 559);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(productprice);
            Controls.Add(productPriceLabel);
            Controls.Add(productWeightBox);
            Controls.Add(productQuantityBox);
            Controls.Add(productIdBox);
            Controls.Add(productNameBox);
            Controls.Add(productweightLabel);
            Controls.Add(productQuantityLabel);
            Controls.Add(productIdLabel);
            Controls.Add(productNameLabel);
            Controls.Add(productDataGrid);
            Controls.Add(clearButton);
            Controls.Add(deleteProductButton);
            Controls.Add(addProductButton);
            Name = "ProductSettingForm";
            Text = "ProductSettingForm";
            ((System.ComponentModel.ISupportInitialize)productDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox productprice;
        private Label productPriceLabel;
        private TextBox productWeightBox;
        private TextBox productQuantityBox;
        private TextBox productIdBox;
        private TextBox productNameBox;
        private Label productweightLabel;
        private Label productQuantityLabel;
        private Label productIdLabel;
        private Label productNameLabel;
        private DataGridView productDataGrid;
        private Button clearButton;
        private Button deleteProductButton;
        private Button addProductButton;
    }
}