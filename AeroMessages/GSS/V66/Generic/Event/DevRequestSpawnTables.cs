using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
using AeroMessages.Common;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 62)]
    public partial class DevRequestSpawnTables
    {
        [AeroArray(typeof(byte))] public DevReqSpawnTableData[] Unk;
    }

    [AeroBlock]
    public struct DevReqSpawnTableData
    {
        [AeroString] public string Unk1;
        public uint Unk2;
        public uint Unk3;
        public uint Unk4;
        public float Unk5; // Type doesn't seem to be uint
        public float Unk6; // Type doesn't seem to be uint
        public byte Unk7;
        [AeroString] public string Unk8;
    }
}