using Ludothek.Application.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ludothek.Application.Model
{
    class MainModel : BaseModel, IEnumerable<Rental>
    {
        List<Toy> dueRentals;
        
        #region Observer
        List<IView> views;
        #endregion

        public MainModel()
        {
            dueRentals = new List<Toy>();
            #region Observer
            views = new List<IView>();
            #endregion
        }

        public void AddDueRental(Toy toy)
        {
            dueRentals.Add(toy);
            UpdateAllViews();
        }

        public void RemoveDueRental(Toy toy)
        {
            dueRentals.Remove(toy);
            UpdateAllViews();
        }

        public void ChangeDueRental(Rental rental, Rental newRental)
        {
            int index = dueRentals.IndexOf(rental);
            dueRentals[index] = newRental;
            UpdateAllViews();
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            return dueRentals.GetEnumerator();
        }

        public IEnumerator<Rental> GetEnumerator()
        {
            return dueRentals.GetEnumerator();
        }

        #endregion

    }
}
