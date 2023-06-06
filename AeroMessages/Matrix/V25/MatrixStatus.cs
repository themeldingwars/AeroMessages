using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 41)]
    public partial class MatrixStatus
    {
        public int MatrixBytesPerSecond; // The BytesPerSecond value shown in the graph
        public int GameShapedBytes; // MatrixBytesPerSecond is subtracted from this value before it is displayed as Game Shaped Bytes.
        public byte PacketUploss; // The client side label for this value
        public byte PacketDownloss; // The client side label for this value

        public ushort Unk5; // related: "prefs.probe_segment_bytes > TARGET_MSS_UNDERSHOOT"
        public byte IsEverlastingGobsocket; // When changed to 1, triggers a notice "Everlasting Gobsocket".

        // -- FUN_00754d40
        public byte HaveUnk7;
        [AeroIf(nameof(HaveUnk7), 1)]
        [AeroArray(typeof(byte))] public MatrixStatusUnk7Data[] Unk7;
        // --

        [AeroArray(typeof(ushort))] public byte[] Unk8; // FUN_016eed70, not 100%
    }
    
    [AeroBlock]
    public struct MatrixStatusUnk7Data
    {
        [AeroArray(8)] public byte[] Unk1;
        public byte Unk2;
        public byte Unk3;
        public byte Unk4;
        public byte Unk5;
    }
}