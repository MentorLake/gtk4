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

public interface GtkTreeDragDestHandle
{
}

internal class GtkTreeDragDestHandleImpl : BaseSafeHandle, GtkTreeDragDestHandle
{
}

public static class GtkTreeDragDestHandleExtensions
{
	public static bool DragDataReceived(this GtkTreeDragDestHandle drag_dest, GtkTreePathHandle dest, GValueHandle value)
	{
		return GtkTreeDragDestExterns.gtk_tree_drag_dest_drag_data_received(drag_dest, dest, value);
	}

	public static bool RowDropPossible(this GtkTreeDragDestHandle drag_dest, GtkTreePathHandle dest_path, GValueHandle value)
	{
		return GtkTreeDragDestExterns.gtk_tree_drag_dest_row_drop_possible(drag_dest, dest_path, value);
	}

}

internal class GtkTreeDragDestExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_drag_dest_drag_data_received(GtkTreeDragDestHandle drag_dest, GtkTreePathHandle dest, GValueHandle value);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_drag_dest_row_drop_possible(GtkTreeDragDestHandle drag_dest, GtkTreePathHandle dest_path, GValueHandle value);

}
