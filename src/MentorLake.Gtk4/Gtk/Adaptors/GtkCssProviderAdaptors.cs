using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCssProviderAdaptors
{
	public static string ToString(this GtkCssProviderHandle provider)
	{
		return GtkCssProviderExterns.gtk_css_provider_to_string(provider);
	}

	public static GtkCssProviderHandle LoadFromData(this GtkCssProviderHandle css_provider, string data, nint length)
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

	public static GtkCssProviderHandle LoadNamed(this GtkCssProviderHandle provider, string name, string variant)
	{
		GtkCssProviderExterns.gtk_css_provider_load_named(provider, name, variant);
		return provider;
	}
}
