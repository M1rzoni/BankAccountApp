namespace BankAccountApp
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
            Button WithdrawBtn;
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            OwnerTxt = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccounstGrid = new DataGridView();
            DepositBtn = new Button();
            CreateAccountBtn = new Button();
            WithdrawBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccounstGrid).BeginInit();
            SuspendLayout();
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point(610, 299);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(134, 51);
            WithdrawBtn.TabIndex = 7;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(915, 880);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 305);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Amount:";
            // 
            // OwnerTxt
            // 
            OwnerTxt.Location = new Point(78, 34);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(154, 23);
            OwnerTxt.TabIndex = 3;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(87, 303);
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(145, 23);
            AmountNum.TabIndex = 4;
            // 
            // BankAccounstGrid
            // 
            BankAccounstGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccounstGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccounstGrid.Location = new Point(268, 34);
            BankAccounstGrid.Name = "BankAccounstGrid";
            BankAccounstGrid.Size = new Size(520, 259);
            BankAccounstGrid.TabIndex = 5;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(268, 299);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(134, 51);
            DepositBtn.TabIndex = 6;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Location = new Point(78, 72);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(154, 51);
            CreateAccountBtn.TabIndex = 8;
            CreateAccountBtn.Text = "Create account";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 367);
            Controls.Add(CreateAccountBtn);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositBtn);
            Controls.Add(BankAccounstGrid);
            Controls.Add(AmountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccounstGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView BankAccounstGrid;
        private Button DepositBtn;
        private Button CreateAccountBtn;
    }
}
