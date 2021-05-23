/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 0
    TypeName: Generic
    MsgId: 91
    MsgName: InteractableStatusChanged
META_END
 */
using Aero.Gen.Attributes;
using AeroMessages.Common;
namespace AeroMessages.GSS.Generic
{
    [Aero]
    public partial class Generic_Event_InteractableStatusChanged
    {
        public EntityId Target;

        [AeroArray(5)]
        public byte[] Unk;

        public byte Interactable;
    }
}