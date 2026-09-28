using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.SlotVisualRequest, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class SlotVisualRequest
    {
        public int LoadoutId;

        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint ItemSdbId;

        public byte VisualType;
        public byte SlotTypeId;

        public uint ConfigId; // 0 PvE, 1 PvP
        public uint Unk2;
        [AeroArray(typeof(byte))] public float[] Unk3;
    }
}