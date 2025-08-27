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
    }
}
