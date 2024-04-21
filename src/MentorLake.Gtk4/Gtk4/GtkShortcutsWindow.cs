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

public class GtkShortcutsWindowHandle : GtkWindowHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkNativeHandle, GtkRootHandle, GtkShortcutManagerHandle
{
}

public class GtkShortcutsWindowSignal
{
	public string Value { get; set; }
	public GtkShortcutsWindowSignal(string value) => Value = value;
}

public static class GtkShortcutsWindowSignals
{
	public static GtkShortcutsWindowSignal Close = new("BindingTransform.MethodDeclaration");
	public static GtkShortcutsWindowSignal Search = new("BindingTransform.MethodDeclaration");
}

public static class GtkShortcutsWindowHandleExtensions
{
	public static GtkShortcutsWindowHandle AddSection(this GtkShortcutsWindowHandle self, GtkShortcutsSectionHandle section)
	{
		GtkShortcutsWindowExterns.gtk_shortcuts_window_add_section(self, section);
		return self;
	}

	public static GtkShortcutsWindowHandle Signal_Close(this GtkShortcutsWindowHandle instance, GtkShortcutsWindowDelegates.Close handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "close", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkShortcutsWindowHandle Signal_Search(this GtkShortcutsWindowHandle instance, GtkShortcutsWindowDelegates.Search handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "search", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkShortcutsWindowDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkShortcutsWindowHandle>))] GtkShortcutsWindowHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Search([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkShortcutsWindowHandle>))] GtkShortcutsWindowHandle self, IntPtr user_data);
}

internal class GtkShortcutsWindowExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_shortcuts_window_add_section(GtkShortcutsWindowHandle self, GtkShortcutsSectionHandle section);

}
