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
[Aero]
public partial class Generic_Event_InteractableStatusChanged
{
    public ulong EntityGUID;

    [AeroArray(5)]
    public byte[] Unk;

    public byte Interactable;
}