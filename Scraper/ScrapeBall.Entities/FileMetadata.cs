using System.Collections.Generic;

namespace ScrapeBall.Entities
{
    public class FileMetadata
    {
        public string SourceUri { get; set; }
        public List<FileLocation> FileLocations { get; set; } = new List<FileLocation>();
        public FileAction Retrieved { get; set; }
        public FileAction Validated { get; set; }
        public FileAction Parsed { get; set; }
    }
}
