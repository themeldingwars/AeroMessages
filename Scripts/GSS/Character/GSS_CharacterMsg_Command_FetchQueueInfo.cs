/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 89
    MsgName: FetchQueueInfo
META_END
 */
[Aero]
public partial class Character_Command_FetchQueueInfo
{
    [AeroArray(typeof(byte))]
    [AeroString]
    public string[] Keys;

    [AeroArray(12)]
    public byte[] Unk;
}