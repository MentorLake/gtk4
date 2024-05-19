namespace MentorLake.Gtk4.Gdk4;

public class GdkKeyEventHandle : GdkEventHandle
{
}

public static class GdkKeyEventHandleExtensions
{
	public static GdkModifierType GetConsumedModifiers(this GdkKeyEventHandle @event)
	{
		return GdkKeyEventExterns.gdk_key_event_get_consumed_modifiers(@event);
	}

	public static uint GetKeycode(this GdkKeyEventHandle @event)
	{
		return GdkKeyEventExterns.gdk_key_event_get_keycode(@event);
	}

	public static uint GetKeyval(this GdkKeyEventHandle @event)
	{
		return GdkKeyEventExterns.gdk_key_event_get_keyval(@event);
	}

	public static uint GetLayout(this GdkKeyEventHandle @event)
	{
		return GdkKeyEventExterns.gdk_key_event_get_layout(@event);
	}

	public static uint GetLevel(this GdkKeyEventHandle @event)
	{
		return GdkKeyEventExterns.gdk_key_event_get_level(@event);
	}

	public static bool GetMatch(this GdkKeyEventHandle @event, out uint keyval, out GdkModifierType modifiers)
	{
		return GdkKeyEventExterns.gdk_key_event_get_match(@event, out keyval, out modifiers);
	}

	public static bool IsModifier(this GdkKeyEventHandle @event)
	{
		return GdkKeyEventExterns.gdk_key_event_is_modifier(@event);
	}

	public static GdkKeyMatch Matches(this GdkKeyEventHandle @event, uint keyval, GdkModifierType modifiers)
	{
		return GdkKeyEventExterns.gdk_key_event_matches(@event, keyval, modifiers);
	}

}

internal class GdkKeyEventExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkModifierType gdk_key_event_get_consumed_modifiers(GdkEventHandle @event);

	[DllImport(Libraries.Gdk4)]
	internal static extern uint gdk_key_event_get_keycode(GdkEventHandle @event);

	[DllImport(Libraries.Gdk4)]
	internal static extern uint gdk_key_event_get_keyval(GdkEventHandle @event);

	[DllImport(Libraries.Gdk4)]
	internal static extern uint gdk_key_event_get_layout(GdkEventHandle @event);

	[DllImport(Libraries.Gdk4)]
	internal static extern uint gdk_key_event_get_level(GdkEventHandle @event);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_key_event_get_match(GdkEventHandle @event, out uint keyval, out GdkModifierType modifiers);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_key_event_is_modifier(GdkEventHandle @event);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkKeyMatch gdk_key_event_matches(GdkEventHandle @event, uint keyval, GdkModifierType modifiers);

}
