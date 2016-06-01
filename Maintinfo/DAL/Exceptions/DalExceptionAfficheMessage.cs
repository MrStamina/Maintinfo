﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Exceptions
{
    public class DalExceptionAfficheMessage : DalException
    {
        public DalExceptionAfficheMessage() : base()
        {
        }

        public DalExceptionAfficheMessage(string message)
            : base(message)
        {
        }
        public DalExceptionAfficheMessage(string message, System.Exception inner)
            : base(message, inner)
        {
        }

    }
}
