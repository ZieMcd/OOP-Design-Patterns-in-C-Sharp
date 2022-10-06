// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using Proxy;

var stopwatch = new Stopwatch();

//Using plain data service
var dataService = new DataService();

dataService.InsertData("Item 1");
dataService.InsertData("Item 2");
dataService.InsertData("Item 3");

stopwatch.Start();

var data = await dataService.GetDate();
Console.WriteLine($"Number of Items: {data.Count}");
data = await dataService.GetDate();
Console.WriteLine($"number of itesm: {data.Count}");

stopwatch.Stop();

Console.WriteLine($"time took to read data: {stopwatch.Elapsed}");
stopwatch.Reset();


//Using proxy
var dataServiceProxy = new DataServiceProxy();

dataServiceProxy.InsertData("Item 1");
dataServiceProxy.InsertData("Item 2");
dataServiceProxy.InsertData("Item 3");

stopwatch.Start();

data = await dataServiceProxy.GetDate();
Console.WriteLine($"Number of Items: {data.Count}");
data = await dataServiceProxy.GetDate();
Console.WriteLine($"Number of Items: {data.Count}");

stopwatch.Stop();
Console.WriteLine($"time took to read data using proxy: {stopwatch.Elapsed}");
