namespace Resturant.Classes
{
    class Manger : Employee
    {

        //public string UserName { get; set; }
        //public string Password { get; set; }
        //public string manager { get; set; }
        private string userName;
        private string password;
        public string UserName { get { return userName; } }
        public string Password { get { return password; } }
        public Manger()
        {
            userName = "admin";
            password = "admin123";
            Name = "Taha";

        }

        public Manger(string name, int id) : base(name, id)
        {
            userName = "admin";
            password = "admin123";
        }
        public Manger(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
    }

}
