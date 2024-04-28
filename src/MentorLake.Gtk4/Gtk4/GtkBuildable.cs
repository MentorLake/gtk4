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

public interface GtkBuildableHandle
{
}

internal class GtkBuildableHandleImpl : BaseSafeHandle, GtkBuildableHandle
{
}

public static class GtkBuildableHandleExtensions
{
	public static string GetBuildableId(this GtkBuildableHandle buildable)
	{
		return GtkBuildableExterns.gtk_buildable_get_buildable_id(buildable);
	}

}

internal class GtkBuildableExterns
{
	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_buildable_get_buildable_id(GtkBuildableHandle buildable);

}
