using ChuckNorrisAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuckNorrisJokesForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void generateJokeBtn_Click(object sender, EventArgs e)
        {
            Joke joke = await ChuckNorrisClient.GetRandomJoke();
            string jokeText = joke.JokeText;
            MessageBox.Show(jokeText);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var categories = await ChuckNorrisClient.GetCategories();

            foreach (var category in categories)
            {
                categoryCbox.Items.Add(category);
            }

        }
    }
}
