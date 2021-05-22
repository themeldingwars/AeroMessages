/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 0
    TypeName: Generic
    MsgId: 100
    MsgName: EncounterUIScopeIn
META_END
 */
[Aero]
public partial class Generic_Event_EncounterUIScopeIn
{
    public ulong EncounterId;

    [AeroArray(typeof(ushort))]
    public byte[] TextData; // Text keys with values inbetween or?

    [AeroArray(-1)]
    public byte[] Unk;
}