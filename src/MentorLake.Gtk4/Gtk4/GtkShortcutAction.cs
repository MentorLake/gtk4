namespace MentorLake.Gtk4.Gtk4;

public class GtkShortcutActionHandle : GObjectHandle
{
	public static GtkShortcutActionHandle ParseString(string @string)
	{
		return GtkShortcutActionExterns.gtk_shortcut_action_parse_string(@string);
	}

}

public static class GtkShortcutActionHandleExtensions
{
	public static bool Activate(this GtkShortcutActionHandle self, GtkShortcutActionFlags flags, GtkWidgetHandle widget, GVariantHandle args)
	{
		return GtkShortcutActionExterns.gtk_shortcut_action_activate(self, flags, widget, args);
	}

	public static GtkShortcutActionHandle Print(this GtkShortcutActionHandle self, GStringHandle @string)
	{
		GtkShortcutActionExterns.gtk_shortcut_action_print(self, @string);
		return self;
	}

	public static string ToString(this GtkShortcutActionHandle self)
	{
		return GtkShortcutActionExterns.gtk_shortcut_action_to_string(self);
	}

}

internal class GtkShortcutActionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkShortcutActionHandle gtk_shortcut_action_parse_string(string @string);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_shortcut_action_activate(GtkShortcutActionHandle self, GtkShortcutActionFlags flags, GtkWidgetHandle widget, GVariantHandle args);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_shortcut_action_print(GtkShortcutActionHandle self, GStringHandle @string);

	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_shortcut_action_to_string(GtkShortcutActionHandle self);

}
