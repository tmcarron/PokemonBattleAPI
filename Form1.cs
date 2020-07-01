using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonBattle
{
    public partial class Bg_Form : Form
    {
        
        public Bg_Form()
        {
            InitializeComponent();
            P1Atk1.Text = "Test Button";

        }


        #region P1 Attack

        private void P1Atk1_Click(object sender, EventArgs e)
        {
            
            RestClient rClient = new RestClient();
            rClient.endPoint = "https://pokeapi.co/api/v2/pokemon/ditto";

            
            TestTxtBox.Text = rClient.makeRequest();

        }


        #endregion

        private void TestTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
