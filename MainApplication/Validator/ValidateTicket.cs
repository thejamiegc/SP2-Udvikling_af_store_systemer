namespace MainApplication.Validator
{
    public class ValidateTicket
    {
        public bool IsValidTicket(string code)
        {
            return !string.IsNullOrEmpty(code) && code.Length == 10; // Example validation
        }
    }
}