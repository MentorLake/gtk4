namespace MentorLake.Gtk4.Gdk4;

public class GdkCrossingEventHandle : GdkEventHandle
{
}

public static class GdkCrossingEventHandleExtensions
{
	public static GdkNotifyType GetDetail(this GdkCrossingEventHandle @event)
	{
		return GdkCrossingEventExterns.gdk_crossing_event_get_detail(@event);
	}

	public static bool GetFocus(this GdkCrossingEventHandle @event)
	{
		return GdkCrossingEventExterns.gdk_crossing_event_get_focus(@event);
	}

	public static GdkCrossingMode GetMode(this GdkCrossingEventHandle @event)
	{
		return GdkCrossingEventExterns.gdk_crossing_event_get_mode(@event);
	}

}

internal class GdkCrossingEventExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkNotifyType gdk_crossing_event_get_detail(GdkEventHandle @event);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_crossing_event_get_focus(GdkEventHandle @event);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkCrossingMode gdk_crossing_event_get_mode(GdkEventHandle @event);

}
