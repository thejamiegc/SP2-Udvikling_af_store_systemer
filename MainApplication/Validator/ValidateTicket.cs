namespace MainApplication.Validator
{
    public class ValidateTicket
    {
        public bool IsValidTicket(string code)
        {
            if (code.Contains("warehouse 1") && code.Contains("chemical b"))
            {
                return false;
            }
            else if (code.Contains("warehouse 1") && code.Contains("chemical a"))
            {
                return true;
            }
            else if (code.Contains("warehouse 2") && code.Contains("chemical a"))
            {
                return false;
            }
            else if (code.Contains("warehouse 2") && code.Contains("chemical b"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}