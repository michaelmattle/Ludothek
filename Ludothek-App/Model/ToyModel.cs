using System;
using System.Collections;
using System.Collections.Generic;

namespace Ludothek.Application.Model
{
    public class ToyModel : IEnumerable<Toy>
    {
        List<Toy> toys;
        #region Observer
        List<IView> views;
        #endregion

        public ToyModel()
        {
            toys = new List<Toy>();

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

        public void AddToy(Toy toy)
        {
            toys.Add(toy);
            UpdateAllViews();
        }

        public void RemoveToy(Toy toy)
        {
            toys.Remove(toy);
            UpdateAllViews();
        }

        public void ChangePerson(Toy toy, Toy newToy)
        {
            int index = toys.IndexOf(toy);
            toys[index] = newToy;
            UpdateAllViews();
        }

        #region Implement Interface IEnumerator<Person>
        //damit direkt über PersonenModel iteriert werden kann
        //z.B. mit foreach()
        public IEnumerator<Toy> GetEnumerator()
        {
            return toys.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return toys.GetEnumerator();
        }
        #endregion
    }
}
