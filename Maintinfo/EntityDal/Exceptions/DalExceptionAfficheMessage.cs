namespace EntityDal.Exceptions
{
    public class DalExceptionAfficheMessage : DalException
    {
        public DalExceptionAfficheMessage() : base()
        {
            
        }

        public DalExceptionAfficheMessage(string message) : base(message)
        {
            
        }

        public DalExceptionAfficheMessage(string message, System.Exception inner) : base(message, inner)
        {
            
        }
    }
}
