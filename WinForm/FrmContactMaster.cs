using CrmBusiness;
using System;
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

        }

        private void UpdateGui()
        {
            
        }
    }
}
