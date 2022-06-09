using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 251, 22)]
    public partial class Generic_Command_TrailRequest
    {
        [AeroArray(5)]
        public byte[] Unk;

        public Vector3 Position1;
        public Vector3 Position2;
    }
}