using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.FriendsListResponse, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class FriendsListResponse
    {
        [AeroArray(typeof(byte))] public FriendsListData[] Friends;
        public uint Page; // Counts up per response of up to 50 friends, an empty response ends the list
    }

    public enum FriendStatusType : byte
    {
        None = 0,
        Friend = 1,
        PendingIn = 2,
        PendingOut = 3,
    }

    [AeroBlock]
    public struct FriendsListData
    {
        public ulong CharacterGuid;
        [AeroString] public string Name;
        [AeroString] public string Note;
        public FriendStatusType StatusType;
        public uint LastSeenAt; // unix seconds
        public byte IsOnline;
    }
}