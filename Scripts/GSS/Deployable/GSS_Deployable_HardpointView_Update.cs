using Bitter;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 37, 1, true)]
    public class DeployableHardpointViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            HardpointChildType = 0x00,
            HardpointChildId = 0x01,
        }

        public string PeepWarning; // Will be set if we encounter an unhandled shadowfield

        public uint HardpointChildType; // DeployableTypeId Of the selected deployable
        public byte HardpointChildId_HaveEntity;
        public string HardpointChildId_Entity;

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
                    case ShadowFieldIndex.HardpointChildType:
                        HardpointChildType = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.HardpointChildId:
                        HardpointChildId_HaveEntity = Stream.Read.Byte();
                        if (HardpointChildId_HaveEntity > 0x00) {
                            HardpointChildId_Entity = Stream.Read.Entity();
                        }
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