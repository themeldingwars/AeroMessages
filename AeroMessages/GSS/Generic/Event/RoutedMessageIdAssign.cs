using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Events
{
    [Aero]
    public partial class RoutedMessageIdAssign
    {
        public ushort ReffId;
    }
}