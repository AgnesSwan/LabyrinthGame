using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labiryntGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void finish(object sender, EventArgs e)
        {
            MessageBox.Show("Winner");
            this.Close();
        }
        private void start()
        {
            Point startingpoint = labelstart.Location;
            startingpoint.Offset(30,10);
            Cursor.Position = PointToScreen(startingpoint);
        }
        private void time()
        {

        }
        private void game_over(object sender, EventArgs e)
        {
            MessageBox.Show("You hit the wall. Starting again...");
            start();
        }
    }
}
