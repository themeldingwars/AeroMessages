using Aero.Gen.Attributes;
using AeroMessages.Common;
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
            JoinLeaderHint = 17,
            FriendRequestOrRemove = 18,
        }
        public ChatMessageAlternateType AlternateType;

        public byte HaveAltData; 
        [AeroIf(nameof(HaveAltData), 1)]
        public ChatAltData AltData;

        public byte HaveAltEntity;
        [AeroIf(nameof(HaveAltEntity), 1)]
        public EntityId AltEntity;

        public byte HaveAltString;
        [AeroIf(nameof(HaveAltString), 1)]
        [AeroString] public string AltString;
    }

    [AeroBlock]
    public struct ChatAltData
    {
        [AeroArray(typeof(ushort))]
        public byte[] Data;
    }
}