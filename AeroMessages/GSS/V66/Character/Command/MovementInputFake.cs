using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
using AeroMessages.Common;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 116)]
    public partial class MovementInputFake
    {
        // First part same as MovementInput
        public ushort ShortTime;
        public byte Unk2;
        public byte Unk3;
        public short Unk4;
        public short Unk5;
        public byte Unk6;

        // not the same~
        public byte Unk7;
        public byte Unk8;
        public byte Unk9;
        public byte Unk10;
        public byte Unk11;
        public byte Unk12;
        public byte Unk13;

        // FUN_009c1930
        // Optional MovementInputData from MovementInput
        public byte HaveMovementInputData;
        [AeroIf(nameof(HaveMovementInputData), 1)]
        public MovementInputData Data;
        // --
        
        // Last part same as MovementInput
        public ushort EndShort;
        public byte EndByte;
    }
}