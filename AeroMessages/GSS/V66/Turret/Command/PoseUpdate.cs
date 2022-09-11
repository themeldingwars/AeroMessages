using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Turret.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 39, 83)]
    public partial class PoseUpdate
    {
        public Quaternion Unk1; // Rot?
        public uint Time;
    }
}