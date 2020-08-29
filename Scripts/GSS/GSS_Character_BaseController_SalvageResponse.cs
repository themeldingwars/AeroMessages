using Bitter;
using System.Collections.Generic;
namespace PacketPeepScript
{

    public struct ItemSalvageResponse
    {
        public ulong GUID;
        public uint SdbId;
        public uint Quantity;

        public ItemSalvageResponse(Bitter.BinaryReader R)
        {
            GUID = R.ULong();
            SdbId = R.UInt();
            Quantity = R.UInt();
        }

        public override string ToString() => $"{(GUID != 0 ?  $"GUID: {GUID}, " : "")}SdbId: {SdbId}, Quantity: {Quantity}";
    }

    public static class MyExtensions
    {
        public static ItemSalvageResponse ItemSalvageResponse(this Bitter.BinaryReader R)
        {
            return new ItemSalvageResponse(R);
        }

        public static ItemSalvageResponse[] ItemSalvageResponseArray(this Bitter.BinaryReader R, int num)
        {
            List<ItemSalvageResponse> list = new List<ItemSalvageResponse>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.ItemSalvageResponse());
            }
            return list.ToArray();
        }
    }

    [Script(MessageType.GSS, 2, 150, true)]
    public class CharacterBaseControllerSalvageResponse : BaseScript
    {
        // Added script so that peep doesn't display the wrong stuff  

        public byte Unk1;
        public byte NumberOfItems;
        public ItemSalvageResponse[] SalvageResponses;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk1 = Stream.Read.Byte();
            NumberOfItems = Stream.Read.Byte();
            SalvageResponses = Stream.Read.ItemSalvageResponseArray(NumberOfItems);
        }
    }
}