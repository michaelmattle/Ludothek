using Ludothek.Application.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludothek.Application.Model
{
    public class CustomerModel : BaseModel, IEnumerable<Customer>
    {
        List<Customer> customers;
        #region Observer
        List<IView> views;
        #endregion

        public CustomerModel()
        {
            customers = new List<Customer>();

            #region Observer
            views = new List<IView>();
            #endregion
        }

        #region Observer
        public void AddView(IView view)
        {
            views.Add(view);
            view.UpdateView();
        }

        public void RemoveView(IView view)
        {
            views.Remove(view);
        }

        public void UpdateAllViews()
        {
            foreach (IView view in views)
            {
                view.UpdateView();
            }
        }
        #endregion

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
            UpdateAllViews();
        }

        public void RemoveCustomer(Customer customer)
        {
            customers.Remove(customer);
            UpdateAllViews();
        }

        public void ChangeCustomer(Customer customer, Customer newCustomer)
        {
            int index = customers.IndexOf(customer);
            customers[index] = newCustomer;
            UpdateAllViews();
        }

        #region Implement Interface IEnumerator<Person>
        //damit direkt über PersonenModel iteriert werden kann
        //z.B. mit foreach()
        public IEnumerator<Customer> GetEnumerator()
        {
            return customers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return customers.GetEnumerator();
        }
        #endregion
    }
}
