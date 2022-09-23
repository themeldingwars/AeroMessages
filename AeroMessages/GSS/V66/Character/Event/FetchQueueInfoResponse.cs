using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 145)]
    public partial class FetchQueueInfoResponse
    {
        public byte Succes;
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
        public ushort PlayerCount1;
        public ushort PlayerCount2;
        public ushort PlayerCount3;
        public ushort MinPlayers;
        public ushort MaxPlayers;
    }

    [AeroBlock]
    public struct QueueRewardsItemData
    {
        public uint Unk1;
        public uint Unk2;
    }

    [AeroBlock]
    public struct QueueRewardsLootData
    {
        [AeroSdb("dbitems::SalvageDisplayItems", "salvage_rewards_id")]
        public uint LootTableId;
        [AeroString] public string DifficultyKey;
    }
}