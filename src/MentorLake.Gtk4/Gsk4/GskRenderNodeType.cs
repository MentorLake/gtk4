using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gsk4;

public enum GskRenderNodeType
{
	GSK_NOT_A_RENDER_NODE,
	GSK_CONTAINER_NODE,
	GSK_CAIRO_NODE,
	GSK_COLOR_NODE,
	GSK_LINEAR_GRADIENT_NODE,
	GSK_REPEATING_LINEAR_GRADIENT_NODE,
	GSK_RADIAL_GRADIENT_NODE,
	GSK_REPEATING_RADIAL_GRADIENT_NODE,
	GSK_CONIC_GRADIENT_NODE,
	GSK_BORDER_NODE,
	GSK_TEXTURE_NODE,
	GSK_INSET_SHADOW_NODE,
	GSK_OUTSET_SHADOW_NODE,
	GSK_TRANSFORM_NODE,
	GSK_OPACITY_NODE,
	GSK_COLOR_MATRIX_NODE,
	GSK_REPEAT_NODE,
	GSK_CLIP_NODE,
	GSK_ROUNDED_CLIP_NODE,
	GSK_SHADOW_NODE,
	GSK_BLEND_NODE,
	GSK_CROSS_FADE_NODE,
	GSK_TEXT_NODE,
	GSK_BLUR_NODE,
	GSK_DEBUG_NODE,
	GSK_GL_SHADER_NODE,
	GSK_TEXTURE_SCALE_NODE,
	GSK_MASK_NODE,
	GSK_FILL_NODE,
	GSK_STROKE_NODE,
	GSK_SUBSURFACE_NODE
}
