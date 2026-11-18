using System.Text;
 //Q1:
string title = "clean code";
string upperTitle = title.ToUpper();
Console.WriteLine(title);
Console.WriteLine(upperTitle);

//Q2:
string s1 = "Clean Code";
string s2 = "Clean Code";
Console.WriteLine(object.ReferenceEquals(s1,s2));

//Q3:
StringBuilder sb = new StringBuilder();
sb.Append("Book List");
sb.Append(" - Updated");
Console.WriteLine(sb.ToString());

//Q4:
sb.Replace("Book List", "Library");
Console.WriteLine(sb);

//Q5:
string title1 = "Clean Code";
int pages = 464;
Console.WriteLine("Book: "+title1 +","+"Pages: "+pages);

//Q6:
Console.WriteLine($"Book: {title1},Pages: {pages}");

//Q7:
Console.WriteLine(string.Format("Book: {0},Pages: {1}",title1,pages));

//Q8:

if (pages > 300)
{
    Console.WriteLine("Long Book");
}
else
{
    Console.WriteLine("Short Book");
}

//Q9:
bool isAvailable = true;
if (pages > 300 && isAvailable )
{
    Console.WriteLine("You can borrow this book");
}

//Q10:
string title2 = "Refactoring";
switch (title2)
{
    case "Clean Code":
        Console.WriteLine("Great choice!");
        break;
    case "Refactoring":
        Console.WriteLine("Nice pick!");
        break;
    default:
        Console.WriteLine("Never heard of it");
        break;
}

//Q11:



//Q12:
string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

for (int i = 0; i < books.Length; i++)
{
    Console.WriteLine((i + 1) + "." + books[i] );
}

//Q13:
int j = 0;
while (j < books.Length)
{
    Console.WriteLine(books[j]);
    j++;
}

//Q14:
int count = 0;
do
{
    Console.WriteLine("Checking book...");
    count++;
} while (count < 3);

//Q15:
foreach (string item in books)
{
    Console.WriteLine(item);
}

//Q16:
for (int K = 0 ; K < books.Length; K++)
{

    if (books[K] == "Refactoring")
        break;
    Console.WriteLine(books[K]);
}

//Q17:
for (int K = 0; K < books.Length; K++)
{
    if (books[K] == "The Pragmatic Programmer")
        continue;
    Console.WriteLine(books[K]);
}

//Q18:
void PrintFirstBook()
{
    if (books.Length == 0)
        return;
    Console.WriteLine(books[0]);
}
PrintFirstBook();
