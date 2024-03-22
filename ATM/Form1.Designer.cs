namespace ATM
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
            this.tblPnlMain = new DevExpress.Utils.Layout.TablePanel();
            this.btnTransferMoney = new System.Windows.Forms.Button();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.tblPnlWithdraw = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.tblPnlDeposit = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.tblPnlCheckBalance = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.tblPnlTransferMoney = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tblPnlSelectAccount = new System.Windows.Forms.TableLayoutPanel();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblPnlMain)).BeginInit();
            this.tblPnlMain.SuspendLayout();
            this.tblPnlWithdraw.SuspendLayout();
            this.tblPnlDeposit.SuspendLayout();
            this.tblPnlCheckBalance.SuspendLayout();
            this.tblPnlTransferMoney.SuspendLayout();
            this.tblPnlSelectAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPnlMain
            // 
            this.tblPnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblPnlMain.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.tblPnlMain.Controls.Add(this.btnTransferMoney);
            this.tblPnlMain.Controls.Add(this.btnCheckBalance);
            this.tblPnlMain.Controls.Add(this.btnDeposit);
            this.tblPnlMain.Controls.Add(this.btnWithdraw);
            this.tblPnlMain.Controls.Add(this.btnExit);
            this.tblPnlMain.Location = new System.Drawing.Point(14, 69);
            this.tblPnlMain.Name = "tblPnlMain";
            this.tblPnlMain.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F)});
            this.tblPnlMain.Size = new System.Drawing.Size(775, 360);
            this.tblPnlMain.TabIndex = 0;
            this.tblPnlMain.UseSkinIndents = true;
            // 
            // btnTransferMoney
            // 
            this.tblPnlMain.SetColumn(this.btnTransferMoney, 0);
            this.btnTransferMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTransferMoney.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferMoney.Location = new System.Drawing.Point(13, 216);
            this.btnTransferMoney.Name = "btnTransferMoney";
            this.tblPnlMain.SetRow(this.btnTransferMoney, 3);
            this.btnTransferMoney.Size = new System.Drawing.Size(749, 64);
            this.btnTransferMoney.TabIndex = 4;
            this.btnTransferMoney.Text = "Transfer Money";
            this.btnTransferMoney.UseVisualStyleBackColor = true;
            this.btnTransferMoney.Click += new System.EventHandler(this.btnTransferMoney_Click);
            // 
            // btnCheckBalance
            // 
            this.tblPnlMain.SetColumn(this.btnCheckBalance, 0);
            this.btnCheckBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheckBalance.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckBalance.Location = new System.Drawing.Point(13, 148);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.tblPnlMain.SetRow(this.btnCheckBalance, 2);
            this.btnCheckBalance.Size = new System.Drawing.Size(749, 64);
            this.btnCheckBalance.TabIndex = 3;
            this.btnCheckBalance.Text = "Check Balance";
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // btnDeposit
            // 
            this.tblPnlMain.SetColumn(this.btnDeposit, 0);
            this.btnDeposit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeposit.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(13, 80);
            this.btnDeposit.Name = "btnDeposit";
            this.tblPnlMain.SetRow(this.btnDeposit, 1);
            this.btnDeposit.Size = new System.Drawing.Size(749, 64);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.tblPnlMain.SetColumn(this.btnWithdraw, 0);
            this.btnWithdraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWithdraw.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Location = new System.Drawing.Point(13, 12);
            this.btnWithdraw.Name = "btnWithdraw";
            this.tblPnlMain.SetRow(this.btnWithdraw, 0);
            this.btnWithdraw.Size = new System.Drawing.Size(749, 64);
            this.btnWithdraw.TabIndex = 1;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnExit
            // 
            this.tblPnlMain.SetColumn(this.btnExit, 0);
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(13, 284);
            this.btnExit.Name = "btnExit";
            this.tblPnlMain.SetRow(this.btnExit, 4);
            this.btnExit.Size = new System.Drawing.Size(749, 63);
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtTop
            // 
            this.txtTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTop.BackColor = System.Drawing.SystemColors.Control;
            this.txtTop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTop.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTop.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtTop.Location = new System.Drawing.Point(14, 0);
            this.txtTop.Multiline = true;
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(774, 75);
            this.txtTop.TabIndex = 1;
            this.txtTop.Text = "Welcome to ZZZ Bank\r\nWhere Your Finances Are Our Priority";
            this.txtTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tblPnlWithdraw
            // 
            this.tblPnlWithdraw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tblPnlWithdraw.ColumnCount = 1;
            this.tblPnlWithdraw.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlWithdraw.Controls.Add(this.button4, 0, 3);
            this.tblPnlWithdraw.Location = new System.Drawing.Point(14, 69);
            this.tblPnlWithdraw.Name = "tblPnlWithdraw";
            this.tblPnlWithdraw.RowCount = 4;
            this.tblPnlWithdraw.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPnlWithdraw.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPnlWithdraw.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPnlWithdraw.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPnlWithdraw.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPnlWithdraw.Size = new System.Drawing.Size(775, 360);
            this.tblPnlWithdraw.TabIndex = 2;
            this.tblPnlWithdraw.Visible = false;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(3, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(769, 84);
            this.button4.TabIndex = 3;
            this.button4.TabStop = false;
            this.button4.Text = "Main Menu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // tblPnlDeposit
            // 
            this.tblPnlDeposit.ColumnCount = 2;
            this.tblPnlDeposit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlDeposit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlDeposit.Controls.Add(this.button3, 0, 0);
            this.tblPnlDeposit.Location = new System.Drawing.Point(14, 69);
            this.tblPnlDeposit.Name = "tblPnlDeposit";
            this.tblPnlDeposit.RowCount = 2;
            this.tblPnlDeposit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlDeposit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlDeposit.Size = new System.Drawing.Size(775, 360);
            this.tblPnlDeposit.TabIndex = 0;
            this.tblPnlDeposit.Visible = false;
            this.tblPnlDeposit.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(381, 174);
            this.button3.TabIndex = 1;
            this.button3.TabStop = false;
            this.button3.Text = "Main Menu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // tblPnlCheckBalance
            // 
            this.tblPnlCheckBalance.ColumnCount = 2;
            this.tblPnlCheckBalance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlCheckBalance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlCheckBalance.Controls.Add(this.button2, 0, 0);
            this.tblPnlCheckBalance.Location = new System.Drawing.Point(14, 69);
            this.tblPnlCheckBalance.Name = "tblPnlCheckBalance";
            this.tblPnlCheckBalance.RowCount = 2;
            this.tblPnlCheckBalance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlCheckBalance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlCheckBalance.Size = new System.Drawing.Size(775, 360);
            this.tblPnlCheckBalance.TabIndex = 3;
            this.tblPnlCheckBalance.Visible = false;
            this.tblPnlCheckBalance.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(381, 174);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.Text = "Main Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // tblPnlTransferMoney
            // 
            this.tblPnlTransferMoney.ColumnCount = 2;
            this.tblPnlTransferMoney.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlTransferMoney.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlTransferMoney.Controls.Add(this.button1, 0, 0);
            this.tblPnlTransferMoney.Location = new System.Drawing.Point(14, 69);
            this.tblPnlTransferMoney.Name = "tblPnlTransferMoney";
            this.tblPnlTransferMoney.RowCount = 2;
            this.tblPnlTransferMoney.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlTransferMoney.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlTransferMoney.Size = new System.Drawing.Size(775, 360);
            this.tblPnlTransferMoney.TabIndex = 4;
            this.tblPnlTransferMoney.Visible = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(381, 174);
            this.button1.TabIndex = 1;
            this.button1.TabStop = false;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // tblPnlSelectAccount
            // 
            this.tblPnlSelectAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tblPnlSelectAccount.ColumnCount = 1;
            this.tblPnlSelectAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlSelectAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPnlSelectAccount.Controls.Add(this.button8, 0, 3);
            this.tblPnlSelectAccount.Controls.Add(this.button9, 0, 2);
            this.tblPnlSelectAccount.Controls.Add(this.button10, 0, 1);
            this.tblPnlSelectAccount.Controls.Add(this.button11, 0, 0);
            this.tblPnlSelectAccount.Location = new System.Drawing.Point(14, 69);
            this.tblPnlSelectAccount.Name = "tblPnlSelectAccount";
            this.tblPnlSelectAccount.RowCount = 4;
            this.tblPnlSelectAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPnlSelectAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPnlSelectAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPnlSelectAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPnlSelectAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPnlSelectAccount.Size = new System.Drawing.Size(775, 360);
            this.tblPnlSelectAccount.TabIndex = 7;
            this.tblPnlSelectAccount.Visible = false;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button8.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.button8.Location = new System.Drawing.Point(3, 273);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(769, 84);
            this.button8.TabIndex = 3;
            this.button8.TabStop = false;
            this.button8.Text = "Main Menu";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Font = new System.Drawing.Font("OCR A Extended", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(3, 183);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(769, 84);
            this.button9.TabIndex = 4;
            this.button9.Text = "Savings: 345678901";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.Font = new System.Drawing.Font("OCR A Extended", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(3, 93);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(769, 84);
            this.button10.TabIndex = 5;
            this.button10.Text = "Reserve: 234567890";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.Font = new System.Drawing.Font("OCR A Extended", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(3, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(769, 84);
            this.button11.TabIndex = 6;
            this.button11.Text = "Checking: 123456789";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tblPnlMain);
            this.Controls.Add(this.tblPnlSelectAccount);
            this.Controls.Add(this.tblPnlWithdraw);
            this.Controls.Add(this.tblPnlTransferMoney);
            this.Controls.Add(this.tblPnlCheckBalance);
            this.Controls.Add(this.tblPnlDeposit);
            this.Controls.Add(this.txtTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tblPnlMain)).EndInit();
            this.tblPnlMain.ResumeLayout(false);
            this.tblPnlWithdraw.ResumeLayout(false);
            this.tblPnlDeposit.ResumeLayout(false);
            this.tblPnlCheckBalance.ResumeLayout(false);
            this.tblPnlTransferMoney.ResumeLayout(false);
            this.tblPnlSelectAccount.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tblPnlMain;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtTop;
        private System.Windows.Forms.Button btnTransferMoney;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TableLayoutPanel tblPnlWithdraw;
        private System.Windows.Forms.TableLayoutPanel tblPnlDeposit;
        private System.Windows.Forms.TableLayoutPanel tblPnlCheckBalance;
        private System.Windows.Forms.TableLayoutPanel tblPnlTransferMoney;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TableLayoutPanel tblPnlSelectAccount;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}

