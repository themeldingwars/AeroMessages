using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
namespace AeroMessages.GSS.V66.AreaVisualData.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 25, 85)]
    public partial class ParticleEffectSpawned // LootObjectView
    {
        public ulong Unk1;
        public uint Unk2;
        public Vector3 Unk3;
        public byte HaveUnk4;
        [AeroIf(nameof(HaveUnk4), 1)] public Vector3 Unk4;
        public short Unk5;
        public short Unk6;
        public short Unk7;
        public short Unk8;
        public byte Unk9;
        public uint Unk10;
        public HalfFloat Unk11;
        public byte HaveUnk12;
        [AeroIf(nameof(HaveUnk12), 1)] public ParticleEffectSpawnedData Unk12;
    }

    [AeroBlock]
    public struct ParticleEffectSpawnedData
    {
        public uint Unk1;
        public uint Unk2;
    }
}