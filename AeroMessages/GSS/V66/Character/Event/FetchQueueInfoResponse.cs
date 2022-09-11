using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 145)]
    public partial class FetchQueueInfoResponse
    {
        public byte Unk1;
        [AeroArray(typeof(byte))] public FetchQueueData[] Data;
    }

    [AeroBlock]
    public struct FetchQueueData
    {
        public uint Unk1;
        public byte Unk2;
        public byte Unk3;
        [AeroString] public string Category;
        [AeroString] public string TitleKey;
        [AeroString] public string DescriptionKey;
        public uint ZoneId;
        public uint Unk8;
        [AeroArray(typeof(byte))] public FetchQueueDataInner1[] ActivationCerts;
        [AeroArray(typeof(byte))] public FetchQueueDataInner2[] DifficultiesDescription;
        [AeroArray(typeof(byte))] public FetchQueueDataInner3[] Unk11;
        [AeroArray(typeof(byte))] public FetchQueueDataInner4[] DifficultiesRewards;
        [AeroArray(typeof(byte))] public FetchQueueDataInner3[] Unk13;
        [AeroArray(typeof(byte))] public FetchQueueDataInner4[] Unk14; // Other rewards or just same parsing?
    }

    [AeroBlock]
    public struct FetchQueueDataInner1
    {
        [AeroSdb("dbitems::Certificate", "id")]
        public uint CertId;
        public byte Unk2;
    }

    [AeroBlock]
    public struct FetchQueueDataInner2
    {
        public uint Unk1;
        [AeroString] public string LabelKey;
        public byte LevelRange1;
        public byte LevelRange2;
        public byte LevelRange3;
        [AeroString] public string Difficulty;
        public ushort PlayerCount1;
        public ushort PlayerCount2;
        public ushort PlayerCount3;
        public ushort PlayerCount4; // Maybe min?
        public ushort PlayerCount5;
    }

    [AeroBlock]
    public struct FetchQueueDataInner3
    {
        public uint Unk1;
        public uint Unk2;
    }

    [AeroBlock]
    public struct FetchQueueDataInner4
    {
        [AeroSdb("dbitems::SalvageDisplayItems", "salvage_rewards_id")]
        public uint RewardsId;

        [AeroString] public string Difficulty;
    }
}