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

namespace MentorLake.Gtk4.Gtk4;

public class GtkCellAreaContextHandle : GObjectHandle
{
}

public static class GtkCellAreaContextHandleExtensions
{
	public static GtkCellAreaContextHandle Allocate(this GtkCellAreaContextHandle context, int width, int height)
	{
		GtkCellAreaContextExterns.gtk_cell_area_context_allocate(context, width, height);
		return context;
	}

	public static GtkCellAreaContextHandle GetAllocation(this GtkCellAreaContextHandle context, out int width, out int height)
	{
		GtkCellAreaContextExterns.gtk_cell_area_context_get_allocation(context, out width, out height);
		return context;
	}

	public static GtkCellAreaHandle GetArea(this GtkCellAreaContextHandle context)
	{
		return GtkCellAreaContextExterns.gtk_cell_area_context_get_area(context);
	}

	public static GtkCellAreaContextHandle GetPreferredHeight(this GtkCellAreaContextHandle context, out int minimum_height, out int natural_height)
	{
		GtkCellAreaContextExterns.gtk_cell_area_context_get_preferred_height(context, out minimum_height, out natural_height);
		return context;
	}

	public static GtkCellAreaContextHandle GetPreferredHeightForWidth(this GtkCellAreaContextHandle context, int width, out int minimum_height, out int natural_height)
	{
		GtkCellAreaContextExterns.gtk_cell_area_context_get_preferred_height_for_width(context, width, out minimum_height, out natural_height);
		return context;
	}

	public static GtkCellAreaContextHandle GetPreferredWidth(this GtkCellAreaContextHandle context, out int minimum_width, out int natural_width)
	{
		GtkCellAreaContextExterns.gtk_cell_area_context_get_preferred_width(context, out minimum_width, out natural_width);
		return context;
	}

	public static GtkCellAreaContextHandle GetPreferredWidthForHeight(this GtkCellAreaContextHandle context, int height, out int minimum_width, out int natural_width)
	{
		GtkCellAreaContextExterns.gtk_cell_area_context_get_preferred_width_for_height(context, height, out minimum_width, out natural_width);
		return context;
	}

	public static GtkCellAreaContextHandle PushPreferredHeight(this GtkCellAreaContextHandle context, int minimum_height, int natural_height)
	{
		GtkCellAreaContextExterns.gtk_cell_area_context_push_preferred_height(context, minimum_height, natural_height);
		return context;
	}

	public static GtkCellAreaContextHandle PushPreferredWidth(this GtkCellAreaContextHandle context, int minimum_width, int natural_width)
	{
		GtkCellAreaContextExterns.gtk_cell_area_context_push_preferred_width(context, minimum_width, natural_width);
		return context;
	}

	public static GtkCellAreaContextHandle Reset(this GtkCellAreaContextHandle context)
	{
		GtkCellAreaContextExterns.gtk_cell_area_context_reset(context);
		return context;
	}

}

internal class GtkCellAreaContextExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_context_allocate(GtkCellAreaContextHandle context, int width, int height);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_context_get_allocation(GtkCellAreaContextHandle context, out int width, out int height);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellAreaHandle gtk_cell_area_context_get_area(GtkCellAreaContextHandle context);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_context_get_preferred_height(GtkCellAreaContextHandle context, out int minimum_height, out int natural_height);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_context_get_preferred_height_for_width(GtkCellAreaContextHandle context, int width, out int minimum_height, out int natural_height);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_context_get_preferred_width(GtkCellAreaContextHandle context, out int minimum_width, out int natural_width);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_context_get_preferred_width_for_height(GtkCellAreaContextHandle context, int height, out int minimum_width, out int natural_width);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_context_push_preferred_height(GtkCellAreaContextHandle context, int minimum_height, int natural_height);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_context_push_preferred_width(GtkCellAreaContextHandle context, int minimum_width, int natural_width);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_context_reset(GtkCellAreaContextHandle context);

}
