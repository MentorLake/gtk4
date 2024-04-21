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

public class GtkSwitchHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkActionableHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkSwitchHandle New()
	{
		return GtkSwitchExterns.gtk_switch_new();
	}

}

public class GtkSwitchSignal
{
	public string Value { get; set; }
	public GtkSwitchSignal(string value) => Value = value;
}

public static class GtkSwitchSignals
{
	public static GtkSwitchSignal Activate = new("BindingTransform.MethodDeclaration");
	public static GtkSwitchSignal StateSet = new("BindingTransform.MethodDeclaration");
}

public static class GtkSwitchHandleExtensions
{
	public static bool GetActive(this GtkSwitchHandle self)
	{
		return GtkSwitchExterns.gtk_switch_get_active(self);
	}

	public static bool GetState(this GtkSwitchHandle self)
	{
		return GtkSwitchExterns.gtk_switch_get_state(self);
	}

	public static GtkSwitchHandle SetActive(this GtkSwitchHandle self, bool is_active)
	{
		GtkSwitchExterns.gtk_switch_set_active(self, is_active);
		return self;
	}

	public static GtkSwitchHandle SetState(this GtkSwitchHandle self, bool state)
	{
		GtkSwitchExterns.gtk_switch_set_state(self, state);
		return self;
	}

	public static GtkSwitchHandle Signal_Activate(this GtkSwitchHandle instance, GtkSwitchDelegates.Activate handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkSwitchHandle Signal_StateSet(this GtkSwitchHandle instance, GtkSwitchDelegates.StateSet handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "state_set", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkSwitchDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSwitchHandle>))] GtkSwitchHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool StateSet([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSwitchHandle>))] GtkSwitchHandle self, bool state, IntPtr user_data);
}

internal class GtkSwitchExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSwitchHandle gtk_switch_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_switch_get_active(GtkSwitchHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_switch_get_state(GtkSwitchHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_switch_set_active(GtkSwitchHandle self, bool is_active);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_switch_set_state(GtkSwitchHandle self, bool state);

}
