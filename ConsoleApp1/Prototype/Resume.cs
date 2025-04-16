using Newtonsoft.Json;

namespace ME.DesignPattern.Main.Prototype
{
    public class Resume : IPrototype<Resume>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<string> Skills { get; set; }

        public Resume Clone()
        {
            return JsonConvert.DeserializeObject<Resume>(JsonConvert.SerializeObject(this));
        }

        public void Show()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Skills: {string.Join(" | ", Skills)}");
        }
    }
}
