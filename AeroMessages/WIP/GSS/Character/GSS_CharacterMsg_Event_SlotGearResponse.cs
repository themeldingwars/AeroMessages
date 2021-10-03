/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 154
    MsgName: SlotGearResponse
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 154)]
    public partial class Character_Event_SlotGearResponse
    {
        public uint LoadoutId;
        public ulong ItemGUID;

        [AeroSdb("dbitems::LoadoutSlot", "id")]
        public byte SlotIdx;

        [AeroArray(5)]
        public byte[] Unk; // 1 more byte than request
    }
}