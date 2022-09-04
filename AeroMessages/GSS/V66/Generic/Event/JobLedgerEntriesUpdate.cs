using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 87)]
    public partial class JobLedgerEntriesUpdate
    {
        [AeroArray(typeof(byte))] public uint[] Unk;
    }
}