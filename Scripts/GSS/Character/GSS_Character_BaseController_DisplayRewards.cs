using Bitter;
using System.Collections.Generic;
namespace PacketPeepScript
{
    public struct StatInfo
    {
        public uint LocalizationId;
        public byte[] Unk;

        public StatInfo(Bitter.BinaryReader R)
        {
            LocalizationId = R.UInt();
            Unk = R.ByteArray(6);
        }

        public override string ToString() => $"{LocalizationId}";
    }

    public struct RewardInfo
    {
        public uint SdbId;
        public ushort Quantity;
        public ushort Unk1;
        public byte[] Unk2;

        public RewardInfo(Bitter.BinaryReader R)
        {
            SdbId = R.UInt();
            Quantity = R.UShort();
            Unk1 = R.UShort();
            Unk2 = R.ByteArray(11);
        }

        public override string ToString() => $"{SdbId} x{Quantity} {(Unk1 != 0 ?  $"(Unk1: {Unk1})" : "")}";
    }

    public static class MyExtensions
    {
        public static StatInfo StatInfo(this Bitter.BinaryReader R)
        {
            return new StatInfo(R);
        }

        public static StatInfo[] StatInfoArray(this Bitter.BinaryReader R, int num)
        {
            List<StatInfo> list = new List<StatInfo>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.StatInfo());
            }
            return list.ToArray();
        }

        public static RewardInfo RewardInfo(this Bitter.BinaryReader R)
        {
            return new RewardInfo(R);
        }

        public static RewardInfo[] RewardInfoArray(this Bitter.BinaryReader R, int num)
        {
            List<RewardInfo> list = new List<RewardInfo>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.RewardInfo());
            }
            return list.ToArray();
        }
    }

    [Script(MessageType.GSS, 2, 133, true)]
    public class CharacterBaseControllerDisplayRewards : BaseScript
    {
        public uint IndexId; // Used by client when claiming
        public uint TitleLocalizationId;
        public byte[] Unk1;
        public byte NumberOfStats;
        public StatInfo[] Stats;
        public byte NumberOfRewards;
        public RewardInfo[] Rewards;
        public byte[] Unk2;
        public byte HaveExperience;
        public uint Experience;
        public byte[] Unk3;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            IndexId = Stream.Read.UInt();
            TitleLocalizationId = Stream.Read.UInt();
            Unk1 = Stream.Read.ByteArray(4);
            NumberOfStats = Stream.Read.Byte();
            Stats = Stream.Read.StatInfoArray(NumberOfStats);
            NumberOfRewards = Stream.Read.Byte();
            Rewards = Stream.Read.RewardInfoArray(NumberOfRewards);
            Unk2 = Stream.Read.ByteArray(9);
            HaveExperience = Stream.Read.Byte();
            Experience = Stream.Read.UInt();
            Unk3 = Stream.Read.ByteArray(3);
        }
    }
}