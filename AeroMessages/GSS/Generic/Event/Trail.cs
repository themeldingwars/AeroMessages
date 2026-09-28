using Aero.Gen.Attributes;
using Aero.Protocol;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.Trail, GssVersion.V1, GssVersion.V74)]
    public partial class Trail
    {
        public uint Id; // TrailRequest.Id
        public TrailStatus Status;

        [AeroArray(typeof(byte))]
        public Vector3[] Points;
    }

    public enum TrailStatus : byte
    {
        Complete = 0,     // replaces the points
        Continuation = 1, // continues the path already shown, the trail fails if the points don't connect
        Failed = 2,       // no path, sent without points
    }
}