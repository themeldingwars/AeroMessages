using Bitter;
using System;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 22, 3, true)]
    public class AreaVisualDataMapMarkerViewKeyframe : BaseScript
    {
        enum BitfieldIndex : byte
        {
            MapMarkers_0,
            MapMarkers_1,
            MapMarkers_2,
            MapMarkers_3,
            MapMarkers_4,
            MapMarkers_5,
            MapMarkers_6,
            MapMarkers_7,
            MapMarkers_8,
            MapMarkers_9,
            MapMarkers_10,
            MapMarkers_11,
            MapMarkers_12,
            MapMarkers_13,
            MapMarkers_14,
            MapMarkers_15,
            MapMarkers_16,
            MapMarkers_17,
            MapMarkers_18,
            MapMarkers_19,
            MapMarkers_20,
            MapMarkers_21,
            MapMarkers_22,
            MapMarkers_23,
            MapMarkers_24,
            MapMarkers_25,
            MapMarkers_26,
            MapMarkers_27,
            MapMarkers_28,
            MapMarkers_29,
            MapMarkers_30,
            MapMarkers_31,
            MapMarkers_32,
            MapMarkers_33,
            MapMarkers_34,
        }

        public byte[] Bitfield; // 35 fields = 5 bytes, last bits are unused
        public float[] Position; // Used if the marker position is 0.
        public MapMarker? MapMarkers_0;
        public MapMarker? MapMarkers_1;
        public MapMarker? MapMarkers_2;
        public MapMarker? MapMarkers_3;
        public MapMarker? MapMarkers_4;
        public MapMarker? MapMarkers_5;
        public MapMarker? MapMarkers_6;
        public MapMarker? MapMarkers_7;
        public MapMarker? MapMarkers_8;
        public MapMarker? MapMarkers_9;
        public MapMarker? MapMarkers_10;
        public MapMarker? MapMarkers_11;
        public MapMarker? MapMarkers_12;
        public MapMarker? MapMarkers_13;
        public MapMarker? MapMarkers_14;
        public MapMarker? MapMarkers_15;
        public MapMarker? MapMarkers_16;
        public MapMarker? MapMarkers_17;
        public MapMarker? MapMarkers_18;
        public MapMarker? MapMarkers_19;
        public MapMarker? MapMarkers_20;
        public MapMarker? MapMarkers_21;
        public MapMarker? MapMarkers_22;
        public MapMarker? MapMarkers_23;
        public MapMarker? MapMarkers_24;
        public MapMarker? MapMarkers_25;
        public MapMarker? MapMarkers_26;
        public MapMarker? MapMarkers_27;
        public MapMarker? MapMarkers_28;
        public MapMarker? MapMarkers_29;
        public MapMarker? MapMarkers_30;
        public MapMarker? MapMarkers_31;
        public MapMarker? MapMarkers_32;
        public MapMarker? MapMarkers_33;
        public MapMarker? MapMarkers_34;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.Stream = Stream;

            if (true) {
                Bitfield = Stream.Read.BitArray(40); // Only first 35 are used
                Position = Stream.Read.FloatArray(3);

                if (Bitfield[(int)BitfieldIndex.MapMarkers_0] == 0)
                    MapMarkers_0 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_1] == 0)
                    MapMarkers_1 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_2] == 0)
                    MapMarkers_2 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_3] == 0)
                    MapMarkers_3 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_4] == 0)
                    MapMarkers_4 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_5] == 0)
                    MapMarkers_5 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_6] == 0)
                    MapMarkers_6 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_7] == 0)
                    MapMarkers_7 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_8] == 0)
                    MapMarkers_8 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_9] == 0)
                    MapMarkers_9 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_10] == 0)
                    MapMarkers_10 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_11] == 0)
                    MapMarkers_11 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_12] == 0)
                    MapMarkers_12 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_13] == 0)
                    MapMarkers_13 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_14] == 0)
                    MapMarkers_14 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_15] == 0)
                    MapMarkers_15 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_16] == 0)
                    MapMarkers_16 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_17] == 0)
                    MapMarkers_17 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_18] == 0)
                    MapMarkers_18 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_19] == 0)
                    MapMarkers_19 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_20] == 0)
                    MapMarkers_20 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_21] == 0)
                    MapMarkers_21 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_22] == 0)
                    MapMarkers_22 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_23] == 0)
                    MapMarkers_23 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_24] == 0)
                    MapMarkers_24 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_25] == 0)
                    MapMarkers_25 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_26] == 0)
                    MapMarkers_26 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_27] == 0)
                    MapMarkers_27 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_28] == 0)
                    MapMarkers_28 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_29] == 0)
                    MapMarkers_29 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_30] == 0)
                    MapMarkers_30 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_31] == 0)
                    MapMarkers_31 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_32] == 0)
                    MapMarkers_32 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_33] == 0)
                    MapMarkers_33 = Stream.Read.MapMarker();

                if (Bitfield[(int)BitfieldIndex.MapMarkers_34] == 0)
                    MapMarkers_34 = Stream.Read.MapMarker();

            }
            
        }
    }

    public struct MapMarker
    {
        public uint? MarkerType; // SDB Table 155
        public byte[] Unk3;
        public string EncounterId;
        public string EncounterMarkerId; // No controller specified.
        public byte? HasDuration;
        public uint? ExpireAtTime; // Gametime ms
        public float[] Position;

        public MapMarker(Bitter.BinaryReader R)
        {
            MarkerType = R.UInt();
            Unk3 = R.ByteArray(6);
            EncounterId = R.Entity();
            EncounterMarkerId = R.Entity();
            HasDuration = R.Byte();
            if (HasDuration != 0x00) {
                ExpireAtTime = R.UInt();
            }
            else {
                ExpireAtTime = 0;
            }
            Position = R.HalfArray(3);
        }

        public override string ToString() => $"MarkerType: {MarkerType}, Position: [{(Position != null ? String.Join(", ", Position) : "null")}]";
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

        public static MapMarker MapMarker(this Bitter.BinaryReader R)
        {
            return new MapMarker(R);
        }

        public static MapMarker[] MapMarkerArray(this Bitter.BinaryReader R, int num)
        {
            List<MapMarker> list = new List<MapMarker>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.MapMarker());
            }
            return list.ToArray();
        }
    }
}