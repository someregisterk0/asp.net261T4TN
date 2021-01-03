using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class FormMenuItem : Form
    {
        public FormMenuItem()
        {
            InitializeComponent();
        }

        private void FormMenuItem_Load(object sender, EventArgs e)
        {
            MenuItemRepository repository = new MenuItemRepository();
            List<MenuItem> list = repository.GetMenuItems();
            foreach (MenuItem item in list)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(item.Name);
                menuStrip.Items.Add(menuItem);
            }
        }
    }
}
