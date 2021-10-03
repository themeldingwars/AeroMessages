/*
META_BEGIN
    MsgType: Matrix
    MsgId: 17
    MsgName: Login
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, 17)]
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

        public byte Unk4;

        public MatrixTicket Ticket;
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