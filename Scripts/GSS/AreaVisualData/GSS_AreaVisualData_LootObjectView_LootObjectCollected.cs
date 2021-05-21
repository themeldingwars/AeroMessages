[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 24, 83, Ver: 1962)]
public partial class AreaVisualData_LootObjectView_LootObjectCollected : AeroBase
{
    [AeroArray(4)]
    public byte[] Unk;

    public ulong LootedByEntity; // Could be the opposite
    public ulong LootedToEntity; // Could be the opposite
}