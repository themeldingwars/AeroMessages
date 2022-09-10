using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
using Aero.Gen;

namespace AeroMessages.GSS.V66.Turret.Controller
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 39, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 39, 4)]
    public partial class BaseController
    {
        // TODO
        /*
        Type = 0x00,
        ParentObjId = 0x01,
        ParentChildIndex = 0x02,
        GunnerId = 0x03,
        SpawnPose = 0x04,
        ProcessDelay = 0x05,
        WeaponFireBaseTime = 0x06,
        Ammo = 0x07,
        FireRateModifier = 0x08,
        HostilityInfo = 0x9, // Faction
        PersonalFactionStance = 0x0a,
        ScalingLevel = 0x0b,

        Clear_PersonalFactionStance = 0x8a,
         */
    }
}