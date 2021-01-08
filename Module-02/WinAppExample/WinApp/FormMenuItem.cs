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
                ToolStripMenuItem toolStrip = new ToolStripMenuItem(item.Name);
                menuStrip.Items.Add(toolStrip);
                if (item.FormName != null)
                {
                    toolStrip.Name = item.FormName;
                    toolStrip.Click += ToolStrip2_Click;
                }
                if (item.Children != null)
                {
                    foreach (MenuItem item2 in item.Children)
                    {
                        ToolStripMenuItem toolStrip2 = new ToolStripMenuItem(item2.Name);
                        toolStrip2.Name = item2.FormName;
                        toolStrip2.Click += ToolStrip2_Click;
                        toolStrip.DropDownItems.Add(toolStrip2);
                    }
                }
            }
        }

        private void ToolStrip2_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStrip = (ToolStripMenuItem)sender;

            //MessageBox.Show(toolStrip.Name);

            Form form =  (Form)Activator.CreateInstance(Type.GetType($"WinApp.{toolStrip.Name}"));
            form.MdiParent = this;
            form.Show();
        }
    }
}
