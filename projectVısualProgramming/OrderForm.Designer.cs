namespace projectVısualProgramming
{
    partial class OrderForm
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
            productNameLabel = new Label();
            productQuantityLabel = new Label();
            createOrderButton = new Button();
            productNameBox = new TextBox();
            productQuantityBox = new TextBox();
            orderDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)orderDataGrid).BeginInit();
            SuspendLayout();
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new Point(139, 26);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(111, 20);
            productNameLabel.TabIndex = 0;
            productNameLabel.Text = "Product Name :";
            // 
            // productQuantityLabel
            // 
            productQuantityLabel.AutoSize = true;
            productQuantityLabel.Location = new Point(139, 80);
            productQuantityLabel.Name = "productQuantityLabel";
            productQuantityLabel.Size = new Size(127, 20);
            productQuantityLabel.TabIndex = 2;
            productQuantityLabel.Text = "Product Quantity :";
            // 
            // createOrderButton
            // 
            createOrderButton.Location = new Point(291, 393);
            createOrderButton.Name = "createOrderButton";
            createOrderButton.Size = new Size(125, 29);
            createOrderButton.TabIndex = 3;
            createOrderButton.Text = "CREATE ORDER";
            createOrderButton.UseVisualStyleBackColor = true;
            createOrderButton.Click += createOrderButton_Click;
            // 
            // productNameBox
            // 
            productNameBox.Location = new Point(272, 26);
            productNameBox.Name = "productNameBox";
            productNameBox.Size = new Size(144, 27);
            productNameBox.TabIndex = 4;            
            // 
            // productQuantityBox
            // 
            productQuantityBox.Location = new Point(272, 73);
            productQuantityBox.Name = "productQuantityBox";
            productQuantityBox.Size = new Size(144, 27);
            productQuantityBox.TabIndex = 5;
            // 
            // orderDataGrid
            // 
            orderDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDataGrid.Location = new Point(46, 126);
            orderDataGrid.Name = "orderDataGrid";
            orderDataGrid.RowHeadersWidth = 51;
            orderDataGrid.RowTemplate.Height = 29;
            orderDataGrid.Size = new Size(612, 227);
            orderDataGrid.TabIndex = 11;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(orderDataGrid);
            Controls.Add(productQuantityBox);
            Controls.Add(productNameBox);
            Controls.Add(createOrderButton);
            Controls.Add(productQuantityLabel);
            Controls.Add(productNameLabel);
            Name = "OrderForm";
            Text = "OrderForm";
            Load += OrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)orderDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label productNameLabel;
        private Label productQuantityLabel;
        private Button createOrderButton;
        private TextBox productNameBox;
        private TextBox productQuantityBox;
        private DataGridView orderDataGrid;
    }
}