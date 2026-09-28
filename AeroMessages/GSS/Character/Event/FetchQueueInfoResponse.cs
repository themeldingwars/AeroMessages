using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.FetchQueueInfo_Response, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class FetchQueueInfoResponse
    {
        public sbyte Succes;
        [AeroArray(typeof(byte))] public FetchQueueData[] Queues;
    }

    [AeroBlock]
    public struct FetchQueueData
    {
        public uint QueueId;
        public byte Qualifies;
        public byte ChallengeEnabled;
        [AeroString] public string Gametype;
        [AeroString] public string DisplayKeyName;
        [AeroString] public string DisplayKeyDesc;
        public uint ZoneId;
        public uint MissionId;
        [AeroArray(typeof(byte))] public QueueCertsData[] Certs;
        [AeroArray(typeof(byte))] public QueueDifficultiesData[] Difficulties;
        [AeroArray(typeof(byte))] public QueueRewardsItemData[] RewardsWinnerItems;
        [AeroArray(typeof(byte))] public QueueRewardsLootData[] RewardsWinnerLoots;
        [AeroArray(typeof(byte))] public QueueRewardsItemData[] RewardsLooserItems;
        [AeroArray(typeof(byte))] public QueueRewardsLootData[] RewardsLooserLoots;
    }

    [AeroBlock]
    public struct QueueCertsData
    {
        [AeroSdb("dbitems::Certificate", "id")]
        public uint CertId;
        public byte Passed;
    }

    [AeroBlock]
    public struct QueueDifficultiesData
    {
        public uint DifficultyId;
        [AeroString] public string UiString;
        public byte MinLevel;
        public byte DisplayLevel;
        public byte MaxSuggestedLevel;
        [AeroString] public string DifficultyKey;
        public ushort MinPlayers;
        public ushort Unk2;
        public ushort MaxPlayers;
        public ushort Unk4;
        public ushort Unk5;
    }

    [AeroBlock]
    public struct QueueRewardsItemData
    {
        public uint ItemSdbId;
        public uint Quantity;
    }

    [AeroBlock]
    public struct QueueRewardsLootData
    {
        [AeroSdb("dbitems::SalvageDisplayItems", "salvage_rewards_id")]
        public uint LootTableId;
        [AeroString] public string DifficultyKey;
    }
}