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

public class GtkStackPageHandle : GObjectHandle, GtkAccessibleHandle
{
}

public static class GtkStackPageHandleExtensions
{
	public static GtkWidgetHandle GetChild(this GtkStackPageHandle self)
	{
		return GtkStackPageExterns.gtk_stack_page_get_child(self);
	}

	public static string GetIconName(this GtkStackPageHandle self)
	{
		return GtkStackPageExterns.gtk_stack_page_get_icon_name(self);
	}

	public static string GetName(this GtkStackPageHandle self)
	{
		return GtkStackPageExterns.gtk_stack_page_get_name(self);
	}

	public static bool GetNeedsAttention(this GtkStackPageHandle self)
	{
		return GtkStackPageExterns.gtk_stack_page_get_needs_attention(self);
	}

	public static string GetTitle(this GtkStackPageHandle self)
	{
		return GtkStackPageExterns.gtk_stack_page_get_title(self);
	}

	public static bool GetUseUnderline(this GtkStackPageHandle self)
	{
		return GtkStackPageExterns.gtk_stack_page_get_use_underline(self);
	}

	public static bool GetVisible(this GtkStackPageHandle self)
	{
		return GtkStackPageExterns.gtk_stack_page_get_visible(self);
	}

	public static GtkStackPageHandle SetIconName(this GtkStackPageHandle self, string setting)
	{
		GtkStackPageExterns.gtk_stack_page_set_icon_name(self, setting);
		return self;
	}

	public static GtkStackPageHandle SetName(this GtkStackPageHandle self, string setting)
	{
		GtkStackPageExterns.gtk_stack_page_set_name(self, setting);
		return self;
	}

	public static GtkStackPageHandle SetNeedsAttention(this GtkStackPageHandle self, bool setting)
	{
		GtkStackPageExterns.gtk_stack_page_set_needs_attention(self, setting);
		return self;
	}

	public static GtkStackPageHandle SetTitle(this GtkStackPageHandle self, string setting)
	{
		GtkStackPageExterns.gtk_stack_page_set_title(self, setting);
		return self;
	}

	public static GtkStackPageHandle SetUseUnderline(this GtkStackPageHandle self, bool setting)
	{
		GtkStackPageExterns.gtk_stack_page_set_use_underline(self, setting);
		return self;
	}

	public static GtkStackPageHandle SetVisible(this GtkStackPageHandle self, bool visible)
	{
		GtkStackPageExterns.gtk_stack_page_set_visible(self, visible);
		return self;
	}

}

internal class GtkStackPageExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_stack_page_get_child(GtkStackPageHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_stack_page_get_icon_name(GtkStackPageHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_stack_page_get_name(GtkStackPageHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_stack_page_get_needs_attention(GtkStackPageHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_stack_page_get_title(GtkStackPageHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_stack_page_get_use_underline(GtkStackPageHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_stack_page_get_visible(GtkStackPageHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_stack_page_set_icon_name(GtkStackPageHandle self, string setting);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_stack_page_set_name(GtkStackPageHandle self, string setting);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_stack_page_set_needs_attention(GtkStackPageHandle self, bool setting);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_stack_page_set_title(GtkStackPageHandle self, string setting);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_stack_page_set_use_underline(GtkStackPageHandle self, bool setting);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_stack_page_set_visible(GtkStackPageHandle self, bool visible);
}
