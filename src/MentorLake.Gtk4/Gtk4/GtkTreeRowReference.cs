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

public class GtkTreeRowReferenceHandle : BaseSafeHandle
{
	public static GtkTreeRowReferenceHandle New(GtkTreeModelHandle model, GtkTreePathHandle path)
	{
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_new(model, path);
	}

	public static GtkTreeRowReferenceHandle NewProxy(GObjectHandle proxy, GtkTreeModelHandle model, GtkTreePathHandle path)
	{
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_new_proxy(proxy, model, path);
	}

}

internal class GtkTreeRowReferenceExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeRowReferenceHandle gtk_tree_row_reference_new(GtkTreeModelHandle model, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeRowReferenceHandle gtk_tree_row_reference_new_proxy(GObjectHandle proxy, GtkTreeModelHandle model, GtkTreePathHandle path);

}

public struct GtkTreeRowReference
{
}
