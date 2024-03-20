using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;
public static class GtkDropTargetAdaptors
{
	public static GtkDropTargetHandle SetGtypes(this GtkDropTargetHandle self, GTypeHandle types, nuint n_types)
	{
		GtkDropTargetExterns.gtk_drop_target_set_gtypes(self, types, n_types);
		return self;
	}

	public static GTypeHandle GetGtypes(this GtkDropTargetHandle self, out nuint n_types)
	{
		return GtkDropTargetExterns.gtk_drop_target_get_gtypes(self, out n_types);
	}

	public static GdkContentFormatsHandle GetFormats(this GtkDropTargetHandle self)
	{
		return GtkDropTargetExterns.gtk_drop_target_get_formats(self);
	}

	public static GtkDropTargetHandle SetActions(this GtkDropTargetHandle self, GdkDragAction actions)
	{
		GtkDropTargetExterns.gtk_drop_target_set_actions(self, actions);
		return self;
	}

	public static GdkDragAction GetActions(this GtkDropTargetHandle self)
	{
		return GtkDropTargetExterns.gtk_drop_target_get_actions(self);
	}

	public static GtkDropTargetHandle SetPreload(this GtkDropTargetHandle self, int preload)
	{
		GtkDropTargetExterns.gtk_drop_target_set_preload(self, preload);
		return self;
	}

	public static int GetPreload(this GtkDropTargetHandle self)
	{
		return GtkDropTargetExterns.gtk_drop_target_get_preload(self);
	}

	public static GdkDropHandle GetDrop(this GtkDropTargetHandle self)
	{
		return GtkDropTargetExterns.gtk_drop_target_get_drop(self);
	}

	public static GdkDropHandle GetCurrentDrop(this GtkDropTargetHandle self)
	{
		return GtkDropTargetExterns.gtk_drop_target_get_current_drop(self);
	}

	public static GValueHandle GetValue(this GtkDropTargetHandle self)
	{
		return GtkDropTargetExterns.gtk_drop_target_get_value(self);
	}

	public static GtkDropTargetHandle Reject(this GtkDropTargetHandle self)
	{
		GtkDropTargetExterns.gtk_drop_target_reject(self);
		return self;
	}
}
