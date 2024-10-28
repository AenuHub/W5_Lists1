public class Program
{
    public static void Main(string[] args)
    {
        List<string> invitees = new List<string>();
        invitees.Add("Illidan Stormrage");
        invitees.Add("Slyvanas Windrunner");
        invitees.Add("Garrosh Hellscream");
        invitees.Add("Kael'thas Sunstrider");
        invitees.Add("Malfurion Stormrage");
        invitees.Add("Tyrande Whisperwind");

        Console.WriteLine("** Invitees **");
        for (int i = 0; i < invitees.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {invitees[i]}");
        }
        
        Console.ReadKey();
    }
}