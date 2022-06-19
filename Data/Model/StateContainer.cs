namespace Weva.Data
{
    public class StateContainer
    {
        private string? savedString;

        public string Property
        {
            get => savedString ?? string.Empty;
            set
            {
                savedString = value;
                NotifyStateChanged();
            }
        }

        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();

        private SelectedVideo? selectedVideo;
        public SelectedVideo? SelectedVideo
        {
            get => selectedVideo ?? null;
            set
            {
                selectedVideo = value;
                NotifyStateChanged();
            }
        }
    }
}