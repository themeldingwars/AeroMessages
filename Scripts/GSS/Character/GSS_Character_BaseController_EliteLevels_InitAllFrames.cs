using Bitter;
using System;
using System.Collections.Generic;
namespace PacketPeepScript
{
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

    public struct FrameInfo
    {
        public uint ChassisId_1;
        public uint ChassisId_2;
        public uint EliteRank;
        public uint EliteXP;
        public uint ElitePoints;
        public byte NumberOfAvailableUpgrades;
        public AvailableUpgradeInfo[] AvailableUpgrades;
        public byte NumberOfPreviousUpgrades;
        public PreviousUpgradeInfo[] PreviousUpgrades;

        public FrameInfo(Bitter.BinaryReader Read)
        {
            ChassisId_1 = Read.UInt();
            ChassisId_2 = Read.UInt();
            EliteRank = Read.UInt();
            EliteXP = Read.UInt();
            ElitePoints = Read.UInt();
            NumberOfAvailableUpgrades = Read.Byte();
            AvailableUpgrades = Read.AvailableUpgradeInfoArray((int)NumberOfAvailableUpgrades);
            NumberOfPreviousUpgrades = Read.Byte();
            PreviousUpgrades = Read.PreviousUpgradeInfoArray((int)NumberOfPreviousUpgrades);
        }

        public override string ToString() => $"Frame: {ChassisId_1}, Rank: {EliteRank}, XP: {EliteXP}, Points: {ElitePoints}, AvailableUpgrades: [{(AvailableUpgrades != null ? String.Join(", ", AvailableUpgrades) : "null")}], PreviousUpgrades: [{(PreviousUpgrades != null ? String.Join(", ", PreviousUpgrades) : "null")}]";
    }

    public struct AvailableUpgradeInfo
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

        public AvailableUpgradeInfo(Bitter.BinaryReader Read)
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

        public override string ToString() => $"(Id: {UpgradeId}, Unk_1: {Unk_1}, StatValue: {StatValue} Name: {LocalizationId}, AdditionalInfo [{(AdditionalInfo != null ? String.Join(", ", AdditionalInfo) : "null")}])";
    }

    public struct PreviousUpgradeInfo
    {
        public uint UpgradeId;
        public uint Count;

        public PreviousUpgradeInfo(Bitter.BinaryReader Read)
        {
            UpgradeId = Read.UInt();
            Count = Read.UInt();
        }

        public override string ToString() => $"(Id: {UpgradeId}, Count: {Count})";
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

        public static AvailableUpgradeInfo AvailableUpgradeInfo(this Bitter.BinaryReader R)
        {
            return new AvailableUpgradeInfo(R);
        }

        public static AvailableUpgradeInfo[] AvailableUpgradeInfoArray(this Bitter.BinaryReader R, int num)
        {
            List<AvailableUpgradeInfo> list = new List<AvailableUpgradeInfo>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.AvailableUpgradeInfo());
            }
            return list.ToArray();
        }

        public static PreviousUpgradeInfo PreviousUpgradeInfo(this Bitter.BinaryReader R)
        {
            return new PreviousUpgradeInfo(R);
        }

        public static PreviousUpgradeInfo[] PreviousUpgradeInfoArray(this Bitter.BinaryReader R, int num)
        {
            List<PreviousUpgradeInfo> list = new List<PreviousUpgradeInfo>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.PreviousUpgradeInfo());
            }
            return list.ToArray();
        }
    }
}
