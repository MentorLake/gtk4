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

public class GtkCellRendererComboHandle : GtkCellRendererTextHandle
{
	public static GtkCellRendererComboHandle New()
	{
		return GtkCellRendererComboExterns.gtk_cell_renderer_combo_new();
	}

}

public static class GtkCellRendererComboSignalExtensions
{
	public static GtkCellRendererComboHandle Signal_Changed(this GtkCellRendererComboHandle instance, GtkCellRendererComboSignalDelegates.Changed handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkCellRendererComboSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellRendererComboHandle>))] GtkCellRendererComboHandle self, string path_string, GtkTreeIterHandle new_iter, IntPtr user_data);
}


public static class GtkCellRendererComboHandleExtensions
{
}

internal class GtkCellRendererComboExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellRendererComboHandle gtk_cell_renderer_combo_new();

}
