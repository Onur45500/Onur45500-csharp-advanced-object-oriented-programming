Rectangle rect1 = new Rectangle(10, 20);
Rectangle rect2 = new Rectangle(30);

Console.WriteLine(rect1.GetArea());
Console.WriteLine(rect2.GetArea());

rect1.BorderSize = 5;
Console.WriteLine(rect1.BorderSize);

rect2.Width = 5;
rect2.Height = 10;
Console.WriteLine(rect2.GetArea());