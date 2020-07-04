using System;
using System.Collections.Generic;

namespace YouTubeVlogger
{
    // The interface of a remote service.
    public interface IThirdPartyYouTubeLib
    {
        IEnumerable<object> GetVideos();
        object GetVideoInfo(Guid id);
        object DownloadVideo(Guid id);
    }
}
