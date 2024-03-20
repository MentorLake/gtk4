using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gsk;
public class GskGLShaderNodeHandle : GObjectHandle
{
}

public class GskRadialGradientNodeHandle : GObjectHandle
{
}

public class GskColorStopHandle : GObjectHandle
{
}

public class GskClipNodeHandle : GObjectHandle
{
}

public class GskRenderNodeHandle : GObjectHandle
{
	public static GskRenderNodeHandle GskColorNodeNew(GdkRGBAHandle rgba, graphene_rect_tHandle bounds)
	{
		return GskRenderNodeExterns.gsk_color_node_new(rgba, bounds);
	}

	public static GskRenderNodeHandle GskTextureNodeNew(GdkTextureHandle texture, graphene_rect_tHandle bounds)
	{
		return GskRenderNodeExterns.gsk_texture_node_new(texture, bounds);
	}

	public static GskRenderNodeHandle GskLinearGradientNodeNew(graphene_rect_tHandle bounds, graphene_point_tHandle start, graphene_point_tHandle end, GskColorStopHandle color_stops, nuint n_color_stops)
	{
		return GskRenderNodeExterns.gsk_linear_gradient_node_new(bounds, start, end, color_stops, n_color_stops);
	}

	public static GskRenderNodeHandle GskRepeatingLinearGradientNodeNew(graphene_rect_tHandle bounds, graphene_point_tHandle start, graphene_point_tHandle end, GskColorStopHandle color_stops, nuint n_color_stops)
	{
		return GskRenderNodeExterns.gsk_repeating_linear_gradient_node_new(bounds, start, end, color_stops, n_color_stops);
	}

	public static GskRenderNodeHandle GskConicGradientNodeNew(graphene_rect_tHandle bounds, graphene_point_tHandle center, float rotation, GskColorStopHandle color_stops, nuint n_color_stops)
	{
		return GskRenderNodeExterns.gsk_conic_gradient_node_new(bounds, center, rotation, color_stops, n_color_stops);
	}

	public static GskRenderNodeHandle GskRadialGradientNodeNew(graphene_rect_tHandle bounds, graphene_point_tHandle center, float hradius, float vradius, float start, float end, GskColorStopHandle color_stops, nuint n_color_stops)
	{
		return GskRenderNodeExterns.gsk_radial_gradient_node_new(bounds, center, hradius, vradius, start, end, color_stops, n_color_stops);
	}

	public static GskRenderNodeHandle GskRepeatingRadialGradientNodeNew(graphene_rect_tHandle bounds, graphene_point_tHandle center, float hradius, float vradius, float start, float end, GskColorStopHandle color_stops, nuint n_color_stops)
	{
		return GskRenderNodeExterns.gsk_repeating_radial_gradient_node_new(bounds, center, hradius, vradius, start, end, color_stops, n_color_stops);
	}

	public static GskRenderNodeHandle GskCairoNodeNew(graphene_rect_tHandle bounds)
	{
		return GskRenderNodeExterns.gsk_cairo_node_new(bounds);
	}

	public static GskRenderNodeHandle GskRepeatNodeNew(graphene_rect_tHandle bounds, GskRenderNodeHandle child, graphene_rect_tHandle child_bounds)
	{
		return GskRenderNodeExterns.gsk_repeat_node_new(bounds, child, child_bounds);
	}

	public static GskRenderNodeHandle GskTextNodeNew(PangoFontHandle font, PangoGlyphStringHandle glyphs, GdkRGBAHandle color, graphene_point_tHandle offset)
	{
		return GskRenderNodeExterns.gsk_text_node_new(font, glyphs, color, offset);
	}
}

public class GskTransformNodeHandle : GObjectHandle
{
}

public class GskRendererClassHandle : GObjectHandle
{
}

public class GskParseLocationHandle : GObjectHandle
{
}

public class GskRoundedRectHandle : GObjectHandle
{
}

public class GskRepeatingRadialGradientNodeHandle : GObjectHandle
{
}

public class GskInsetShadowNodeHandle : GObjectHandle
{
}

public class GskDebugNodeHandle : GObjectHandle
{
}

public class GskRepeatingLinearGradientNodeHandle : GObjectHandle
{
}

public class GskColorMatrixNodeHandle : GObjectHandle
{
}

public class GskConicGradientNodeHandle : GObjectHandle
{
}

public class GskTextureNodeHandle : GObjectHandle
{
}

public class GskShadowHandle : GObjectHandle
{
}

public class GskTransformHandle : GObjectHandle
{
	public static GskTransformHandle New()
	{
		return GskTransformExterns.gsk_transform_new();
	}
}

public class GskLinearGradientNodeHandle : GObjectHandle
{
}

public class GskBlendNodeHandle : GObjectHandle
{
}

public class GskGLShaderClassHandle : GObjectHandle
{
}

public class GskOpacityNodeHandle : GObjectHandle
{
}

public class GskCrossFadeNodeHandle : GObjectHandle
{
}

public class GskRoundedClipNodeHandle : GObjectHandle
{
}

public class GskCairoRendererClassHandle : GObjectHandle
{
}

public class GskCairoNodeHandle : GObjectHandle
{
}

public class GskRendererHandle : GObjectHandle
{
	public static GskRendererHandle NewForSurface(GdkSurfaceHandle surface)
	{
		return GskRendererExterns.gsk_renderer_new_for_surface(surface);
	}

	public static GskRendererHandle GskCairoRendererNew()
	{
		return GskRendererExterns.gsk_cairo_renderer_new();
	}
}

public class GskRepeatNodeHandle : GObjectHandle
{
}

public class GskBorderNodeHandle : GObjectHandle
{
}

public class GskShadowNodeHandle : GObjectHandle
{
}

public class GskContainerNodeHandle : GObjectHandle
{
}

public class GskShaderArgsBuilderHandle : GObjectHandle
{
}

public class GskCairoRendererHandle : GObjectHandle
{
}

public class GskOutsetShadowNodeHandle : GObjectHandle
{
}

public class GskTextNodeHandle : GObjectHandle
{
}

public class GskBlurNodeHandle : GObjectHandle
{
}

public class GskColorNodeHandle : GObjectHandle
{
}

public class GskGLShaderHandle : GObjectHandle
{
	public static GskGLShaderHandle GskGlShaderNewFromBytes(GBytesHandle sourcecode)
	{
		return GskGLShaderExterns.gsk_gl_shader_new_from_bytes(sourcecode);
	}

	public static GskGLShaderHandle GskGlShaderNewFromResource(string resource_path)
	{
		return GskGLShaderExterns.gsk_gl_shader_new_from_resource(resource_path);
	}
}
