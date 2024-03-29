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

public class GtkCssProviderHandle : GObjectHandle
{
	public static GtkCssProviderHandle New()
	{
		return GtkCssProviderExterns.gtk_css_provider_new();
	}

}

public class GtkCssProviderSignal
{
	public string Value { get; set; }
	public GtkCssProviderSignal(string value) => Value = value;
}

public static class GtkCssProviderSignals
{
	public static GtkCssProviderSignal ParsingError = new("parsing-error");
}

public static class GtkCssProviderHandleExtensions
{
	public static GtkCssProviderHandle LoadFromBytes(this GtkCssProviderHandle css_provider, GBytesHandle data)
	{
		GtkCssProviderExterns.gtk_css_provider_load_from_bytes(css_provider, data);
		return css_provider;
	}

	public static GtkCssProviderHandle LoadFromData(this GtkCssProviderHandle css_provider, string data, int length)
	{
		GtkCssProviderExterns.gtk_css_provider_load_from_data(css_provider, data, length);
		return css_provider;
	}

	public static GtkCssProviderHandle LoadFromFile(this GtkCssProviderHandle css_provider, GFileHandle file)
	{
		GtkCssProviderExterns.gtk_css_provider_load_from_file(css_provider, file);
		return css_provider;
	}

	public static GtkCssProviderHandle LoadFromPath(this GtkCssProviderHandle css_provider, string path)
	{
		GtkCssProviderExterns.gtk_css_provider_load_from_path(css_provider, path);
		return css_provider;
	}

	public static GtkCssProviderHandle LoadFromResource(this GtkCssProviderHandle css_provider, string resource_path)
	{
		GtkCssProviderExterns.gtk_css_provider_load_from_resource(css_provider, resource_path);
		return css_provider;
	}

	public static GtkCssProviderHandle LoadFromString(this GtkCssProviderHandle css_provider, string @string)
	{
		GtkCssProviderExterns.gtk_css_provider_load_from_string(css_provider, @string);
		return css_provider;
	}

	public static GtkCssProviderHandle LoadNamed(this GtkCssProviderHandle provider, string name, string variant)
	{
		GtkCssProviderExterns.gtk_css_provider_load_named(provider, name, variant);
		return provider;
	}

	public static string ToString(this GtkCssProviderHandle provider)
	{
		return GtkCssProviderExterns.gtk_css_provider_to_string(provider);
	}

	public static GtkCssProviderHandle Connect(this GtkCssProviderHandle instance, GtkCssProviderSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkCssProviderExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCssProviderHandle gtk_css_provider_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_css_provider_load_from_bytes(GtkCssProviderHandle css_provider, GBytesHandle data);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_css_provider_load_from_data(GtkCssProviderHandle css_provider, string data, int length);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_css_provider_load_from_file(GtkCssProviderHandle css_provider, GFileHandle file);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_css_provider_load_from_path(GtkCssProviderHandle css_provider, string path);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_css_provider_load_from_resource(GtkCssProviderHandle css_provider, string resource_path);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_css_provider_load_from_string(GtkCssProviderHandle css_provider, string @string);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_css_provider_load_named(GtkCssProviderHandle provider, string name, string variant);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_css_provider_to_string(GtkCssProviderHandle provider);
}
