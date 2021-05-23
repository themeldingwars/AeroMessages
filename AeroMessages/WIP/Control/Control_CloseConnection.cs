/*
META_BEGIN
    MsgType: Control
    MsgId: 0
    MsgName: CloseConnection
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.Control
{
    [Aero]
    public partial class Control_CloseConnection
    {
        [AeroArray(3)]
        public float Unk;
    }
}