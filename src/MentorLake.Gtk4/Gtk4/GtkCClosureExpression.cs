namespace MentorLake.Gtk4.Gtk4;

public class GtkCClosureExpressionHandle : GtkExpressionHandle
{
	public static GtkCClosureExpressionHandle GtkCclosureExpressionNew(GType value_type, GClosureMarshal marshal, uint n_params, GtkExpressionHandle[] @params, IntPtr callback_func, IntPtr user_data, GClosureNotify user_destroy)
	{
		return GtkCClosureExpressionExterns.gtk_cclosure_expression_new(value_type, marshal, n_params, @params, callback_func, user_data, user_destroy);
	}

}

public static class GtkCClosureExpressionHandleExtensions
{
}

internal class GtkCClosureExpressionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCClosureExpressionHandle gtk_cclosure_expression_new(GType value_type, GClosureMarshal marshal, uint n_params, GtkExpressionHandle[] @params, IntPtr callback_func, IntPtr user_data, GClosureNotify user_destroy);

}
