using Ludothek.Application.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludothek.Application.Model
{
    class MainModel : BaseModel
    {
        List<string> returns;

        #region Observer
        List<IView> views;
        #endregion

        public MainModel()
        {
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
       
    }
}
