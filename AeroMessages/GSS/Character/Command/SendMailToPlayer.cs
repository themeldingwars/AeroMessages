using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.SendMailToPlayer, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
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