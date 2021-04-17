using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace YTFC
{
    public class DebugExtractor
    {
        public string DebugString
        {
            set
            {
                try
                {
                    string[] relevantData = { "cmt:", "len:", "optimal_format:", "debug_videoId:" };
                    var partialData =
                        Regex.Replace(value, "[{}\",]", String.Empty).Split('\n')
                        .Where(s => relevantData.Any(rd => s.Contains(rd)))
                        .ToDictionary(l => l.Split(':')[0].Trim(), l => l.Split(':')[1].Trim());

                    string formatedFPS = partialData["optimal_format"].Split('p')[1];

                    FormattedData = new Dictionary<string, dynamic>
                    {
                        { "seconds", Single.Parse(partialData["cmt"]) },
                        { "length", Single.Parse(partialData["len"]) },
                        { "fps", Int32.Parse(String.IsNullOrEmpty(formatedFPS) ? "30" : formatedFPS) },
                        { "vidID", partialData["debug_videoId"] }
                    };
                }
                catch
                {
                    FormattedData = null;
                }
            }
        }

        public Dictionary<string, dynamic> FormattedData;

        public float Seconds => (float)Math.Round(FormattedData["seconds"] - (FormattedData["seconds"] % (1f / (float)FormattedData["fps"])), 3);
        public int FPS => FormattedData["fps"];
        public string ID => FormattedData["vidID"];
    }
}