namespace DTO
{
    public class AccountDTO
    {
        private string _Username;
        private string _Password;
        private string _typeAccount;

        public AccountDTO(string username, string password, string typeAccount)
        {
            Username = username;
            Password = password;
            TypeAccount = typeAccount;
        }

        public string Username { get => _Username; set => _Username = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string TypeAccount { get => _typeAccount; set => _typeAccount = value; }
    }
}
