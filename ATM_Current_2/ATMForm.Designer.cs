namespace ATM
{
    partial class ATMForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ChooseActionPanel = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SelectAccountsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button10 = new System.Windows.Forms.Button();
            this.ToAccounts = new System.Windows.Forms.ListBox();
            this.ToAccountTextBox = new System.Windows.Forms.TextBox();
            this.FromAccountTextBox = new System.Windows.Forms.TextBox();
            this.FromAccounts = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.toLabel = new System.Windows.Forms.Label();
            this.EnterAmountPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ExitButton2 = new System.Windows.Forms.Button();
            this.EnterAmountTextBox = new System.Windows.Forms.TextBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.CompleteTransactionButton = new System.Windows.Forms.Button();
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SelectAccountsMainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EnterAmountMainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ChooseActionPanel.SuspendLayout();
            this.SelectAccountsPanel.SuspendLayout();
            this.EnterAmountPanel.SuspendLayout();
            this.MainTableLayoutPanel.SuspendLayout();
            this.SelectAccountsMainPanel.SuspendLayout();
            this.EnterAmountMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(405, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 101);
            this.button1.TabIndex = 0;
            this.button1.Text = "Withdraw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(814, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 101);
            this.button2.TabIndex = 1;
            this.button2.Text = "CheckBalance";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.checkBalance_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(405, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(256, 101);
            this.button3.TabIndex = 2;
            this.button3.Text = "Transfer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(814, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(256, 101);
            this.button4.TabIndex = 3;
            this.button4.Text = "Deposit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // ChooseActionPanel
            // 
            this.ChooseActionPanel.Controls.Add(this.button2);
            this.ChooseActionPanel.Controls.Add(this.button3);
            this.ChooseActionPanel.Controls.Add(this.button4);
            this.ChooseActionPanel.Controls.Add(this.button1);
            this.ChooseActionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChooseActionPanel.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseActionPanel.Location = new System.Drawing.Point(3, 190);
            this.ChooseActionPanel.Name = "ChooseActionPanel";
            this.ChooseActionPanel.Size = new System.Drawing.Size(1432, 306);
            this.ChooseActionPanel.TabIndex = 4;
            this.ChooseActionPanel.TabStop = false;
            this.ChooseActionPanel.Text = "How Can We Help?";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(3, 3);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(1432, 181);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "\r\n\r\n\r\nWelcome to ZZZ Bank\r\nYour Finances, Our Priority";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(3, 502);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(1432, 171);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.Exit);
            // 
            // SelectAccountsPanel
            // 
            this.SelectAccountsPanel.ColumnCount = 2;
            this.SelectAccountsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SelectAccountsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SelectAccountsPanel.Controls.Add(this.button10, 0, 2);
            this.SelectAccountsPanel.Controls.Add(this.ToAccounts, 1, 1);
            this.SelectAccountsPanel.Controls.Add(this.ToAccountTextBox, 1, 0);
            this.SelectAccountsPanel.Controls.Add(this.FromAccountTextBox, 0, 0);
            this.SelectAccountsPanel.Controls.Add(this.FromAccounts, 0, 1);
            this.SelectAccountsPanel.Controls.Add(this.button5, 1, 2);
            this.SelectAccountsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectAccountsPanel.Location = new System.Drawing.Point(3, 256);
            this.SelectAccountsPanel.Name = "SelectAccountsPanel";
            this.SelectAccountsPanel.RowCount = 3;
            this.SelectAccountsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.02638F));
            this.SelectAccountsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.88969F));
            this.SelectAccountsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.08393F));
            this.SelectAccountsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SelectAccountsPanel.Size = new System.Drawing.Size(1432, 417);
            this.SelectAccountsPanel.TabIndex = 6;
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button10.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(139, 264);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(437, 118);
            this.button10.TabIndex = 5;
            this.button10.Text = "Exit";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Exit);
            // 
            // ToAccounts
            // 
            this.ToAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToAccounts.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToAccounts.FormattingEnabled = true;
            this.ToAccounts.ItemHeight = 38;
            this.ToAccounts.Location = new System.Drawing.Point(719, 74);
            this.ToAccounts.Name = "ToAccounts";
            this.ToAccounts.Size = new System.Drawing.Size(710, 152);
            this.ToAccounts.TabIndex = 3;
            this.ToAccounts.SelectedIndexChanged += new System.EventHandler(this.ToAccounts_SelectedIndexChanged);
            // 
            // ToAccountTextBox
            // 
            this.ToAccountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ToAccountTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ToAccountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ToAccountTextBox.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToAccountTextBox.Location = new System.Drawing.Point(939, 9);
            this.ToAccountTextBox.Multiline = true;
            this.ToAccountTextBox.Name = "ToAccountTextBox";
            this.ToAccountTextBox.Size = new System.Drawing.Size(269, 52);
            this.ToAccountTextBox.TabIndex = 1;
            this.ToAccountTextBox.Text = "Deposit Account";
            // 
            // FromAccountTextBox
            // 
            this.FromAccountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FromAccountTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.FromAccountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FromAccountTextBox.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromAccountTextBox.Location = new System.Drawing.Point(188, 9);
            this.FromAccountTextBox.Multiline = true;
            this.FromAccountTextBox.Name = "FromAccountTextBox";
            this.FromAccountTextBox.Size = new System.Drawing.Size(339, 52);
            this.FromAccountTextBox.TabIndex = 0;
            this.FromAccountTextBox.Text = "Withdraw Account";
            this.FromAccountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FromAccounts
            // 
            this.FromAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FromAccounts.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromAccounts.FormattingEnabled = true;
            this.FromAccounts.ItemHeight = 38;
            this.FromAccounts.Location = new System.Drawing.Point(3, 74);
            this.FromAccounts.Name = "FromAccounts";
            this.FromAccounts.Size = new System.Drawing.Size(710, 152);
            this.FromAccounts.TabIndex = 2;
            this.FromAccounts.SelectedIndexChanged += new System.EventHandler(this.FromAccounts_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(855, 264);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(437, 118);
            this.button5.TabIndex = 4;
            this.button5.Text = "Proceed";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(510, 371);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(0, 13);
            this.toLabel.TabIndex = 7;
            // 
            // EnterAmountPanel
            // 
            this.EnterAmountPanel.ColumnCount = 2;
            this.EnterAmountPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EnterAmountPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EnterAmountPanel.Controls.Add(this.ExitButton2, 0, 1);
            this.EnterAmountPanel.Controls.Add(this.AmountTextBox, 1, 0);
            this.EnterAmountPanel.Controls.Add(this.CompleteTransactionButton, 1, 1);
            this.EnterAmountPanel.Controls.Add(this.EnterAmountTextBox, 0, 0);
            this.EnterAmountPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnterAmountPanel.Location = new System.Drawing.Point(3, 253);
            this.EnterAmountPanel.Name = "EnterAmountPanel";
            this.EnterAmountPanel.RowCount = 2;
            this.EnterAmountPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.EnterAmountPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.EnterAmountPanel.Size = new System.Drawing.Size(1432, 420);
            this.EnterAmountPanel.TabIndex = 10;
            this.EnterAmountPanel.TabStop = true;
            // 
            // ExitButton2
            // 
            this.ExitButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitButton2.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton2.Location = new System.Drawing.Point(139, 266);
            this.ExitButton2.Name = "ExitButton2";
            this.ExitButton2.Size = new System.Drawing.Size(437, 118);
            this.ExitButton2.TabIndex = 6;
            this.ExitButton2.Text = "Exit";
            this.ExitButton2.UseVisualStyleBackColor = true;
            this.ExitButton2.Click += new System.EventHandler(this.Exit);
            // 
            // EnterAmountTextBox
            // 
            this.EnterAmountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnterAmountTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.EnterAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterAmountTextBox.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterAmountTextBox.Location = new System.Drawing.Point(139, 94);
            this.EnterAmountTextBox.Multiline = true;
            this.EnterAmountTextBox.Name = "EnterAmountTextBox";
            this.EnterAmountTextBox.Size = new System.Drawing.Size(437, 42);
            this.EnterAmountTextBox.TabIndex = 0;
            this.EnterAmountTextBox.Text = "Enter Amount:";
            this.EnterAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AmountTextBox.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountTextBox.Location = new System.Drawing.Point(895, 91);
            this.AmountTextBox.Multiline = true;
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(358, 49);
            this.AmountTextBox.TabIndex = 1;
            this.AmountTextBox.Text = "$0";
            this.AmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AmountTextBox.Click += new System.EventHandler(this.AmountTextBox_Click);
            // 
            // CompleteTransactionButton
            // 
            this.CompleteTransactionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CompleteTransactionButton.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompleteTransactionButton.Location = new System.Drawing.Point(855, 266);
            this.CompleteTransactionButton.Name = "CompleteTransactionButton";
            this.CompleteTransactionButton.Size = new System.Drawing.Size(437, 118);
            this.CompleteTransactionButton.TabIndex = 5;
            this.CompleteTransactionButton.Text = "Complete Transaction";
            this.CompleteTransactionButton.UseVisualStyleBackColor = true;
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 1;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.textBox3, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.ChooseActionPanel, 0, 1);
            this.MainTableLayoutPanel.Controls.Add(this.exitButton, 0, 2);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 3;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.2963F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.92593F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(1438, 676);
            this.MainTableLayoutPanel.TabIndex = 11;
            // 
            // SelectAccountsMainPanel
            // 
            this.SelectAccountsMainPanel.ColumnCount = 1;
            this.SelectAccountsMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SelectAccountsMainPanel.Controls.Add(this.SelectAccountsPanel, 0, 1);
            this.SelectAccountsMainPanel.Controls.Add(this.textBox1, 0, 0);
            this.SelectAccountsMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectAccountsMainPanel.Location = new System.Drawing.Point(0, 0);
            this.SelectAccountsMainPanel.Name = "SelectAccountsMainPanel";
            this.SelectAccountsMainPanel.RowCount = 2;
            this.SelectAccountsMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.SelectAccountsMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.SelectAccountsMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SelectAccountsMainPanel.Size = new System.Drawing.Size(1438, 676);
            this.SelectAccountsMainPanel.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1432, 247);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "\r\n\r\n\r\nWelcome to ZZZ Bank\r\nYour Finances, Our Priority";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EnterAmountMainPanel
            // 
            this.EnterAmountMainPanel.ColumnCount = 1;
            this.EnterAmountMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EnterAmountMainPanel.Controls.Add(this.EnterAmountPanel, 0, 1);
            this.EnterAmountMainPanel.Controls.Add(this.textBox2, 0, 0);
            this.EnterAmountMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnterAmountMainPanel.Location = new System.Drawing.Point(0, 0);
            this.EnterAmountMainPanel.Name = "EnterAmountMainPanel";
            this.EnterAmountMainPanel.RowCount = 2;
            this.EnterAmountMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.12654F));
            this.EnterAmountMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.87346F));
            this.EnterAmountMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.EnterAmountMainPanel.Size = new System.Drawing.Size(1438, 676);
            this.EnterAmountMainPanel.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(1432, 244);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "\r\n\r\n\r\nWelcome to ZZZ Bank\r\nYour Finances, Our Priority";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ATMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 676);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.EnterAmountMainPanel);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Controls.Add(this.SelectAccountsMainPanel);
            this.Name = "ATMForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ChooseActionPanel.ResumeLayout(false);
            this.SelectAccountsPanel.ResumeLayout(false);
            this.SelectAccountsPanel.PerformLayout();
            this.EnterAmountPanel.ResumeLayout(false);
            this.EnterAmountPanel.PerformLayout();
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.MainTableLayoutPanel.PerformLayout();
            this.SelectAccountsMainPanel.ResumeLayout(false);
            this.SelectAccountsMainPanel.PerformLayout();
            this.EnterAmountMainPanel.ResumeLayout(false);
            this.EnterAmountMainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox ChooseActionPanel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TableLayoutPanel SelectAccountsPanel;
        private System.Windows.Forms.TextBox ToAccountTextBox;
        private System.Windows.Forms.TextBox FromAccountTextBox;
        private System.Windows.Forms.ListBox ToAccounts;
        private System.Windows.Forms.ListBox FromAccounts;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TableLayoutPanel EnterAmountPanel;
        private System.Windows.Forms.TextBox EnterAmountTextBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button CompleteTransactionButton;
        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel SelectAccountsMainPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel EnterAmountMainPanel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button ExitButton2;
    }
}