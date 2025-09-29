namespace AdminLTE_APP.Models
{
    public class Login
    {
        private string? username;
        private string? password;

        public string? Username
        {
            get { return username; }
            set { username = value; }
        }

        public string? Password
        {
            get { return password; }
            set { password = value; }
        }

        public Login() { }
        public Login(string? username, string? password)
        {
            this.username = username;
            this.password = password;
        }
        public override string ToString()
        {
            return $"Username: {username}, Password: {password}";
        }
    }
}
