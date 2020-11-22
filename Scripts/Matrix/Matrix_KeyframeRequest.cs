using Bitter;
using System.Collections.Generic;
using System;
namespace PacketPeepScript
{
    [Script(MessageType.Matrix, 20)]
    public class KeyframeRequest : BaseScript
    {
        public byte HaveRequestByEntityID;
        public byte NumRequestsByEntityID;
        public RequestByEntity[] EntityRequests;
        public byte HaveRequestByRefID;
        public byte NumRequestByRefID;
        public ushort[] RefRequests;

        public override void Read(Bitter.BinaryStream Stream)
        {
           Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            
            HaveRequestByEntityID = Stream.Read.Byte();
            if (HaveRequestByEntityID == 1)
            {
                NumRequestsByEntityID = Stream.Read.Byte();
                EntityRequests = Stream.Read.EntityRequestArray(NumRequestsByEntityID);
            }

            HaveRequestByRefID = Stream.Read.Byte();
            if (HaveRequestByRefID == 1)
            {
                NumRequestByRefID = Stream.Read.Byte();
                RefRequests = Stream.Read.UShortArray(NumRequestByRefID);
            }
        }
    }

    public static class MyExtensions
    {
        public static RequestByEntity[] EntityRequestArray(this Bitter.BinaryReader R, int num)
        {
            List<RequestByEntity> list = new List<RequestByEntity>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(new RequestByEntity(R));
            }
            return list.ToArray();
        }
    }

    public struct RequestByEntity
    {
        public byte ControllerID;
        public byte[] EntityID;
        public ushort RefID;
        public byte Unk2;
        public uint Checksum;

        public RequestByEntity(Bitter.BinaryReader R)
        {
            ControllerID = R.Byte();
            EntityID     = R.ByteArray(7);
            RefID        = R.UShort();
            Unk2         = R.Byte();
            Checksum     = R.UInt();
        }

        public override string ToString() => $"Ctrl: {ControllerID}, Ent: [{String.Join(", ", EntityID)}], Ref: {RefID}, Unk: {Unk2}, Checksum: {Checksum}";
    }
}