using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 206)]
    public partial class SlotGearRequest
    {
        public uint LoadoutId;
        public ulong ItemGUID;

        [AeroSdb("dbitems::LoadoutSlot", "id")]
        public byte SlotIdx;

        [AeroArray(4)]
        public byte[] Unk;
    }
}