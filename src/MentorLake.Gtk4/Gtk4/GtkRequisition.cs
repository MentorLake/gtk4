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

public class GtkRequisitionHandle : BaseSafeHandle
{
	public static GtkRequisitionHandle New()
	{
		return GtkRequisitionExterns.gtk_requisition_new();
	}

}

internal class GtkRequisitionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkRequisitionHandle gtk_requisition_new();
}

public struct GtkRequisition
{
	public int width;
	public int height;
}
