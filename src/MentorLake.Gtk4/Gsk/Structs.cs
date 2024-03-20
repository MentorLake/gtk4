using System.Runtime.CompilerServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Graphene;

namespace MentorLake.Gtk4.Gsk;

public struct GskGLShaderNode { }
public struct GskRadialGradientNode { }

public struct GskColorStop
{
	public float offset;

	public GdkRGBA color;
}

public struct GskClipNode { }
public struct GskRenderNode { }
public struct GskTransformNode { }
public struct GskRendererClass { }

public struct GskParseLocation
{
	public nuint bytes;

	public nuint chars;

	public nuint lines;

	public nuint line_bytes;

	public nuint line_chars;
}

public struct GskRoundedRect
{
	public graphene_rect_t bounds;

	public _corner_e__FixedBuffer corner;

	[InlineArray(4)]
	public struct _corner_e__FixedBuffer
	{
		public graphene_size_t e0;
	}
}

public struct GskRepeatingRadialGradientNode { }
public struct GskInsetShadowNode { }
public struct GskDebugNode { }
public struct GskRepeatingLinearGradientNode { }
public struct GskColorMatrixNode { }
public struct GskConicGradientNode { }
public struct GskTextureNode { }

public struct GskShadow
{
	public GdkRGBA color;

	public float dx;

	public float dy;

	public float radius;
}

public struct GskTransform { }
public struct GskLinearGradientNode { }
public struct GskBlendNode { }

public struct GskGLShaderClass
{
	public GObjectClass parent_class;
}

public struct GskOpacityNode { }
public struct GskCrossFadeNode { }
public struct GskRoundedClipNode { }
public struct GskCairoRendererClass { }
public struct GskCairoNode { }
public struct GskRenderer { }
public struct GskRepeatNode { }
public struct GskBorderNode { }
public struct GskShadowNode { }
public struct GskContainerNode { }
public struct GskShaderArgsBuilder { }
public struct GskCairoRenderer { }
public struct GskOutsetShadowNode { }
public struct GskTextNode { }
public struct GskBlurNode { }
public struct GskColorNode { }
public struct GskGLShader { }
