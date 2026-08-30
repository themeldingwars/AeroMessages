using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, MatrixMessage.Login, MatrixVersion.V1, MatrixVersion.V26)]
    public partial class Login
    {
        public byte CharacterIsDev;
        public uint ClientVersion;

        [AeroString] public string Unk2;

        public ulong CharacterGuid;
        public ClientPreferencesData ClientPreferences;

        public byte Unk7;

        public byte Locale;
        [AeroString] public string Red5Sig2; // Comma separated list of base64 sig somethings

        public byte HaveUnk9;
        [AeroIf(nameof(HaveUnk9), 1)] public LoginUnk9Data Unk9;

        public MatrixTicket Ticket;
    }

    [AeroBlock]
    public struct LoginUnk9Data
    {
        public ulong A1;
        [AeroString] public string A2;
    }

    [AeroBlock]
    public struct MatrixTicket
    {
        [AeroArray(45)]
        public byte[] Part1;
        [AeroArray(45)]
        public byte[] Part2;
        [AeroArray(45)]
        public byte[] Part3;
        [AeroArray(45)]
        public byte[] Part4;
        [AeroArray(45)]
        public byte[] Part5;
        [AeroArray(45)]
        public byte[] Part6;
        [AeroArray(45)]
        public byte[] Part7;
        [AeroArray(45)]
        public byte[] Part8;
        [AeroArray(10)]
        public byte[] Part9;
    }
}