bool A;
bool B;
bool C;

string pack;

string books;
double bookBill;
double packBill;
double totalBill;

Console.WriteLine("Which Package would you like?\n");
Console.WriteLine("\t * Package A: For $9.95 a per month, 10 audiobooks are provided. Additional books are $2.00 per book.");
Console.WriteLine("\t * Package B: For $13.95 per month, 20 audiobooks are provided. Additional books are $1.00 per book");
Console.WriteLine("\t * Package C: For $19.95 per month, unlimited audiobook access is provided.");

pack = Console.ReadLine();

switch (pack)
{
    case "A":

        Console.WriteLine("You have selected Package A. How many audiobooks would you like?");
        books = Console.ReadLine();
        int booksInt = Convert.ToInt32(books);
        if (booksInt > 10)
        {
            bookBill = (booksInt-10) * 2.00;
            
        }


        
        break;

    case "B":
        Console.WriteLine("You have selected Package B. How many audiobooks would you like?");
        books = Console.ReadLine();
        int booksInt = Convert.ToInt32;
        break;

    case "C":

        break;
}