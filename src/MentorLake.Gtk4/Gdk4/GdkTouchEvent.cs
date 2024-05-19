namespace MentorLake.Gtk4.Gdk4;

public class GdkTouchEventHandle : GdkEventHandle
{
}

public static class GdkTouchEventHandleExtensions
{
	public static bool GetEmulatingPointer(this GdkTouchEventHandle @event)
	{
		return GdkTouchEventExterns.gdk_touch_event_get_emulating_pointer(@event);
	}

}

internal class GdkTouchEventExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_touch_event_get_emulating_pointer(GdkEventHandle @event);

}
