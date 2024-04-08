

using System.Globalization;

namespace ExternalDataProvider.Misc;

public static class DateTimeFormatExtensions
{
    public static string AsUnixFormat(this DateTime dateTime)
    {
        long unixTime = ((DateTimeOffset)dateTime).ToUnixTimeSeconds();
        return unixTime.ToString(CultureInfo.InvariantCulture);
    }

    public static string AsUsShortFormat(this DateTime dateTime)
    {
        var currentCulture = CultureInfo.CurrentCulture;

        var usCulture = new CultureInfo("en-US");

        CultureInfo.CurrentCulture = usCulture;

        var result = dateTime.ToString("d");

        CultureInfo.CurrentCulture = currentCulture;

        return result;
    }
}
