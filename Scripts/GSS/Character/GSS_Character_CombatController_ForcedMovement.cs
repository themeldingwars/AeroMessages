[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 5, 113, Ver: 1962)]
public partial class CharacterCombatControllerForcedMovement : AeroBase
{
    public byte Flags;

    [AeroArray(5)]
    public byte[] Unk2;

    [AeroIf(Flags, 0x01)]
    public Type1Data Data;

    [AeroIf(Flags, 0x05)]
    public Type5Data Data;

}

[Aero(AeroType.Block)]
public partial class Type1Data : AeroBase
{
  public Vector3 Position;
  public Vector3 Direction;
  public Vector3 Velocity;
  public uint Time;
  public ushort ShortTime;
}

[Aero(AeroType.Block)]
public partial class Type5Data : AeroBase
{
  public Vector3 Type5_Velocity; // These are a bit of an assumption
  public uint Time1;
  public uint Time2;
  public byte Unk2;
  public ushort ShortTime1;
}