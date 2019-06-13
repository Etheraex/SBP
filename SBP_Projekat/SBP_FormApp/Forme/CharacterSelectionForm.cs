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
using SBP_Data;
using SBP_Data.Models;
namespace SBP_Projekat.Forme
{
    public partial class CharacterSelectionForm : Form
    {
        IgracDTO _igrac;
        List<LikDTO> _likovi;
        public CharacterSelectionForm(IgracDTO igrac , Form parent)
        {
            this.MdiParent = parent;
            _igrac = igrac;
            _likovi = DTOManager.Instance.VratiListuLikova(igrac.ID);
            InitializeComponent();
        }

        private void updateTalb() { }
    }
}
