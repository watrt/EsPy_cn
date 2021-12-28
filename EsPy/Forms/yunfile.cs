using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace EsPy.Forms
{
    public partial class yunfile :DockContent, IForm
    {
        public yunfile()
        {
            InitializeComponent();
            this.HideOnClose = true;
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public ToolStrip ToolStrip
        {
            get
            {
                //return this.toolStrip1;
                return null;
            }
        }

        public ToolStrip MenuStrip
        { get { return this.menuStrip1; } }
    }
}
