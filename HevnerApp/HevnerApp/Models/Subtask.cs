namespace HevnerApp.Models
{
    public class Subtask
    {
        // Properties
        private int _id;
        private int _taskId;
        private string _name;
        private string _description;
        private int _createdBy;
        private string _createdAt;
        private string _status;
        
        // Constructor
        public Subtask(int id, int taskId, string name, string description, int createdBy, string createdAt, string status)
        {
            _id = id;
            _taskId = taskId;
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

        public int TaskId
        {
            get => _taskId;
            set => _taskId = value;
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

        public string CreatedAt
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