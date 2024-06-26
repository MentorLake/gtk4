namespace MentorLake.Gtk4.Gtk4;

public class GtkAlternativeTriggerHandle : GtkShortcutTriggerHandle
{
	public static GtkAlternativeTriggerHandle New(GtkShortcutTriggerHandle first, GtkShortcutTriggerHandle second)
	{
		return GtkAlternativeTriggerExterns.gtk_alternative_trigger_new(first, second);
	}

}

public static class GtkAlternativeTriggerHandleExtensions
{
	public static GtkShortcutTriggerHandle GetFirst(this GtkAlternativeTriggerHandle self)
	{
		return GtkAlternativeTriggerExterns.gtk_alternative_trigger_get_first(self);
	}

	public static GtkShortcutTriggerHandle GetSecond(this GtkAlternativeTriggerHandle self)
	{
		return GtkAlternativeTriggerExterns.gtk_alternative_trigger_get_second(self);
	}

}

internal class GtkAlternativeTriggerExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAlternativeTriggerHandle gtk_alternative_trigger_new(GtkShortcutTriggerHandle first, GtkShortcutTriggerHandle second);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkShortcutTriggerHandle gtk_alternative_trigger_get_first(GtkAlternativeTriggerHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkShortcutTriggerHandle gtk_alternative_trigger_get_second(GtkAlternativeTriggerHandle self);

}
