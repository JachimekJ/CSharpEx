//Your application allows users to manage a simple to-do list.
//The program will let users add tasks, view the list of tasks, and mark tasks as completed.

using System;

public class ToDoList
{
    // This array will hold the tasks. The size is set to 10 for simplicity.
    public static string[] tasks = new string[10];
    int taskCount = 0;
    
    // Method to add a task to the list
    // The method takes a string parameter representing the task to be added.
    public void AddTask(string task)
    {
        if (taskCount < tasks.Length)
        {
            tasks[taskCount] = task;
            taskCount++;
            Console.WriteLine("Task added: " + task);

        }
        else
        {
            Console.WriteLine("Task list is full. Cannot add more tasks.");
        }
    }

    // Method to view all tasks in the list
    // This method does not take any parameters and returns void
    public void ViewTasks()
    {
        Console.WriteLine("To-Do List:");
        for (int i = 0; i < taskCount; i++)
        {
            Console.WriteLine((i + 1) + ". " + tasks[i]);
        }  
    }

    // Method to mark a task as completed
    // The method takes an integer parameter representing the task number to be marked as completed.

    public void CompleteTask()
    {
        Console.WriteLine("Enter the task number to set it as completed:");
        int taskNumber = Convert.ToInt32(Console.ReadLine()) - 1;

        if (taskNumber >= 0 && taskNumber < taskCount)
        {
            Console.WriteLine("Task completed: " + tasks[taskNumber]);
            tasks[taskNumber] = null; // Remove the task from the list
            taskCount--;
            // Shift tasks down to fill the gap
            for (int i = taskNumber; i < taskCount; i++)
            {
                tasks[i] = tasks[i + 1];
            }
        }
        else
        {
            Console.WriteLine("Invalid task number. Please try again.");
        }
    }

    // Main method to run the program
    public static void Main(string[] args)
    {
        ToDoList toDoList = new ToDoList();
        bool running = true;
        
            while (running)
            {
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Complete Task");
                Console.WriteLine("4. Exit");
                Console.Write("Please, choose an option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the task: ");
                        string task = Console.ReadLine();
                        toDoList.AddTask(task);
                        break;
                    case 2:
                        toDoList.ViewTasks();
                        break;
                    case 3:
                        toDoList.CompleteTask();
                        break;
                    case 4:
                        running = false;
                        Console.WriteLine("Exiting the program. See you next  time!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            }
    }



}