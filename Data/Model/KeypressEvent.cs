namespace Weva.Data
{
    public class KeypressEvent
    {
        public KeypressEvent(float begin, string? key)
        {
            Begin = begin;
            Key = key;
        }

        public float Begin { get; set; }
        public float End { get; set; }
        public float Duration { get; set; }
        public string? Key { get; set; }
    }
}
