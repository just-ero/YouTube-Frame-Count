using System;

namespace YTFC
{
    public partial class RetimeForm
    {
        private string ShortTimeFormat(TimeSpan time)
        {
            if (time.Hours > 0) return time.ToString(@"h\:mm\:ss\.fff");
            else if (time.Minutes > 0) return time.ToString(@"m\:ss\.fff");
            else return time.ToString(@"s\.fff");
        }

        private string LongTimeFormat(TimeSpan time)
        {
            if (time.Hours > 0) return $"{time.Hours}h {time.Minutes:00}m {time.Seconds:00}s {time.Milliseconds:000}ms";
            else if (time.Minutes > 0) return $"{time.Minutes}m {time.Seconds:00}s {time.Milliseconds:000}ms";
            else return $"{time.Seconds}s {time.Milliseconds:000}ms";
        }

        private string FormatToTime(float seconds)
        {
            if (seconds < 0) seconds = -seconds;
            TimeSpan time = TimeSpan.FromSeconds(seconds);

            if (TimeFormat.Checked) return LongTimeFormat(time);
            else return ShortTimeFormat(time);
        }
    }
}