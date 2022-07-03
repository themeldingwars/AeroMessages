using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.View
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 12, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 12, 3)]
    public partial class MovementView
    {
        private MovementData Movement;
    }
}