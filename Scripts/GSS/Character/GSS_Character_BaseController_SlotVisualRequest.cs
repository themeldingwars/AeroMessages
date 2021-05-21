[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Client, 2, 207, Ver: 1962)]
public partial class CharacterBaseControllerSlotVisualRequest : AeroBase
{
    public uint LoadoutId;

    [AeroSDB("dbitems::RootItem", "sdb_id")]
    public uint ItemSdbId;

    public byte SlotIdx1; // ?
    public byte SlotIdx2; // ?

    [AeroArray(9)]
    public byte[] Unk;
}