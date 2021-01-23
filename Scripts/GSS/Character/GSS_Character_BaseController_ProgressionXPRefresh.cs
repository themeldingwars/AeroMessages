using System.Collections.Generic;
using System;
using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 89, true)]
    public class CharacterBaseControllerProgressionXPRefresh : BaseScript
    {
        public byte NumFrames;
        public FrameInfo[] Frames;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            NumFrames = Stream.Read.Byte();
            Frames = Stream.Read.FrameInfoArray(NumFrames);
        }
    }
    
    public struct FrameInfo
    {
        public uint ChassisID;
        public uint XpValue1;
        public uint XpValue2;
        public byte CurrentLevel;
        public byte[] Unk;
        
        
        public FrameInfo(Bitter.BinaryReader Read)
        {
            ChassisID = Read.UInt();
            XpValue1 = Read.UInt();
            XpValue2 = Read.UInt();
            CurrentLevel = Read.Byte();
            Unk = Read.ByteArray(7);
        }
        
        public override string ToString() => $"Chassis: {ChassisID}, Level: {CurrentLevel}, CurrentXP: {XpValue1}, MaximumXP: {XpValue2}, Unk [{(Unk != null ? String.Join(", ", Unk) : "null")}]";
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
    }
}