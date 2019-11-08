using System;

namespace ScrapeBall.Entities
{
    public class FileAction
    {
        public bool Pending { get; set; }
        public DateTime Occured { get; set; }
        public string Agent { get; set; }
        public FileAction Validated { get; set; }
        public bool Rerun { get; set; }
    }
}
