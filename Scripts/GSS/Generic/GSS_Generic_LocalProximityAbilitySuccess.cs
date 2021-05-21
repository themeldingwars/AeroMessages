[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Client, 251, 20, Ver: 1962)]
public partial class ServerGenericLocalProximityAbilitySuccess : AeroBase
{
    public ulong SourceEntityGUID;
    public byte Unk;
    public uint ClientProximityCommandId;

    [AeroArray(typeof(byte))]
    public ulong[] TargetsGUIDs;

    public uint Time;
}