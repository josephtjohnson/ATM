using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Account
    {
        int accountNum;
        int customerID;
        double balance;
        double pendingBalance;
        string pendingBalanceDate;
        double dailyDepositAmount;
        double dailyTransactionTotal;
        double dailyTransactionLimit = 3000.0;
        string dailyTransactionDate;
        Transaction newTransaction;

        public Account(int accountNum, int customerID, double balance, double pendingBalance, string pendingBalanceDate, double dailyDepositAmount, double dailyTransactionTotal, double dailyTransactionLimit, string dailyTransactionDate)
        {
            this.accountNum = accountNum;
            this.customerID = customerID;
            this.balance = balance;
            this.pendingBalance = pendingBalance;
            this.pendingBalanceDate = pendingBalanceDate;
            this.dailyDepositAmount = dailyDepositAmount;
            this.dailyTransactionTotal = dailyTransactionTotal;
            this.dailyTransactionLimit = dailyTransactionLimit;
            this.dailyTransactionDate = dailyTransactionDate;
        }
        
        public double getAccountBalance()
        {
            return this.balance;
        }

        public Transaction getNewTransaction()
        {
            return newTransaction;
        }


        public int withdrawMoney(double amount, double machineCash)
        {
            updateDailyTransaction();
            if (checkDailyTransaction() == false)
                return 1;
            if (verifyDailyTransaction(amount) == false)
                return 2;
            if (verifyAccountBalance(amount) == false)
                return 3;
            if (checkMachineCash(amount, machineCash) == false)
                return 4;
            updateBalanceWithdraw(amount);
            updateDailyTransactionTotal(amount);
            updateAccountData();

            //newTransaction = new Transaction(accountNum, "Withdraw", amount, -1, -1);
            //newTransaction.saveTransaction();

            return 0;
        }

        public int depositMoney(double amount) 
        {
            updateDailyTransaction();
            updateDailyPendingBalance();
            if (checkDailyTransaction() == false)
                return 1;
            if (verifyDailyTransaction(amount) == false)
                return 2;
            updateBalanceDeposit(amount);
            updateDailyTransactionTotal(amount);
            updatePendingBalance(amount);
            updateAccountData();

            //newTransaction = new Transaction(accountNum, "Deposit", amount, -1, -1);
            //newTransaction.saveTransaction();

            return 0;

        }

        public int transferMoney(double amount, Account toAccount) 
        {
            this.updateDailyTransaction();
            toAccount.updateDailyTransaction();

            //verify fromAccount works
            if(this.checkDailyTransaction() == false)
                return 1;
            if(this.verifyDailyTransaction(amount) == false)
                return 2;
            if (this.verifyDailyTransaction(amount) == false)
                return 3;
            if(this.verifyAccountBalance(amount) == false)
                return 4;

            //verify toAccount works
            if (toAccount.checkDailyTransaction() == false)
                return 5;
            if (toAccount.verifyDailyTransaction(amount) == false)
                return 6;

            this.updateBalanceWithdraw(amount);
            toAccount.updateBalanceDeposit(amount);

            this.updateDailyTransactionTotal(amount);
            toAccount.updateDailyTransactionTotal(amount);

            toAccount.updatePendingBalance(amount);

            this.updateAccountData();
            toAccount.updateAccountData();

            //newTransaction = new Transaction(accountNum, "Transfer", amount, this.accountNum, toAccount.accountNum);
            //newTransaction.saveTransaction();

            return 0;
        }

        private void updateDailyTransaction()
        {
            string todayDate = DateTime.Now.ToString("yyyy-MM-dd");
            Console.WriteLine("old date: " + dailyTransactionDate);
            Console.WriteLine("new date: " + todayDate);
            if (!dailyTransactionDate.Equals(todayDate))
            {
                dailyTransactionDate = todayDate;
                dailyTransactionTotal = 0.0;
                dailyDepositAmount = 0.0;
                Console.WriteLine("Date being changed.");
            }
        }

        private void updateDailyPendingBalance()
        {
            string todayDate = DateTime.Now.ToString("yyy-MM-dd");
            if(!pendingBalanceDate.Equals(todayDate))
            {
                pendingBalanceDate = todayDate;
                pendingBalance = 0.0;
            }
        }

        public bool checkDailyTransaction()
        {
            if (dailyTransactionTotal >= 3000.0)
                return false;
            return true;
        }

        private bool verifyDailyTransaction(double amount)
        {
            if ((dailyTransactionTotal + amount) > 3000.0)
                return false;
            else
                return true;
        }

        private bool verifyAccountBalance(double amount)
        {
            if (amount > Math.Abs((pendingBalance - balance)))
                return false;
            return true;
        }

        private bool checkMachineCash(double amount, double machineCash)
        {
            if (amount > machineCash)
                return false;
            return true;
        }

        private void updateBalanceWithdraw(double amount)
        {
            balance = balance - amount;
        }

        private void updateBalanceDeposit(double amount)
        {
            balance = balance + amount;
        }

        private void updateDailyTransactionTotal(double amount)
        {
            dailyTransactionTotal = dailyTransactionTotal + amount;
        }

        private void updatePendingBalance(double amount)
        {
            pendingBalance = pendingBalance + amount;
        }

        private void updateAccountData()
        {
            //string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
            //MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            //try
            //{
            //    Console.WriteLine("Connecting to MySQL...");
            //    conn.Open();
            //    //string sql = "INSERT INTO changstudent (id, name) VALUES (@uid, @uname)";
            //    string sql = "UPDATE changAccount SET dailyTransDate=@date, dailyTransTotal=@total, balance=@newBalance WHERE accountNum=@accNum;";
            //    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
            //    cmd.Parameters.AddWithValue("@date", dailyTransactionDate);
            //    cmd.Parameters.AddWithValue("@total", dailyTransactionTotal);
            //    cmd.Parameters.AddWithValue("@newBalance", balance);
            //    cmd.Parameters.AddWithValue("@accNum", accountNum);

            //    if this is a deposit then add pendingBalance;

            //    cmd.ExecuteNonQuery();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
            //conn.Close();
            //Console.WriteLine("Done.");

        }

        public int getAccountNum()
        {
            return accountNum;
        }
        public static ArrayList retrieveAccounts(int id)
        {
            ArrayList accountList = new ArrayList();
            ////ArrayList eventList = new ArrayList();  //a list to save the events
            ////prepare an SQL query to retrieve all the events on the same, specified date
            //DataTable myTable = new DataTable();
            //string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
            //MySqlConnection conn = new MySqlConnection(connStr);
            //try
            //{
            //    Console.WriteLine("Connecting to MySQL...");
            //    conn.Open();
            //    string sql = "SELECT * FROM changAccount WHERE customerID=@myID ORDER BY accountNum ASC";
            //    MySqlCommand cmd = new MySqlCommand(sql, conn);
            //    cmd.Parameters.AddWithValue("@myID", id);
            //    MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
            //    myAdapter.Fill(myTable);
            //    Console.WriteLine("Table is ready.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
            //conn.Close();
            ////convert the retrieved data to events and save them to the list
            //foreach (DataRow row in myTable.Rows)
            //{
            //    Account newAccount = new Account();

            //    newAccount.accountNum = Int32.Parse(row["accountNum"].ToString());
            //    newAccount.customerID = Int32.Parse(row["customerID"].ToString());
            //    newAccount.balance = Double.Parse(row["balance"].ToString());
            //    newAccount.dailyTransactionTotal = Double.Parse(row["dailyTransTotal"].ToString());
            //    newAccount.dailyTransactionDate = row["dailyTransDate"].ToString();
            //    newAccount.dailyDepositAmount = Double.Parse(row["dailyDepositAmount"].ToString());
            //    /*
            //    newEvent.eventDate = row["date"].ToString();
            //    newEvent.eventStartTime = Int32.Parse(row["startTime"].ToString());
            //    newEvent.eventEndTime = Int32.Parse(row["endTime"].ToString());
            //    newEvent.eventContent = row["content"].ToString();
            //    */
            //    accountList.Add(newAccount);
            //}
            //Console.WriteLine("*********" + accountList.Count);
            return accountList;  //return the event list
        }
    }
}
