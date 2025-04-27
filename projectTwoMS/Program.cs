class LibraryManager
{
    static void Main()
    {
        // Constants defining the maximum number of books in the library and the maximum books a user can borrow
        const int MaxBooks = 5; // Maximum number of books the library can hold
        const int MaxBorrowedBooks = 3; // Maximum number of books a user can borrow

        // Arrays to store the books in the library and the books borrowed by the user
        string[] library = new string[MaxBooks]; // Array to store book titles in the library
        string[] borrowedBooks = new string[MaxBorrowedBooks]; // Array to track borrowed books

        // Main program loop
        while (true)
        {
            // Prompt the user for an action
            Console.WriteLine("Would you like to add, remove, view, search, borrow, check-in, or exit? (add/remove/view/search/borrow/check-in/exit)");
            string userAction = Console.ReadLine()?.ToLower(); // Read user input and convert it to lowercase

            // Handle the user's action using a switch statement
            switch (userAction)
            {
                case "add":
                    // Add a book to the library
                    AddBook(library);
                    break;
                case "remove":
                    // Remove a book from the library
                    RemoveBook(library);
                    break;
                case "view":
                    // View all books currently in the library
                    ViewBooks(library);
                    break;
                case "search":
                    // Search for a specific book in the library
                    SearchBook(library);
                    break;
                case "borrow":
                    // Borrow a book from the library
                    BorrowBook(library, borrowedBooks);
                    break;
                case "check-in":
                    // Check in a borrowed book
                    CheckInBook(library, borrowedBooks);
                    break;
                case "exit":
                    // Exit the program
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    // Handle invalid input
                    Console.WriteLine("Invalid action. Please type 'add', 'remove', 'view', 'search', 'borrow', 'check-in', or 'exit'.");
                    break;
            }
        }
    }

    // Method to add a book to the library
    static void AddBook(string[] library)
    {
        // Check if the library is full
        if (Array.TrueForAll(library, book => !string.IsNullOrEmpty(book)))
        {
            Console.WriteLine("The library is full. No more books can be added.");
            return;
        }

        // Prompt the user to enter the title of the book to add
        Console.WriteLine("Enter the title of the book to add:");
        string newBook = Console.ReadLine();

        // Find the first empty slot in the library array and add the book
        for (int i = 0; i < library.Length; i++)
        {
            if (string.IsNullOrEmpty(library[i]))
            {
                library[i] = newBook;
                Console.WriteLine($"Book '{newBook}' added to the library.");
                return;
            }
        }
    }

    // Method to remove a book from the library
    static void RemoveBook(string[] library)
    {
        // Check if the library is empty
        if (Array.TrueForAll(library, book => string.IsNullOrEmpty(book)))
        {
            Console.WriteLine("The library is empty. No books to remove.");
            return;
        }

        // Prompt the user to enter the title of the book to remove
        Console.WriteLine("Enter the title of the book to remove:");
        string bookToRemove = Console.ReadLine();

        // Search for the book in the library and remove it if found
        for (int i = 0; i < library.Length; i++)
        {
            if (library[i]?.Equals(bookToRemove, StringComparison.OrdinalIgnoreCase) == true)
            {
                library[i] = null; // Remove the book by setting the slot to null
                Console.WriteLine($"Book '{bookToRemove}' removed from the library.");
                return;
            }
        }

        // If the book is not found, inform the user
        Console.WriteLine($"Book '{bookToRemove}' not found in the library.");
    }

    // Method to view all books currently in the library
    static void ViewBooks(string[] library)
    {
        Console.WriteLine("Books currently in the library:");
        bool hasBooks = false; // Flag to check if there are any books in the library

        // Iterate through the library array and display all non-empty slots
        foreach (string book in library)
        {
            if (!string.IsNullOrEmpty(book))
            {
                Console.WriteLine($"- {book}");
                hasBooks = true;
            }
        }

        // If no books are found, inform the user
        if (!hasBooks)
        {
            Console.WriteLine("The library is empty.");
        }
    }

    // Method to search for a specific book in the library
    static void SearchBook(string[] library)
    {
        // Prompt the user to enter the title of the book to search for
        Console.WriteLine("Enter the title of the book to search for:");
        string bookToSearch = Console.ReadLine();

        // Search for the book in the library
        foreach (string book in library)
        {
            if (book?.Equals(bookToSearch, StringComparison.OrdinalIgnoreCase) == true)
            {
                Console.WriteLine($"Book '{bookToSearch}' is available in the library.");
                return;
            }
        }

        // If the book is not found, inform the user
        Console.WriteLine($"Book '{bookToSearch}' is not in the library.");
    }

    // Method to borrow a book from the library
    static void BorrowBook(string[] library, string[] borrowedBooks)
    {
        // Check if the user has reached the borrowing limit
        if (Array.TrueForAll(borrowedBooks, book => !string.IsNullOrEmpty(book)))
        {
            Console.WriteLine("You have reached the borrowing limit of 3 books.");
            return;
        }

        // Prompt the user to enter the title of the book to borrow
        Console.WriteLine("Enter the title of the book to borrow:");
        string bookToBorrow = Console.ReadLine();

        // Search for the book in the library
        for (int i = 0; i < library.Length; i++)
        {
            if (library[i]?.Equals(bookToBorrow, StringComparison.OrdinalIgnoreCase) == true)
            {
                // Add the book to the borrowedBooks array
                for (int j = 0; j < borrowedBooks.Length; j++)
                {
                    if (string.IsNullOrEmpty(borrowedBooks[j]))
                    {
                        borrowedBooks[j] = bookToBorrow; // Mark the book as borrowed
                        library[i] = null; // Remove the book from the library
                        Console.WriteLine($"Book '{bookToBorrow}' borrowed successfully.");
                        return;
                    }
                }
            }
        }

        // If the book is not found, inform the user
        Console.WriteLine($"Book '{bookToBorrow}' is not available in the library.");
    }

    // Method to check in a borrowed book
    static void CheckInBook(string[] library, string[] borrowedBooks)
    {
        // Prompt the user to enter the title of the book to check in
        Console.WriteLine("Enter the title of the book to check in:");
        string bookToCheckIn = Console.ReadLine();

        // Search for the book in the borrowedBooks array
        for (int i = 0; i < borrowedBooks.Length; i++)
        {
            if (borrowedBooks[i]?.Equals(bookToCheckIn, StringComparison.OrdinalIgnoreCase) == true)
            {
                borrowedBooks[i] = null; // Remove the book from the borrowedBooks array

                // Add the book back to the library
                for (int j = 0; j < library.Length; j++)
                {
                    if (string.IsNullOrEmpty(library[j]))
                    {
                        library[j] = bookToCheckIn; // Add the book to the library
                        Console.WriteLine($"Book '{bookToCheckIn}' checked in successfully.");
                        return;
                    }
                }
            }
        }

        // If the book is not found in the borrowedBooks array, inform the user
        Console.WriteLine($"Book '{bookToCheckIn}' is not currently borrowed.");
    }
}