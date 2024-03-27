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

namespace MentorLake.Gtk4.Gdk4;

public class GdkVulkanContextHandle : GdkDrawContextHandle
{
}

public class GdkVulkanContextSignal
{
	public string Value { get; set; }
	public GdkVulkanContextSignal(string value) => Value = value;
}

public static class GdkVulkanContextSignals
{
	public static GdkVulkanContextSignal ImagesUpdated = new("images-updated");
}

public static class GdkVulkanContextHandleExtensions
{
	public static GdkVulkanContextHandle Connect(this GdkVulkanContextHandle instance, GdkVulkanContextSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GdkVulkanContextExterns
{
}
