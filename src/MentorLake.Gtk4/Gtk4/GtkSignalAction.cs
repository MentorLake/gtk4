namespace MentorLake.Gtk4.Gtk4;

public class GtkSignalActionHandle : GtkShortcutActionHandle
{
	public static GtkSignalActionHandle New(string signal_name)
	{
		return GtkSignalActionExterns.gtk_signal_action_new(signal_name);
	}

}

public static class GtkSignalActionHandleExtensions
{
	public static string GetSignalName(this GtkSignalActionHandle self)
	{
		return GtkSignalActionExterns.gtk_signal_action_get_signal_name(self);
	}

}

internal class GtkSignalActionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSignalActionHandle gtk_signal_action_new(string signal_name);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_signal_action_get_signal_name(GtkSignalActionHandle self);

}
