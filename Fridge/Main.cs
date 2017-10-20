using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fridge
{
    public partial class Fridge : Form
    {
        private List<Beer> _beerList;

        public Fridge()
        {
            InitializeComponent();
            _beerList = new List<Beer>();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBeer addBeer = new AddBeer(this);
            addBeer.Show();
        }

        public void AddBeer(Beer beer)
        {
            _beerList.Add(beer);

            listView1.Items.Add(new ListViewItem(new string[] { beer.Name, beer.Brewery, beer.ABV.ToString(), beer.Style.ToString(), beer.Quantity.ToString() }));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var beerName = listView1.SelectedItems[0].Text;
            MessageBox.Show("Drink " + beerName + "?");

        }
    }
}
