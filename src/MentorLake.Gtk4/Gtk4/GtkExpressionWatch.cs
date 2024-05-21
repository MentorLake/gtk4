namespace MentorLake.Gtk4.Gtk4;

public class GtkExpressionWatchHandle : BaseSafeHandle
{
}


public static class GtkExpressionWatchHandleExtensions
{
	public static bool Evaluate(this GtkExpressionWatchHandle watch, GValueHandle value)
	{
		return GtkExpressionWatchExterns.gtk_expression_watch_evaluate(watch, value);
	}

	public static GtkExpressionWatchHandle Ref(this GtkExpressionWatchHandle watch)
	{
		return GtkExpressionWatchExterns.gtk_expression_watch_ref(watch);
	}

	public static GtkExpressionWatchHandle Unref(this GtkExpressionWatchHandle watch)
	{
		GtkExpressionWatchExterns.gtk_expression_watch_unref(watch);
		return watch;
	}

	public static GtkExpressionWatchHandle Unwatch(this GtkExpressionWatchHandle watch)
	{
		GtkExpressionWatchExterns.gtk_expression_watch_unwatch(watch);
		return watch;
	}

}
internal class GtkExpressionWatchExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_expression_watch_evaluate(GtkExpressionWatchHandle watch, GValueHandle value);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkExpressionWatchHandle gtk_expression_watch_ref(GtkExpressionWatchHandle watch);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_expression_watch_unref(GtkExpressionWatchHandle watch);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_expression_watch_unwatch(GtkExpressionWatchHandle watch);

}

public struct GtkExpressionWatch
{
}
