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

public class GtkShortcutLabelHandle : GtkWidgetHandle
{
	public static GtkShortcutLabelHandle New(string accelerator)
	{
		return GtkShortcutLabelExterns.gtk_shortcut_label_new(accelerator);
	}
}

public static class GtkShortcutLabelSignals
{
}

public static class GtkShortcutLabelHandleExtensions
{
	public static string GetAccelerator(this GtkShortcutLabelHandle self)
	{
		return GtkShortcutLabelExterns.gtk_shortcut_label_get_accelerator(self);
	}

	public static string GetDisabledText(this GtkShortcutLabelHandle self)
	{
		return GtkShortcutLabelExterns.gtk_shortcut_label_get_disabled_text(self);
	}

	public static GtkShortcutLabelHandle SetAccelerator(this GtkShortcutLabelHandle self, string accelerator)
	{
		GtkShortcutLabelExterns.gtk_shortcut_label_set_accelerator(self, accelerator);
		return self;
	}

	public static GtkShortcutLabelHandle SetDisabledText(this GtkShortcutLabelHandle self, string disabled_text)
	{
		GtkShortcutLabelExterns.gtk_shortcut_label_set_disabled_text(self, disabled_text);
		return self;
	}

}

internal class GtkShortcutLabelExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_shortcut_label_get_accelerator(GtkShortcutLabelHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_shortcut_label_get_disabled_text(GtkShortcutLabelHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_shortcut_label_set_accelerator(GtkShortcutLabelHandle self, string accelerator);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_shortcut_label_set_disabled_text(GtkShortcutLabelHandle self, string disabled_text);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkShortcutLabelHandle gtk_shortcut_label_new(string accelerator);
}
