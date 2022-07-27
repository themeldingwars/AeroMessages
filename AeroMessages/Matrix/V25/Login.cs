using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, 17)]
    public partial class Login
    {
        public byte Unk1;
        public uint ClientVersion;
        [AeroString] public string Unk2;
        public ulong CharacterGuid;
        public uint Unk3; // 
        public uint Unk4;
        public ushort Unk5; // 
        public byte Unk6;
        public byte Unk7;
        public byte Unk8;
        [AeroString] public string Red5Sig2; // Comma separated list of base64 sig somethings
        public byte Unk9; // ? Might be a struct
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