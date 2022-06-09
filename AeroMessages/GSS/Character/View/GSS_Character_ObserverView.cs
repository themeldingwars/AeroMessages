using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
using Aero.Gen;

namespace AeroMessages.GSS.Character
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 8, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 8, 3)]
    public partial class Character_ObserverView
    {
        private StaticInfoData StaticInfo;
        private uint SpawnTime;
        private byte EffectsFlags;
        private GibVisuals GibVisualsID;
        private uint ProcessDelay;
        private CharacterStateData CharacterState; 
        private HostilityInfoData HostilityInfo;

        [AeroNullable] private PersonalFactionStanceData PersonalFactionStance;

        private byte CurrentHealthPct;
        private MaxVital MaxHealth;
        private EmoteData EmoteID;

        [AeroNullable] private AttachedToData AttachedTo;

        private byte SnapMount;
        private byte SinFlags;

        [AeroNullable] private SinFactionsAcquiredByData SinFactionsAcquiredBy;

        [AeroNullable] private SinTeamsAcquiredByData SinTeamsAcquiredBy;

        private ulong ArmyGUID;
        private ulong OwnerId;
        private ushort NPCType; // Could also be that DockedParams is 2 bytes shorter for ObserverView compared to BaseController

        private DockedParamsData DockedParams;

        [AeroNullable] private LookAtTargetData LookAtTarget;

        private byte WaterLevelAndDesc;

        [AeroNullable] private CarryableObject CarryableObjects_0;

        [AeroNullable] private CarryableObject CarryableObjects_1;

        [AeroNullable] private CarryableObject CarryableObjects_2;

        [AeroNullable] private RespawnTimesData RespawnTimes;

        [AeroSdb("dbencounterdata::SinCardTemplate", "Id")]
        //[AeroSdb("dbencounterdata::SinCardFields", "TemplateId")]
        private uint SinCardType;

        [AeroNullable] private SinCardFieldData SinCardFields_0;

        [AeroNullable] private SinCardFieldData SinCardFields_1;

        [AeroNullable] private SinCardFieldData SinCardFields_2;

        [AeroNullable] private SinCardFieldData SinCardFields_3;

        [AeroNullable] private SinCardFieldData SinCardFields_4;

        [AeroNullable] private SinCardFieldData SinCardFields_5;

        [AeroNullable] private SinCardFieldData SinCardFields_6;

        [AeroNullable] private SinCardFieldData SinCardFields_7;

        [AeroNullable] private SinCardFieldData SinCardFields_8;

        [AeroNullable] private SinCardFieldData SinCardFields_9;

        [AeroNullable] private SinCardFieldData SinCardFields_10;

        [AeroNullable] private SinCardFieldData SinCardFields_11;

        [AeroNullable] private SinCardFieldData SinCardFields_12;

        [AeroNullable] private SinCardFieldData SinCardFields_13;

        [AeroNullable] private SinCardFieldData SinCardFields_14;

        [AeroNullable] private SinCardFieldData SinCardFields_15;

        [AeroNullable] private SinCardFieldData SinCardFields_16;

        [AeroNullable] private SinCardFieldData SinCardFields_17;

        [AeroNullable] private SinCardFieldData SinCardFields_18;

        [AeroNullable] private SinCardFieldData SinCardFields_19;

        [AeroNullable] private SinCardFieldData SinCardFields_20;

        [AeroNullable] private SinCardFieldData SinCardFields_21;

        [AeroNullable] private SinCardFieldData SinCardFields_22;

        private byte AssetOverrides;
    }
}