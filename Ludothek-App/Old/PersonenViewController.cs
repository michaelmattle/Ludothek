using System.Windows.Forms;

//Controller Part of MVC

namespace PersonenverwaltungMVC_2
{
    class PersonenViewController
    {
        PersonenModel model;
        PersonenView view;
        ListBox listBox; 

        public PersonenViewController(PersonenModel model, PersonenView view, ListBox listBox)
        {
            this.model = model;
            this.view = view;
            this.listBox = listBox;
            listBox.DisplayMember = nameof(Person.Name);
        }

        public void UpdateView()
        {
            view.ResetEditMasks();
            listBox.Items.Clear();
            foreach (Person person in model)
            {
                listBox.Items.Add(person);
            }
        }

        public void Sort(bool isSorted)
        {
            listBox.Sorted = isSorted;
            //no change in model, but update all views
            model.UpdateAllViews();
        }

        public void AddPerson(Person person)
        {
            model.AddPerson(person);
        }

        public void RemoveSelectedPerson()
        {
            Person person = listBox.SelectedItem as Person;
            if (person != null)
              model.RemovePerson(person);
        }

        public void ChangeSelectedPerson(Person newPerson)
        {
            Person person = listBox.SelectedItem as Person;
            if (person != null)
              model.ChangePerson(person, newPerson);
        }

        public void SelectionChanged()
        {
            Person person = listBox.SelectedItem as Person;
            if (person != null)
            {
                view.SetEditmask(person, listBox.SelectedIndex);
            }
            else
            {
                view.ResetEditMasks();
            }
        }

    }
}
