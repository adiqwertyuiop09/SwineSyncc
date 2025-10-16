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
            navPanel.Controls.Add(navigationPanel);

            navigationPanel.pigManagementBtn.Click += (s, e) => LoadPigManagement();
            
        }
      
        private void ShowUserControl(UserControl uc)
        {        
            mainPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(uc);
        }

        private void LoadPigManagement()
        {
            PigManagement pigUC = new PigManagement();
            pigUC.RegisterPigClicked += (s, e) => ShowUserControl(new RegisterPig());
            ShowUserControl(pigUC);
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        
    }
}
