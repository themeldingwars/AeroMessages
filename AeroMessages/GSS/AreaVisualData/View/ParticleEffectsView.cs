using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using Aero.Gen;

namespace AeroMessages.GSS.AreaVisualData.View
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssAreaVisualDataView.ParticleEffectsView, GssVersion.V1, GssVersion.V74)]
    public partial class ParticleEffectsView
    {
        [AeroNullable] private ParticleEffect ParticleEffects_0;
        [AeroNullable] private ParticleEffect ParticleEffects_1;
        [AeroNullable] private ParticleEffect ParticleEffects_2;
        [AeroNullable] private ParticleEffect ParticleEffects_3;
        [AeroNullable] private ParticleEffect ParticleEffects_4;
        [AeroNullable] private ParticleEffect ParticleEffects_5;
        [AeroNullable] private ParticleEffect ParticleEffects_6;
        [AeroNullable] private ParticleEffect ParticleEffects_7;
        [AeroNullable] private ParticleEffect ParticleEffects_8;
        [AeroNullable] private ParticleEffect ParticleEffects_9;
        [AeroNullable] private ParticleEffect ParticleEffects_10;
        [AeroNullable] private ParticleEffect ParticleEffects_11;
        [AeroNullable] private ParticleEffect ParticleEffects_12;
        [AeroNullable] private ParticleEffect ParticleEffects_13;
        [AeroNullable] private ParticleEffect ParticleEffects_14;
        [AeroNullable] private ParticleEffect ParticleEffects_15;
        [AeroNullable] private ParticleEffect ParticleEffects_16;
        [AeroNullable] private ParticleEffect ParticleEffects_17;
        [AeroNullable] private ParticleEffect ParticleEffects_18;
        [AeroNullable] private ParticleEffect ParticleEffects_19;
    }
}