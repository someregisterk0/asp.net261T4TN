using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp
{
    class MenuItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string FormName { get; set; }
        public string ParentId { get; set; }
        public List<MenuItem> Children { get; set; }
    }
}
