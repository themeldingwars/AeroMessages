using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
using AeroMessages.Common;

namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.DockToPlayer, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class DockToPlayer
    {
        public EntityId Unk1;
        public Vector3 Unk2;
    }
}