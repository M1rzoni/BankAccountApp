using System.Drawing.Imaging;

namespace BankAccountApp
{
    public partial class Form1 : Form
    {

        List<BankAccount> BankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();


            BankAccounstGrid.DataSource = BankAccounts;
        }



        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(OwnerTxt.Text))
                return;

            BankAccount bankAccount = new BankAccount(OwnerTxt.Text);
            BankAccounts.Add(bankAccount);

            RefresGrid();

            OwnerTxt.Text = "";

        }

        private void RefresGrid()
        {
            BankAccounstGrid.DataSource = null;
            BankAccounstGrid.DataSource = BankAccounts;
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {

            if (BankAccounstGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = BankAccounstGrid.SelectedRows[0].DataBoundItem as BankAccount;

              string message =  selectedBankAccount.Deposite(AmountNum.Value);

                RefresGrid();

                AmountNum.Value = 0;

                MessageBox.Show(message);


            }

        }
         
        private void WithdrawBtn_Click(object sender, EventArgs e)
        {

            if (BankAccounstGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = BankAccounstGrid.SelectedRows[0].DataBoundItem as BankAccount;

                    string message = selectedBankAccount.Withdraw(AmountNum.Value);

                    RefresGrid();

                    AmountNum.Value = 0;

                    MessageBox.Show(message);

                }
               
               
            }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
