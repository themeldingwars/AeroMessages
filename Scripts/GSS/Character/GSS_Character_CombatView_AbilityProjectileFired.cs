using Bitter;
using System;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 11, 96, true)]
    public class CharacterCombatViewAbilityProjectileFired : BaseScript
    {
        public ushort ShortTime;
        public ushort[] PackedUnk; // Could be a ruse, if not, what vector would this be???
        public float[] UnpackedUnk;
        public ushort[] PackedAim; // Confirmed that this second one is the aim
        public float[] Aim;
        public ushort AmmoType; // Definition in Sdb table 120, references from table 238
        public float Range; // Value is found in fireprojcdef table 238

        public byte[] Unk1;
        public ushort Hardpoint;

        public byte[] Unk5;

        public byte UnkFlag;
        public string UnkFlaggedEntity;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.Stream = Stream;

            if (true)
            {
                ShortTime = Stream.Read.UShort();
                PackedUnk = Stream.Read.UShortArray(3);
                UnpackedUnk = UnpackFloatArray(PackedUnk);
                PackedAim = Stream.Read.UShortArray(3);
                Aim = UnpackFloatArray(PackedAim);
                AmmoType = Stream.Read.UShort();
                Range = Stream.Read.Float();

                Unk1 = Stream.Read.ByteArray(14);

                Hardpoint = Stream.Read.UShort();

                Unk5 = Stream.Read.ByteArray(2);

                UnkFlag = Stream.Read.Byte();
                if (UnkFlag > 0)
                {
                    UnkFlaggedEntity = Stream.Read.Entity();
                }
            }
        }
        
        // Util funcs to handle floats packed as ushort
        private float UnpackFloat(ushort val)
        {
            float result = (1.0f / 32767f) * val;
            if (result >= 0) {
                result = (result -1f) * -1f; 
            }
            return result;
        }
        private float[] UnpackFloatArray(ushort[] arr)
        {
            return Array.ConvertAll(arr, val => UnpackFloat(val));
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