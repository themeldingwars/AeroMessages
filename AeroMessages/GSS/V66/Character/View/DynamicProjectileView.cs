using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
using Aero.Gen;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.View
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 14, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 14, 3)]
    public partial class DynamicProjectileView
    {
        // Guesswork
        [AeroNullable] private DynamicProjectileInfo DynamicProjectileInfos_0;
        [AeroNullable] private DynamicProjectileInfo DynamicProjectileInfos_1;
        [AeroNullable] private DynamicProjectileInfo DynamicProjectileInfos_2;
        [AeroNullable] private DynamicProjectileInfo DynamicProjectileInfos_3;
        [AeroNullable] private DynamicProjectileInfo DynamicProjectileInfos_4;
        [AeroNullable] private DynamicProjectileInfo DynamicProjectileInfos_5;
        [AeroNullable] private DynamicProjectileInfo DynamicProjectileInfos_6;
        [AeroNullable] private DynamicProjectileInfo DynamicProjectileInfos_7;
        [AeroNullable] private DynamicProjectileInfo DynamicProjectileInfos_8;
        [AeroNullable] private DynamicProjectileInfo DynamicProjectileInfos_9;
        [AeroNullable] private DynamicProjectileInfo DynamicProjectileInfos_10;
        [AeroNullable] private DynamicProjectileInfo DynamicProjectileInfos_11;
        [AeroNullable] private DynamicProjectileInfo DynamicProjectileInfos_12;
        [AeroNullable] private DynamicProjectileInfo DynamicProjectileInfos_13;
        [AeroNullable] private DynamicProjectileInfo DynamicProjectileInfos_14;
        [AeroNullable] private DynamicProjectileInfo DynamicProjectileInfos_15;
        [AeroNullable] private DynamicProjectilePosition DynamicProjectilePositions_0;
        [AeroNullable] private DynamicProjectilePosition DynamicProjectilePositions_1;
        [AeroNullable] private DynamicProjectilePosition DynamicProjectilePositions_2;
        [AeroNullable] private DynamicProjectilePosition DynamicProjectilePositions_3;
        [AeroNullable] private DynamicProjectilePosition DynamicProjectilePositions_4;
        [AeroNullable] private DynamicProjectilePosition DynamicProjectilePositions_5;
        [AeroNullable] private DynamicProjectilePosition DynamicProjectilePositions_6;
        [AeroNullable] private DynamicProjectilePosition DynamicProjectilePositions_7;
        [AeroNullable] private DynamicProjectilePosition DynamicProjectilePositions_8;
        [AeroNullable] private DynamicProjectilePosition DynamicProjectilePositions_9;
        [AeroNullable] private DynamicProjectilePosition DynamicProjectilePositions_10;
        [AeroNullable] private DynamicProjectilePosition DynamicProjectilePositions_11;
        [AeroNullable] private DynamicProjectilePosition DynamicProjectilePositions_12;
        [AeroNullable] private DynamicProjectilePosition DynamicProjectilePositions_13;
        [AeroNullable] private DynamicProjectilePosition DynamicProjectilePositions_14;
        [AeroNullable] private DynamicProjectilePosition DynamicProjectilePositions_15;
    }

    [AeroBlock]
    public struct DynamicProjectileInfo
    {
        public uint Unk; // Uncertain type
    }

    [AeroBlock]
    public struct DynamicProjectilePosition
    {
        public Vector3 Position;
        public uint Unk;
    }
}