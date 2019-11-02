namespace HevnerApp.Models
{
    public class Task
    {

        // Properties
        private int _id;
        private int _projectId;
        private string _name;
        private string _description;
        private int _createdBy;
        private int _createdAt;
        private string _status;

        // Constructor
        public Task(int id, int projectId, string name, string description, int createdBy, int createdAt, string status)
        {
            _id = id;
            _projectId = projectId;
            _name = name;
            _description = description;
            _createdBy = createdBy;
            _createdAt = createdAt;
            _status = status;
        }

        // Getters and setters
        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public int ProjectId
        {
            get => _projectId;
            set => _projectId = value;
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

        public int CreatedBy
        {
            get => _createdBy;
            set => _createdBy = value;
        }

        public int CreatedAt
        {
            get => _createdAt;
            set => _createdAt = value;
        }

        public string Status
        {
            get => _status;
            set => _status = value;
        }
    }
}