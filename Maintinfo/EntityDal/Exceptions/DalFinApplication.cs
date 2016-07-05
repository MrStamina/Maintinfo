namespace EntityDal.Exceptions
{
    public class DalFinApplication : DalException
    {
        public DalFinApplication() : base()
        {
            
        }

        public DalFinApplication(string message) : base(message)
        {
            
        }

        public DalFinApplication(string message, System.Exception inner) : base(message,inner)
        {
            
        }
    }
}
