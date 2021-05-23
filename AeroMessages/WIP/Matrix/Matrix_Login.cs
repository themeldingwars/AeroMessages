/*
META_BEGIN
    MsgType: Matrix
    MsgId: 17
    MsgName: Login
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.Matrix
{
    [Aero]
    public partial class Matrix_Login
    {
        public byte Unk1;
        public ushort ClientVersion;

        [AeroArray(3)]
        public byte[] Unk2;

        public ulong CharacterGuid;

        [AeroArray(9)]
        public byte[] Unk3;
        public int NumRed5Sig2S;

        [AeroString]
        public string Red5Sig2; // Comma separated list of base64 sig somethings

        [AeroArray(376)]
        public byte[] Red5Sig1; // From Web Requests to ClientAPI
    }
}