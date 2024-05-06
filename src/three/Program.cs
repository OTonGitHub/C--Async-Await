Console.WriteLine("Console App (One)\n-----------------\n");

Console.WriteLine("1: " + Thread.CurrentThread.ManagedThreadId);
var client = new HttpClient();

Console.WriteLine("2: " + Thread.CurrentThread.ManagedThreadId);
var task = client.GetStringAsync("https://google.com");

Console.WriteLine("3: " + Thread.CurrentThread.ManagedThreadId);
var num = 0;
for (int i = 0; i < 1_000_000; i++) // 1_000_000_000 > google.com
{
    num += i;
}

Console.WriteLine("4: " + Thread.CurrentThread.ManagedThreadId);
var page = await task; // If Task Is Not Completed, Current Thread Is Returned To Thread Pool & Function Sleeps.

// If Function Fell Asleep, Likely Another Thread Resumes It From Here
Console.WriteLine("5: " + Thread.CurrentThread.ManagedThreadId);







