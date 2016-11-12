using Ludothek.Application.Model;
using System.Windows.Forms;

namespace Ludothek.Application.Controller
{
    class ToyController : BaseController
    {
        Model.ToyModel model;
        View.ToysListView view;
        ListView listView;

        public ToyController(Model.ToyModel model, View.ToysListView view, ListView listView) : base()
        {
            this.model = model;
            this.view = view;
            this.listView = listView;
        }

        public void update()
        {
            listView.Items.Clear();
            foreach ( Toy toy in model )
            {
                ListViewItem item = new ListViewItem(toy.Name);
                item.SubItems.Add(toy.Brand);
                item.SubItems.Add(toy.Category);
                item.SubItems.Add(toy.PricePerWeek.ToString());
                listView.Items.Add(item);
            }
        }
    }
}
