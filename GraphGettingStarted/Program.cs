// See https://aka.ms/new-console-template for more information
Console.WriteLine(".NET Core Graph Tutorial\n");

// Adding my service principal 
var appId = "df57226e-81c9-4e72-88b5-3828d38d6583";
string[] scopes = {"User.Read", "Mail.Read", "Mail.Send"};

int choice = -1;

while (choice != 0) {
    Console.WriteLine("Please choose one of the following options:");
    Console.WriteLine("0. Exit");
    Console.WriteLine("1. Display access token");
    Console.WriteLine("2. View the signed in user");
    Console.WriteLine("3. View the signed in user emails");
    Console.WriteLine("4. Send an email as the signed in user");

    try
    {
        choice = int.Parse(Console.ReadLine()!);
    }
    catch (System.FormatException)
    {
        // Set to invalid value
        choice = -1;
    }

    switch(choice)
    {
        case 0:
            // Exit the program
            Console.WriteLine("Goodbye...");
            break;
        case 1:
            // Display access token
            break;
        case 2:
            // Get signed in user
            break;
        case 3:
            // Get messages
            break;
        case 4:
            // Send mail
            break;
        default:
            Console.WriteLine("Invalid choice! Please try again.");
            break;
    }
}
