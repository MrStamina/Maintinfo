using System;

namespace EntityDal.Exceptions
{
    public class DalException :Exception
    {
        public DalException() : base()
        {
            
        }

        public DalException(string message) : base(message)
        {
            
        }

        public DalException(string message, System.Exception inner) : base(message, inner)
        {
            
        }
    }
}
