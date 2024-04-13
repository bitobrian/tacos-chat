using TacosChatSsr.Models;

namespace TacosChatSsr.Services;

public class FakeChatService
{
    private async Task<List<string>> GetFakeChatMessagesAsync()
    {
        var fakeChatMessages = new List<string>
        {
            "first!",
            "👋",
            "🌮",
            "🎉",
            "may i be in charge of the party planning committee?",
            "let's get this party started!",
            "bears, beets, battlestar galactica",
            "i'm a little teapot, short and stout",
            "i'm a lumberjack and i'm okay",
            "i'm a barbie"
        };

        return await Task.FromResult(fakeChatMessages);
    }


    private async Task<List<FakePerson>> GetFakePeopleAsync()
    {
        var fakePeople = new List<FakePerson>
        {
            new("John", "Doe"),
            new("Jane", "Doe"),
            new("Alice", "Smith"),
            new("Bob", "Smith"),
            new("Charlie", "Brown"),
            new("Daisy", "Duck"),
            new("Eve", "White"),
            new("Frank", "Black"),
            new("Grace", "Green"),
            new("Henry", "Blue"),
            new("Ivy", "Red"),
            new("Jack", "Yellow"),
            new("Kate", "Purple"),
            new("Larry", "Orange"),
            new("Molly", "Pink"),
            new("Nancy", "Gray"),
            new("Oscar", "Brown"),
            new("Penny", "Black"),
            new("Quincy", "Green"),
            new("Randy", "Blue"),
            new("Sally", "Red"),
            new("Tom", "Yellow"),
            new("Ursula", "Purple"),
            new("Victor", "Orange"),
            new("Wendy", "Pink"),
            new("Xavier", "Gray"),
            new("Yvonne", "Brown"),
            new("Zack", "Black")
        };

        return await Task.FromResult(fakePeople);
    }

    // get a fake chat message with a random person
    public async Task<AppChatMessage> GetFakeChatMessageAsync()
    {
        var fakePeople = await GetFakePeopleAsync();
        var random = new Random();
        var randomPerson = fakePeople[random.Next(fakePeople.Count)];
        var fakeChatMessages = await GetFakeChatMessagesAsync();
        var randomMessage = fakeChatMessages[random.Next(fakeChatMessages.Count)];
        var appChatMessage = new AppChatMessage(DateTime.Now, randomPerson.FirstName, randomMessage);

        return await Task.FromResult(appChatMessage);
    }
}

public record FakePerson(string FirstName, string LastName);
