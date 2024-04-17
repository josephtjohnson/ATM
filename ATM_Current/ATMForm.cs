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
            MainTableLayoutPanel.Visible = false;
            SelectAccountsMainPanel.Visible = true;
            FromAccountTextBox.Text = "Withdraw Account";
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
            MainTableLayoutPanel.Visible = false;
            SelectAccountsMainPanel.Visible = true;
            ToAccountTextBox.Text = "Deposit Account";
            FromAccountTextBox.Visible = false;
            FromAccounts.Visible = false;

            FromAccounts.Items.Clear();
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
            MainTableLayoutPanel.Visible = false;
            SelectAccountsMainPanel.Visible = true;
            FromAccountTextBox.Text = "From Account";
            ToAccountTextBox.Text = "To Account";

            FromAccounts.Items.Clear();
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
            MainTableLayoutPanel.Visible = false;
            SelectAccountsMainPanel.Visible = true;
            FromAccountTextBox.Text = "Account";
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
                selectedFromAccount = (Account)accountList[FromAccounts.SelectedIndex];

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

            else if (actionCode == 4) //CheckBalance
            {
                selectedFromAccount = (Account)accountList[FromAccounts.SelectedIndex];
            }
        }

        private void ToAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (actionCode == 2 || actionCode == 3) 
            {
                selectedToAccount = (Account)accountList[ToAccounts.SelectedIndex];

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

        private void proceedButton_Click(object sender, EventArgs e)
        {

            SelectAccountsMainPanel.Visible = false;

            if (actionCode == 1) //Withdraw
            {
                EnterAmountMainPanel.Visible = true;
                CompleteTransactionButon.Click += new EventHandler(completeWithdrawTransaction_Click);
            }

            else if (actionCode == 2) //deposit
            {
                EnterAmountMainPanel.Visible = true;
                CompleteTransactionButon.Click += new EventHandler(completeDepositTransaction_Click);
            }

            else if (actionCode == 3) 
            {
                EnterAmountMainPanel.Visible = true;
                CompleteTransactionButon.Click += new EventHandler(completeTransferTransaction_Click);
            }

            else if (actionCode == 4)
            {
                EnterAmountMainPanel.Visible = true;
                CompleteTransactionButon.Click += new EventHandler(completeCheckBalanceTransaction_Click);

            }

            actionCode = -1;
        }

        private void completeWithdrawTransaction_Click(object sender, EventArgs e)
        {
            double amount = Double.Parse(AmountTextBox.Text.Remove(0,1));
            int errorCode = selectedFromAccount.withdrawMoney(amount, machineCash);
            if (errorCode == 0)
            {
                //fromLabel.Text = "Please take the money.\n Transaction number: "
                //    + selectedFromAccount.getNewTransaction().getTransNum() + "\n" + "Withdrawal amount: $"
                //    + selectedFromAccount.getNewTransaction().getAmount() + "\n" + "From account: "
                //    + selectedFromAccount.getAccountNum();

                fromLabel.Text = "Take your money!";

                Thread.Sleep(3000);
                EnterAmountPanel.Visible= false;
                fromLabel.Text = string.Empty;
                ChooseActionPanel.Visible = true;
            }
            else if (errorCode == 1)
            {
                fromLabel.Text = "The transactions of this account have exceeded the max limit $3000 for today.\n"
                    + "Please select another account.";
            }
            else if (errorCode == 2)
            {
                fromLabel.Text = "The amount will make the transactions of this account exceed the max limit $3000 for today.\n"
                    + "Please enter a smaller amount.";
            }
            else if (errorCode == 3)
            {
                fromLabel.Text = "The amount you entered is greater than the balance of the selected account.\n"
                    + "Please enter a smaller amount.";
            }
            else if (errorCode == 4)
            {
                fromLabel.Text = "The machince doesn't have enough cash for your withdrawal.\n"
                    + "Please enter a smaller amount.";
            }

            actionCode = -1;

        }

        private void completeDepositTransaction_Click(object sender, EventArgs e)
        {
            double amount = Double.Parse(AmountTextBox.Text.Remove(0,1));
            int errorCode = selectedToAccount.depositMoney(amount);
            if (errorCode == 0)
            {
                //fromLabel.Text = "Please insert the money.\n Transaction number: "
                //    + selectedToAccount.getNewTransaction().getTransNum() + "\n" + "Deposit amount: $"
                //    + selectedToAccount.getNewTransaction().getAmount() + "\n" + "To account: "
                //    + selectedToAccount.getAccountNum();

                fromLabel.Text = "Give your money";

                Thread.Sleep(3000);
                EnterAmountPanel.Visible = false;
                fromLabel.Text = string.Empty;
                ChooseActionPanel.Visible = true;
            }
            else if (errorCode == 1)
            {
                fromLabel.Text = "The transactions of this account have exceeded the max limit $3000 for today.\n"
                    + "Please select another account.";
            }
            else if (errorCode == 2)
            {
                fromLabel.Text = "The amount will make the transactions of this account exceed the max limit $3000 for today.\n"
                    + "Please enter a smaller amount.";
            }

            actionCode = -1;

        }

        private void completeTransferTransaction_Click(object sender, EventArgs e)
        {
            double amount = Double.Parse(AmountTextBox.Text.Remove(0,1));
            int errorCode = selectedFromAccount.transferMoney(amount, selectedToAccount);
            if (errorCode == 0)
            {
                //fromLabel.Text = "Transfer Complete.\n Transaction number: "
                //    + selectedToAccount.getNewTransaction().getTransNum() + "\n" + "Transfer amount: $"
                //    + selectedToAccount.getNewTransaction().getAmount() + "\n" + "To account: "
                //    + selectedToAccount.getAccountNum();

                fromLabel.Text = "Transfer your money";

                Thread.Sleep(3000);
                EnterAmountPanel.Visible = false;
                fromLabel.Text = string.Empty;
                ChooseActionPanel.Visible = true;
            }
            else if (errorCode == 1)
            {
                fromLabel.Text = "The transactions of the originating account have exceeded the max limit $3000 for today.\n"
                    + "Please select another account.";
            }
            else if (errorCode == 2)
            {
                fromLabel.Text = "The amount will make the transactions of the originating account exceed the max limit $3000 for today.\n"
                    + "Please enter a smaller amount.";
            }
            else if (errorCode == 3)
            {
                fromLabel.Text = "The amount you entered is greater than the balance of the originating account.\n"
                    + "Please enter a smaller amount.";
            }
            else if (errorCode == 5)
            {
                fromLabel.Text = "The transactions of the target account have exceeded the max limit $3000 for today.\n"
                    + "Please select another account.";
            }
            else if (errorCode == 6)
            {
                fromLabel.Text = "The amount will make the transactions of the target account exceed the max limit $3000 for today.\n"
                    + "Please enter a smaller amount.";
            }

            actionCode = -1;

        }

        private void completeCheckBalanceTransaction_Click(object sender, EventArgs e)
        {
            EnterAmountTextBox.Text = "Current Balance";
            AmountTextBox.Text = selectedFromAccount.getAccountBalance().ToString();

            Thread.Sleep(3000);
            EnterAmountPanel.Visible = false;
            ChooseActionPanel.Visible = true;


            actionCode = -1;

        }
    }
}
