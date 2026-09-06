using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.SendRadioMessage, GssVersion.V1, GssVersion.V74)]
    public partial class SendRadioMessage
    {   
        public uint Unk1;
        public int Unk2;   
    }
}