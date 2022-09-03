using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 131)]
    public partial class WorkbenchUpdate
    {
        public int Unk1;
        [AeroArray(typeof(byte))] public ulong[] Unk2;
    }

    [AeroBlock]
    public struct WorkbenchUpdateData
    {
        public ulong Unk1;
        public uint Unk2;
        public uint Unk3;
        public uint Unk4;
        [AeroArray(typeof(byte))] public WorkbenchUpdateInner1[] Unk5;
        public byte Unk6;
        public uint Unk7;
        [AeroArray(typeof(byte))] public WorkbenchUpdateInner2[] Unk8;
        public uint Unk9;
        public uint Unk10;
        public byte Unk11;
        public ulong Unk12;
    }

    [AeroBlock]
    public struct WorkbenchUpdateInner1
    {
        public uint Unk1;
        [AeroArray(typeof(byte))] public WorkbenchUpdateInner1_1[] Unk2;
    }

    [AeroBlock]
    public struct WorkbenchUpdateInner1_1
    {
        public uint Unk1;   
        public uint Unk2;
        public uint Unk3;
        [AeroString] public string Unk4;
    }

    [AeroBlock]
    public struct WorkbenchUpdateInner2
    {
        public uint Unk1;   
        public uint Unk2;
        public uint Unk3;
        [AeroArray(typeof(byte))] public uint[] Unk4;
    }
}