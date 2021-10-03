/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 0
    TypeName: Generic
    MsgId: 98
    MsgName: Trail
META_END
 */
using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 98)]
    public partial class Generic_Event_Trail
    {
        [AeroArray(5)]
        public byte[] Unk;

        [AeroArray(typeof(byte))]
        public Vector3[] Points;
    }
}