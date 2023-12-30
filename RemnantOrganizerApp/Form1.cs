using RemnantOrganizerApp.Model;
using Newtonsoft.Json;
using System.Diagnostics;

namespace RemnantOrganizerApp
{
    public partial class Form1 : Form
    {
        List<Ring> itemList = new List<Ring>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var directory = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Data");

            var file = directory + @"\Rings.json";

            string jsonContent = System.IO.File.ReadAllText(file);

            // Deserialize JSON to a list of Item objects
            itemList = JsonConvert.DeserializeObject<List<Ring>>(jsonContent);

            // Display the items
            foreach (var item in itemList)
            {
                Debug.WriteLine($"Id: {item.Id}, Name: {item.Name}, Description: {item.Description}");
            }
        }
    }
}
