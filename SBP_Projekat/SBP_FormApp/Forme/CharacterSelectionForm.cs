using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBP_Data.DTOs;

namespace SBP_Projekat.Forme
{
    public partial class CharacterSelection : Form
    {
        IgracDTO _igrac;
        public CharacterSelection(IgracDTO igrac , Form parent)
        {
            this.MdiParent = parent;
            _igrac = igrac;
            InitializeComponent();
        }

        private void updateTalb() { }
    }
}
