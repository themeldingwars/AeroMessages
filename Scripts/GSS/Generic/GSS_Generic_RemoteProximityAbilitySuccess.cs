[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Client, 251, 21, Ver: 1962)]
public partial class ServerGenericRemoteProximityAbilitySuccess : AeroBase
{
    public ulong SourceEntityGUID;
    public byte Unk;
    public uint ClientProximityCommandId;

    [AeroArray(typeof(byte))]
    public ulong[] TargetsGUIDs;

    public uint Time;
}