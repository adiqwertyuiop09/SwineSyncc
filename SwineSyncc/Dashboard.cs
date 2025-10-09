using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwineSyncc
{
    public partial class Dashboard : Form
    {
        private NavigationPanel navigationPanel;
        public Dashboard()
        {
            InitializeComponent();
            navigationPanel = new NavigationPanel();
            navigationPanel.Dock = DockStyle.Fill;
            navPanel.Controls.Add(navigationPanel); 

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
