namespace Finance
{
    class AlfaBank : Bank
    {
        public AlfaBank(User client) : base(client)
        {
            this.BankName = "AlfaBank";
        }
    }
}
