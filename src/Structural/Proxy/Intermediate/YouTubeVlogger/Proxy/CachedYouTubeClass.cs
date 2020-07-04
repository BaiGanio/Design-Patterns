using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeVlogger
{
    // To save some bandwidth, we can cache request results and keep
    // them for some time. But it may be impossible to put such code
    // directly into the service class. For example, it could have
    // been provided as part of a third party library and/or defined
    // as `final`. That's why we put the caching code into a new
    // proxy class which implements the same interface as the
    // service class. It delegates to the service object only when
    // the real requests have to be sent.
    public class CachedYouTubeClass : IThirdPartyYouTubeLib
    {
        private IThirdPartyYouTubeLib _service;
        private IEnumerable<object> _cachedVideos;
        private object _cachedVideoInfo;
        private bool _needRequest;

        public CachedYouTubeClass(IThirdPartyYouTubeLib service)
        {
            _service = service;
        }
        public object DownloadVideo(Guid id)
        {
            if (DownloadExist(id) || _needRequest)
            {
                _service.DownloadVideo(id);
            }
            return _cachedVideos.Any();
        }

        public object GetVideoInfo(Guid id)
        {
            if (_cachedVideoInfo == null || _needRequest)
            {
                _cachedVideoInfo = _service.GetVideoInfo(id);
            }
            return _cachedVideoInfo;
        }

        public IEnumerable<object> GetVideos()
        {
            if (_cachedVideos == null || _needRequest)
            {
                _cachedVideos = _service.GetVideos();
            }
            return _cachedVideos;
        }

        private bool DownloadExist(Guid id)
        {
            if (_cachedVideos != null)
            {
                return _cachedVideos.Contains(id);
            }
            return false;
        }
    }
}
