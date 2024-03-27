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

public class GtkAboutDialogHandle : GtkWindowHandle
{
	public static GtkAboutDialogHandle New()
	{
		return GtkAboutDialogExterns.gtk_about_dialog_new();
	}
}

public class GtkAboutDialogSignal
{
	public string Value { get; set; }
	public GtkAboutDialogSignal(string value) => Value = value;
}

public static class GtkAboutDialogSignals
{
	public static GtkAboutDialogSignal ActivateLink = new("activate-link");
}

public static class GtkAboutDialogHandleExtensions
{
	public static GtkAboutDialogHandle AddCreditSection(this GtkAboutDialogHandle about, string section_name, string[] people)
	{
		GtkAboutDialogExterns.gtk_about_dialog_add_credit_section(about, section_name, people);
		return about;
	}

	public static string GetArtists(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_artists(about);
	}

	public static string GetAuthors(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_authors(about);
	}

	public static string GetComments(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_comments(about);
	}

	public static string GetCopyright(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_copyright(about);
	}

	public static string GetDocumenters(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_documenters(about);
	}

	public static string GetLicense(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_license(about);
	}

	public static GtkLicense GetLicenseType(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_license_type(about);
	}

	public static GdkPaintableHandle GetLogo(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_logo(about);
	}

	public static string GetLogoIconName(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_logo_icon_name(about);
	}

	public static string GetProgramName(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_program_name(about);
	}

	public static string GetSystemInformation(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_system_information(about);
	}

	public static string GetTranslatorCredits(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_translator_credits(about);
	}

	public static string GetVersion(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_version(about);
	}

	public static string GetWebsite(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_website(about);
	}

	public static string GetWebsiteLabel(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_website_label(about);
	}

	public static bool GetWrapLicense(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_wrap_license(about);
	}

	public static GtkAboutDialogHandle SetArtists(this GtkAboutDialogHandle about, string[] artists)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_artists(about, artists);
		return about;
	}

	public static GtkAboutDialogHandle SetAuthors(this GtkAboutDialogHandle about, string[] authors)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_authors(about, authors);
		return about;
	}

	public static GtkAboutDialogHandle SetComments(this GtkAboutDialogHandle about, string comments)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_comments(about, comments);
		return about;
	}

	public static GtkAboutDialogHandle SetCopyright(this GtkAboutDialogHandle about, string copyright)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_copyright(about, copyright);
		return about;
	}

	public static GtkAboutDialogHandle SetDocumenters(this GtkAboutDialogHandle about, string[] documenters)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_documenters(about, documenters);
		return about;
	}

	public static GtkAboutDialogHandle SetLicense(this GtkAboutDialogHandle about, string license)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_license(about, license);
		return about;
	}

	public static GtkAboutDialogHandle SetLicenseType(this GtkAboutDialogHandle about, GtkLicense license_type)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_license_type(about, license_type);
		return about;
	}

	public static GtkAboutDialogHandle SetLogo(this GtkAboutDialogHandle about, GdkPaintableHandle logo)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_logo(about, logo);
		return about;
	}

	public static GtkAboutDialogHandle SetLogoIconName(this GtkAboutDialogHandle about, string icon_name)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_logo_icon_name(about, icon_name);
		return about;
	}

	public static GtkAboutDialogHandle SetProgramName(this GtkAboutDialogHandle about, string name)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_program_name(about, name);
		return about;
	}

	public static GtkAboutDialogHandle SetSystemInformation(this GtkAboutDialogHandle about, string system_information)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_system_information(about, system_information);
		return about;
	}

	public static GtkAboutDialogHandle SetTranslatorCredits(this GtkAboutDialogHandle about, string translator_credits)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_translator_credits(about, translator_credits);
		return about;
	}

	public static GtkAboutDialogHandle SetVersion(this GtkAboutDialogHandle about, string version)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_version(about, version);
		return about;
	}

	public static GtkAboutDialogHandle SetWebsite(this GtkAboutDialogHandle about, string website)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_website(about, website);
		return about;
	}

	public static GtkAboutDialogHandle SetWebsiteLabel(this GtkAboutDialogHandle about, string website_label)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_website_label(about, website_label);
		return about;
	}

	public static GtkAboutDialogHandle SetWrapLicense(this GtkAboutDialogHandle about, bool wrap_license)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_wrap_license(about, wrap_license);
		return about;
	}

	public static GtkAboutDialogHandle Connect(this GtkAboutDialogHandle instance, GtkAboutDialogSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkAboutDialogExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_about_dialog_add_credit_section(GtkAboutDialogHandle about, string section_name, string[] people);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_about_dialog_get_artists(GtkAboutDialogHandle about);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_about_dialog_get_authors(GtkAboutDialogHandle about);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_about_dialog_get_comments(GtkAboutDialogHandle about);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_about_dialog_get_copyright(GtkAboutDialogHandle about);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_about_dialog_get_documenters(GtkAboutDialogHandle about);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_about_dialog_get_license(GtkAboutDialogHandle about);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkLicense gtk_about_dialog_get_license_type(GtkAboutDialogHandle about);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkPaintableHandle gtk_about_dialog_get_logo(GtkAboutDialogHandle about);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_about_dialog_get_logo_icon_name(GtkAboutDialogHandle about);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_about_dialog_get_program_name(GtkAboutDialogHandle about);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_about_dialog_get_system_information(GtkAboutDialogHandle about);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_about_dialog_get_translator_credits(GtkAboutDialogHandle about);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_about_dialog_get_version(GtkAboutDialogHandle about);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_about_dialog_get_website(GtkAboutDialogHandle about);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_about_dialog_get_website_label(GtkAboutDialogHandle about);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_about_dialog_get_wrap_license(GtkAboutDialogHandle about);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_about_dialog_set_artists(GtkAboutDialogHandle about, string[] artists);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_about_dialog_set_authors(GtkAboutDialogHandle about, string[] authors);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_about_dialog_set_comments(GtkAboutDialogHandle about, string comments);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_about_dialog_set_copyright(GtkAboutDialogHandle about, string copyright);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_about_dialog_set_documenters(GtkAboutDialogHandle about, string[] documenters);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_about_dialog_set_license(GtkAboutDialogHandle about, string license);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_about_dialog_set_license_type(GtkAboutDialogHandle about, GtkLicense license_type);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_about_dialog_set_logo(GtkAboutDialogHandle about, GdkPaintableHandle logo);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_about_dialog_set_logo_icon_name(GtkAboutDialogHandle about, string icon_name);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_about_dialog_set_program_name(GtkAboutDialogHandle about, string name);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_about_dialog_set_system_information(GtkAboutDialogHandle about, string system_information);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_about_dialog_set_translator_credits(GtkAboutDialogHandle about, string translator_credits);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_about_dialog_set_version(GtkAboutDialogHandle about, string version);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_about_dialog_set_website(GtkAboutDialogHandle about, string website);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_about_dialog_set_website_label(GtkAboutDialogHandle about, string website_label);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_about_dialog_set_wrap_license(GtkAboutDialogHandle about, bool wrap_license);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAboutDialogHandle gtk_about_dialog_new();
}
