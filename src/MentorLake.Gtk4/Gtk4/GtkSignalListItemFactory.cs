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

public class GtkSignalListItemFactoryHandle : GtkListItemFactoryHandle
{
	public static GtkSignalListItemFactoryHandle New()
	{
		return GtkSignalListItemFactoryExterns.gtk_signal_list_item_factory_new();
	}

}

public class GtkSignalListItemFactorySignal
{
	public string Value { get; set; }
	public GtkSignalListItemFactorySignal(string value) => Value = value;
}

public static class GtkSignalListItemFactorySignals
{
	public static GtkSignalListItemFactorySignal Bind = new("BindingTransform.MethodDeclaration");
	public static GtkSignalListItemFactorySignal Setup = new("BindingTransform.MethodDeclaration");
	public static GtkSignalListItemFactorySignal Teardown = new("BindingTransform.MethodDeclaration");
	public static GtkSignalListItemFactorySignal Unbind = new("BindingTransform.MethodDeclaration");
}

public static class GtkSignalListItemFactoryHandleExtensions
{
	public static GtkSignalListItemFactoryHandle Signal_Bind(this GtkSignalListItemFactoryHandle instance, GtkSignalListItemFactoryDelegates.Bind handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "bind", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkSignalListItemFactoryHandle Signal_Setup(this GtkSignalListItemFactoryHandle instance, GtkSignalListItemFactoryDelegates.Setup handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "setup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkSignalListItemFactoryHandle Signal_Teardown(this GtkSignalListItemFactoryHandle instance, GtkSignalListItemFactoryDelegates.Teardown handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "teardown", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkSignalListItemFactoryHandle Signal_Unbind(this GtkSignalListItemFactoryHandle instance, GtkSignalListItemFactoryDelegates.Unbind handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "unbind", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkSignalListItemFactoryDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Bind([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSignalListItemFactoryHandle>))] GtkSignalListItemFactoryHandle self, GObjectHandle @object, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Setup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSignalListItemFactoryHandle>))] GtkSignalListItemFactoryHandle self, GObjectHandle @object, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Teardown([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSignalListItemFactoryHandle>))] GtkSignalListItemFactoryHandle self, GObjectHandle @object, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Unbind([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSignalListItemFactoryHandle>))] GtkSignalListItemFactoryHandle self, GObjectHandle @object, IntPtr user_data);
}

internal class GtkSignalListItemFactoryExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSignalListItemFactoryHandle gtk_signal_list_item_factory_new();

}
