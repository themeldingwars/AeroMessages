using Bitter;
using System;
using System.Collections.Generic;
namespace PacketPeepScript
{
    public struct PointData
    {
        public float[] Position;

        public PointData(Bitter.BinaryReader R)
        {
            Position = R.FloatArray(3);
        }

        public override string ToString() => $"{(Position != null ? String.Join(", ", Position) : "null")}";
    }

    public static class MyExtensions
    {
        public static PointData PointData(this Bitter.BinaryReader R)
        {
            return new PointData(R);
        }

        public static PointData[] PointDataArray(this Bitter.BinaryReader R, int num)
        {
            List<PointData> list = new List<PointData>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.PointData());
            }
            return list.ToArray();
        }
    }

    [Script(MessageType.GSS, 0, 98, true)]
    public class GenericTrail : BaseScript
    {

        public byte[] Unk;
        public byte NumberOfPoints;
        public PointData[] PointData;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
    
            Unk = Stream.Read.ByteArray(5);
            NumberOfPoints = Stream.Read.Byte();
            PointData = Stream.Read.PointDataArray(NumberOfPoints);

        }
    }
}