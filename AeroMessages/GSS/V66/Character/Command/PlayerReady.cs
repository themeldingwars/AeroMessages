using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 88)]
    public partial class PlayerReady
    {
        public sbyte Unk1;
        public sbyte Unk2;
        
        public byte HaveUnk3;
        [AeroIf(nameof(HaveUnk3), 1)]
        [AeroArray(typeof(byte))] public ulong[] Unk3;
    }
}