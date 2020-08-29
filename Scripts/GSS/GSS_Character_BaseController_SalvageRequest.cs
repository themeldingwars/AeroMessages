using Bitter;
using System.Collections.Generic;
namespace PacketPeepScript
{
    public struct ItemSalvageRequest
    {
        public ulong GUID;
        public uint SdbId;
        public uint Quantity; // (Needed when stackables like modules are salvaged in bulk)

        public ItemSalvageRequest(Bitter.BinaryReader R)
        {
            GUID = R.ULong();
            SdbId = R.UInt();
            Quantity = R.UInt();
        }

        public override string ToString() => $"{(GUID != 0 ?  $"GUID: {GUID}, " : "")}SdbId: {SdbId}, Quantity: {Quantity}";
    }

    public static class MyExtensions
    {
        public static ItemSalvageRequest ItemSalvageRequest(this Bitter.BinaryReader R)
        {
            return new ItemSalvageRequest(R);
        }

        public static ItemSalvageRequest[] ItemSalvageRequestArray(this Bitter.BinaryReader R, int num)
        {
            List<ItemSalvageRequest> list = new List<ItemSalvageRequest>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.ItemSalvageRequest());
            }
            return list.ToArray();
        }
    }

    [Script(MessageType.GSS, 2, 202, false)]
    public class CharacterBaseControllerSalvageRequest : BaseScript
    {
        public byte NumberOfItems;
        public ItemSalvageRequest[] SalvageRequests;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            NumberOfItems = Stream.Read.Byte();
            SalvageRequests = Stream.Read.ItemSalvageRequestArray(NumberOfItems);
        }
    }
}