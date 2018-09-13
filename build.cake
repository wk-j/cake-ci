Task("Hello").Does(() => {
    Console.WriteLine("Hello, world!");
});


RunTarget("Hello");