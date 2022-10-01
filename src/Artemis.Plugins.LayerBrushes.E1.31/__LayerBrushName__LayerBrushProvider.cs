using Artemis.Core.LayerBrushes;
using Artemis.Plugins.LayerBrushes.E1._31.LayerBrushes;
using Artemis.UI.Shared.Services.PropertyInput;

namespace Artemis.Plugins.LayerBrushes.E1._31
{
    public class E1.31LayerBrushProvider : LayerBrushProvider
{
    public override void Enable()
    {
        RegisterLayerBrushDescriptor < E1.31LayerBrush > ("E1.31 layer brush", "E1.31 layer brush", "QuestionMark");
    }

    public override void Disable()
    {
    }
}}