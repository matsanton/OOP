namespace ErrorHandler
{
    public class DateInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to enter a date in the wrong format. This fired an error!";
        }
    }
}
