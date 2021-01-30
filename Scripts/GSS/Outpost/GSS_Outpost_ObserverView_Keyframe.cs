using Bitter;
using System.Collections.Generic;
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
        public string EncounterId;
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
                EncounterId = Stream.Read.String();
                Unk4 = Stream.Read.ByteArray(8);
            }
            
        }
    }

    public static class MyExtensions
    {
        public static Bitter.BinaryStream Stream;
            
        public enum Controller : byte
        {
            Generic = 0x00,
            Character = 0x01,
            Melding = 0x0f,
            MeldingBubble = 0x11,
            AreaVisualData = 0x13,
            Vehicle = 0x1a,
            Anchor = 0x20,
            Deployable = 0x22,
            Turret = 0x26,
            TinyObjectType = 0x29,
            CharacterAbilityPhysics = 0x2a,
            ProjectileObjectType = 0x2b,
            Outpost = 0x2c,
            ResourceArea = 0x2e,
            ResourceNode = 0x2f,
            Encounter = 0x31,
            Carryable = 0x32,
            LootStoreExtension = 0x34,
            TeamManager = 0x36,
        }
        
        public static string Entity(this Bitter.BinaryReader rdr)
        {
            Controller controller;
            ulong id;

            controller = (Controller) rdr.Byte();
            Stream.baseStream.ByteOffset--;
            id = rdr.ULong() & 0xFFFFFFFFFFFFFF00;

            if (controller == 0 && id == 0) return "None";
            return $"{controller}:{id}";
        }

        public static string[] EntityArray(this Bitter.BinaryReader R, int num)
        {
            List<string> list = new List<string>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.Entity());
            }
            return list.ToArray();
        }

        public static string StringZ(this Bitter.BinaryReader rdr)
        {
            string ret = "";
            do
            {
                byte b = rdr.Byte();
                if (b == 0x00)
                    break;
                ret += (char)b;
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);
            return ret;
        }
    }
}