namespace HevnerApp.Models
{
    public class User
    {

        // Properties
        private int _id;
        private string _name;
        private string _email;
        private string _password;
        private string _dateAdded;

        // Constructor
        public User(int id, string name, string email, string password, string dateAdded)
        {
            _id = id;
            _name = name;
            _email = email;
            _password = password;
            _dateAdded = dateAdded;
        }

        // Getters and setters
        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public string Password
        {
            get => _password;
            set => _password = value;
        }

        public string DateAdded
        {
            get => _dateAdded;
            set => _dateAdded = value;
        }
    }
}