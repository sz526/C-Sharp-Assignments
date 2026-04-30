using Datastrukturer.Models;


var numberRepo = new DataContainer<int>();
numberRepo.Add(100);
Console.WriteLine($"int repository: {numberRepo.Get(0)}");


var nameRepo = new DataContainer<string>();
nameRepo.Add("Morten");
Console.WriteLine($"name repository: {nameRepo.Get(0)}");