using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPDfilling
{
    public partial class HelpForm : Form
    {
        private int currentIndex = 0;
        private List<Panel> panels = new List<Panel>();
        public HelpForm()
        {
            InitializeComponent();
            panels.Add(helppanel1);
            panels.Add(helppanel2);
            panels.Add(helppanel3);
            panels.Add(helppanel4);
            UpdatePanel();
        }

        private void UpdatePanel()
        {
            foreach (Panel panel in panels)
            {
                panel.Visible = false;
            }
            panels[currentIndex].Visible = true;
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex == panels.Count)
            {
                currentIndex = 0;
            }
            UpdatePanel();
        }

        private void prevbtn_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = panels.Count - 1;
            }
            UpdatePanel();
        }
    }
}