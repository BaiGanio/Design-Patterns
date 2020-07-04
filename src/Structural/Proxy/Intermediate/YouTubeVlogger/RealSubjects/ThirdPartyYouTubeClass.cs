using System;
using System.Collections.Generic;

namespace YouTubeVlogger
{
    // The concrete implementation of a service connector. Methods
    // of this class can request information from YouTube. The speed
    // of the request depends on a user's internet connection as
    // well as YouTube's. The application will slow down if a lot of
    // requests are fired at the same time, even if they all request
    // the same information.
    public class ThirdPartyYouTubeClass : IThirdPartyYouTubeLib
    {
        public object DownloadVideo(Guid id)
        {
            Console.WriteLine("Send an API request to YouTube...");
            Console.WriteLine($"Downloading video with id: {id}");

            return new object();
        }

        public object GetVideoInfo(Guid id)
        {
            Console.WriteLine("Send an API request to YouTube...");
            Console.WriteLine($"Fetching metadata for video with id: {id}");

            return new object();
        }

        public IEnumerable<object> GetVideos()
        {
            Console.WriteLine("Send an API request to YouTube...");
            Console.WriteLine("Fetching all videos...");

            return new List<object>();
        }
    }
}
