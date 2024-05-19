namespace MentorLake.Gtk4.Gdk4;

public class GdkButtonEventHandle : GdkEventHandle
{
}

public static class GdkButtonEventHandleExtensions
{
	public static uint GetButton(this GdkButtonEventHandle @event)
	{
		return GdkButtonEventExterns.gdk_button_event_get_button(@event);
	}

}

internal class GdkButtonEventExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern uint gdk_button_event_get_button(GdkEventHandle @event);

}
