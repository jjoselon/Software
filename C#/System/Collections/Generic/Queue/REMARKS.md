> Los Queue y Stacks son utiles cuando necesitamos almacenamiento temporal de información; 
esto es, cuando queremos descartar un elemento después de recibir su valor

> Usamos los [`Queue<T>`](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1?view=netframework-4.7.2) si necesitamos acceder a información en el mismo orden en el que fue almacenada
en la collección

> Usamos [`Stack<T>`](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1?view=netframework-4.7.2) si necesitamos acceder a la información de la colleción en orden inverso

> Usamos [`ConcurrentQueue<T>`](https://docs.microsoft.com/en-us/dotnet/api/system.collections.concurrent.concurrentqueue-1?view=netframework-4.7.2) y [`ConcurrentStack<T>`](https://docs.microsoft.com/en-us/dotnet/api/system.collections.concurrent.concurrentstack-1?view=netframework-4.7.2)
si necesitamos acceder a la información de la colleción desde multiples threads concurrentamente.
