using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, 24)]
    public partial class RequestResume
    {
        public EntityId Sender;
    }
}