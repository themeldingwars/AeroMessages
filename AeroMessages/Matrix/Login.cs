using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, MatrixMessage.Login, MatrixVersion.V1, MatrixVersion.V32)]
    public partial class Login
    {
        public byte SecurityFlags; // bit 0: dev character, bit 4: a spectator target is set (so 0, 1 or 0x11)
        public uint ClientVersion;

        [AeroString] public string Unk2; // always empty from the 1962 client

        public ulong CharacterGuid;
        public ClientPreferencesData ClientPreferences;

        public byte Unk7; // always 0 from the 1962 client

        public byte Locale;
        [AeroString] public string Red5Sig2; // Comma separated list of base64 sig somethings

        public byte HaveUnk9; // always 0 from the 1962 client
        [AeroIf(nameof(HaveUnk9), 1)] public LoginUnk9Data Unk9;

        [AeroBlob] public byte[] Ticket;
    }

    [AeroBlock]
    public struct LoginUnk9Data
    {
        public ulong A1;
        [AeroString] public string A2;
    }
}