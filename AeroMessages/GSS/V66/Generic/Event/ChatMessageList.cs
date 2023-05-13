using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 118)]
    public partial class ChatMessageList
    {
        [AeroArray(typeof(byte))] public ChatMessageData[] Messages;
    }

    [AeroBlock]
    public struct ChatMessageData
    {
        public EntityId SenderId;
        [AeroString] public string SenderName;
        [AeroString] public string Message;
        public byte Channel;
        public byte ChatIconFlags;

        public enum ChatMessageAlternateType : byte
        {
            NONE = 0,
            ChatDuelResult = 1,
            ChatVendingMachineWinnerInfo = 2,
            ChatUnlockedAchievement = 3,
            SquadInviteForward = 4,
            PlayerStateDetails = 5,
            RequestPlayerStateDetails = 6,
            PlayerDisconnected = 7,
            PlayerTransferring = 8,
            GroupPreferences = 9,
            GroupWaypoint = 10,
            SquadMatchQueue = 11,
            SquadQueueIneligibility = 12,
            SquadRequestInvite = 13,
            GeoReportAdded = 14,
            GeoReportRemoved = 15,
            QuickChatMessage = 16,
            LootCollected = 17,
            JoinLeaderHint = 18,
            FriendRequestOrRemove = 19,
        }
        public ChatMessageAlternateType AlternateType;

        public byte HaveAltData;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.ChatDuelResult)]
        public ChatAltData_ChatDuelResult AltData_ChatDuelResult;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.ChatVendingMachineWinnerInfo)]
        public ChatAltData_ChatVendingMachineWinnerInfo AltData_ChatVendingMachineWinnerInfo;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.ChatUnlockedAchievement)]
        public ChatAltData_ChatUnlockedAchievement AltData_ChatUnlockedAchievement;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.SquadInviteForward)]
        public ChatAltData_SquadInviteForward AltData_SquadInviteForward;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.PlayerStateDetails)]
        public ChatAltData_PlayerStateDetails AltData_PlayerStateDetails;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.RequestPlayerStateDetails)]
        public ChatAltData_RequestPlayerStateDetails AltData_RequestPlayerStateDetails;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.PlayerDisconnected)]
        public ChatAltData_PlayerDisconnected AltData_PlayerDisconnected;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.PlayerTransferring)]
        public ChatAltData_PlayerTransferring AltData_PlayerTransferring;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.GroupPreferences)]
        public ChatAltData_GroupPreferences AltData_GroupPreferences;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.GroupWaypoint)]
        public ChatAltData_GroupWaypoint AltData_GroupWaypoint;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.SquadMatchQueue)]
        public ChatAltData_SquadMatchQueue AltData_SquadMatchQueue;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.SquadQueueIneligibility)]
        public ChatAltData_SquadQueueIneligibility AltData_SquadQueueIneligibility;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.SquadRequestInvite)]
        public ChatAltData_SquadRequestInvite AltData_SquadRequestInvite;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.GeoReportAdded)]
        public ChatAltData_GeoReportAdded AltData_GeoReportAdded;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.GeoReportRemoved)]
        public ChatAltData_GeoReportRemoved AltData_GeoReportRemoved;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.QuickChatMessage)]
        public ChatAltData_QuickChatMessage AltData_QuickChatMessage;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.LootCollected)]
        public ChatAltData_LootCollected AltData_LootCollected;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.JoinLeaderHint)]
        public ChatAltData_JoinLeaderHint AltData_JoinLeaderHint;

        [AeroIf(nameof(HaveAltData), 1)]
        [AeroIf(nameof(AlternateType),ChatMessageAlternateType.FriendRequestOrRemove)]
        public ChatAltData_FriendRequestOrRemove AltData_FriendRequestOrRemove;

        public byte HaveAltEntity;
        [AeroIf(nameof(HaveAltEntity), 1)]
        public EntityId AltEntity;

        public byte HaveAltString;
        [AeroIf(nameof(HaveAltString), 1)]
        [AeroString] public string AltString;
    }

    [AeroBlock]
    public struct ChatAltData_ChatDuelResult
    {
        public ushort DataLength;

        // Guesswork
        [AeroString] public string CDR_Unk1;
        [AeroString] public string CDR_Unk2;
    }

    [AeroBlock]
    public struct ChatAltData_ChatVendingMachineWinnerInfo
    {
        public ushort DataLength;

        // Guesswork
        [AeroString] public string CDR_PlayerName;
        public byte CDR_Gender;
        public uint CDR_ItemTypeId;
        public uint CDR_Quality;
    }

    [AeroBlock]
    public struct ChatAltData_ChatUnlockedAchievement
    {
        public ushort DataLength;

        // Guesswork
        public uint CUA_Unk1;
        [AeroString] public string CUA_Unk2;
        public byte CUA_Gender;
    }

    [AeroBlock]
    public struct ChatAltData_SquadInviteForward
    {
        public ushort DataLength;

        // Guesswork
        [AeroString] public string SIF_Name; // Player?
    }

    [AeroBlock]
    public struct ChatAltData_PlayerStateDetails
    {
        public ushort DataLength;

        public byte Unk1; // Special read func, casted to uint?. 0 for DarkCisum, 1 for CrissKitty.
        public uint ChassisId;
        public byte Level;
        public byte EffectiveLevel;
        public uint EliteRank;
        public ulong InstanceId;
        public uint ZoneId;
        [AeroString] public string ServerHost;
        public uint PvPRank; // Bit of a guess

        public byte HaveUnk10;
        [AeroIf(nameof(HaveUnk10), 1)]
        public PSDData Unk10;

        public byte ChatIconFlags; // Again tho?
        public byte CharacterState;
        public uint MaxHealth;
        public ushort Unk14;
    }

    [AeroBlock]
    public struct PSDData
    {
        public ulong PSDD_Unk1;
        public uint  PSDD_Unk2;
        public byte  PSDD_Unk3;
        public byte  PSDD_Unk4;
    }

    [AeroBlock]
    public struct ChatAltData_RequestPlayerStateDetails
    {
        public ushort DataLength;
        // No additional data
        // Does something on squad and platoon channel, and something different on friends channel.
    }

    [AeroBlock]
    public struct ChatAltData_PlayerDisconnected
    {
        public ushort DataLength;
        [AeroArray(nameof(DataLength))] public byte[] Data;
        // Probably no additional data
        // Only does something on Friends channel
    }

    [AeroBlock]
    public struct ChatAltData_PlayerTransferring
    {
        public ushort DataLength;
        // No additional data
    }

    [AeroBlock]
    public struct ChatAltData_GroupPreferences
    {
        public ushort DataLength;

        public byte GP_Unk1;
        public byte GP_Unk2;
        public byte GP_Unk3;
        public byte GP_Unk4;
        public byte GP_Unk5;
        public byte GP_Unk6;
        public HalfFloat GP_Unk7;
        public byte GP_Unk8;
        [AeroArray(typeof(byte))] public EntityId[] Entities;
    }

    [AeroBlock]
    public struct ChatAltData_GroupWaypoint
    {
        public ushort DataLength;

        // Guesswork
        public byte HaveWaypoint;
        [AeroIf(nameof(HaveWaypoint), 1)]
        public GroupWaypoint_Data Waypoint;
    }

    [AeroBlock]
    public struct GroupWaypoint_Data
    {
        public uint Unk1;
        public ulong Unk2;
        public uint Unk3;
        public Vector3 Position;
    }

    [AeroBlock]
    public struct ChatAltData_SquadMatchQueue
    {
        public ushort DataLength;

        // Guesswork
        public ulong GroupId;
        [AeroString] public string SMQ_Unk1; // random zone group?
        [AeroString] public string SMQ_Unk2; // leader?
    }
    [AeroBlock]
    public struct ChatAltData_SquadQueueIneligibility
    {
        /*
        chatId
        entityId
         */
        public ushort DataLength;

        public byte DataCount; // Throws exception if 0?
        [AeroArray(nameof(DataCount))] public SQIData[] Data;
    }

    [AeroBlock]
    public struct SQIData
    {
        public uint QueueId;
        [AeroArray(typeof(byte))] public uint[] SQI_Unk2; // Unknown type
        [AeroArray(typeof(byte))] public int[] SQI_Unk3; // ReadArray_Int32_Weird
    }


    [AeroBlock]
    public struct ChatAltData_SquadRequestInvite
    {
        public ushort DataLength;

        // Possibly no additional data?
        [AeroArray(nameof(DataLength))] public byte[] Data;
    }

    [AeroBlock]
    public struct ChatAltData_GeoReportAdded
    {
        public ushort DataLength;

        // Guesswork
        public ulong GRA_Unk1;
        public uint GRA_Unk2; // Maybe same as GRR_Unk1?
        public Vector3 GRA_Position;
        [AeroArray(typeof(byte))] public GeoReportData[] Data;

    }

    [AeroBlock]
    public struct ChatAltData_GeoReportRemoved
    {
        public ushort DataLength;

        // Guesswork
        public uint GRR_Unk1; // Maybe same as GRA_Unk2?
    }

    [AeroBlock]
    public struct ChatAltData_QuickChatMessage
    {
        public ushort DataLength;
        
        // Guesswork
        public uint QCM_Id;
    }

    [AeroBlock]
    public struct ChatAltData_LootCollected
    {
        public ushort DataLength;

        public uint ItemTypeId;
        [AeroString] public string LootedTo; // or lootedBy??
        public uint Quantity;
        public uint Boosted; // Assumption
        public uint Quality; // Assumption
        [AeroArray(typeof(byte))] public uint[] Modules; // Assumption
        public byte RewardType; // Assumption
    }

    [AeroBlock]
    public struct ChatAltData_JoinLeaderHint
    {
        public ushort DataLength;

        // Possibly no additional data?
        [AeroArray(nameof(DataLength))] public byte[] Data;
    }

    [AeroBlock]
    public struct ChatAltData_FriendRequestOrRemove
    {
        public ushort DataLength;

        // Guesswork
        public sbyte FROR_StatusType;
    }
}