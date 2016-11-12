using Ludothek.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludothek.Application.Controller
{
    class CustomerController : BaseController
    {
        public CustomerController(Repository repo) : base()
        {
            Model = new Customer();
        }
    }
}
