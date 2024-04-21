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

public class GtkFileChooserNativeHandle : GtkNativeDialogHandle, GtkFileChooserHandle
{
	public static GtkFileChooserNativeHandle New(string title, GtkWindowHandle parent, GtkFileChooserAction action, string accept_label, string cancel_label)
	{
		return GtkFileChooserNativeExterns.gtk_file_chooser_native_new(title, parent, action, accept_label, cancel_label);
	}

}

public static class GtkFileChooserNativeHandleExtensions
{
	public static string GetAcceptLabel(this GtkFileChooserNativeHandle self)
	{
		return GtkFileChooserNativeExterns.gtk_file_chooser_native_get_accept_label(self);
	}

	public static string GetCancelLabel(this GtkFileChooserNativeHandle self)
	{
		return GtkFileChooserNativeExterns.gtk_file_chooser_native_get_cancel_label(self);
	}

	public static GtkFileChooserNativeHandle SetAcceptLabel(this GtkFileChooserNativeHandle self, string accept_label)
	{
		GtkFileChooserNativeExterns.gtk_file_chooser_native_set_accept_label(self, accept_label);
		return self;
	}

	public static GtkFileChooserNativeHandle SetCancelLabel(this GtkFileChooserNativeHandle self, string cancel_label)
	{
		GtkFileChooserNativeExterns.gtk_file_chooser_native_set_cancel_label(self, cancel_label);
		return self;
	}

}

internal class GtkFileChooserNativeExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFileChooserNativeHandle gtk_file_chooser_native_new(string title, GtkWindowHandle parent, GtkFileChooserAction action, string accept_label, string cancel_label);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_chooser_native_get_accept_label(GtkFileChooserNativeHandle self);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_chooser_native_get_cancel_label(GtkFileChooserNativeHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_chooser_native_set_accept_label(GtkFileChooserNativeHandle self, string accept_label);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_chooser_native_set_cancel_label(GtkFileChooserNativeHandle self, string cancel_label);

}
