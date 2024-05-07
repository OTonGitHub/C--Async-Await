using Microsoft.AspNetCore.Mvc;

namespace Second.Controllers;

public class AvoidStateMachine : Controller
{
    private const string cnn = "https://CNN.com";

    /*
     * Primary lesson: avoid spawning State Machine when not needed.
     * But, use await, and spawn machine if need to do something with data,
     * before returning it. 
    */

    // If other function is needed, will need to await on it.
    public async Task<ActionResult> Index()
    {
        var item = InputOutputNetwork();
        return Content(item + await InputOutputNetworkAss());
    }

    public async Task<string> InputOutputNetworkAss()
    {
        var client = new HttpClient();
        // better to just not await, and remove async, and return Task.
        var content = await client.GetStringAsync(cnn);
        // do something with content.
        // which then won't return a task, because its awaited.
        // since function is async, it expects await
        // which means it expects return string, not Task<string>.
        return content; // if async, return must be string, not Task.
    }
    // kinda works fine?
    public Task<string> InputOutputNetwork()
    {
        var client = new HttpClient();
        var content = client.GetStringAsync(cnn);
        return content;
    }

    // Have To Implement A Task, Task Is Completed
    public Task<string> InputOutput()
    {
        // works synchronously. async is not used.
        var message = "Hello Worldy";
        return Task.FromResult(message);
    }

    // Have To Implement A Task, Task Is Completed
    public Task InputOutputCompleted()
    {
        return Task.CompletedTask;
    }
}
