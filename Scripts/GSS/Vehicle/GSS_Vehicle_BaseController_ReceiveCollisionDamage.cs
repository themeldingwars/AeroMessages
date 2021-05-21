[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Client, 27, 86, Ver: 1962)]
public partial class VehicleBaseControllerReceiveCollisionDamage : AeroBase
{
    public ushort Unk1_DamageValue; // Not really sure about this value
    public byte Unk2; // Possibly number of entities we collided with, or just if we collided with one
    public ulong CollidedWithEntity;
}