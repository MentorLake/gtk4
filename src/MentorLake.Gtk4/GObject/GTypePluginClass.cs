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

namespace MentorLake.Gtk4.GObject;

public class GTypePluginClassHandle : BaseSafeHandle
{
}

internal class GTypePluginClassExterns
{
}

public struct GTypePluginClass
{
	public GTypePluginUse use_plugin;
	public GTypePluginUnuse unuse_plugin;
	public GTypePluginCompleteTypeInfo complete_type_info;
	public GTypePluginCompleteInterfaceInfo complete_interface_info;
}
