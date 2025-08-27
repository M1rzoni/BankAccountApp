namespace BankAccountApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BankAccount bankAccount = new BankAccount("Saldina Nurak");
            BankAccount bankAccount2 = new BankAccount("Elon Musk");
            BankAccount bankAccount3 = new BankAccount("Bill Gates");
           

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(bankAccount);
            bankAccounts.Add(bankAccount2);
            bankAccounts.Add(bankAccount3);

            BankAccounstGrid.DataSource = bankAccounts;
        }

        private void label2_Click (object sender, EventArgs e)
        {

        }

        
    }
}
