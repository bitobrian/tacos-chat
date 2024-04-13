namespace TacosChatSsr.Models;

public class ErrorContext
{
    public string ErrorMessage { get; set; } = string.Empty;
    public string ErrorStackTrace { get; set; } = string.Empty;
    public string ErrorType { get; set; } = string.Empty;
    public string ErrorSource { get; set; } = string.Empty;

    public void SetThrowError(Exception ex)
    {
        ErrorMessage = ex.Message;
        ErrorStackTrace = ex.StackTrace;
        ErrorType = ex.GetType().ToString();
        ErrorSource = ex.Source;

        throw ex;
    }
}
