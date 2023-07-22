using SOLID_Review_the_queue___Open__Closed;

var myQueue = new MyQueue<int>();

myQueue.Queue(1);
myQueue.Queue(2);
myQueue.Queue(3);
myQueue.Queue(4);
myQueue.Queue(5);

Console.WriteLine("sto stampando i dati dalla queue:");
foreach (int item in myQueue)
{
    Console.WriteLine(item);
}

Console.WriteLine("sto prendendo l'ultimo elemento dalla queue");
var result1 = myQueue.Peek();
Console.WriteLine(result1);


Console.WriteLine("sto eleminando l'ultimo elemento dalla queue");
var result2 = myQueue.Dequeue();
Console.WriteLine(result2);

Console.WriteLine("sto stampando i restanti dati");

foreach (int item in myQueue)
{
    Console.WriteLine(item);
}