using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkFileChooserNativeAdaptors
{
	public static string GetAcceptLabel(this GtkFileChooserNativeHandle self)
	{
		return GtkFileChooserNativeExterns.gtk_file_chooser_native_get_accept_label(self);
	}

	public static GtkFileChooserNativeHandle SetAcceptLabel(this GtkFileChooserNativeHandle self, string accept_label)
	{
		GtkFileChooserNativeExterns.gtk_file_chooser_native_set_accept_label(self, accept_label);
		return self;
	}

	public static string GetCancelLabel(this GtkFileChooserNativeHandle self)
	{
		return GtkFileChooserNativeExterns.gtk_file_chooser_native_get_cancel_label(self);
	}

	public static GtkFileChooserNativeHandle SetCancelLabel(this GtkFileChooserNativeHandle self, string cancel_label)
	{
		GtkFileChooserNativeExterns.gtk_file_chooser_native_set_cancel_label(self, cancel_label);
		return self;
	}
}
