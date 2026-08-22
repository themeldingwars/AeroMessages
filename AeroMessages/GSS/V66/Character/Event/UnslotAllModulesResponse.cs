using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 153)]
    public partial class UnslotAllModulesResponse
    {
        public ulong Unk1;
        public sbyte Unk2;
    }
}