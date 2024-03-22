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
            tblPnlMain.Visible = false;
            tblPnlSelectAccount.Visible = true;
            //call method that sets panel visibility and passes in the account being selected
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            tblPnlMain.Visible = false;
            tblPnlSelectAccount.Visible = true;
            //call method that sets panel visibility and passes in the account being selected
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            tblPnlMain.Visible = false;
            tblPnlSelectAccount.Visible = true;
            //call method that sets panel visibility and passes in the account being selected
        }

        private void btnTransferMoney_Click(object sender, EventArgs e)
        {
            tblPnlMain.Visible = false;
            tblPnlSelectAccount.Visible = true;
            //call method that sets panel visibility and passes in the account being selected
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            tblPnlWithdraw.Visible = false;
            tblPnlDeposit.Visible = false;
            tblPnlCheckBalance.Visible = false;
            tblPnlTransferMoney.Visible = false;
            tblPnlSelectAccount.Visible = false;
            tblPnlMain.Visible = true;
        }
    }
}
