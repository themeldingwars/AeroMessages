using Bitter;
using System;
using System.Collections.Generic;
namespace PacketPeepScript
{

    public struct FrameInfo
    {
        public uint ChassisId_1;
        public uint ChassisId_2;
        public uint EliteRank;
        public uint EliteXP;
        public uint ElitePoints;
        public byte NumberOfUpgrades;
        public UpgradeInfo[] Upgrades;
        public byte UnkByte;

        public FrameInfo(Bitter.BinaryReader Read)
        {
            ChassisId_1 = Read.UInt();
            ChassisId_2 = Read.UInt();
            EliteRank = Read.UInt();
            EliteXP = Read.UInt();
            ElitePoints = Read.UInt();
            NumberOfUpgrades = Read.Byte();
            Upgrades = Read.UpgradeInfoArray((int)NumberOfUpgrades);
            UnkByte = Read.Byte();
        }

        public override string ToString() => $"Frame: {ChassisId_1}, Rank: {EliteRank}, XP: {EliteXP}, Points: {ElitePoints}, Upgrades: [{(Upgrades != null ? String.Join(", ", Upgrades) : "null")}], UnkByte: {UnkByte}";
    }

    public struct UpgradeInfo
    {
        public uint UpgradeId;
        public uint Unk_1;
        public float StatValue;

        public byte AdditionalInfoCount;
        public uint[] AdditionalInfo;
        //public uint? Count;
        //public uint? ItemSDBId;
        //public uint[] Unk_AdditionalInfo;

        public uint LocalizationId;

        public UpgradeInfo(Bitter.BinaryReader Read)
        {
            UpgradeId = Read.UInt();
            Unk_1 = Read.UInt();
            StatValue = Read.Float();

            AdditionalInfoCount = Read.Byte();
            AdditionalInfo = Read.UIntArray((int)AdditionalInfoCount);
            /*
            if (AdditionalInfoCount > 0)
            {
                if (AdditionalInfoCount >= 1)
                {
                    Count = Read.UInt();
                }
                if (AdditionalInfoCount >= 2)
                {
                    ItemSDBId = Read.UInt();
                }
                if (AdditionalInfoCount >= 3)
                {
                    Unk_AdditionalInfo = Read.UIntArray((int)AdditionalInfoCount-2);
                }
            }
            */
            LocalizationId = Read.UInt();
        }

        public override string ToString() => $"(Id: {UpgradeId}, Name: {LocalizationId})";
    }

    [Script(MessageType.GSS, 2, 186, true)]
    public class CharacterBaseControllerEliteLevelsInitAllFrames : BaseScript
    {
        public uint CurrentFrame_Id; 

        public byte NumberOfFrames;
        public FrameInfo[] Frames;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            if (true) {
                CurrentFrame_Id = Stream.Read.UInt();
                NumberOfFrames = Stream.Read.Byte();
                Frames = Stream.Read.FrameInfoArray((int)NumberOfFrames);
            }
        }
    }

    public static class MyExtensions
    {
        public static FrameInfo FrameInfo(this Bitter.BinaryReader R)
        {
            return new FrameInfo(R);
        }

        public static FrameInfo[] FrameInfoArray(this Bitter.BinaryReader R, int num)
        {
            List<FrameInfo> list = new List<FrameInfo>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.FrameInfo());
            }
            return list.ToArray();
        }

        public static UpgradeInfo UpgradeInfo(this Bitter.BinaryReader R)
        {
            return new UpgradeInfo(R);
        }

        public static UpgradeInfo[] UpgradeInfoArray(this Bitter.BinaryReader R, int num)
        {
            List<UpgradeInfo> list = new List<UpgradeInfo>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.UpgradeInfo());
            }
            return list.ToArray();
        }
    }
}
