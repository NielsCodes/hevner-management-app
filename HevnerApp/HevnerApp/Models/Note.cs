namespace HevnerApp.Models
{
    public class Note
    {
        // Properties
        private int _id;
        private int _parentId;
        private string _parentType;
        private string _text;
        private int _createdBy;
        private string _createdAt;
        
        // Constructor
        public Note(int id, int parentId, string parentType, string text, int createdBy, string createdAt)
        {
            _id = id;
            _parentId = parentId;
            _parentType = parentType;
            _text = text;
            _createdBy = createdBy;
            _createdAt = createdAt;
        }

        // Getters and setters
        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public int ParentId
        {
            get => _parentId;
            set => _parentId = value;
        }

        public string ParentType
        {
            get => _parentType;
            set => _parentType = value;
        }

        public string Text
        {
            get => _text;
            set => _text = value;
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
    }
}