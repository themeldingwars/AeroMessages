using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.DebugEncounterVolumes, GssVersion.V1, GssVersion.V67)]
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