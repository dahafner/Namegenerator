using NameGenerator.Data;

namespace NameGenerator.Logic
{
    internal class Generator
    {
        private readonly List<Syllable> syllables;

        public Generator(List<Syllable> syllables)
        {
            this.syllables = syllables;
        }

        public string Get(int lenght)
        {
            var result = string.Empty;
            var random = new Random();            

            for(var i = 0; i < lenght; i++)
            {
                var next = this.syllables[random.Next(0, syllables.Count - 1)].Text;
                result += next;
            }

            result = result.ToLower();
            result = result.Substring(0, 1).ToUpper() + result.Substring(1);

            return result;
        }

        public List<string> Get(int lenght, int count)
        {
            var result = new List<string>();

            for(var i = 0; i < count; i++)
            {
                result.Add(this.Get(lenght));
            }

            return result;
        }
    }
}
