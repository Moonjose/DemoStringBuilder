using DemoStringBuilder.Entities;

Comment c1 = new Comment("YEP YEP LIGHT WEIGHT");
Comment c2 = new Comment("I LOVE YOU RONNIE COLEMAN");

Post p1 = new Post(
    DateTime.Parse("23/04/2015 15:30:19"),
    "Yeah Buddy",
    "Lets go to gym yep yep buddy light weight baby",
    33
    );

Comment c3 = new Comment("Good night");
Comment c4 = new Comment("May the Force be with you");

Post p2 = new Post(
    DateTime.Parse("28/07/2018 23:14:19"),
    "Good night guys",
    "See you tomorrow",
    5
    );

p1.AddComment(c1);
p1.AddComment(c2);
p2.AddComment(c3);
p2.AddComment(c4);

Console.WriteLine(p1);
Console.WriteLine(p2);