namespace MentorLake.Gtk4.Gdk4;

public class GdkFocusEventHandle : GdkEventHandle
{
}

public static class GdkFocusEventHandleExtensions
{
	public static bool GetIn(this GdkFocusEventHandle @event)
	{
		return GdkFocusEventExterns.gdk_focus_event_get_in(@event);
	}

}

internal class GdkFocusEventExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_focus_event_get_in(GdkEventHandle @event);

}
