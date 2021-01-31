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

            Clear_MapMarkers_0 = 0x81,
            Clear_MapMarkers_1 = 0x82,
            Clear_MapMarkers_2 = 0x83,
            Clear_MapMarkers_3 = 0x84,
            Clear_MapMarkers_4 = 0x85,
            Clear_MapMarkers_5 = 0x86,
            Clear_MapMarkers_6 = 0x87,
            Clear_MapMarkers_7 = 0x88,
            Clear_MapMarkers_8 = 0x89,
            Clear_MapMarkers_9 = 0x8a,
            Clear_MapMarkers_10 = 0x8b,
            Clear_MapMarkers_11 = 0x8c,
            Clear_MapMarkers_12 = 0x8d,
            Clear_MapMarkers_13 = 0x8e,
            Clear_MapMarkers_14 = 0x8f,
            Clear_MapMarkers_15 = 0x90,
            Clear_MapMarkers_16 = 0x91,
            Clear_MapMarkers_17 = 0x92,
            Clear_MapMarkers_18 = 0x93,
            Clear_MapMarkers_19 = 0x94,
            Clear_MapMarkers_20 = 0x95,
            Clear_MapMarkers_21 = 0x96,
            Clear_MapMarkers_22 = 0x97,
            Clear_MapMarkers_23 = 0x98,
            Clear_MapMarkers_24 = 0x99,
            Clear_MapMarkers_25 = 0x9a,
            Clear_MapMarkers_26 = 0x9b,
            Clear_MapMarkers_27 = 0x9c,
            Clear_MapMarkers_28 = 0x9d,
            Clear_MapMarkers_29 = 0x9e,
            Clear_MapMarkers_30 = 0x9f,
            Clear_MapMarkers_31 = 0xa0,
            Clear_MapMarkers_32 = 0xa1,
            Clear_MapMarkers_33 = 0xa2,
            Clear_MapMarkers_34 = 0xa3,
        }

        public string PeepWarning; // Will be set if we encounter an unhandled shadowfield

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

        public bool? Clear_MapMarkers_0;
        public bool? Clear_MapMarkers_1;
        public bool? Clear_MapMarkers_2;
        public bool? Clear_MapMarkers_3;
        public bool? Clear_MapMarkers_4;
        public bool? Clear_MapMarkers_5;
        public bool? Clear_MapMarkers_6;
        public bool? Clear_MapMarkers_7;
        public bool? Clear_MapMarkers_8;
        public bool? Clear_MapMarkers_9;
        public bool? Clear_MapMarkers_10;
        public bool? Clear_MapMarkers_11;
        public bool? Clear_MapMarkers_12;
        public bool? Clear_MapMarkers_13;
        public bool? Clear_MapMarkers_14;
        public bool? Clear_MapMarkers_15;
        public bool? Clear_MapMarkers_16;
        public bool? Clear_MapMarkers_17;
        public bool? Clear_MapMarkers_18;
        public bool? Clear_MapMarkers_19;
        public bool? Clear_MapMarkers_20;
        public bool? Clear_MapMarkers_21;
        public bool? Clear_MapMarkers_22;
        public bool? Clear_MapMarkers_23;
        public bool? Clear_MapMarkers_24;
        public bool? Clear_MapMarkers_25;
        public bool? Clear_MapMarkers_26;
        public bool? Clear_MapMarkers_27;
        public bool? Clear_MapMarkers_28;
        public bool? Clear_MapMarkers_29;
        public bool? Clear_MapMarkers_30;
        public bool? Clear_MapMarkers_31;
        public bool? Clear_MapMarkers_32;
        public bool? Clear_MapMarkers_33;
        public bool? Clear_MapMarkers_34;

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
                        MapMarkers_0 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_1:
                        MapMarkers_1 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_2:
                        MapMarkers_2 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_3:
                        MapMarkers_3 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_4:
                        MapMarkers_4 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_5:
                        MapMarkers_5 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_6:
                        MapMarkers_6 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_7:
                        MapMarkers_7 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_8:
                        MapMarkers_8 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_9:
                        MapMarkers_9 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_10:
                        MapMarkers_10 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_11:
                        MapMarkers_11 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_12:
                        MapMarkers_12 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_13:
                        MapMarkers_13 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_14:
                        MapMarkers_14 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_15:
                        MapMarkers_15 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_16:
                        MapMarkers_16 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_17:
                        MapMarkers_17 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_18:
                        MapMarkers_18 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_19:
                        MapMarkers_19 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_20:
                        MapMarkers_20 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_21:
                        MapMarkers_21 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_22:
                        MapMarkers_22 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_23:
                        MapMarkers_23 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_24:
                        MapMarkers_24 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_25:
                        MapMarkers_25 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_26:
                        MapMarkers_26 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_27:
                        MapMarkers_27 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_28:
                        MapMarkers_28 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_29:
                        MapMarkers_29 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_30:
                        MapMarkers_30 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_31:
                        MapMarkers_31 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_32:
                        MapMarkers_32 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_33:
                        MapMarkers_33 = Stream.Read.MapMarker();
                        break;
                    case ShadowFieldIndex.MapMarkers_34:
                        MapMarkers_34 = Stream.Read.MapMarker();
                        break;

                    case ShadowFieldIndex.Clear_MapMarkers_0:
                        Clear_MapMarkers_0 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_1:
                        Clear_MapMarkers_1 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_2:
                        Clear_MapMarkers_2 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_3:
                        Clear_MapMarkers_3 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_4:
                        Clear_MapMarkers_4 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_5:
                        Clear_MapMarkers_5 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_6:
                        Clear_MapMarkers_6 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_7:
                        Clear_MapMarkers_7 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_8:
                        Clear_MapMarkers_8 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_9:
                        Clear_MapMarkers_9 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_10:
                        Clear_MapMarkers_10 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_11:
                        Clear_MapMarkers_11 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_12:
                        Clear_MapMarkers_12 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_13:
                        Clear_MapMarkers_13 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_14:
                        Clear_MapMarkers_14 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_15:
                        Clear_MapMarkers_15 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_16:
                        Clear_MapMarkers_16 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_17:
                        Clear_MapMarkers_17 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_18:
                        Clear_MapMarkers_18 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_19:
                        Clear_MapMarkers_19 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_20:
                        Clear_MapMarkers_20 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_21:
                        Clear_MapMarkers_21 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_22:
                        Clear_MapMarkers_22 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_23:
                        Clear_MapMarkers_23 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_24:
                        Clear_MapMarkers_24 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_25:
                        Clear_MapMarkers_25 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_26:
                        Clear_MapMarkers_26 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_27:
                        Clear_MapMarkers_27 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_28:
                        Clear_MapMarkers_28 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_29:
                        Clear_MapMarkers_29 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_30:
                        Clear_MapMarkers_30 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_31:
                        Clear_MapMarkers_31 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_32:
                        Clear_MapMarkers_32 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_33:
                        Clear_MapMarkers_33 = true;
                        break;
                    case ShadowFieldIndex.Clear_MapMarkers_34:
                        Clear_MapMarkers_34 = true;
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

        public override string ToString() => $"MarkerType: {MarkerType}, Position: [{(Position != null ? String.Join(", ", Position) : "null")}], EncounterId: {EncounterId}, EncounterMarkerId: {EncounterMarkerId},{(HasDuration != 0 ? $" ExpireAtTime: {ExpireAtTime}," : "")} Unk3: [{(Unk3 != null ? String.Join(", ", Unk3) : "null")}],";
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