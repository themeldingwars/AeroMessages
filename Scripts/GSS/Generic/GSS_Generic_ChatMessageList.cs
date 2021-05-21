[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 0, 118, Ver: 1962)]
public partial class GenericChatMessageList : AeroBase
{
    public byte Unk1;
    public ulong SenderGUID;

    [AeroNullTermString]
    public string SenderName;

    [AeroNullTermString]
    public string Message;

    public byte Channel;
}