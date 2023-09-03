namespace TacosChatCore.Models;

public class Emoji
{
    public Dictionary<string, string> Source { get; set; } = new Dictionary<string, string>();

    public Emoji()
    {
        Source.Add(":D", "😀");
        Source.Add(":)", "🙂");
        Source.Add(":(", "🙁");
        Source.Add(":P", "😛");
        Source.Add(":O", "😮");
        Source.Add(":|", "😐");
        Source.Add(":*", "😘");
        Source.Add(":$", "🤑");
        Source.Add(":S", "😖");
        Source.Add(":X", "🤐");
        Source.Add(":Z", "🤤");
        Source.Add(":B", "😎");
        Source.Add(":C", "😕");
        Source.Add(":T", "😤");
        Source.Add(":L", "😵");
        Source.Add(":G", "😬");
        Source.Add(":K", "😳");
    }
}