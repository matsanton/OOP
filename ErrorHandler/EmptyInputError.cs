namespace ErrorHandler
{
    public class EmptyInputError : UserError
    {
        public override string UEMessage()
        {
            return "You did not enter anything in a required field. This fired an error!";
        }
    }
}
