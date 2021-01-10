using Bitter;
using System.Collections.Generic;
namespace PacketPeepScript
{
    public struct SlotModuleRequest
    {
        public uint SdbId;
        public byte SlotIdx;

        public SlotModuleRequest(Bitter.BinaryReader R)
        {
            SdbId = R.UInt();
            SlotIdx = R.Byte();
        }

        public override string ToString() => $"{SdbId} -> {SlotIdx}";
    }

    public static class MyExtensions
    {
        public static SlotModuleRequest SlotModuleRequest(this Bitter.BinaryReader R)
        {
            return new SlotModuleRequest(R);
        }

        public static SlotModuleRequest[] SlotModuleRequestArray(this Bitter.BinaryReader R, int num)
        {
            List<SlotModuleRequest> list = new List<SlotModuleRequest>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.SlotModuleRequest());
            }
            return list.ToArray();
        }
    }

    [Script(MessageType.GSS, 2, 204, false)]
    public class CharacterBaseControllerSlotModuleRequest : BaseScript
    {
        public ulong ItemGUID;
        public byte NumberOfModules;
        public SlotModuleRequest[] Modules;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            ItemGUID = Stream.Read.ULong();
            NumberOfModules = Stream.Read.Byte();
            Modules = Stream.Read.SlotModuleRequestArray(NumberOfModules);
        }
    }
}