using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 188)]
    public partial class DuelRequest
    {
        // FUN_009db930
        public byte Unk1;
        [AeroString] public string Unk2;
        public EntityId RequestingEntity;
        [AeroString] public string Unk3;
        public EntityId Unk4;
        [AeroString] public string TargetName;
        [AeroArray(typeof(byte))] public ulong[] Unk5;
        [AeroArray(typeof(byte))] public ulong[] Unk6;
        public ushort Unk7;
        public ushort Unk8;
        public uint Unk9;
        public byte Unk10;
        public ulong TargetEntity; // TODO: Verify this
        // --
        public byte Unk12;
    }
}