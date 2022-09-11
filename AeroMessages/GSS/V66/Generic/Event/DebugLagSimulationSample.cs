using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
using AeroMessages.Common;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 95)]
    public partial class DebugLagSimulationSample
    {
        public ushort Unk1;
        public ushort Unk2;
        public ushort Unk3;
        public ushort Unk4;
        public ushort Unk5;
        public ushort Unk6;
        public ushort Unk7;
        public ushort Unk8;
        public ushort Unk9;
        public ushort Unk10;
        public ushort Unk11;
        public ushort Unk12;
        public ushort Unk13;
    }
}