using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 8, 103)]
    public partial class Character_Event_Respawned
    {
        public ushort ShortTime;

        [AeroArray(2)]
        public byte[] Unk;
    }
}