namespace MentorLake.Gtk4.Gtk4;

public class GtkClosureExpressionHandle : GtkExpressionHandle
{
	public static GtkClosureExpressionHandle New(GType value_type, GClosureHandle closure, uint n_params, GtkExpressionHandle[] @params)
	{
		return GtkClosureExpressionExterns.gtk_closure_expression_new(value_type, closure, n_params, @params);
	}

}

public static class GtkClosureExpressionHandleExtensions
{
}

internal class GtkClosureExpressionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkClosureExpressionHandle gtk_closure_expression_new(GType value_type, GClosureHandle closure, uint n_params, GtkExpressionHandle[] @params);

}
