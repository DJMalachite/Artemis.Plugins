using Artemis.Core.LayerBrushes;
using Artemis.Plugins.LayerBrushes.sACNReceiver.LayerBrushes;
using Artemis.UI.Shared.Services.PropertyInput;

namespace Artemis.Plugins.LayerBrushes.sACNReceiver
{
    public class CustomLayerBrushProvider : LayerBrushProvider
    {
        public override void Enable()
        {
            RegisterLayerBrushDescriptor<CustomLayerBrush>("sACNReceiver", "sACNReceiver", "TrackLight");
        }

        public override void Disable()
        {
        }
    }
}