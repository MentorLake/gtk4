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

public class GtkFontChooserDialogHandle : GtkDialogHandle
{
	public static GtkFontChooserDialogHandle New(string title, GtkWindowHandle parent)
	{
		return GtkFontChooserDialogExterns.gtk_font_chooser_dialog_new(title, parent);
	}
}

public static class GtkFontChooserDialogSignals
{
}

public static class GtkFontChooserDialogHandleExtensions
{
}

internal class GtkFontChooserDialogExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFontChooserDialogHandle gtk_font_chooser_dialog_new(string title, GtkWindowHandle parent);
}
