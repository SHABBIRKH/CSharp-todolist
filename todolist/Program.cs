
using System.Collections;

namespace student_grade_tracker
{


    class Program
    {
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the To-Do List App!");

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Mark Task as Completed");
                Console.WriteLine("3. View Tasks");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        MarkTaskAsCompleted();
                        break;
                    case "3":
                        ViewTasks();
                        break;
                    case "4":
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }

        static void AddTask()
        {
            Console.Write("Enter the task: ");
            string task = Console.ReadLine();
            tasks.Add(task);
            Console.WriteLine("Task added successfully!");
        }

        static void MarkTaskAsCompleted()
        {
            Console.WriteLine("Tasks:");
            DisplayTasks();
            Console.Write("Enter the index of the task to mark as completed: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= tasks.Count)
            {
                tasks.RemoveAt(index - 1);
                Console.WriteLine("Task marked as completed!");
            }
            else
            {
                Console.WriteLine("Invalid index. Please enter a valid index.");
            }
        }

        static void ViewTasks()
        {
            Console.WriteLine("Tasks:");
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks found.");
            }
            else
            {
                DisplayTasks();
            }
        }

        static void DisplayTasks()
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }
}