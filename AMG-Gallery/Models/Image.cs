using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMG_Gallery.Models
{
    public class Image
    {
        public int Id { get; set; }

        public Guid Uuid { get; set; }

        public string Filename { get; set; }

        public string Path { get; set; }

        public long Size { get; set; }
    }
}
