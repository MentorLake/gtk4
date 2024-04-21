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

public class GtkEventControllerLegacyHandle : GtkEventControllerHandle
{
	public static GtkEventControllerLegacyHandle New()
	{
		return GtkEventControllerLegacyExterns.gtk_event_controller_legacy_new();
	}

}

public class GtkEventControllerLegacySignal
{
	public string Value { get; set; }
	public GtkEventControllerLegacySignal(string value) => Value = value;
}

public static class GtkEventControllerLegacySignals
{
	public static GtkEventControllerLegacySignal Event = new("BindingTransform.MethodDeclaration");
}

public static class GtkEventControllerLegacyHandleExtensions
{
	public static GtkEventControllerLegacyHandle Signal_Event(this GtkEventControllerLegacyHandle instance, GtkEventControllerLegacyDelegates.Event handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkEventControllerLegacyDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool Event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerLegacyHandle>))] GtkEventControllerLegacyHandle self, GdkEventHandle @event, IntPtr user_data);
}

internal class GtkEventControllerLegacyExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEventControllerLegacyHandle gtk_event_controller_legacy_new();

}
