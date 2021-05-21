[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 2, 135, Ver: 1962)]
public partial class CharacterBaseControllerTrackerPulse : AeroBase
{
    public ulong Entity;

    [AeroArray(6)]
    public byte[] Unk1;

    [AeroNullTermString]
    public string Text;

    public byte Unk2;

    // Nothing concrete
    public ulong Entity;

    [AeroArray(28)]
    public byte[] Unk1;

    [AeroArray(3)]
    public float[] FloatArray1;

    [AeroArray(8)]
    public byte[] Unk2;
}