namespace MentorLake.Gtk4.Gtk4;

public class GtkShortcutLabelHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkShortcutLabelHandle New(string accelerator)
	{
		return GtkShortcutLabelExterns.gtk_shortcut_label_new(accelerator);
	}

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
	internal static extern GtkShortcutLabelHandle gtk_shortcut_label_new(string accelerator);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_shortcut_label_get_accelerator(GtkShortcutLabelHandle self);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_shortcut_label_get_disabled_text(GtkShortcutLabelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_shortcut_label_set_accelerator(GtkShortcutLabelHandle self, string accelerator);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_shortcut_label_set_disabled_text(GtkShortcutLabelHandle self, string disabled_text);

}
