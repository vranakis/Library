using Library.Models;

Console.WriteLine("Hello World!");

var dateTime = DateTime.Now;

var journal = new Journal("FS.V.", "Reality is a Dream", "Yolo", 33, dateTime);
var textbook = new TextBook("FS.V.", "Yo book", "me", "me");
var member = new Member("Nikos", "Petrou");

if (member.IsActive)
{
    Console.WriteLine("Member is Active");
    journal.Rent(member);
    textbook.Rent(member);
}
else
{
    Console.WriteLine("Member is not Active");
}

if (journal.Available) { 
    Console.WriteLine("The journal is still available"); 
}

else {
    Console.WriteLine("The journal is now NOT available"); 
}



textbook.Return(member);




