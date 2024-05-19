using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gio;

public class GPropertyActionHandle : GObjectHandle, GActionHandle
{
	public static GPropertyActionHandle New(string name, GObjectHandle @object, string property_name)
	{
		return GPropertyActionExterns.g_property_action_new(name, @object, property_name);
	}

}

public static class GPropertyActionHandleExtensions
{
}

internal class GPropertyActionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GPropertyActionHandle g_property_action_new(string name, GObjectHandle @object, string property_name);

}
