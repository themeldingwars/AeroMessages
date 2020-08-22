
using System.Collections.Generic;
using Bitter;

namespace PacketPeepScript {
    [Script(MessageType.GSS, 2, 89, true)]
    public class CharacterBaseControllerProgressionXPRefresh : BaseScript {
        public byte NumFrames;
        public List<FrameInfo> Frames;

        public override void Read(Bitter.BinaryStream Stream) {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            NumFrames = Stream.Read.Byte();
            Frames = Stream.Read.TypeList<FrameInfo>(NumFrames);
		}
	}
	
	public struct FrameInfo : Bitter.BinaryWrapper.ReadWrite {
		public uint ChassisID;
		public uint XpValue1;
		public uint XpValue2;
		public byte CurrentLevel;
		public byte[] Unk;
		
		public void Read(BinaryStream Stream) {
			ChassisID = Stream.Read.UInt();
			XpValue1 = Stream.Read.UInt();
			XpValue2 = Stream.Read.UInt();
			CurrentLevel = Stream.Read.Byte();
			Unk = Stream.Read.ByteArray(7);
        }
		
        public void Write(BinaryStream Stream) {
			throw new System.NotImplementedException();
		}
		
		public override string ToString() => $"Chassis: {ChassisID}, Level: {CurrentLevel}";
    }
}