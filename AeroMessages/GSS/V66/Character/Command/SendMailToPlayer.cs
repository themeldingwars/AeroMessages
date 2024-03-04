using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 84)]
    public partial class SendMailToPlayer
    {
        public ulong ClientGeneratedGuid;
        [AeroString] public string Recipient;
        [AeroString] public string Subject;
        [AeroString] public string Body;
        [AeroArray(typeof(byte))] public MailAttachmentData[] Attachments;
    }

    [AeroBlock]
    public struct MailAttachmentData {
        public uint ItemSdbId;
        [AeroString] public string Unk;
        public ulong ItemGuid;
        public uint Quality;  // Not sure about this one
        public uint Quantity;
    }
}