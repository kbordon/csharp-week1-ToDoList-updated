using System.Collections.Generic;

namespace ToDoList.Models
{
    public class Task
    {
        private string _description;
        private static List<string> _instances = new List<string> {};

        public Task (string description)
        {
            _description = description;
            _instances.Add(_description);
        }
        public string GetDescription()
        {
            return _description;
        }
        public void SetDescription(string newDescription)
        {
            _description = newDescription;
        }
        public static List<string> GetAll()
        {
            return _instances;
        }
        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}
