using System;
using System.Collections.Generic;

namespace YouTubeVlogger
{
    // The GUI class, which used to work directly with a service
    // object, stays unchanged as long as it works with the service
    // object through an interface. We can safely pass a proxy
    // object instead of a real service object since they both
    // implement the same interface.
    public class YouTubeManager
    {
        private IThirdPartyYouTubeLib _service;
        private IEnumerable<object> _cachedVideos;
        private object _cachedVideoInfo;
        private bool _needRequest;

        public YouTubeManager(IThirdPartyYouTubeLib service)
        {
            _service = service;
        }

        public void RenderVideoInfoPage(Guid id)
        {
            Console.WriteLine("Fetching data for the video info page....");
            var data = _service.GetVideoInfo(id);
            Console.WriteLine("Rendering the video page with data....");  
        }
        public void RenderPanelWithListOfVideos()
        {
            Console.WriteLine("Fetching data with list of videos....");
            var data = _service.GetVideos();
            Console.WriteLine("Rendering the panel holding the list of videos....");
        }

        public void ReactOnUserInput()
        {
            Console.WriteLine("Fetching data with list of videos....");
            var data = _service.GetVideos();
            Console.WriteLine("Rendering the panel holding the list of videos....");
        }
    }
}
