using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 121)]
    public partial class Character_Event_PrivateDialog
    {
        public uint Time;
        public EntityId Entity;
        public uint DialogId; // TODO: "dbdialogdata::DialogScript" ?
    }
}