using System.Collections.Generic;
using Spectre.Console;

namespace GreetingApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 1. Start med en fin tittel
            AnsiConsole.Clear();
            AnsiConsole.Write(new Rule("[yellow]Greeting System v1.0[/]").RuleStyle("grey"));

            // 2. Brukerinput (bruker metoden vi lærte fra læreren)
            string name = AnsiConsole.Ask<string>("Hva er ditt [green]navn[/]?");

            // 3. Generer hilsen
            string customizedGreeting = GreetingLogic.GetTimeBasedGreeting(DateTime.Now.Hour);

            // 4. Vis resultatet i en fin Panel
            var panel = new Panel($"[bold white]{customizedGreeting}, {name}![/]\n[grey]Klokken er nå {DateTime.Now:HH:mm}[/]");
            panel.Border = BoxBorder.Rounded;
            panel.Padding = new Padding(1, 1, 1, 1);

            AnsiConsole.Write(panel);
            
            AnsiConsole.MarkupLine("\n[italic grey]Trykk en tast for å avslutte...[/]");
            Console.ReadKey(true);
        }
    }

    public static class GreetingLogic
    {
        public static string GetTimeBasedGreeting(int hour)
        {
            // En Lookup Table (Dictionary) som knytter timer til kategorier
            // Her bruker vi en enkel if-logikk for å finne nøkkelen til vår Dictionary
            string timeOfDay = hour switch
            {
                >= 5 and < 10 => "Morgen",
                >= 10 and < 18 => "Dag",
                >= 18 and < 23 => "Kveld",
                _ => "Natt"
            };

            var greetings = new Dictionary<string, string>
            {
                { "Morgen", "God morgen" },
                { "Dag", "God dag" },
                { "Kveld", "God kveld" },
                { "Natt", "God natt, natteravn" }
            };

            return greetings[timeOfDay];
        }
    }
}
