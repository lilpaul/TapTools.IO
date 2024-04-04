namespace TapTools.IO.Sdk.Models;

public static class Constants
{
    public static class Interval
    {
        public const string ThreeMinutes = "3m";
        public const string FiveMinutes = "5m";
        public const string FifteenMinutes = "15m";
        public const string HalfHour = "30m";
        public const string OneHour = "1h";
        public const string TwoHours = "2h";
        public const string HalfDay = "12h";
        public const string OneDay = "1d";
        public const string ThreeDays = "3d";
        public const string OneWeek = "1w";
        public const string OneMonth = "1M";
    }

    public static class Indicator
    {
        public const string MovingAverage = "ma";
        public const string ExponentialMovingAverage = "ema";
        public const string RelativeStrengthIndex = "rsi";
        public const string MovingAverageConvergenceDivergence = "macd";
        public const string BollingerBands = "bb";
        public const string BollingerBandWidth = "bbw";
    }

    public static class PoolAdaOptions
    {
        public const int AdaOnly = 1;
        public const int All = 0;
    }

    public static class CirculatingType
    {
        public const string Mcap = "mcap";
        public const string Fdv = "fdv";
    }

    public static class Timeframe
    {
        public const string OneHour = "1h";
        public const string FourHours = "4h";
        public const string HalfDay = "12h";
        public const string OneDay = "24h";
        public const string OneWeek = "7d";
        public const string OneMonth = "30d";
        public const string HalfYear = "180d";
        public const string OneYear = "1y";
        public const string All = "all";
    }

    public static class SortBy
    {
        public const string Amount = "amount";
        public const string Time = "time";
    }

    public static class SortOrder
    {
        public const string Asc = "asc";
        public const string Desc = "desc";
    }
}