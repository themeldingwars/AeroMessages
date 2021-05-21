[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 2, 154, Ver: 1962)]
public partial class CharacterBaseControllerSlotGearResponse : AeroBase
{
    public uint LoadoutId;
    public ulong ItemGUID;

    [AeroSDB("dbitems::LoadoutSlot", "id")]
    public byte SlotIdx;

    [AeroArray(5)]
    public byte[] Unk; // 1 more byte than request
}