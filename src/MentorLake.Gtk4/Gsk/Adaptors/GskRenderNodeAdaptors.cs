using System.Runtime.InteropServices;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gsk;
public static class GskRenderNodeAdaptors
{
	public static GskRenderNodeHandle Ref(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_render_node_ref(node);
	}

	public static GskRenderNodeHandle Unref(this GskRenderNodeHandle node)
	{
		GskRenderNodeExterns.gsk_render_node_unref(node);
		return node;
	}

	public static GskRenderNodeType GetNodeType(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_render_node_get_node_type(node);
	}

	public static GskRenderNodeHandle GetBounds(this GskRenderNodeHandle node, graphene_rect_tHandle bounds)
	{
		GskRenderNodeExterns.gsk_render_node_get_bounds(node, bounds);
		return node;
	}

	public static GskRenderNodeHandle Draw(this GskRenderNodeHandle node, cairoHandle cr)
	{
		GskRenderNodeExterns.gsk_render_node_draw(node, cr);
		return node;
	}

	public static GBytesHandle Serialize(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_render_node_serialize(node);
	}

	public static int WriteToFile(this GskRenderNodeHandle node, string filename, out GErrorHandle error)
	{
		return GskRenderNodeExterns.gsk_render_node_write_to_file(node, filename, out error);
	}

	public static GskRenderNodeHandle GskDebugNodeNew(this GskRenderNodeHandle child, string message)
	{
		return GskRenderNodeExterns.gsk_debug_node_new(child, message);
	}

	public static GskRenderNodeHandle GskDebugNodeGetChild(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_debug_node_get_child(node);
	}

	public static string GskDebugNodeGetMessage(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_debug_node_get_message(node);
	}

	public static GdkRGBAHandle GskColorNodeGetColor(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_color_node_get_color(node);
	}

	public static GdkTextureHandle GskTextureNodeGetTexture(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_texture_node_get_texture(node);
	}

	public static graphene_point_tHandle GskLinearGradientNodeGetStart(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_linear_gradient_node_get_start(node);
	}

	public static graphene_point_tHandle GskLinearGradientNodeGetEnd(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_linear_gradient_node_get_end(node);
	}

	public static nuint GskLinearGradientNodeGetNColorStops(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_linear_gradient_node_get_n_color_stops(node);
	}

	public static GskColorStopHandle GskLinearGradientNodeGetColorStops(this GskRenderNodeHandle node, out nuint n_stops)
	{
		return GskRenderNodeExterns.gsk_linear_gradient_node_get_color_stops(node, out n_stops);
	}

	public static graphene_point_tHandle GskConicGradientNodeGetCenter(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_conic_gradient_node_get_center(node);
	}

	public static float GskConicGradientNodeGetRotation(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_conic_gradient_node_get_rotation(node);
	}

	public static float GskConicGradientNodeGetAngle(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_conic_gradient_node_get_angle(node);
	}

	public static nuint GskConicGradientNodeGetNColorStops(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_conic_gradient_node_get_n_color_stops(node);
	}

	public static GskColorStopHandle GskConicGradientNodeGetColorStops(this GskRenderNodeHandle node, out nuint n_stops)
	{
		return GskRenderNodeExterns.gsk_conic_gradient_node_get_color_stops(node, out n_stops);
	}

	public static nuint GskRadialGradientNodeGetNColorStops(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_radial_gradient_node_get_n_color_stops(node);
	}

	public static GskColorStopHandle GskRadialGradientNodeGetColorStops(this GskRenderNodeHandle node, out nuint n_stops)
	{
		return GskRenderNodeExterns.gsk_radial_gradient_node_get_color_stops(node, out n_stops);
	}

	public static graphene_point_tHandle GskRadialGradientNodeGetCenter(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_radial_gradient_node_get_center(node);
	}

	public static float GskRadialGradientNodeGetHradius(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_radial_gradient_node_get_hradius(node);
	}

	public static float GskRadialGradientNodeGetVradius(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_radial_gradient_node_get_vradius(node);
	}

	public static float GskRadialGradientNodeGetStart(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_radial_gradient_node_get_start(node);
	}

	public static float GskRadialGradientNodeGetEnd(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_radial_gradient_node_get_end(node);
	}

	public static GskRoundedRectHandle GskBorderNodeGetOutline(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_border_node_get_outline(node);
	}

	public static float[] GskBorderNodeGetWidths(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_border_node_get_widths(node);
	}

	public static GdkRGBAHandle GskBorderNodeGetColors(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_border_node_get_colors(node);
	}

	public static GskRoundedRectHandle GskInsetShadowNodeGetOutline(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_inset_shadow_node_get_outline(node);
	}

	public static GdkRGBAHandle GskInsetShadowNodeGetColor(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_inset_shadow_node_get_color(node);
	}

	public static float GskInsetShadowNodeGetDx(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_inset_shadow_node_get_dx(node);
	}

	public static float GskInsetShadowNodeGetDy(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_inset_shadow_node_get_dy(node);
	}

	public static float GskInsetShadowNodeGetSpread(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_inset_shadow_node_get_spread(node);
	}

	public static float GskInsetShadowNodeGetBlurRadius(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_inset_shadow_node_get_blur_radius(node);
	}

	public static GskRoundedRectHandle GskOutsetShadowNodeGetOutline(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_outset_shadow_node_get_outline(node);
	}

	public static GdkRGBAHandle GskOutsetShadowNodeGetColor(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_outset_shadow_node_get_color(node);
	}

	public static float GskOutsetShadowNodeGetDx(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_outset_shadow_node_get_dx(node);
	}

	public static float GskOutsetShadowNodeGetDy(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_outset_shadow_node_get_dy(node);
	}

	public static float GskOutsetShadowNodeGetSpread(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_outset_shadow_node_get_spread(node);
	}

	public static float GskOutsetShadowNodeGetBlurRadius(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_outset_shadow_node_get_blur_radius(node);
	}

	public static cairoHandle GskCairoNodeGetDrawContext(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_cairo_node_get_draw_context(node);
	}

	public static cairo_surfaceHandle GskCairoNodeGetSurface(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_cairo_node_get_surface(node);
	}

	public static uint GskContainerNodeGetNChildren(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_container_node_get_n_children(node);
	}

	public static GskRenderNodeHandle GskContainerNodeGetChild(this GskRenderNodeHandle node, uint idx)
	{
		return GskRenderNodeExterns.gsk_container_node_get_child(node, idx);
	}

	public static GskRenderNodeHandle GskTransformNodeNew(this GskRenderNodeHandle child, GskTransformHandle transform)
	{
		return GskRenderNodeExterns.gsk_transform_node_new(child, transform);
	}

	public static GskRenderNodeHandle GskTransformNodeGetChild(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_transform_node_get_child(node);
	}

	public static GskTransformHandle GskTransformNodeGetTransform(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_transform_node_get_transform(node);
	}

	public static GskRenderNodeHandle GskOpacityNodeNew(this GskRenderNodeHandle child, float opacity)
	{
		return GskRenderNodeExterns.gsk_opacity_node_new(child, opacity);
	}

	public static GskRenderNodeHandle GskOpacityNodeGetChild(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_opacity_node_get_child(node);
	}

	public static float GskOpacityNodeGetOpacity(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_opacity_node_get_opacity(node);
	}

	public static GskRenderNodeHandle GskColorMatrixNodeNew(this GskRenderNodeHandle child, graphene_matrix_tHandle color_matrix, graphene_vec4_tHandle color_offset)
	{
		return GskRenderNodeExterns.gsk_color_matrix_node_new(child, color_matrix, color_offset);
	}

	public static GskRenderNodeHandle GskColorMatrixNodeGetChild(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_color_matrix_node_get_child(node);
	}

	public static graphene_matrix_tHandle GskColorMatrixNodeGetColorMatrix(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_color_matrix_node_get_color_matrix(node);
	}

	public static graphene_vec4_tHandle GskColorMatrixNodeGetColorOffset(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_color_matrix_node_get_color_offset(node);
	}

	public static GskRenderNodeHandle GskRepeatNodeGetChild(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_repeat_node_get_child(node);
	}

	public static graphene_rect_tHandle GskRepeatNodeGetChildBounds(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_repeat_node_get_child_bounds(node);
	}

	public static GskRenderNodeHandle GskClipNodeNew(this GskRenderNodeHandle child, graphene_rect_tHandle clip)
	{
		return GskRenderNodeExterns.gsk_clip_node_new(child, clip);
	}

	public static GskRenderNodeHandle GskClipNodeGetChild(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_clip_node_get_child(node);
	}

	public static graphene_rect_tHandle GskClipNodeGetClip(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_clip_node_get_clip(node);
	}

	public static GskRenderNodeHandle GskRoundedClipNodeNew(this GskRenderNodeHandle child, GskRoundedRectHandle clip)
	{
		return GskRenderNodeExterns.gsk_rounded_clip_node_new(child, clip);
	}

	public static GskRenderNodeHandle GskRoundedClipNodeGetChild(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_rounded_clip_node_get_child(node);
	}

	public static GskRoundedRectHandle GskRoundedClipNodeGetClip(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_rounded_clip_node_get_clip(node);
	}

	public static GskRenderNodeHandle GskShadowNodeNew(this GskRenderNodeHandle child, GskShadowHandle shadows, nuint n_shadows)
	{
		return GskRenderNodeExterns.gsk_shadow_node_new(child, shadows, n_shadows);
	}

	public static GskRenderNodeHandle GskShadowNodeGetChild(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_shadow_node_get_child(node);
	}

	public static GskShadowHandle GskShadowNodeGetShadow(this GskRenderNodeHandle node, nuint i)
	{
		return GskRenderNodeExterns.gsk_shadow_node_get_shadow(node, i);
	}

	public static nuint GskShadowNodeGetNShadows(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_shadow_node_get_n_shadows(node);
	}

	public static GskRenderNodeHandle GskBlendNodeNew(this GskRenderNodeHandle bottom, GskRenderNodeHandle top, GskBlendMode blend_mode)
	{
		return GskRenderNodeExterns.gsk_blend_node_new(bottom, top, blend_mode);
	}

	public static GskRenderNodeHandle GskBlendNodeGetBottomChild(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_blend_node_get_bottom_child(node);
	}

	public static GskRenderNodeHandle GskBlendNodeGetTopChild(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_blend_node_get_top_child(node);
	}

	public static GskBlendMode GskBlendNodeGetBlendMode(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_blend_node_get_blend_mode(node);
	}

	public static GskRenderNodeHandle GskCrossFadeNodeNew(this GskRenderNodeHandle start, GskRenderNodeHandle end, float progress)
	{
		return GskRenderNodeExterns.gsk_cross_fade_node_new(start, end, progress);
	}

	public static GskRenderNodeHandle GskCrossFadeNodeGetStartChild(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_cross_fade_node_get_start_child(node);
	}

	public static GskRenderNodeHandle GskCrossFadeNodeGetEndChild(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_cross_fade_node_get_end_child(node);
	}

	public static float GskCrossFadeNodeGetProgress(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_cross_fade_node_get_progress(node);
	}

	public static PangoFontHandle GskTextNodeGetFont(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_text_node_get_font(node);
	}

	public static int GskTextNodeHasColorGlyphs(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_text_node_has_color_glyphs(node);
	}

	public static uint GskTextNodeGetNumGlyphs(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_text_node_get_num_glyphs(node);
	}

	public static PangoGlyphInfoHandle[] GskTextNodeGetGlyphs(this GskRenderNodeHandle node, out uint[] n_glyphs)
	{
		return GskRenderNodeExterns.gsk_text_node_get_glyphs(node, out n_glyphs);
	}

	public static GdkRGBAHandle GskTextNodeGetColor(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_text_node_get_color(node);
	}

	public static graphene_point_tHandle GskTextNodeGetOffset(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_text_node_get_offset(node);
	}

	public static GskRenderNodeHandle GskBlurNodeNew(this GskRenderNodeHandle child, float radius)
	{
		return GskRenderNodeExterns.gsk_blur_node_new(child, radius);
	}

	public static GskRenderNodeHandle GskBlurNodeGetChild(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_blur_node_get_child(node);
	}

	public static float GskBlurNodeGetRadius(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_blur_node_get_radius(node);
	}

	public static uint GskGlShaderNodeGetNChildren(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_gl_shader_node_get_n_children(node);
	}

	public static GskRenderNodeHandle GskGlShaderNodeGetChild(this GskRenderNodeHandle node, uint idx)
	{
		return GskRenderNodeExterns.gsk_gl_shader_node_get_child(node, idx);
	}

	public static GBytesHandle GskGlShaderNodeGetArgs(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_gl_shader_node_get_args(node);
	}

	public static GskGLShaderHandle GskGlShaderNodeGetShader(this GskRenderNodeHandle node)
	{
		return GskRenderNodeExterns.gsk_gl_shader_node_get_shader(node);
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
