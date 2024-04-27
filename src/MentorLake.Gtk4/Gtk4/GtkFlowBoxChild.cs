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

public class GtkFlowBoxChildHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkFlowBoxChildHandle New()
	{
		return GtkFlowBoxChildExterns.gtk_flow_box_child_new();
	}

}

public static class GtkFlowBoxChildSignalExtensions
{
	public static GtkFlowBoxChildHandle Signal_Activate(this GtkFlowBoxChildHandle instance, GtkFlowBoxChildSignalDelegates.Activate handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkFlowBoxChildSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFlowBoxChildHandle>))] GtkFlowBoxChildHandle self, IntPtr user_data);
}


public static class GtkFlowBoxChildHandleExtensions
{
	public static GtkFlowBoxChildHandle Changed(this GtkFlowBoxChildHandle child)
	{
		GtkFlowBoxChildExterns.gtk_flow_box_child_changed(child);
		return child;
	}

	public static GtkWidgetHandle GetChild(this GtkFlowBoxChildHandle self)
	{
		return GtkFlowBoxChildExterns.gtk_flow_box_child_get_child(self);
	}

	public static int GetIndex(this GtkFlowBoxChildHandle child)
	{
		return GtkFlowBoxChildExterns.gtk_flow_box_child_get_index(child);
	}

	public static bool IsSelected(this GtkFlowBoxChildHandle child)
	{
		return GtkFlowBoxChildExterns.gtk_flow_box_child_is_selected(child);
	}

	public static GtkFlowBoxChildHandle SetChild(this GtkFlowBoxChildHandle self, GtkWidgetHandle child)
	{
		GtkFlowBoxChildExterns.gtk_flow_box_child_set_child(self, child);
		return self;
	}

}

internal class GtkFlowBoxChildExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFlowBoxChildHandle gtk_flow_box_child_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flow_box_child_changed(GtkFlowBoxChildHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_flow_box_child_get_child(GtkFlowBoxChildHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_flow_box_child_get_index(GtkFlowBoxChildHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_flow_box_child_is_selected(GtkFlowBoxChildHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flow_box_child_set_child(GtkFlowBoxChildHandle self, GtkWidgetHandle child);

}
