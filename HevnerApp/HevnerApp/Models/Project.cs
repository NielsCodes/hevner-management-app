namespace HevnerApp.Models
{
    public class Project
    {
        // Properties
        private int _id;
        private string _name;
        private string _description;
        private string _startDate;
        private string _deadline;
        private string _createdBy;
        private string _createdAt;
        private bool _hasFinished;

        public Project(int id, string name, string description, string startDate, string deadline, string createdBy, string createdAt, bool hasFinished)
        {
            _id = id;
            _name = name;
            _description = description;
            _startDate = startDate;
            _deadline = deadline;
            _createdBy = createdBy;
            _createdAt = createdAt;
            _hasFinished = hasFinished;
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

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public string StartDate
        {
            get => _startDate;
            set => _startDate = value;
        }

        public string Deadline
        {
            get => _deadline;
            set => _deadline = value;
        }

        public string CreatedBy
        {
            get => _createdBy;
            set => _createdBy = value;
        }

        public string CreatedAt
        {
            get => _createdAt;
            set => _createdAt = value;
        }
        
        public bool HasFinished
        {
            get => _hasFinished;
            set => _hasFinished = value;
        }
    }
}