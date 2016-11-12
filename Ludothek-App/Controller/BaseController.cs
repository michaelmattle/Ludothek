using Ludothek.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludothek.Application.Controller
{
    public abstract class BaseController
    {
        protected Repository Repository;
        public BaseModel Model;
    }
}
