using Bitter;
using System;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 22, 1, true)]
    public class AreaVisualDataMapMarkerViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            Position = 0x00,
            MapMarkers_0 = 0x01,
            MapMarkers_1 = 0x02,
            MapMarkers_2 = 0x03,
            MapMarkers_3 = 0x04,
            MapMarkers_4 = 0x05,
            MapMarkers_5 = 0x06,
            MapMarkers_6 = 0x07,
            MapMarkers_7 = 0x08,
            MapMarkers_8 = 0x09,
            MapMarkers_9 = 0x0a,
            MapMarkers_10 = 0x0b,
            MapMarkers_11 = 0x0c,
            MapMarkers_12 = 0x0d,
            MapMarkers_13 = 0x0e,
            MapMarkers_14 = 0x0f,
            MapMarkers_15 = 0x10,
            MapMarkers_16 = 0x11,
            MapMarkers_17 = 0x12,
            MapMarkers_18 = 0x13,
            MapMarkers_19 = 0x14,
            MapMarkers_20 = 0x15,
            MapMarkers_21 = 0x16,
            MapMarkers_22 = 0x17,
            MapMarkers_23 = 0x18,
            MapMarkers_24 = 0x19,
            MapMarkers_25 = 0x1a,
            MapMarkers_26 = 0x1b,
            MapMarkers_27 = 0x1c,
            MapMarkers_28 = 0x1d,
            MapMarkers_29 = 0x1e,
            MapMarkers_30 = 0x1f,
            MapMarkers_31 = 0x20,
            MapMarkers_32 = 0x21,
            MapMarkers_33 = 0x22,
            MapMarkers_34 = 0x23,
        }

        public string PeepWarning; // Will be set if we encounter an unhandled shadowfield

        public float[] Position; // Used if the marker position is 0.

        public MapMarkersData? MapMarkers_0;
        public MapMarkersData? MapMarkers_1;
        public MapMarkersData? MapMarkers_2;
        public MapMarkersData? MapMarkers_3;
        public MapMarkersData? MapMarkers_4;
        public MapMarkersData? MapMarkers_5;
        public MapMarkersData? MapMarkers_6;
        public MapMarkersData? MapMarkers_7;
        public MapMarkersData? MapMarkers_8;
        public MapMarkersData? MapMarkers_9;
        public MapMarkersData? MapMarkers_10;
        public MapMarkersData? MapMarkers_11;
        public MapMarkersData? MapMarkers_12;
        public MapMarkersData? MapMarkers_13;
        public MapMarkersData? MapMarkers_14;
        public MapMarkersData? MapMarkers_15;
        public MapMarkersData? MapMarkers_16;
        public MapMarkersData? MapMarkers_17;
        public MapMarkersData? MapMarkers_18;
        public MapMarkersData? MapMarkers_19;
        public MapMarkersData? MapMarkers_20;
        public MapMarkersData? MapMarkers_21;
        public MapMarkersData? MapMarkers_22;
        public MapMarkersData? MapMarkers_23;
        public MapMarkersData? MapMarkers_24;
        public MapMarkersData? MapMarkers_25;
        public MapMarkersData? MapMarkers_26;
        public MapMarkersData? MapMarkers_27;
        public MapMarkersData? MapMarkers_28;
        public MapMarkersData? MapMarkers_29;
        public MapMarkersData? MapMarkers_30;
        public MapMarkersData? MapMarkers_31;
        public MapMarkersData? MapMarkers_32;
        public MapMarkersData? MapMarkers_33;
        public MapMarkersData? MapMarkers_34;

        public byte[] UnableToParse;
        



        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.Stream = Stream;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.MapMarkers_0:
                        MapMarkers_0 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_1:
                        MapMarkers_1 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_2:
                        MapMarkers_2 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_3:
                        MapMarkers_3 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_4:
                        MapMarkers_4 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_5:
                        MapMarkers_5 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_6:
                        MapMarkers_6 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_7:
                        MapMarkers_7 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_8:
                        MapMarkers_8 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_9:
                        MapMarkers_9 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_10:
                        MapMarkers_10 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_11:
                        MapMarkers_11 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_12:
                        MapMarkers_12 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_13:
                        MapMarkers_13 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_14:
                        MapMarkers_14 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_15:
                        MapMarkers_15 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_16:
                        MapMarkers_16 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_17:
                        MapMarkers_17 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_18:
                        MapMarkers_18 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_19:
                        MapMarkers_19 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_20:
                        MapMarkers_20 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_21:
                        MapMarkers_21 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_22:
                        MapMarkers_22 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_23:
                        MapMarkers_23 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_24:
                        MapMarkers_24 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_25:
                        MapMarkers_25 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_26:
                        MapMarkers_26 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_27:
                        MapMarkers_27 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_28:
                        MapMarkers_28 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_29:
                        MapMarkers_29 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_30:
                        MapMarkers_30 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_31:
                        MapMarkers_31 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_32:
                        MapMarkers_32 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_33:
                        MapMarkers_33 = Stream.Read.MapMarkersData();
                        break;
                    case ShadowFieldIndex.MapMarkers_34:
                        MapMarkers_34 = Stream.Read.MapMarkersData();
                        break;

                    default:
                        PeepWarning += $"Dont know how to parse shadowfield {sfidx}";
                        int remaining = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
                        UnableToParse = Stream.Read.ByteArray(remaining);
                        break;
                }
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);
        }
    }

    // Assuming same format as in keyframe
    public struct MapMarkersData
    {
        public uint? MarkerType; // SDB Table 155
        public byte[] Unk3;
        public string EncounterId;
        public string EncounterMarkerId; // No controller specified.
        public byte? HasDuration;
        public uint? ExpireAtTime; // Gametime ms
        public float[] Position;

        public MapMarkersData(Bitter.BinaryReader R)
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

        public static MapMarkersData MapMarkersData(this Bitter.BinaryReader R)
        {
            return new MapMarkersData(R);
        }

        public static MapMarkersData[] MapMarkersDataArray(this Bitter.BinaryReader R, int num)
        {
            List<MapMarkersData> list = new List<MapMarkersData>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.MapMarkersData());
            }
            return list.ToArray();
        }
    }
}