using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkStyleContextHandle : GObjectHandle
{
}

public static class GtkStyleContextSignals
{
}

public static class GtkStyleContextHandleExtensions
{
	public static GtkStyleContextHandle AddClass(this GtkStyleContextHandle context, string class_name)
	{
		GtkStyleContextExterns.gtk_style_context_add_class(context, class_name);
		return context;
	}

	public static GtkStyleContextHandle AddProvider(this GtkStyleContextHandle context, GtkStyleProviderHandle provider, uint priority)
	{
		GtkStyleContextExterns.gtk_style_context_add_provider(context, provider, priority);
		return context;
	}

	public static GtkStyleContextHandle GetBorder(this GtkStyleContextHandle context, out GtkBorder border)
	{
		GtkStyleContextExterns.gtk_style_context_get_border(context, out border);
		return context;
	}

	public static GtkStyleContextHandle GetColor(this GtkStyleContextHandle context, out GdkRGBA color)
	{
		GtkStyleContextExterns.gtk_style_context_get_color(context, out color);
		return context;
	}

	public static GdkDisplayHandle GetDisplay(this GtkStyleContextHandle context)
	{
		return GtkStyleContextExterns.gtk_style_context_get_display(context);
	}

	public static GtkStyleContextHandle GetMargin(this GtkStyleContextHandle context, out GtkBorder margin)
	{
		GtkStyleContextExterns.gtk_style_context_get_margin(context, out margin);
		return context;
	}

	public static GtkStyleContextHandle GetPadding(this GtkStyleContextHandle context, out GtkBorder padding)
	{
		GtkStyleContextExterns.gtk_style_context_get_padding(context, out padding);
		return context;
	}

	public static int GetScale(this GtkStyleContextHandle context)
	{
		return GtkStyleContextExterns.gtk_style_context_get_scale(context);
	}

	public static GtkStateFlags GetState(this GtkStyleContextHandle context)
	{
		return GtkStyleContextExterns.gtk_style_context_get_state(context);
	}

	public static bool HasClass(this GtkStyleContextHandle context, string class_name)
	{
		return GtkStyleContextExterns.gtk_style_context_has_class(context, class_name);
	}

	public static bool LookupColor(this GtkStyleContextHandle context, string color_name, out GdkRGBA color)
	{
		return GtkStyleContextExterns.gtk_style_context_lookup_color(context, color_name, out color);
	}

	public static GtkStyleContextHandle RemoveClass(this GtkStyleContextHandle context, string class_name)
	{
		GtkStyleContextExterns.gtk_style_context_remove_class(context, class_name);
		return context;
	}

	public static GtkStyleContextHandle RemoveProvider(this GtkStyleContextHandle context, GtkStyleProviderHandle provider)
	{
		GtkStyleContextExterns.gtk_style_context_remove_provider(context, provider);
		return context;
	}

	public static GtkStyleContextHandle Restore(this GtkStyleContextHandle context)
	{
		GtkStyleContextExterns.gtk_style_context_restore(context);
		return context;
	}

	public static GtkStyleContextHandle Save(this GtkStyleContextHandle context)
	{
		GtkStyleContextExterns.gtk_style_context_save(context);
		return context;
	}

	public static GtkStyleContextHandle SetDisplay(this GtkStyleContextHandle context, GdkDisplayHandle display)
	{
		GtkStyleContextExterns.gtk_style_context_set_display(context, display);
		return context;
	}

	public static GtkStyleContextHandle SetScale(this GtkStyleContextHandle context, int scale)
	{
		GtkStyleContextExterns.gtk_style_context_set_scale(context, scale);
		return context;
	}

	public static GtkStyleContextHandle SetState(this GtkStyleContextHandle context, GtkStateFlags flags)
	{
		GtkStyleContextExterns.gtk_style_context_set_state(context, flags);
		return context;
	}

	public static string ToString(this GtkStyleContextHandle context, GtkStyleContextPrintFlags flags)
	{
		return GtkStyleContextExterns.gtk_style_context_to_string(context, flags);
	}

	public static GtkStyleContextHandle AddProviderForDisplay(this GtkStyleContextHandle @handle, GdkDisplayHandle display, GtkStyleProviderHandle provider, uint priority)
	{
		GtkStyleContextExterns.gtk_style_context_add_provider_for_display(display, provider, priority);
		return @handle;
	}

	public static GtkStyleContextHandle RemoveProviderForDisplay(this GtkStyleContextHandle @handle, GdkDisplayHandle display, GtkStyleProviderHandle provider)
	{
		GtkStyleContextExterns.gtk_style_context_remove_provider_for_display(display, provider);
		return @handle;
	}

	public static GtkStyleContextHandle GtkRenderFrame(this GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkStyleContextExterns.gtk_render_frame(context, cr, x, y, width, height);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderExpander(this GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkStyleContextExterns.gtk_render_expander(context, cr, x, y, width, height);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderIcon(this GtkStyleContextHandle context, cairo_tHandle cr, GdkTextureHandle texture, double x, double y)
	{
		GtkStyleContextExterns.gtk_render_icon(context, cr, texture, x, y);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderLine(this GtkStyleContextHandle context, cairo_tHandle cr, double x0, double y0, double x1, double y1)
	{
		GtkStyleContextExterns.gtk_render_line(context, cr, x0, y0, x1, y1);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderBackground(this GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkStyleContextExterns.gtk_render_background(context, cr, x, y, width, height);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderLayout(this GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, PangoLayoutHandle layout)
	{
		GtkStyleContextExterns.gtk_render_layout(context, cr, x, y, layout);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderArrow(this GtkStyleContextHandle context, cairo_tHandle cr, double angle, double x, double y, double size)
	{
		GtkStyleContextExterns.gtk_render_arrow(context, cr, angle, x, y, size);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderActivity(this GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkStyleContextExterns.gtk_render_activity(context, cr, x, y, width, height);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderHandle(this GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkStyleContextExterns.gtk_render_handle(context, cr, x, y, width, height);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderFocus(this GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkStyleContextExterns.gtk_render_focus(context, cr, x, y, width, height);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderCheck(this GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkStyleContextExterns.gtk_render_check(context, cr, x, y, width, height);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderOption(this GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkStyleContextExterns.gtk_render_option(context, cr, x, y, width, height);
		return context;
	}

}

internal class GtkStyleContextExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_style_context_add_class(GtkStyleContextHandle context, string class_name);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_style_context_add_provider(GtkStyleContextHandle context, GtkStyleProviderHandle provider, uint priority);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_style_context_get_border(GtkStyleContextHandle context, out GtkBorder border);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_style_context_get_color(GtkStyleContextHandle context, out GdkRGBA color);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkDisplayHandle gtk_style_context_get_display(GtkStyleContextHandle context);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_style_context_get_margin(GtkStyleContextHandle context, out GtkBorder margin);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_style_context_get_padding(GtkStyleContextHandle context, out GtkBorder padding);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_style_context_get_scale(GtkStyleContextHandle context);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkStateFlags gtk_style_context_get_state(GtkStyleContextHandle context);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_style_context_has_class(GtkStyleContextHandle context, string class_name);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_style_context_lookup_color(GtkStyleContextHandle context, string color_name, out GdkRGBA color);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_style_context_remove_class(GtkStyleContextHandle context, string class_name);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_style_context_remove_provider(GtkStyleContextHandle context, GtkStyleProviderHandle provider);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_style_context_restore(GtkStyleContextHandle context);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_style_context_save(GtkStyleContextHandle context);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_style_context_set_display(GtkStyleContextHandle context, GdkDisplayHandle display);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_style_context_set_scale(GtkStyleContextHandle context, int scale);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_style_context_set_state(GtkStyleContextHandle context, GtkStateFlags flags);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_style_context_to_string(GtkStyleContextHandle context, GtkStyleContextPrintFlags flags);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_style_context_add_provider_for_display(GdkDisplayHandle display, GtkStyleProviderHandle provider, uint priority);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_style_context_remove_provider_for_display(GdkDisplayHandle display, GtkStyleProviderHandle provider);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_render_frame(GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_render_expander(GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_render_icon(GtkStyleContextHandle context, cairo_tHandle cr, GdkTextureHandle texture, double x, double y);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_render_line(GtkStyleContextHandle context, cairo_tHandle cr, double x0, double y0, double x1, double y1);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_render_background(GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_render_layout(GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, PangoLayoutHandle layout);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_render_arrow(GtkStyleContextHandle context, cairo_tHandle cr, double angle, double x, double y, double size);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_render_activity(GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_render_handle(GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_render_focus(GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_render_check(GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_render_option(GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height);
}
