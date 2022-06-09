using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Turret
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 40, 83)]
    public partial class Turret_Event_ProjectileFired
    {
        public uint Time;
        public Vector3 Aim;
        public byte Unk;
    }
}