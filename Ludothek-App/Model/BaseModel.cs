using Ludothek.Application.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludothek.Application.Model
{
    public interface BaseModel
    {
        #region Observer
        void AddView(IView view);
        void RemoveView(IView view);
        void UpdateAllViews();
        #endregion
    }
}
