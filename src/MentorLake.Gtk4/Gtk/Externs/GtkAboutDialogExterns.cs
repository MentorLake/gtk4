using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkAboutDialogExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_get_program_name")]
    internal static extern string gtk_about_dialog_get_program_name(this GtkAboutDialogHandle about);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_set_program_name")]
    internal static extern void gtk_about_dialog_set_program_name(this GtkAboutDialogHandle about, string name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_get_version")]
    internal static extern string gtk_about_dialog_get_version(this GtkAboutDialogHandle about);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_set_version")]
    internal static extern void gtk_about_dialog_set_version(this GtkAboutDialogHandle about, string version);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_get_copyright")]
    internal static extern string gtk_about_dialog_get_copyright(this GtkAboutDialogHandle about);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_set_copyright")]
    internal static extern void gtk_about_dialog_set_copyright(this GtkAboutDialogHandle about, string copyright);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_get_comments")]
    internal static extern string gtk_about_dialog_get_comments(this GtkAboutDialogHandle about);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_set_comments")]
    internal static extern void gtk_about_dialog_set_comments(this GtkAboutDialogHandle about, string comments);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_get_license")]
    internal static extern string gtk_about_dialog_get_license(this GtkAboutDialogHandle about);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_set_license")]
    internal static extern void gtk_about_dialog_set_license(this GtkAboutDialogHandle about, string license);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_set_license_type")]
    internal static extern void gtk_about_dialog_set_license_type(this GtkAboutDialogHandle about, GtkLicense license_type);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_get_license_type")]
    internal static extern GtkLicense gtk_about_dialog_get_license_type(this GtkAboutDialogHandle about);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_get_wrap_license")]
    internal static extern int gtk_about_dialog_get_wrap_license(this GtkAboutDialogHandle about);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_set_wrap_license")]
    internal static extern void gtk_about_dialog_set_wrap_license(this GtkAboutDialogHandle about, int wrap_license);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_get_system_information")]
    internal static extern string gtk_about_dialog_get_system_information(this GtkAboutDialogHandle about);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_set_system_information")]
    internal static extern void gtk_about_dialog_set_system_information(this GtkAboutDialogHandle about, string system_information);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_get_website")]
    internal static extern string gtk_about_dialog_get_website(this GtkAboutDialogHandle about);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_set_website")]
    internal static extern void gtk_about_dialog_set_website(this GtkAboutDialogHandle about, string website);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_get_website_label")]
    internal static extern string gtk_about_dialog_get_website_label(this GtkAboutDialogHandle about);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_set_website_label")]
    internal static extern void gtk_about_dialog_set_website_label(this GtkAboutDialogHandle about, string website_label);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_get_authors")]
    internal static extern string gtk_about_dialog_get_authors(this GtkAboutDialogHandle about);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_set_authors")]
    internal static extern void gtk_about_dialog_set_authors(this GtkAboutDialogHandle about, string[] authors);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_get_documenters")]
    internal static extern string gtk_about_dialog_get_documenters(this GtkAboutDialogHandle about);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_set_documenters")]
    internal static extern void gtk_about_dialog_set_documenters(this GtkAboutDialogHandle about, string[] documenters);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_get_artists")]
    internal static extern string gtk_about_dialog_get_artists(this GtkAboutDialogHandle about);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_set_artists")]
    internal static extern void gtk_about_dialog_set_artists(this GtkAboutDialogHandle about, string[] artists);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_get_translator_credits")]
    internal static extern string gtk_about_dialog_get_translator_credits(this GtkAboutDialogHandle about);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_set_translator_credits")]
    internal static extern void gtk_about_dialog_set_translator_credits(this GtkAboutDialogHandle about, string translator_credits);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_get_logo")]
    internal static extern GdkPaintableHandle gtk_about_dialog_get_logo(this GtkAboutDialogHandle about);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_set_logo")]
    internal static extern void gtk_about_dialog_set_logo(this GtkAboutDialogHandle about, GdkPaintableHandle logo);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_get_logo_icon_name")]
    internal static extern string gtk_about_dialog_get_logo_icon_name(this GtkAboutDialogHandle about);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_set_logo_icon_name")]
    internal static extern void gtk_about_dialog_set_logo_icon_name(this GtkAboutDialogHandle about, string icon_name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_about_dialog_add_credit_section")]
    internal static extern void gtk_about_dialog_add_credit_section(this GtkAboutDialogHandle about, string section_name, string[] people);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkAboutDialogHandle gtk_about_dialog_new();
}
