using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 45, 3, true)]
    public class OutpostObserverViewKeyframe : BaseScript
    {
        public byte[] Unk_Bitfield;
        public uint NameLocalizationId;
        public float[] Position;
        public uint LevelRangeId;
        public byte Synced; // Doesn't look right, investigate
        public int TeleportCost;
        public float Progress;
        public byte FactionId;
        public byte Team;
        public byte UnderAttack;
        public byte OutpostType;
        public uint PossibleBuffsId;
        public byte PowerLevel;
        public ushort MWCurrent;
        public ushort MWMax;
        public uint MapMarkerTypeId;
        public float Radius;
        public byte[] Unk3_1;
        public byte[] Unk3_2;
        public byte[] EncounterId;
        public byte[] Unk4;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            if (true) {
                Unk_Bitfield = Stream.Read.BitArray(16); 
                NameLocalizationId = Stream.Read.UInt();
                Position = Stream.Read.FloatArray(3);
                LevelRangeId = Stream.Read.UInt();
                Synced = Stream.Read.Byte();
                TeleportCost = Stream.Read.Int();
                Progress = Stream.Read.Float();
                FactionId = Stream.Read.Byte();
                Team = Stream.Read.Byte();
                UnderAttack = Stream.Read.Byte();
                OutpostType = Stream.Read.Byte();
                PossibleBuffsId = Stream.Read.UInt();
                PowerLevel = Stream.Read.Byte();
                MWCurrent = Stream.Read.UShort();
                MWMax = Stream.Read.UShort();
                MapMarkerTypeId = Stream.Read.UInt();
                Radius = Stream.Read.Float(); 
                Unk3_1 = Stream.Read.ByteArray(4);
                if (Unk_Bitfield[0] == 0x00) {
                    Unk3_2 = Stream.Read.ByteArray(4);
                }
                EncounterId = Stream.Read.ByteArray(8);
                Unk4 = Stream.Read.ByteArray(8);
            }
            
        }
    }
}