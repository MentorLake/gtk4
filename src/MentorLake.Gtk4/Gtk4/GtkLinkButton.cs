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

public class GtkLinkButtonHandle : GtkButtonHandle, GtkAccessibleHandle, GtkActionableHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkLinkButtonHandle New(string uri)
	{
		return GtkLinkButtonExterns.gtk_link_button_new(uri);
	}

	public static GtkLinkButtonHandle NewWithLabel(string uri, string label)
	{
		return GtkLinkButtonExterns.gtk_link_button_new_with_label(uri, label);
	}

}

public static class GtkLinkButtonSignalExtensions
{
	public static GtkLinkButtonHandle Signal_ActivateLink(this GtkLinkButtonHandle instance, GtkLinkButtonSignalDelegates.ActivateLink handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "activate_link", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkLinkButtonSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool ActivateLink([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkLinkButtonHandle>))] GtkLinkButtonHandle self, IntPtr user_data);
}


public static class GtkLinkButtonHandleExtensions
{
	public static string GetUri(this GtkLinkButtonHandle link_button)
	{
		return GtkLinkButtonExterns.gtk_link_button_get_uri(link_button);
	}

	public static bool GetVisited(this GtkLinkButtonHandle link_button)
	{
		return GtkLinkButtonExterns.gtk_link_button_get_visited(link_button);
	}

	public static GtkLinkButtonHandle SetUri(this GtkLinkButtonHandle link_button, string uri)
	{
		GtkLinkButtonExterns.gtk_link_button_set_uri(link_button, uri);
		return link_button;
	}

	public static GtkLinkButtonHandle SetVisited(this GtkLinkButtonHandle link_button, bool visited)
	{
		GtkLinkButtonExterns.gtk_link_button_set_visited(link_button, visited);
		return link_button;
	}

}

internal class GtkLinkButtonExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkLinkButtonHandle gtk_link_button_new(string uri);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkLinkButtonHandle gtk_link_button_new_with_label(string uri, string label);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_link_button_get_uri(GtkLinkButtonHandle link_button);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_link_button_get_visited(GtkLinkButtonHandle link_button);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_link_button_set_uri(GtkLinkButtonHandle link_button, string uri);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_link_button_set_visited(GtkLinkButtonHandle link_button, bool visited);

}
