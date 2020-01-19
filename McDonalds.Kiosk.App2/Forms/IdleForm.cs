using McDonalds.Kiosk.Core.Contracts;
using System.Windows.Forms;

namespace McDonalds.Kiosk.App2.Forms
{
    public partial class IdleForm : Form
    {
        private readonly ISessionManager _sessionManager;

        public IdleForm(ISessionManager sessionManager)
        {
            _sessionManager = sessionManager;

            InitializeComponent();
        }

        private void OpenSessionButon_Click(object sender, System.EventArgs e) 
            => _sessionManager.Open();
    }
}
