using System;
using System.Windows.Forms;

namespace PersonenverwaltungMVC_2
{
    public partial class PersonenListView : Form, IPersonenView
    {
        PersonenModel personenModel;
        PersonenListViewController personelListViewController;

        public PersonenListView(PersonenModel model)
        {
            InitializeComponent();
            personenModel = model;
            personelListViewController = new PersonenListViewController(personenModel, this, listAllCustomers);
        }


        #region Observer
        private void PersonenListView_Load(object sender, EventArgs e)
        {
            //register observer
            personenModel.AddView(this);
        }

        private void PersonenListView_FormClosing(object sender, FormClosingEventArgs e)
        {
            //deregister observer
            personenModel.RemoveView(this);
        }

        public void UpdateView()
        {
            personelListViewController.update();
        }
        #endregion
    }
}
