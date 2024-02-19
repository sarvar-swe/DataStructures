using System.Collections;

ArrayList arrayList = [5];
//Add adds a new item at the end of the list
arrayList.Add(6);
//AddRange adds a collection of elements at the end of the array list
arrayList.AddRange(new int[] {-7, 8});
arrayList.AddRange(new object[] {"Marcin", "Kate"});
//Insert places an element in a specified location within the collection
arrayList.Insert(5, 7.8);

// Count returns the number of elements stored currently in the array list
int count = arrayList.Count;
Console.WriteLine(count);
//Capacity indicates how many elements can be stored within it
int capacity = arrayList.Capacity;
Console.WriteLine(capacity);
Console.WriteLine("-----------------\n");

foreach(var item in arrayList)
{
    Console.Write($"{item} ");
}

Console.WriteLine("\n");

arrayList.Reverse();

foreach(var item in arrayList)
{
    Console.Write($"{item} ");
}

Console.WriteLine("\n");

bool containsMarcin = arrayList.Contains("Marcin");
Console.WriteLine(containsMarcin);

bool containsAnn = arrayList.IndexOf("Ann") >= 0;
Console.WriteLine(containsAnn);

arrayList.Remove(5);
arrayList.RemoveAt(1);
arrayList.RemoveRange(1, 2);
arrayList.Clear();

foreach(var item in arrayList)
{
    Console.Write($"{item} ");
}