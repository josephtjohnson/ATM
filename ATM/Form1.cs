using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            SelectAccount();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            tblPnlMain.Visible = false;
            tblPnlSelectAccount.Visible = true;
            txtTop.Text = "Deposit In Progress";
            //call method that sets panel visibility and passes in the account being selected
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            tblPnlMain.Visible = false;
            tblPnlSelectAccount.Visible = true;
            txtTop.Text = "Balance Check In Progress";
            //call method that sets panel visibility and passes in the account being selected
        }

        private void btnTransferMoney_Click(object sender, EventArgs e)
        {
            tblPnlMain.Visible = false;
            tblPnlSelectAccount.Visible = true;
            txtTop.Text = "Transfer In Progress";
            //call method that sets panel visibility and passes in the account being selected
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            txtTop.Text = "Welcome to ZZZ Bank\r\nWhere Your Finances Are Our Priority";
            tblPnlWithdrawDeposit.Visible = false;
            tblPnlCheckBalance.Visible = false;
            tblPnlSelectAccount.Visible = false;
            tblPnlMain.Visible = true;
        }

        private void SelectAccount()
        {
            tblPnlSelectAccount.Visible = true;
            WithdrawMoney(btnChecking1.Text);
        }

        private void WithdrawMoney(string account)
        {
            tblPnlMain.Visible = false;
            tblPnlSelectAccount.Visible = true;
            txtTop.Text = "Withdrawal In Progress";
            //call method that sets panel visibility and passes in the account being selected
            //store account selection
            //make the select account panel invisible
            //make the enter the amount panel visible
            //store the amount
            //check against the database
            //throw error if needed
            //error may be exceed transaction allowed total
            //error may be ATM doesn't have sufficient cash available
            //return to the main menu
            //if not complete the transaction
            //store info in the database
            //return to the main menu
        }
    }
}
