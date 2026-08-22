using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 141)]
    public partial class UiNamedVariableUpdate
    {
        public uint Unk1;
        public float Unk2;
    }
}