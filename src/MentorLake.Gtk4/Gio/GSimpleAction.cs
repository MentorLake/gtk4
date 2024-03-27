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

namespace MentorLake.Gtk4.Gio;

public class GSimpleActionHandle : GObjectHandle
{
	public static GSimpleActionHandle New(string name, GVariantTypeHandle parameter_type)
	{
		return GSimpleActionExterns.g_simple_action_new(name, parameter_type);
	}
	public static GSimpleActionHandle NewStateful(string name, GVariantTypeHandle parameter_type, GVariantHandle state)
	{
		return GSimpleActionExterns.g_simple_action_new_stateful(name, parameter_type, state);
	}
}

public class GSimpleActionSignal
{
	public string Value { get; set; }
	public GSimpleActionSignal(string value) => Value = value;
}

public static class GSimpleActionSignals
{
	public static GSimpleActionSignal Activate = new("activate");
	public static GSimpleActionSignal ChangeState = new("change-state");
}

public static class GSimpleActionHandleExtensions
{
	public static GSimpleActionHandle SetEnabled(this GSimpleActionHandle simple, bool enabled)
	{
		GSimpleActionExterns.g_simple_action_set_enabled(simple, enabled);
		return simple;
	}

	public static GSimpleActionHandle SetState(this GSimpleActionHandle simple, GVariantHandle value)
	{
		GSimpleActionExterns.g_simple_action_set_state(simple, value);
		return simple;
	}

	public static GSimpleActionHandle SetStateHint(this GSimpleActionHandle simple, GVariantHandle state_hint)
	{
		GSimpleActionExterns.g_simple_action_set_state_hint(simple, state_hint);
		return simple;
	}

	public static GSimpleActionHandle Connect(this GSimpleActionHandle instance, GSimpleActionSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GSimpleActionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_action_set_enabled(GSimpleActionHandle simple, bool enabled);
	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_action_set_state(GSimpleActionHandle simple, GVariantHandle value);
	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_action_set_state_hint(GSimpleActionHandle simple, GVariantHandle state_hint);
	[DllImport(Libraries.Gio)]
	internal static extern GSimpleActionHandle g_simple_action_new(string name, GVariantTypeHandle parameter_type);
	[DllImport(Libraries.Gio)]
	internal static extern GSimpleActionHandle g_simple_action_new_stateful(string name, GVariantTypeHandle parameter_type, GVariantHandle state);
}
