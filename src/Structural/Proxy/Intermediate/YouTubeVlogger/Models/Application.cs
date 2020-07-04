namespace YouTubeVlogger
{
    public static class Application
    {
        static readonly IThirdPartyYouTubeLib aYouTubeService = new ThirdPartyYouTubeClass();
        static readonly IThirdPartyYouTubeLib aYouTubeProxy = new CachedYouTubeClass(aYouTubeService);
        private static readonly YouTubeManager manager = new YouTubeManager(aYouTubeProxy);

        public static void DoJob()
        {
            manager.ReactOnUserInput();
        }
    }
}
