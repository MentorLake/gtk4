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

public class GtkAccessibleListHandle : BaseSafeHandle
{
	public static GtkAccessibleListHandle NewFromArray(GtkAccessibleHandle[] accessibles, int n_accessibles)
	{
		return GtkAccessibleListExterns.gtk_accessible_list_new_from_array(accessibles, n_accessibles);
	}

	public static GtkAccessibleListHandle NewFromList(GListHandle list)
	{
		return GtkAccessibleListExterns.gtk_accessible_list_new_from_list(list);
	}

}

internal class GtkAccessibleListExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAccessibleListHandle gtk_accessible_list_new_from_array(GtkAccessibleHandle[] accessibles, int n_accessibles);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAccessibleListHandle gtk_accessible_list_new_from_list(GListHandle list);

}

public struct GtkAccessibleList
{
}
