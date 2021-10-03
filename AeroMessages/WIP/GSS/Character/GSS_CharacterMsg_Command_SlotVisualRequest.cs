/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 207
    MsgName: SlotVisualRequest
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 207)]
    public partial class Character_Command_SlotVisualRequest
    {
        public uint LoadoutId;

        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint ItemSdbId;

        public byte SlotIdx1; // ?
        public byte SlotIdx2; // ?

        [AeroArray(9)]
        public byte[] Unk;
    }
}