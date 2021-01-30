using Bitter;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 45, 1, true)]
    public class OutpostObserverViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            OutpostName            = 0x00,
            Position               = 0x01,
            LevelBandId            = 0x02,
            SinUnlockIndex         = 0x03,
            TeleportCost           = 0x04,
            Dynamic_00             = 0x05,
            Dynamic_01             = 0x06,
            Dynamic_02             = 0x07,
            Dynamic_03             = 0x08,
            Dynamic_04             = 0x09,
            Dynamic_05             = 0x0a,
            Dynamic_06             = 0x0b,
            Dynamic_07             = 0x0c,
            Dynamic_08             = 0x0d,
            Dynamic_09             = 0x0e,
            Dynamic_10             = 0x0f,
            Dynamic_11             = 0x10,
            NearbyResourceItems_0  = 0x11,
            NearbyResourceItems_1  = 0x12,
            NearbyResourceItems_2  = 0x13,
            NearbyResourceItems_3  = 0x14,
            NearbyResourceItems_4  = 0x15,
            NearbyResourceItems_5  = 0x16,
            NearbyResourceItems_6  = 0x17,
            NearbyResourceItems_7  = 0x18,
            NearbyResourceItems_8  = 0x19,
            NearbyResourceItems_9  = 0x1a,
            NearbyResourceItems_10 = 0x1b,
            NearbyResourceItems_11 = 0x1c,
            NearbyResourceItems_12 = 0x1d,
            NearbyResourceItems_13 = 0x1e,
            NearbyResourceItems_14 = 0x1f,
            NearbyResourceItems_15 = 0x20,
            EncounterId            = 0x21,
            ScopeBubbleInfo        = 0x22,
        }

        public string PeepWarning; // Will be set if we encounter an unhandled shadowfield

        public byte? Dynamic_01;
        public byte? Dynamic_03;

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
                    case ShadowFieldIndex.Dynamic_01:
                        Dynamic_01 = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.Dynamic_03:
                        Dynamic_03 = Stream.Read.Byte();
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