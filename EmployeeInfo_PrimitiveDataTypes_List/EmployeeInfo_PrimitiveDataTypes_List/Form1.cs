using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInfo_PrimitiveDataTypes_List
{
    public partial class EmployeeInfoUI : Form
    {
        public EmployeeInfoUI()
        {
            InitializeComponent();
        }

        List<int> idList = new List<int>();
        List<string> nameList = new List<string>();
        List<string> emailList = new List<string>();
        List<string> phoneList = new List<string>();
        List<int> salaryList = new List<int>();
        List<string> addressList = new List<string>(); 

        private void EmployeeInformationUI_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string phone = phoneTextBox.Text;
            int salary = Convert.ToInt32(salaryTextBox.Text);
            string address = addressTextBox.Text;

            idList.Add(id);
            nameList.Add(name);
            emailList.Add(email);
            phoneList.Add(phone);
            salaryList.Add(salary);
            addressList.Add(address);

            idTextBox.Text = "";
            nameTextBox.Text = "";
            emailTextBox.Text = "";
            phoneTextBox.Text = "";
            salaryTextBox.Text = "";
            addressTextBox.Text = "";

            ListViewItem items = new ListViewItem(id.ToString());
            items.SubItems.Add(name);
            items.SubItems.Add(email);
            items.SubItems.Add(phone);
            items.SubItems.Add(salary.ToString());
            items.SubItems.Add(address);

            employeeListView.Items.Add(items);

        }

        private void employeeListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = employeeListView.SelectedIndices[0];

            idTextBox.Text = idList[selectedIndex].ToString();
            nameTextBox.Text = nameList[selectedIndex];
            emailTextBox.Text = emailList[selectedIndex];
            phoneTextBox.Text = phoneList[selectedIndex];
            salaryTextBox.Text = salaryList[selectedIndex].ToString();
            addressTextBox.Text = addressList[selectedIndex];



        }
    }
}
