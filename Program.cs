using System.Diagnostics;
using System.Runtime.CompilerServices;
using Paralelismo.bin;

string[] ceps = new string[5]; // vai receber os ceps
ceps[0] = "13211-513";
ceps[1] = "15130-970";
ceps[2] = "09322-258";
ceps[3] = "17523-008";
ceps[4] = "11620-970";


var parrallelOptions = new ParallelOptions();
parrallelOptions.MaxDegreeOfParallelism = 8;//limitar em duas threads
var stopWatch = new Stopwatch();


stopWatch.Start();

Parallel.ForEach(ceps,parrallelOptions, cep =>  
{
    Console.WriteLine( new ViaCepService().GetCep(cep) + $" Thread: {Thread.CurrentThread.ManagedThreadId} ");

});


stopWatch.Stop();

Console.WriteLine($"O tempo de processamento total é de {stopWatch.ElapsedMilliseconds}ms");


//utilizar o webservices

