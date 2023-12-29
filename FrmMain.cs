using NameGenerator.Data;
using NameGenerator.Logic;
using Newtonsoft.Json;

namespace NameGenerator
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            var list = new List<Syllable>();
            list.Add(new Syllable { Text = "La" });
            list.Add(new Syllable { Text = "Li" });
            list.Add(new Syllable { Text = "Lu" });
            list.Add(new Syllable { Text = "Le" });
            list.Add(new Syllable { Text = "Lo" });
            list.Add(new Syllable { Text = "Sa" });
            list.Add(new Syllable { Text = "Si" });
            list.Add(new Syllable { Text = "Su" });
            list.Add(new Syllable { Text = "Se" });
            list.Add(new Syllable { Text = "So" });
            list.Add(new Syllable { Text = "Sil" });
            list.Add(new Syllable { Text = "Ta" });
            list.Add(new Syllable { Text = "Ti" });
            list.Add(new Syllable { Text = "Tu" });
            list.Add(new Syllable { Text = "Te" });
            list.Add(new Syllable { Text = "To" });
            list.Add(new Syllable { Text = "Tol" });
            list.Add(new Syllable { Text = "Na" });
            list.Add(new Syllable { Text = "Ni" });
            list.Add(new Syllable { Text = "Nu" });
            list.Add(new Syllable { Text = "Ne" });
            list.Add(new Syllable { Text = "No" });
            list.Add(new Syllable { Text = "Va" });
            list.Add(new Syllable { Text = "Var" });
            list.Add(new Syllable { Text = "Ven" });
            list.Add(new Syllable { Text = "Val" });
            list.Add(new Syllable { Text = "Re" });
            list.Add(new Syllable { Text = "Rel" });
            list.Add(new Syllable { Text = "Ren" });
            list.Add(new Syllable { Text = "Ri" });
            list.Add(new Syllable { Text = "Ris" });
            list.Add(new Syllable { Text = "Ai" });
            list.Add(new Syllable { Text = "Ae" });
            list.Add(new Syllable { Text = "Aen" });
            list.Add(new Syllable { Text = "Ael" });
            list.Add(new Syllable { Text = "Ua" });
            list.Add(new Syllable { Text = "Ue" });
            list.Add(new Syllable { Text = "Ual" });
            list.Add(new Syllable { Text = "Da" });
            list.Add(new Syllable { Text = "Do" });
            list.Add(new Syllable { Text = "Di" });
            list.Add(new Syllable { Text = "Ea" });
            list.Add(new Syllable { Text = "e'a" });
            list.Add(new Syllable { Text = "En" });
            list.Add(new Syllable { Text = "El" });
            list.Add(new Syllable { Text = "Elt" });
            list.Add(new Syllable { Text = "Un" });
            list.Add(new Syllable { Text = "Us" });
            list.Add(new Syllable { Text = "Ul" });
            list.Add(new Syllable { Text = "u'a" });
            list.Add(new Syllable { Text = "Ia" });
            list.Add(new Syllable { Text = "i'a" });
            list.Add(new Syllable { Text = "il" });
            list.Add(new Syllable { Text = "is" });
            list.Add(new Syllable { Text = "in" });
            list.Add(new Syllable { Text = "io" });

        }

        private List<List<Syllable>> syllableLists = new List<List<Syllable>>();

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var files = Directory.GetFiles(Path.Combine(Application.StartupPath, "Lists"), "*.json");
            foreach (var file in files)
            {
                var json = File.ReadAllText(file);
                syllableLists.Add(JsonConvert.DeserializeObject<List<Syllable>>(json));
            }
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            var generator = new Generator(this.syllableLists[0]);

            var result = generator.Get((int)this.NudSyllableCount.Value, (int)this.NudSuggestionCount.Value);

            this.TxtOutput.Text = null;
            foreach (var name in result)
            {
                this.TxtOutput.Text += name + "\r\n";
            }
        }
    }
}
