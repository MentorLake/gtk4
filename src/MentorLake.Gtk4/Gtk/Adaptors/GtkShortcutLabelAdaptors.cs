using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkShortcutLabelAdaptors
{
	public static string GetAccelerator(this GtkShortcutLabelHandle self)
	{
		return GtkShortcutLabelExterns.gtk_shortcut_label_get_accelerator(self);
	}

	public static GtkShortcutLabelHandle SetAccelerator(this GtkShortcutLabelHandle self, string accelerator)
	{
		GtkShortcutLabelExterns.gtk_shortcut_label_set_accelerator(self, accelerator);
		return self;
	}

	public static string GetDisabledText(this GtkShortcutLabelHandle self)
	{
		return GtkShortcutLabelExterns.gtk_shortcut_label_get_disabled_text(self);
	}

	public static GtkShortcutLabelHandle SetDisabledText(this GtkShortcutLabelHandle self, string disabled_text)
	{
		GtkShortcutLabelExterns.gtk_shortcut_label_set_disabled_text(self, disabled_text);
		return self;
	}
}
