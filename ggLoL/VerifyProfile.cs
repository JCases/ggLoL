namespace ggLoL
{
    abstract class VerifyProfile : User
    {
        public string key { get; set; }

        public VerifyProfile(string name, string password, string email, 
            string nick, bool verify) : 
            base(name, password, email, nick, verify)
        { }
    }
}
