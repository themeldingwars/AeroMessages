﻿using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Events
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 9)]
    public partial class RoutedMessageIdAssign
    {
        public ushort ReffId;
    }
}