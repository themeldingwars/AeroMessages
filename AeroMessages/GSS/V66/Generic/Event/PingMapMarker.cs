using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 111)]
    public partial class PingMapMarker
    {   
        public ulong EncounterMarkerId; // Marker guid?
        public uint Type;
    }
}