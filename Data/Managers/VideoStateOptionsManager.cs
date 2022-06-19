using Blazored.Video.Support;

namespace Weva.Data
{
    public static class VideoStateOptionsManager
    {
        public static Dictionary<VideoEvents, VideoStateOptions> GetOptions()
        {
            Dictionary<VideoEvents, VideoStateOptions> options = new Dictionary<VideoEvents, VideoStateOptions>();
            var option = new VideoStateOptions() { All = true };
            options[VideoEvents.Abort] = option;
            options[VideoEvents.CanPlay] = option;
            options[VideoEvents.CanPlayThrough] = option;
            options[VideoEvents.DurationChange] = option;
            options[VideoEvents.Emptied] = option;
            options[VideoEvents.Ended] = option;
            options[VideoEvents.Error] = option;
            options[VideoEvents.LoadedData] = option;
            options[VideoEvents.LoadedMetadata] = option;
            options[VideoEvents.LoadStart] = option;
            options[VideoEvents.Pause] = option;
            options[VideoEvents.Play] = option;
            options[VideoEvents.Playing] = option;
            options[VideoEvents.Progress] = option;
            options[VideoEvents.RateChange] = option;
            options[VideoEvents.Seeked] = option;
            options[VideoEvents.Seeking] = option;
            options[VideoEvents.Stalled] = option;
            options[VideoEvents.Suspend] = option;
            options[VideoEvents.TimeUpdate] = option;
            options[VideoEvents.VolumeChange] = option;
            options[VideoEvents.Waiting] = option;

            return options;
        }
    }
}