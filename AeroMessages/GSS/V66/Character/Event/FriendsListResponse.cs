using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 195)]
    public partial class FriendsListResponse
    {
        [AeroArray(typeof(byte))] public FriendsListData[] Unk1;
        public uint Unk2;
    }

    [AeroBlock]
    public struct FriendsListData
    {
        public ulong Unk1;
        [AeroString] public string Unk2;
        [AeroString] public string Unk3;
        public byte Unk4;
        public uint Unk5;
        public byte Unk6;
    }
}