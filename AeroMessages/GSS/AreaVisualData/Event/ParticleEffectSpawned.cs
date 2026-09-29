using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.AreaVisualData.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssAreaVisualDataMessage.ParticleEffectSpawned, GssAreaVisualDataView.ForceShieldView, GssVersion.V1, GssVersion.V74)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssAreaVisualDataMessage.ParticleEffectSpawned, GssAreaVisualDataView.ParticleEffectsView, GssVersion.V74, GssVersion.V74)]
    public partial class ParticleEffectSpawned
    {
        public ParticleEffect Data;
    }
}