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

public interface GRemoteActionGroupHandle
{
}

public static class GRemoteActionGroupHandleExtensions
{
	public static GRemoteActionGroupHandle ActivateActionFull(this GRemoteActionGroupHandle remote, string action_name, GVariantHandle parameter, GVariantHandle platform_data)
	{
		GRemoteActionGroupExterns.g_remote_action_group_activate_action_full(remote, action_name, parameter, platform_data);
		return remote;
	}

	public static GRemoteActionGroupHandle ChangeActionStateFull(this GRemoteActionGroupHandle remote, string action_name, GVariantHandle value, GVariantHandle platform_data)
	{
		GRemoteActionGroupExterns.g_remote_action_group_change_action_state_full(remote, action_name, value, platform_data);
		return remote;
	}

}

internal class GRemoteActionGroupExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_remote_action_group_activate_action_full(GRemoteActionGroupHandle remote, string action_name, GVariantHandle parameter, GVariantHandle platform_data);
	[DllImport(Libraries.Gio)]
	internal static extern void g_remote_action_group_change_action_state_full(GRemoteActionGroupHandle remote, string action_name, GVariantHandle value, GVariantHandle platform_data);
}
