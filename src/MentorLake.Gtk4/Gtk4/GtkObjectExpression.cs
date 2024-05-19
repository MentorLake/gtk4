namespace MentorLake.Gtk4.Gtk4;

public class GtkObjectExpressionHandle : GtkExpressionHandle
{
	public static GtkObjectExpressionHandle New(GObjectHandle @object)
	{
		return GtkObjectExpressionExterns.gtk_object_expression_new(@object);
	}

}

public static class GtkObjectExpressionHandleExtensions
{
	public static GObjectHandle GetObject(this GtkObjectExpressionHandle expression)
	{
		return GtkObjectExpressionExterns.gtk_object_expression_get_object(expression);
	}

}

internal class GtkObjectExpressionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkObjectExpressionHandle gtk_object_expression_new(GObjectHandle @object);

	[DllImport(Libraries.Gtk4)]
	internal static extern GObjectHandle gtk_object_expression_get_object(GtkExpressionHandle expression);

}
