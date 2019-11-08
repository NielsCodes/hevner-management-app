using System.Collections.Generic;

namespace HevnerApp.Models
{
    public class Task
    {

        // Properties
        private int _id;
        private Project _parentProject;
        private string _name;
        private string _description;
        private User _createdBy;
        private string _createdAt;
        private string _status;
        private string _cycle;
        private List<Note> _notes = new List<Note>();
        private List<Subtask> _subtasks = new List<Subtask>();

        // Add new Note
        public void AddNote(Note note)
        {
            _notes.Add(note);
        }
        
        // Add new Subtask
        public void AddSubtask(Subtask subtask)
        {
            _subtasks.Add(subtask);
        }
        
        // Constructor
        public Task(int id, Project parentProject, string name, string description, User createdBy, string createdAt, string status, string cycle)
        {
            _id = id;
            _parentProject = parentProject;
            _name = name;
            _description = description;
            _createdBy = createdBy;
            _createdAt = createdAt;
            _status = status;
            _cycle = cycle;
        }
        
        // Getters and setters
        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public Project ParentProject
        {
            get => _parentProject;
            set => _parentProject = value;
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

        public User CreatedBy
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
        
        public string Cycle
        {
            get => _cycle;
            set => _cycle = value;
        }

        public List<Note> Notes
        {
            get => _notes;
            set => _notes = value;
        }

        public List<Subtask> Subtasks
        {
            get => _subtasks;
            set => _subtasks = value;
        }
    }
}