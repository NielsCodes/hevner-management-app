using System.Collections.Generic;
using HevnerApp.Models;

namespace HevnerApp.DataAccessLayer
{
    public class DAL
    {

        private static List<Project> _projects = new List<Project>();
        
        // Get all projects and related data
        public List<Project> GetData()
        {
            return _projects;
        }
        
        // Populate DAL with static test data
        public void PopulateTestData()
        {
            
            // Create user
            User user1 = new User(1, "John Doe", "john@zuyd.nl", "SupergoedWachtwoord123!", "01-01-2019");
            
            // Create Projects
            Project project1 = new Project(1, "Onderzoek 1", "Lorem ipsum 1", "01-01-2019", "01-01-2020", user1, "01-01-2019", false);
            Project project2 = new Project(2, "Onderzoek 2", "Lorem ipsum 2", "01-01-2019", "01-01-2020", user1, "01-01-2019", false);
            Project project3 = new Project(3, "Onderzoek 3", "Lorem ipsum 3", "01-01-2019", "01-01-2020", user1, "01-01-2019", true);

            // Create Tasks
            Task task1 = new Task(1, project1, "To-do task", "Lorem ipsum dolor sit amet", user1, "01-01-2019", "todo", "rigor");
            Task task2 = new Task(2, project1, "In progress task", "Lorem ipsum dolor sit amet", user1, "01-01-2019", "progress", "rigor");
            Task task3 = new Task(3, project1, "Done task", "Lorem ipsum dolor sit amet", user1, "01-01-2019", "done", "design");
            Task task4 = new Task(4, project2, "In progress task", "Lorem ipsum dolor sit amet", user1, "01-01-2019", "progress", "relevance");
            Task task5 = new Task(5, project3, "Done task", "Lorem ipsum dolor sit amet", user1, "01-01-2019", "done", "design");
            
            // Create Subtasks
            Subtask subtask1 = new Subtask(1, task1, "To-do subtask", "Lorem ipsum dolor sit amet", user1, "01-01-2019", "todo");
            Subtask subtask2 = new Subtask(2, task2, "Done subtask", "Lorem ipsum dolor sit amet", user1, "01-01-2019", "done");
            
            // Add Notes
            // -- Projects
            project1.AddNote(new Note(1, 1, "project", "Lorem ipsum dolor sit amet", user1, "01-01-2019" ));
            project1.AddNote(new Note(2, 1, "project", "Lorem ipsum dolor sit amet", user1, "01-01-2019" ));
            project2.AddNote(new Note(3, 2, "project", "Lorem ipsum dolor sit amet", user1, "01-01-2019" ));
            project3.AddNote(new Note(4, 3, "project", "Lorem ipsum dolor sit amet", user1, "01-01-2019" ));
            
            // -- Tasks
            task1.AddNote(new Note(5, 1, "task", "Lorem ipsum dolor sit amet", user1, "01-01-2019" ));
            task1.AddNote(new Note(6, 1, "task", "Lorem ipsum dolor sit amet", user1, "01-01-2019" ));
            task1.AddNote(new Note(7, 1, "task", "Lorem ipsum dolor sit amet", user1, "01-01-2019" ));
            task2.AddNote(new Note(8, 2, "task", "Lorem ipsum dolor sit amet", user1, "01-01-2019" ));
            task3.AddNote(new Note(9, 3, "task", "Lorem ipsum dolor sit amet", user1, "01-01-2019" ));
            
            // -- Subtasks
            subtask1.AddNote(new Note(10, 1, "subtask", "Lorem ipsum dolor sit amet", user1, "01-01-2019" ));
            subtask1.AddNote(new Note(11, 1, "subtask", "Lorem ipsum dolor sit amet", user1, "01-01-2019" ));
            subtask2.AddNote(new Note(12, 2, "subtask", "Lorem ipsum dolor sit amet", user1, "01-01-2019" ));
            
            // Add Subtasks to Tasks
            task1.AddSubtask(subtask1);
            task2.AddSubtask(subtask2);
            
            // Add Tasks to Projects
            project1.AddTask(task1);
            project1.AddTask(task2);
            project1.AddTask(task3);
            project2.AddTask(task4);
            project3.AddTask(task5);
            
            // Add Projects to List
            _projects.Add(project1);
            _projects.Add(project2);
            _projects.Add(project3);

        }
        
        // Getter and setter
        public List<Project> Projects
        {
            get => _projects;
            set => _projects = value;
        }
        
    }
}