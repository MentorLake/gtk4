namespace MentorLake.Gtk4.Gtk4;

public class GtkAlertDialogHandle : GObjectHandle
{
	public static GtkAlertDialogHandle New(string format, IntPtr @__arglist)
	{
		return GtkAlertDialogExterns.gtk_alert_dialog_new(format, @__arglist);
	}

}

public static class GtkAlertDialogHandleExtensions
{
	public static GtkAlertDialogHandle Choose(this GtkAlertDialogHandle self, GtkWindowHandle parent, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GtkAlertDialogExterns.gtk_alert_dialog_choose(self, parent, cancellable, callback, user_data);
		return self;
	}

	public static int ChooseFinish(this GtkAlertDialogHandle self, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GtkAlertDialogExterns.gtk_alert_dialog_choose_finish(self, result, out error);
	}

	public static IntPtr GetButtons(this GtkAlertDialogHandle self)
	{
		return GtkAlertDialogExterns.gtk_alert_dialog_get_buttons(self);
	}

	public static int GetCancelButton(this GtkAlertDialogHandle self)
	{
		return GtkAlertDialogExterns.gtk_alert_dialog_get_cancel_button(self);
	}

	public static int GetDefaultButton(this GtkAlertDialogHandle self)
	{
		return GtkAlertDialogExterns.gtk_alert_dialog_get_default_button(self);
	}

	public static string GetDetail(this GtkAlertDialogHandle self)
	{
		return GtkAlertDialogExterns.gtk_alert_dialog_get_detail(self);
	}

	public static string GetMessage(this GtkAlertDialogHandle self)
	{
		return GtkAlertDialogExterns.gtk_alert_dialog_get_message(self);
	}

	public static bool GetModal(this GtkAlertDialogHandle self)
	{
		return GtkAlertDialogExterns.gtk_alert_dialog_get_modal(self);
	}

	public static GtkAlertDialogHandle SetButtons(this GtkAlertDialogHandle self, string labels)
	{
		GtkAlertDialogExterns.gtk_alert_dialog_set_buttons(self, labels);
		return self;
	}

	public static GtkAlertDialogHandle SetCancelButton(this GtkAlertDialogHandle self, int button)
	{
		GtkAlertDialogExterns.gtk_alert_dialog_set_cancel_button(self, button);
		return self;
	}

	public static GtkAlertDialogHandle SetDefaultButton(this GtkAlertDialogHandle self, int button)
	{
		GtkAlertDialogExterns.gtk_alert_dialog_set_default_button(self, button);
		return self;
	}

	public static GtkAlertDialogHandle SetDetail(this GtkAlertDialogHandle self, string detail)
	{
		GtkAlertDialogExterns.gtk_alert_dialog_set_detail(self, detail);
		return self;
	}

	public static GtkAlertDialogHandle SetMessage(this GtkAlertDialogHandle self, string message)
	{
		GtkAlertDialogExterns.gtk_alert_dialog_set_message(self, message);
		return self;
	}

	public static GtkAlertDialogHandle SetModal(this GtkAlertDialogHandle self, bool modal)
	{
		GtkAlertDialogExterns.gtk_alert_dialog_set_modal(self, modal);
		return self;
	}

	public static GtkAlertDialogHandle Show(this GtkAlertDialogHandle self, GtkWindowHandle parent)
	{
		GtkAlertDialogExterns.gtk_alert_dialog_show(self, parent);
		return self;
	}

}

internal class GtkAlertDialogExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAlertDialogHandle gtk_alert_dialog_new(string format, IntPtr @__arglist);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_alert_dialog_choose(GtkAlertDialogHandle self, GtkWindowHandle parent, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_alert_dialog_choose_finish(GtkAlertDialogHandle self, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern IntPtr gtk_alert_dialog_get_buttons(GtkAlertDialogHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_alert_dialog_get_cancel_button(GtkAlertDialogHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_alert_dialog_get_default_button(GtkAlertDialogHandle self);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_alert_dialog_get_detail(GtkAlertDialogHandle self);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_alert_dialog_get_message(GtkAlertDialogHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_alert_dialog_get_modal(GtkAlertDialogHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_alert_dialog_set_buttons(GtkAlertDialogHandle self, string labels);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_alert_dialog_set_cancel_button(GtkAlertDialogHandle self, int button);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_alert_dialog_set_default_button(GtkAlertDialogHandle self, int button);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_alert_dialog_set_detail(GtkAlertDialogHandle self, string detail);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_alert_dialog_set_message(GtkAlertDialogHandle self, string message);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_alert_dialog_set_modal(GtkAlertDialogHandle self, bool modal);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_alert_dialog_show(GtkAlertDialogHandle self, GtkWindowHandle parent);

}
