using PersonsFormUI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonsFormUI
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();

        public Dashboard()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            listBoxInfoFound.DataSource = people;
            listBoxInfoFound.DisplayMember = "FullInfo";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchByLastName_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetPeople(txtSearchLastName.Text);

            UpdateBinding();
        }

        private void listBoxInfoFound_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
