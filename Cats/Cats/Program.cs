using Cats;
using System.Collections.Immutable;

int a = 10;

int[] ints = new int[a];
int[] ints2 = { 1, 2, 3, 4, 5, 6, 7 , 8, 9, 10 };



var cat1 = new Cat() { name = "yorgis" };
var cat2 = new Cat() { name = "siifis" };

Cat[] cats = { cat1, cat2 };


var hehe = cats.Any(cat => cat.name == "yorgis");

Console.WriteLine(hehe);

var list = new List<Cat>();

Dictionary<string, Cat> catdict = new();
catdict.Add(cat1.name, cat1);
catdict.Add(cat2.name, cat2);
catdict.Remove("siifis");

Cat catFromDictionary = catdict["yorgis"];

var catlinq = catdict.Where(c => c.Value.name == "Spot").First().Value;

foreach (string catkey in catdict.Keys)
{
    Console.WriteLine(catkey);
}

var queue = new Queue<Cat>();
queue.Enqueue(catlinq);
queue.Dequeue();

ImmutableList<string> names = ["Alice", "Bob", "Charlie"];
ImmutableList<string> updatedNames = names.Add("Diana");

