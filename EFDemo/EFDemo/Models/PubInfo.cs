using System;
using System.Collections.Generic;

namespace EFDemo.Models
{
    public partial class PubInfo
    {
        public string PubId { get; set; }
        public byte[] Logo { get; set; }
        public string PrInfo { get; set; }

        public Publishers Pub { get; set; }
    }
}
