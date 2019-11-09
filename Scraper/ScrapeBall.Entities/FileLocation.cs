using System;
using System.Collections.Generic;
using System.Text;

namespace ScrapeBall.Entities
{
    public enum BlockStorageType
    {
        Local, Cloud
    }

    public class FileLocation
    {
        public BlockStorageType StorageType { get; set; }
        public string Address { get; set; }
    }
}
