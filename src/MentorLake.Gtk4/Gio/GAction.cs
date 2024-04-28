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

public interface GActionHandle
{
}

internal class GActionHandleImpl : BaseSafeHandle, GActionHandle
{
}

public static class GActionHandleExtensions
{
	public static GActionHandle Activate(this GActionHandle action, GVariantHandle parameter)
	{
		GActionExterns.g_action_activate(action, parameter);
		return action;
	}

	public static GActionHandle ChangeState(this GActionHandle action, GVariantHandle value)
	{
		GActionExterns.g_action_change_state(action, value);
		return action;
	}

	public static bool GetEnabled(this GActionHandle action)
	{
		return GActionExterns.g_action_get_enabled(action);
	}

	public static string GetName(this GActionHandle action)
	{
		return GActionExterns.g_action_get_name(action);
	}

	public static GVariantTypeHandle GetParameterType(this GActionHandle action)
	{
		return GActionExterns.g_action_get_parameter_type(action);
	}

	public static GVariantHandle GetState(this GActionHandle action)
	{
		return GActionExterns.g_action_get_state(action);
	}

	public static GVariantHandle GetStateHint(this GActionHandle action)
	{
		return GActionExterns.g_action_get_state_hint(action);
	}

	public static GVariantTypeHandle GetStateType(this GActionHandle action)
	{
		return GActionExterns.g_action_get_state_type(action);
	}

}

internal class GActionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_action_activate(GActionHandle action, GVariantHandle parameter);

	[DllImport(Libraries.Gio)]
	internal static extern void g_action_change_state(GActionHandle action, GVariantHandle value);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_action_get_enabled(GActionHandle action);

	[DllImport(Libraries.Gio)]
	internal static extern string g_action_get_name(GActionHandle action);

	[DllImport(Libraries.Gio)]
	internal static extern GVariantTypeHandle g_action_get_parameter_type(GActionHandle action);

	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_action_get_state(GActionHandle action);

	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_action_get_state_hint(GActionHandle action);

	[DllImport(Libraries.Gio)]
	internal static extern GVariantTypeHandle g_action_get_state_type(GActionHandle action);

}
