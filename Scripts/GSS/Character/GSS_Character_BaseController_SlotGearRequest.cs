[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Client, 2, 206, Ver: 1962)]
public partial class CharacterBaseControllerSlotGearRequest : AeroBase
{
    public uint LoadoutId;
    public ulong ItemGUID;

    [AeroSDB("dbitems::LoadoutSlot", "id")]
    public byte SlotIdx;

    [AeroArray(4)]
    public byte[] Unk;
}