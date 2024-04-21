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

public interface GtkScrollableHandle
{
}

public static class GtkScrollableHandleExtensions
{
	public static bool GetBorder(this GtkScrollableHandle scrollable, out GtkBorder border)
	{
		return GtkScrollableExterns.gtk_scrollable_get_border(scrollable, out border);
	}

	public static GtkAdjustmentHandle GetHadjustment(this GtkScrollableHandle scrollable)
	{
		return GtkScrollableExterns.gtk_scrollable_get_hadjustment(scrollable);
	}

	public static GtkScrollablePolicy GetHscrollPolicy(this GtkScrollableHandle scrollable)
	{
		return GtkScrollableExterns.gtk_scrollable_get_hscroll_policy(scrollable);
	}

	public static GtkAdjustmentHandle GetVadjustment(this GtkScrollableHandle scrollable)
	{
		return GtkScrollableExterns.gtk_scrollable_get_vadjustment(scrollable);
	}

	public static GtkScrollablePolicy GetVscrollPolicy(this GtkScrollableHandle scrollable)
	{
		return GtkScrollableExterns.gtk_scrollable_get_vscroll_policy(scrollable);
	}

	public static GtkScrollableHandle SetHadjustment(this GtkScrollableHandle scrollable, GtkAdjustmentHandle hadjustment)
	{
		GtkScrollableExterns.gtk_scrollable_set_hadjustment(scrollable, hadjustment);
		return scrollable;
	}

	public static GtkScrollableHandle SetHscrollPolicy(this GtkScrollableHandle scrollable, GtkScrollablePolicy policy)
	{
		GtkScrollableExterns.gtk_scrollable_set_hscroll_policy(scrollable, policy);
		return scrollable;
	}

	public static GtkScrollableHandle SetVadjustment(this GtkScrollableHandle scrollable, GtkAdjustmentHandle vadjustment)
	{
		GtkScrollableExterns.gtk_scrollable_set_vadjustment(scrollable, vadjustment);
		return scrollable;
	}

	public static GtkScrollableHandle SetVscrollPolicy(this GtkScrollableHandle scrollable, GtkScrollablePolicy policy)
	{
		GtkScrollableExterns.gtk_scrollable_set_vscroll_policy(scrollable, policy);
		return scrollable;
	}

}

internal class GtkScrollableExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_scrollable_get_border(GtkScrollableHandle scrollable, out GtkBorder border);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAdjustmentHandle gtk_scrollable_get_hadjustment(GtkScrollableHandle scrollable);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkScrollablePolicy gtk_scrollable_get_hscroll_policy(GtkScrollableHandle scrollable);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAdjustmentHandle gtk_scrollable_get_vadjustment(GtkScrollableHandle scrollable);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkScrollablePolicy gtk_scrollable_get_vscroll_policy(GtkScrollableHandle scrollable);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scrollable_set_hadjustment(GtkScrollableHandle scrollable, GtkAdjustmentHandle hadjustment);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scrollable_set_hscroll_policy(GtkScrollableHandle scrollable, GtkScrollablePolicy policy);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scrollable_set_vadjustment(GtkScrollableHandle scrollable, GtkAdjustmentHandle vadjustment);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scrollable_set_vscroll_policy(GtkScrollableHandle scrollable, GtkScrollablePolicy policy);

}
