using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 84)]
    public partial class SendMailToPlayer
    {
        public ulong Unk1;
        [AeroString] public string Unk2;
        [AeroString] public string Unk3;
        [AeroString] public string Unk4;
        [AeroArray(typeof(byte))] public MailData[] Unk5;
    }

    [AeroBlock]
    public struct MailData {
        public uint Unk1;
        [AeroString] public string Unk2;
        public ulong Unk3;
        public uint Unk4;
        public uint Unk5;
    }
}