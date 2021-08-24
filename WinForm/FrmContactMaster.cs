using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class FrmContactMaster : Form
    {
        #region private attributes
        private Contact contact = null;
        #endregion private attributes

        public FrmContactMaster()
        {
            InitializeComponent();
        }

        private void FrmContact_Load(object sender, EventArgs e)
        {
            this.CreateContact();
            this.UpdateGui();
        }

        private void CreateContact()
        {
            contact = new Contact("Ricard", "Mathieu");
        }

        private void UpdateGui()
        {
            this.textBoxName.Text = contact.Name;
        }
    }
}
