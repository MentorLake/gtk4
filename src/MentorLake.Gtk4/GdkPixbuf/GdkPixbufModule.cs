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

namespace MentorLake.Gtk4.GdkPixbuf;

public class GdkPixbufModuleHandle : BaseSafeHandle
{
}

internal class GdkPixbufModuleExterns
{
}

public struct GdkPixbufModule
{
	public string module_name;
	public string module_path;
	public GModuleHandle module;
	public GdkPixbufFormatHandle info;
	public GdkPixbufModuleLoadFunc load;
	public GdkPixbufModuleLoadXpmDataFunc load_xpm_data;
	public GdkPixbufModuleBeginLoadFunc begin_load;
	public GdkPixbufModuleStopLoadFunc stop_load;
	public GdkPixbufModuleIncrementLoadFunc load_increment;
	public GdkPixbufModuleLoadAnimationFunc load_animation;
	public GdkPixbufModuleSaveFunc save;
	public GdkPixbufModuleSaveCallbackFunc save_to_callback;
	public GdkPixbufModuleSaveOptionSupportedFunc is_save_option_supported;
	public IntPtr _reserved1;
	public IntPtr _reserved2;
	public IntPtr _reserved3;
	public IntPtr _reserved4;
}
