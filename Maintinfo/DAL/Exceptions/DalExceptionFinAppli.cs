using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Exceptions
{
    public class DalExceptionFinAppli : DalException
    {
        public DalExceptionFinAppli() : base()
        {
        }

        public DalExceptionFinAppli(string message)
            : base(message)
        {
        }
        public DalExceptionFinAppli(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }
}
