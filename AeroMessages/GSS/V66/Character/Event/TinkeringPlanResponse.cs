using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 157)]
    public partial class TinkeringPlanResponse
    {   
        [AeroString] public string Unk1;
        public uint Unk2;
        public sbyte Unk3;
        public ulong Unk4;
        public ulong Unk5;
        public sbyte Unk6;
    }
}