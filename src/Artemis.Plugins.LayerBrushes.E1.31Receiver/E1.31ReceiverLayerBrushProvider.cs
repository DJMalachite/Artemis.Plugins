using Artemis.Core.LayerBrushes;
using Artemis.Plugins.LayerBrushes.E1._31Receiver.LayerBrushes;
using Artemis.UI.Shared.Services.PropertyInput;

namespace Artemis.Plugins.LayerBrushes.E1._31Receiver
{
    public class E1.31ReceiverLayerBrushProvider : LayerBrushProvider
{
    public override void Enable()
    {
        RegisterLayerBrushDescriptor < E1.31ReceiverLayerBrush > ("E1.31Receiver layer brush", "E1.31Receiver layer brush", "QuestionMark");
    }

    public override void Disable()
    {
    }
}}