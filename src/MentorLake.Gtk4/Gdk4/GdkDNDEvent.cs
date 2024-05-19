namespace MentorLake.Gtk4.Gdk4;

public class GdkDNDEventHandle : GdkEventHandle
{
}

public static class GdkDNDEventHandleExtensions
{
	public static GdkDropHandle GdkDndEventGetDrop(this GdkDNDEventHandle @event)
	{
		return GdkDNDEventExterns.gdk_dnd_event_get_drop(@event);
	}

}

internal class GdkDNDEventExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDropHandle gdk_dnd_event_get_drop(GdkEventHandle @event);

}
