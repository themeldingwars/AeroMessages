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

        public ChatMessageAlternateData AltData;

        public byte HaveAltEntity;
        [AeroIf(nameof(HaveAltEntity), 1)]
        public EntityId AltEntity;

        public byte HaveAltString;
        [AeroIf(nameof(HaveAltString), 1)]
        [AeroString] public string AltString;
    }
}