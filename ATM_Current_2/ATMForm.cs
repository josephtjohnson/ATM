using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATM
{
    public partial class ATMForm : Form
    {
        Customer currentCustomer = new Customer(1,"test","test");
        ArrayList accountList = new ArrayList();
        Account selectedFromAccount;
        Account selectedToAccount;
        double machineCash = 100000;
        int actionCode = -1;
        public ATMForm()
        {
            InitializeComponent();
            //accountList = Account.retrieveAccounts(currentCustomer.GetId());
            SelectAccountsMainPanel.Visible = false;
            EnterAmountMainPanel.Visible = false;
            textBox3.SelectionStart = 0;
            textBox3.SelectionLength = 0;

            accountList.Add(new Account(1, 1, 1000, 100, "2024-04-01", 0, 0, 3000, "2024-04-17"));
            accountList.Add(new Account(2, 1, 50, 100, "2024-04-15", 0, 0, 3000, "2024-04-11"));
            accountList.Add(new Account(3, 1, 50000, 0, "2024-04-03", 0, 0, 3000, "2024-04-16"));
        }

        //public ATMForm()
        //{
        //    InitializeComponent();
        //}

        //public ATMForm(Customer customer)
        //{
        //  InitializeComponent();
        //}

        private void Exit(object sender, EventArgs e) 
        {
            Application.Exit();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            AmountTextBox.Text = "$";
            MainTableLayoutPanel.Visible = false;
            SelectAccountsMainPanel.Visible = true;
            FromAccountTextBox.Text = "Withdraw Account";
            FromAccounts.Visible = true;
            ToAccountTextBox.Visible = false;
            ToAccounts.Visible = false;

            FromAccounts.Items.Clear();
            Account tempAccount;
            //Console.WriteLine("number of account: " + accountList.Count);
            for (int i = 0; i < accountList.Count; i++)
            {
                tempAccount = (Account)accountList[i];
                FromAccounts.Items.Add("                            " + tempAccount.getAccountNum());
            }

            actionCode = 1;

        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            AmountTextBox.Text = "$";
            MainTableLayoutPanel.Visible = false;
            SelectAccountsMainPanel.Visible = true;
            ToAccountTextBox.Text = "Deposit Account";
            ToAccounts.Visible = true;
            FromAccountTextBox.Visible = false;
            FromAccounts.Visible = false;

            ToAccounts.Items.Clear();
            Account tempAccount;
            //Console.WriteLine("number of account: " + accountList.Count);
            for (int i = 0; i < accountList.Count; i++)
            {
                tempAccount = (Account)accountList[i];
                ToAccounts.Items.Add("                            " + tempAccount.getAccountNum());
            }

            actionCode = 2;

        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            AmountTextBox.Text = "$";
            MainTableLayoutPanel.Visible = false;
            SelectAccountsMainPanel.Visible = true;
            FromAccountTextBox.Text = "From Account";
            FromAccounts.Visible = true;
            ToAccountTextBox.Text = "To Account";
            ToAccounts.Visible = true;

            FromAccounts.Items.Clear();
            ToAccounts.Items.Clear();
            Account tempAccount;
            //Console.WriteLine("number of account: " + accountList.Count);
            for (int i = 0; i < accountList.Count; i++)
            {
                tempAccount = (Account)accountList[i];
                FromAccounts.Items.Add("                            " + tempAccount.getAccountNum());
                ToAccounts.Items.Add("                            " + tempAccount.getAccountNum());
            }

            actionCode = 3;

        }

        private void checkBalance_Click(object sender, EventArgs e)
        {
            AmountTextBox.Text = "$";
            MainTableLayoutPanel.Visible = false;
            SelectAccountsMainPanel.Visible = true;
            FromAccountTextBox.Text = "Account";
            FromAccounts.Visible = true;
            ToAccountTextBox.Visible = false;
            ToAccounts.Visible = false;

            FromAccounts.Items.Clear();
            Account tempAccount;
            //Console.WriteLine("number of account: " + accountList.Count);
            for (int i = 0; i < accountList.Count; i++)
            {
                tempAccount = (Account)accountList[i];
                FromAccounts.Items.Add("                            " + tempAccount.getAccountNum());
            }

            actionCode = 4;

        }

        private void FromAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (actionCode == 1 || actionCode == 3) //Withdraw or Transfer
            {
                if (FromAccounts.SelectedIndex >= 0)
                { 
                    this.selectedFromAccount = (Account)accountList[FromAccounts.SelectedIndex];

                    if (selectedFromAccount.checkDailyTransaction() == false)
                    {
                        MessageBox.Show("The transactions of this account have exceeded the max limit $3000 for today.\n"
                             + "Please select another account.");

                        FromAccounts.SelectedIndex = -1;
                        selectedFromAccount = null;

                    }

                    else if (selectedToAccount != null)
                    {
                        if (selectedFromAccount == selectedToAccount)
                        {
                            MessageBox.Show("The same account cannot be selected for a transfer");

                            FromAccounts.SelectedIndex = -1;
                            selectedFromAccount = null;

                            ToAccounts.SelectedIndex = -1;
                            selectedToAccount = null;
                        }

                    }
                }
            }

            else if (actionCode == 4) //CheckBalance
            {
                if (FromAccounts.SelectedIndex >= 0)
                {
                    selectedFromAccount = (Account)accountList[FromAccounts.SelectedIndex];
                }
            }
        }

        private void ToAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (actionCode == 2 || actionCode == 3) 
            {
                if ((ToAccounts.SelectedIndex >= 0))
                {
                    this.selectedToAccount = (Account)accountList[ToAccounts.SelectedIndex];

                    if (selectedToAccount.checkDailyTransaction() == false)
                    {
                        MessageBox.Show("The transactions of this account have exceeded the max limit $3000 for today.\n"
                             + "Please select another account.");

                        ToAccounts.SelectedIndex = -1;
                        selectedToAccount = null;
                    }

                    else if (selectedFromAccount != null)
                    {
                        if (selectedFromAccount == selectedToAccount)
                        {
                            MessageBox.Show("The same account cannot be selected for a transfer");

                            FromAccounts.SelectedIndex = -1;
                            selectedFromAccount = null;

                            ToAccounts.SelectedIndex = -1;
                            selectedToAccount = null;
                        }

                    }
                }

            }
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            if (actionCode == 1) //Withdraw
            {
                if (FromAccounts.SelectedIndex >= 0)
                {
                    EnterAmountMainPanel.Visible = true;
                    CompleteTransactionButton.Click += new EventHandler(completeWithdrawTransaction_Click);
                    SelectAccountsMainPanel.Visible = false;
                    EnterAmountPanel.Visible = true;
                    actionCode = -1;
                }
                else
                {
                    MessageBox.Show("Please select an account");
                }
            }

            else if (actionCode == 2) //deposit
            {
                if (ToAccounts.SelectedIndex >= 0)
                {
                    EnterAmountMainPanel.Visible = true;
                    CompleteTransactionButton.Click += new EventHandler(completeDepositTransaction_Click);
                    SelectAccountsMainPanel.Visible = false;
                    EnterAmountPanel.Visible = true;
                    actionCode = -1;
                }
                else
                {
                    MessageBox.Show("Please select an account");
                }

            }

            else if (actionCode == 3) //transfer
            {
                if (FromAccounts.SelectedIndex >= 0 && ToAccounts.SelectedIndex >= 0)
                {
                    EnterAmountMainPanel.Visible = true;
                    CompleteTransactionButton.Click += new EventHandler(completeTransferTransaction_Click);
                    SelectAccountsMainPanel.Visible = false;
                    EnterAmountPanel.Visible = true;
                    actionCode = -1;
                }
                else
                {
                    MessageBox.Show("Please select accounts");
                }
            }

            else if (actionCode == 4) //check balance
            {
                if (FromAccounts.SelectedIndex >= 0)
                {

                    EnterAmountMainPanel.Visible = true;
                    this.ActiveControl = null;
                    CompleteTransactionButton.Click += new EventHandler(completeCheckBalanceTransaction_Click);
                    SelectAccountsMainPanel.Visible = false;
                    EnterAmountPanel.Visible = true;
                    CompleteTransactionButton.Text = "Return to Main Menu";
                    EnterAmountTextBox.Text = "Current Balance";
                    AmountTextBox.Text = "$" + selectedFromAccount.getAccountBalance().ToString();
                    actionCode = -1;
                }
                else
                {
                    MessageBox.Show("Please select an account");
                }
            }
        }

        private void completeWithdrawTransaction_Click(object sender, EventArgs e)
        {
            double amount;

            if (Double.TryParse(AmountTextBox.Text, out amount) == false)
            {
                MessageBox.Show("Please type a valid amount from $0 - $3000.");
            }
            else
            {
                int errorCode = selectedFromAccount.withdrawMoney(amount, machineCash);
                if (errorCode == 0)
                {
                    //fromLabel.Text = "Please take the money.\n Transaction number: "
                    //    + selectedFromAccount.getNewTransaction().getTransNum() + "\n" + "Withdrawal amount: $"
                    //    + selectedFromAccount.getNewTransaction().getAmount() + "\n" + "From account: "
                    //    + selectedFromAccount.getAccountNum();

                    DialogResult dr = MessageBox.Show("Take your money");

                    if (dr == DialogResult.OK)
                    {
                        EnterAmountMainPanel.Visible = false;
                        MainTableLayoutPanel.Visible = true;
                    }
                }
                else if (errorCode == 1)
                {
                    MessageBox.Show("The transactions of this account have exceeded the max limit $3000 for today.\n"
                        + "Please select another account.");
                }
                else if (errorCode == 2)
                {
                    MessageBox.Show("The amount will make the transactions of this account exceed the max limit $3000 for today.\n"
                        + "Please enter a smaller amount.");
                }
                else if (errorCode == 3)
                {
                    MessageBox.Show("The amount you entered is greater than the balance of the selected account.\n"
                        + "Please enter a smaller amount.");
                }
                else if (errorCode == 4)
                {
                    MessageBox.Show("The machince doesn't have enough cash for your withdrawal.\n"
                        + "Please enter a smaller amount.");
                }

                actionCode = -1;
                CompleteTransactionButton.Click -= new EventHandler(completeWithdrawTransaction_Click);
                this.selectedFromAccount = null;

            }

        }

        private void completeDepositTransaction_Click(object sender, EventArgs e)
        {
            double amount;
            
            if (Double.TryParse(AmountTextBox.Text, out amount) == false)
            {
                MessageBox.Show("Please type a valid amount from $0 - $3000.");
            }
            else
            {
                int errorCode = selectedToAccount.depositMoney(amount);
                if (errorCode == 0)
                {
                    //fromLabel.Text = "Please insert the money.\n Transaction number: "
                    //    + selectedToAccount.getNewTransaction().getTransNum() + "\n" + "Deposit amount: $"
                    //    + selectedToAccount.getNewTransaction().getAmount() + "\n" + "To account: "
                    //    + selectedToAccount.getAccountNum();

                    DialogResult dr = MessageBox.Show("Give your money");

                    if (dr == DialogResult.OK)
                    {
                        EnterAmountMainPanel.Visible = false;
                        MainTableLayoutPanel.Visible = true;
                    }
                }
                else if (errorCode == 1)
                {
                    MessageBox.Show("The transactions of this account have exceeded the max limit $3000 for today.\n"
                        + "Please select another account.");
                }
                else if (errorCode == 2)
                {
                    MessageBox.Show("The amount will make the transactions of this account exceed the max limit $3000 for today.\n"
                        + "Please enter a smaller amount.");
                }

                actionCode = -1;
                CompleteTransactionButton.Click -= new EventHandler(completeDepositTransaction_Click);
                this.selectedToAccount = null;
            }

        }

        private void completeTransferTransaction_Click(object sender, EventArgs e)
        {
            double amount;

            if (Double.TryParse(AmountTextBox.Text, out amount) == false)
            {
                MessageBox.Show("Please type a valid amount from $0 - $3000.");
            }
            else
            {
                int errorCode = selectedFromAccount.transferMoney(amount, selectedToAccount);
                if (errorCode == 0)
                {
                    //fromLabel.Text = "Transfer Complete.\n Transaction number: "
                    //    + selectedToAccount.getNewTransaction().getTransNum() + "\n" + "Transfer amount: $"
                    //    + selectedToAccount.getNewTransaction().getAmount() + "\n" + "To account: "
                    //    + selectedToAccount.getAccountNum();

                    DialogResult dr = MessageBox.Show("Transfer your money");

                    if (dr == DialogResult.OK)
                    {
                        EnterAmountMainPanel.Visible = false;
                        MainTableLayoutPanel.Visible = true;
                    }
                }
                else if (errorCode == 1)
                {
                    MessageBox.Show("The transactions of the originating account have exceeded the max limit $3000 for today.\n"
                        + "Please select another account.");
                }
                else if (errorCode == 2)
                {
                    MessageBox.Show("The amount will make the transactions of the originating account exceed the max limit $3000 for today.\n"
                        + "Please enter a smaller amount.");
                }
                else if (errorCode == 3)
                {
                    MessageBox.Show("The amount you entered is greater than the balance of the originating account.\n"
                        + "Please enter a smaller amount.");
                }
                else if (errorCode == 5)
                {
                    MessageBox.Show("The transactions of the target account have exceeded the max limit $3000 for today.\n"
                        + "Please select another account.");
                }
                else if (errorCode == 6)
                {
                    MessageBox.Show("The amount will make the transactions of the target account exceed the max limit $3000 for today.\n"
                        + "Please enter a smaller amount.");
                }

                actionCode = -1;
                CompleteTransactionButton.Click -= new EventHandler(completeTransferTransaction_Click);
                this.selectedFromAccount = null;
                this.selectedToAccount = null;
            }
        }

        private void completeCheckBalanceTransaction_Click(object sender, EventArgs e)
        {
            EnterAmountMainPanel.Visible = false;
            MainTableLayoutPanel.Visible = true;
            EnterAmountTextBox.Text = "Enter Amount:";
            AmountTextBox.Text = "$";
            CompleteTransactionButton.Text = "Complete Transaction";


            actionCode = -1;
            CompleteTransactionButton.Click -= new EventHandler(completeCheckBalanceTransaction_Click);
            this.selectedFromAccount = null;

        }

        private void AmountTextBox_Click(object sender, EventArgs e)
        {
            AmountTextBox.Text = string.Empty;
        }
    }
}
