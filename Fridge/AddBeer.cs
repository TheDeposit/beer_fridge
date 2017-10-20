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
    public partial class AddBeer : Form
    {
        private Fridge _fridge;

        public AddBeer(Fridge fridge)
        {
            _fridge = fridge;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = tb_BeerName.Text;
            var style = cb_Style.Text;
            var newBeer = new Beer(name, "BG", 8.0, BeerStyle.IPA, 1);

            _fridge.AddBeer(newBeer);

            this.Close();
        }
    }
}
