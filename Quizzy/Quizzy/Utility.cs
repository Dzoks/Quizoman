using System.Linq;
using System.Text.RegularExpressions;

namespace Quizzy
{
    class Utility
    {
        static readonly Regex YoutubeVideoRegex = new Regex(@"youtu(?:\.be|be\.com)/(?:(.*)v(/|=)|(.*/)?)([a-zA-Z0-9-_]+)", RegexOptions.IgnoreCase);
        public static bool IsYoutubeLinkValid(string url)
        {
            return YoutubeVideoRegex.Match(url).Success;
        }

        public static string getYoutubeEmbedLink(string url)
        {
           var youtubeMatch=YoutubeVideoRegex.Match(url);
            return "https://www.youtube.com/embed/"+ youtubeMatch.Groups[youtubeMatch.Groups.Count - 1].Value;
        }
        public static bool IsEmptyOrWhiteSpace(string value)
        {
            return value.All(char.IsWhiteSpace);
        }
    }
}
