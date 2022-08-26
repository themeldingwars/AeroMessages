using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
using AeroMessages.Common;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 115)]
    public partial class MovementInput
    {
        public ushort ShortTime;
        public byte Unk2;
        public byte Unk3;
        public short Unk4;
        public short Unk5;
        public byte Unk6;
        public MovementPoseData PoseData;
        public ushort EndShort;
        public byte EndByte;
    }
}