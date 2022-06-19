using Microsoft.AspNetCore.Components.Forms;

namespace Weva.Data
{
    public enum SelectedFileType { Video, Data };

    public abstract class SelectedFile
    {
        public SelectedFileType SelectedFileType;
        public string? Filename { get; }
        public string? ContentType { get; }
        public string? LocalUrl { get; set; }
        public DateTimeOffset? LastModified { get; }

        public SelectedFile(IBrowserFile browserFile)
        {
            Filename = browserFile.Name;
            ContentType = browserFile.ContentType;
            LastModified = browserFile.LastModified;

            var buffers = new byte[browserFile.Size];
            LocalUrl = $"data:{ContentType};base64,{Convert.ToBase64String(buffers)}";
        }
    };

    public class SelectedVideo : SelectedFile
    {
        public float? Duration { get; set; }

        public SelectedVideo(IBrowserFile browserFile) : base(browserFile)
        {
            SelectedFileType = SelectedFileType.Video;
        }
    }

    public class SelectedData : SelectedFile
    {
        public SelectedData(IBrowserFile browserFile) : base(browserFile)
        {
            SelectedFileType = SelectedFileType.Data;
        }
    }
}