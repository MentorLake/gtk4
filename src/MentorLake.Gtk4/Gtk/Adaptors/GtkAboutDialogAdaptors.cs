using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkAboutDialogAdaptors
{
	public static string GetProgramName(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_program_name(about);
	}

	public static GtkAboutDialogHandle SetProgramName(this GtkAboutDialogHandle about, string name)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_program_name(about, name);
		return about;
	}

	public static string GetVersion(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_version(about);
	}

	public static GtkAboutDialogHandle SetVersion(this GtkAboutDialogHandle about, string version)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_version(about, version);
		return about;
	}

	public static string GetCopyright(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_copyright(about);
	}

	public static GtkAboutDialogHandle SetCopyright(this GtkAboutDialogHandle about, string copyright)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_copyright(about, copyright);
		return about;
	}

	public static string GetComments(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_comments(about);
	}

	public static GtkAboutDialogHandle SetComments(this GtkAboutDialogHandle about, string comments)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_comments(about, comments);
		return about;
	}

	public static string GetLicense(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_license(about);
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

	public static GtkLicense GetLicenseType(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_license_type(about);
	}

	public static int GetWrapLicense(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_wrap_license(about);
	}

	public static GtkAboutDialogHandle SetWrapLicense(this GtkAboutDialogHandle about, int wrap_license)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_wrap_license(about, wrap_license);
		return about;
	}

	public static string GetSystemInformation(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_system_information(about);
	}

	public static GtkAboutDialogHandle SetSystemInformation(this GtkAboutDialogHandle about, string system_information)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_system_information(about, system_information);
		return about;
	}

	public static string GetWebsite(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_website(about);
	}

	public static GtkAboutDialogHandle SetWebsite(this GtkAboutDialogHandle about, string website)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_website(about, website);
		return about;
	}

	public static string GetWebsiteLabel(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_website_label(about);
	}

	public static GtkAboutDialogHandle SetWebsiteLabel(this GtkAboutDialogHandle about, string website_label)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_website_label(about, website_label);
		return about;
	}

	public static string GetAuthors(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_authors(about);
	}

	public static GtkAboutDialogHandle SetAuthors(this GtkAboutDialogHandle about, string[] authors)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_authors(about, authors);
		return about;
	}

	public static string GetDocumenters(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_documenters(about);
	}

	public static GtkAboutDialogHandle SetDocumenters(this GtkAboutDialogHandle about, string[] documenters)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_documenters(about, documenters);
		return about;
	}

	public static string GetArtists(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_artists(about);
	}

	public static GtkAboutDialogHandle SetArtists(this GtkAboutDialogHandle about, string[] artists)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_artists(about, artists);
		return about;
	}

	public static string GetTranslatorCredits(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_translator_credits(about);
	}

	public static GtkAboutDialogHandle SetTranslatorCredits(this GtkAboutDialogHandle about, string translator_credits)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_translator_credits(about, translator_credits);
		return about;
	}

	public static GdkPaintableHandle GetLogo(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_logo(about);
	}

	public static GtkAboutDialogHandle SetLogo(this GtkAboutDialogHandle about, GdkPaintableHandle logo)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_logo(about, logo);
		return about;
	}

	public static string GetLogoIconName(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_logo_icon_name(about);
	}

	public static GtkAboutDialogHandle SetLogoIconName(this GtkAboutDialogHandle about, string icon_name)
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_logo_icon_name(about, icon_name);
		return about;
	}

	public static GtkAboutDialogHandle AddCreditSection(this GtkAboutDialogHandle about, string section_name, string[] people)
	{
		GtkAboutDialogExterns.gtk_about_dialog_add_credit_section(about, section_name, people);
		return about;
	}
}
