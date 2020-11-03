using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS3VersionChecker
{
    [ProtoContract]
    public class BadgeMessage
    {
        [ProtoMember(1)]
        public int Value { get; set; }

        [ProtoMember(2)]
        public long Timestamp { get; set; }

        [ProtoMember(3)]
        public BadgeData[] SubElement { get; set; }
    }

    [ProtoContract]
    public class BadgeData
    {
        [ProtoMember(1)]
        public string UUID { get; set; }

        [ProtoMember(2)]
        public string Name { get; set; }

        [ProtoMember(3)]
        public string URL { get; set; }

        [ProtoMember(4)]
        public string Description { get; set; }

        [ProtoMember(5)]
        public long Timestamp { get; set; }

        [ProtoMember(6)]
        public long Value { get; set; }
    }
}
