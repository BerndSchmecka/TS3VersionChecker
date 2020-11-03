using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS3VersionChecker
{
    [ProtoContract]
    public class VersionMessage
    {
        [ProtoMember(1)]
        public int Value { get; set; }

        [ProtoMember(2)]
        public VersionData[] SubElement { get; set; }

        [ProtoMember(3)]
        public int Value2 { get; set; }
    }

    [ProtoContract]
    public class VersionData
    {
        [ProtoMember(1)]
        public string Channel { get; set; }

        [ProtoMember(2)]
        public long Timestamp { get; set; }

        [ProtoMember(3)]
        public string Version { get; set; }
    }
}
