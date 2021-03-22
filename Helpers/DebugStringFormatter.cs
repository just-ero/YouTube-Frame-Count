using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace YTFC
{
    public partial class RetimeForm
    {
        private Dictionary<string, dynamic> FormatDebugString(string dbgString)
        {
            Dictionary<string, string> partialData = new Dictionary<string, string>();

            try
            {
                string[] relevantData = { "cmt:", "len:", "optimal_format:", "debug_videoId:" };

                partialData =
                    Regex.Replace(dbgString, "[{}\",]", String.Empty).Split('\n')
                    .Where(s => relevantData.Any(rd => s.Contains(rd)))
                    .ToDictionary(l => l.Split(':')[0].Trim(), l => l.Split(':')[1].Trim());

                string formatedFPS = partialData["optimal_format"].Split('p')[1];

                return new Dictionary<string, dynamic>
                {
                    { "seconds", Single.Parse(partialData["cmt"]) },
                    { "length", Single.Parse(partialData["len"]) },
                    { "fps", Int32.Parse(String.IsNullOrEmpty(formatedFPS) ? "30" : formatedFPS) },
                    { "vidID", partialData["debug_videoId"] }
                };
            }
            catch { return null; }
        }
    }
}
