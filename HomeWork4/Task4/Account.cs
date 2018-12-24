namespace Task4
{
    struct Account
    {
        public string Login { get; set; }
        public string PassWord { get; set; }

        public Account(string login, string password)
        {
            Login = login;
            PassWord = password;
        }
    }
}
