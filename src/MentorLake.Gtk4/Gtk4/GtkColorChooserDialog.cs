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

public class GtkColorChooserDialogHandle : GtkDialogHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkColorChooserHandle, GtkConstraintTargetHandle, GtkNativeHandle, GtkRootHandle, GtkShortcutManagerHandle
{
	public static GtkColorChooserDialogHandle New(string title, GtkWindowHandle parent)
	{
		return GtkColorChooserDialogExterns.gtk_color_chooser_dialog_new(title, parent);
	}

}

public static class GtkColorChooserDialogHandleExtensions
{
}

internal class GtkColorChooserDialogExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkColorChooserDialogHandle gtk_color_chooser_dialog_new(string title, GtkWindowHandle parent);

}
