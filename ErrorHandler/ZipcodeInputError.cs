namespace ErrorHandler
{
    public class ZipcodeInputError : UserError
    {
        public override string UEMessage()
        {
            return "You entered a zipcode with wrong format. This fired an error!";
        }
    }
}
