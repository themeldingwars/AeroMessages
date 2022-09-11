using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
using AeroMessages.Common;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 97)]
    public partial class DebugEncounterVolumes
    {
        [AeroArray(typeof(byte))] public DbgVol1 Unk1;
        [AeroArray(typeof(byte))] public DbgVol2 Unk2;
        [AeroArray(typeof(byte))] public DbgVol2 Unk3;
        [AeroArray(typeof(byte))] public DbgVol3 Unk4;
    }

    [AeroBlock]
    public struct DbgVol1
    {
        [AeroArray(4)] public Vector4 Unk;
    }

    [AeroBlock]
    public struct DbgVol2
    {
        [AeroArray(4)] public Vector4 Unk;
    }

    [AeroBlock]
    public struct DbgVol3
    {
        [AeroString] public string Unk1;
        [AeroArray(4)] public Vector4 Unk2;
    }
}