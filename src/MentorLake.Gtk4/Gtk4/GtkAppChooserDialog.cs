using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkAppChooserDialogHandle : GtkDialogHandle, GtkAccessibleHandle, GtkAppChooserHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkNativeHandle, GtkRootHandle, GtkShortcutManagerHandle
{
	public static GtkAppChooserDialogHandle New(GtkWindowHandle parent, GtkDialogFlags flags, GFileHandle file)
	{
		return GtkAppChooserDialogExterns.gtk_app_chooser_dialog_new(parent, flags, file);
	}

	public static GtkAppChooserDialogHandle NewForContentType(GtkWindowHandle parent, GtkDialogFlags flags, string content_type)
	{
		return GtkAppChooserDialogExterns.gtk_app_chooser_dialog_new_for_content_type(parent, flags, content_type);
	}

}

public static class GtkAppChooserDialogHandleExtensions
{
	public static string GetHeading(this GtkAppChooserDialogHandle self)
	{
		return GtkAppChooserDialogExterns.gtk_app_chooser_dialog_get_heading(self);
	}

	public static GtkWidgetHandle GetWidget(this GtkAppChooserDialogHandle self)
	{
		return GtkAppChooserDialogExterns.gtk_app_chooser_dialog_get_widget(self);
	}

	public static GtkAppChooserDialogHandle SetHeading(this GtkAppChooserDialogHandle self, string heading)
	{
		GtkAppChooserDialogExterns.gtk_app_chooser_dialog_set_heading(self, heading);
		return self;
	}

}

internal class GtkAppChooserDialogExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAppChooserDialogHandle gtk_app_chooser_dialog_new(GtkWindowHandle parent, GtkDialogFlags flags, GFileHandle file);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAppChooserDialogHandle gtk_app_chooser_dialog_new_for_content_type(GtkWindowHandle parent, GtkDialogFlags flags, string content_type);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_app_chooser_dialog_get_heading(GtkAppChooserDialogHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_app_chooser_dialog_get_widget(GtkAppChooserDialogHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_app_chooser_dialog_set_heading(GtkAppChooserDialogHandle self, string heading);

}
