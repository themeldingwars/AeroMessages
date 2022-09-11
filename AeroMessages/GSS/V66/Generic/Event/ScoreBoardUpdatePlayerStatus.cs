using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
using AeroMessages.Common;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 43)]
    public partial class ScoreBoardUpdatePlayerStatus
    {   
        public EntityId Player; // Assumption
        public byte Unk1;
        public uint Unk2;
        public byte Unk3;
        public byte Unk4; // Alt read
        public sbyte Unk5;
        public byte Unk6;
    }
}