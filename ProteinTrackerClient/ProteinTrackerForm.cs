using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProteinTrackerClient.ProteinTrackerService;

namespace ProteinTrackerClient
{
    public partial class ProteinTrackerForm : Form
    {
        private ProteinTrackingServiceSoapClient service = new ProteinTrackingServiceSoapClient();
        private User[] users;

        public ProteinTrackerForm()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            users = service.ListUsers();
            cboSelectUser.DataSource = users;
            cboSelectUser.DisplayMember = "Name";
            cboSelectUser.ValueMember = "UserId";
        }

        private void OnAddNewUser(object sender, EventArgs e)
        {
            service.AddUser(txtName.Text, int.Parse(txtGoal.Text));
            users = service.ListUsers();
            cboSelectUser.DataSource = users;
        }

        private void OnUserChanged(object sender, EventArgs e)
        {
            var index = cboSelectUser.SelectedIndex;
            lblTotal.Text = users[index].Total.ToString();
            lblGoal.Text = users[index].Goal.ToString();
        }

       // async private void OnAddProtein(object sender, EventArgs e)
       private void OnAddProtein(object sender, EventArgs e)
        {
            var userId = users[cboSelectUser.SelectedIndex].UserId;
            var newTotal = service.AddProtein(int.Parse(txtAmount.Text), userId);
            lblTotal.Text = newTotal.ToString();
            /*
                        try
                        {
                            var auth = new AuthenticationHeader { UserName = "Bob", Password = "Pass" };
                            var newTotal = await service.AddProteinAsync(auth, int.Parse(txtAmount.Text), userId);

                            users[cboSelectUser.SelectedIndex].Total = newTotal.AddProteinResult;
                            lblTotal.Text = newTotal.AddProteinResult.ToString();
                        }
                        catch (FaultException exception)
                        {
                            Console.WriteLine(exception.Message);
                        }
            */
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
