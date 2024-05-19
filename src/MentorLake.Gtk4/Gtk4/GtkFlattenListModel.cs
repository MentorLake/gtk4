namespace MentorLake.Gtk4.Gtk4;

public class GtkFlattenListModelHandle : GObjectHandle, GListModelHandle, GtkSectionModelHandle
{
	public static GtkFlattenListModelHandle New(GListModelHandle model)
	{
		return GtkFlattenListModelExterns.gtk_flatten_list_model_new(model);
	}

}

public static class GtkFlattenListModelHandleExtensions
{
	public static GListModelHandle GetModel(this GtkFlattenListModelHandle self)
	{
		return GtkFlattenListModelExterns.gtk_flatten_list_model_get_model(self);
	}

	public static GListModelHandle GetModelForItem(this GtkFlattenListModelHandle self, uint position)
	{
		return GtkFlattenListModelExterns.gtk_flatten_list_model_get_model_for_item(self, position);
	}

	public static GtkFlattenListModelHandle SetModel(this GtkFlattenListModelHandle self, GListModelHandle model)
	{
		GtkFlattenListModelExterns.gtk_flatten_list_model_set_model(self, model);
		return self;
	}

}

internal class GtkFlattenListModelExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFlattenListModelHandle gtk_flatten_list_model_new(GListModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern GListModelHandle gtk_flatten_list_model_get_model(GtkFlattenListModelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GListModelHandle gtk_flatten_list_model_get_model_for_item(GtkFlattenListModelHandle self, uint position);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flatten_list_model_set_model(GtkFlattenListModelHandle self, GListModelHandle model);

}
