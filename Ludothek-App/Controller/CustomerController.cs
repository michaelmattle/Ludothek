using System;
using Ludothek.Application.Model;
using Ludothek.Application.View;

namespace Ludothek.Application.Controller
{
    class CustomerController : BaseController
    {
        CustomerModel model;
        CustomerListView view;


        public CustomerController(Repository repo) : base()
        {
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
