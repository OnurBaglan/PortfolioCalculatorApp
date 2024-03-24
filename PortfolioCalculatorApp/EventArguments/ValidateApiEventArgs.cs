namespace PortfolioCalculatorApp.EventArguments;

public class ValidateApiEventArgs : EventArgs
{
	public ApiSources ApiSource { get; set; }

    public ValidateApiEventArgs(int apiSourceId)
    {
        ApiSource= (ApiSources)apiSourceId;

    }
}