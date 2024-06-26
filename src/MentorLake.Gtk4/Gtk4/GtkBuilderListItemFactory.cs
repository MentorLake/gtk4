namespace MentorLake.Gtk4.Gtk4;

public class GtkBuilderListItemFactoryHandle : GtkListItemFactoryHandle
{
	public static GtkBuilderListItemFactoryHandle NewFromBytes(GtkBuilderScopeHandle scope, GBytesHandle bytes)
	{
		return GtkBuilderListItemFactoryExterns.gtk_builder_list_item_factory_new_from_bytes(scope, bytes);
	}

	public static GtkBuilderListItemFactoryHandle NewFromResource(GtkBuilderScopeHandle scope, string resource_path)
	{
		return GtkBuilderListItemFactoryExterns.gtk_builder_list_item_factory_new_from_resource(scope, resource_path);
	}

}

public static class GtkBuilderListItemFactoryHandleExtensions
{
	public static GBytesHandle GetBytes(this GtkBuilderListItemFactoryHandle self)
	{
		return GtkBuilderListItemFactoryExterns.gtk_builder_list_item_factory_get_bytes(self);
	}

	public static string GetResource(this GtkBuilderListItemFactoryHandle self)
	{
		return GtkBuilderListItemFactoryExterns.gtk_builder_list_item_factory_get_resource(self);
	}

	public static GtkBuilderScopeHandle GetScope(this GtkBuilderListItemFactoryHandle self)
	{
		return GtkBuilderListItemFactoryExterns.gtk_builder_list_item_factory_get_scope(self);
	}

}

internal class GtkBuilderListItemFactoryExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBuilderListItemFactoryHandle gtk_builder_list_item_factory_new_from_bytes(GtkBuilderScopeHandle scope, GBytesHandle bytes);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBuilderListItemFactoryHandle gtk_builder_list_item_factory_new_from_resource(GtkBuilderScopeHandle scope, string resource_path);

	[DllImport(Libraries.Gtk4)]
	internal static extern GBytesHandle gtk_builder_list_item_factory_get_bytes(GtkBuilderListItemFactoryHandle self);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_builder_list_item_factory_get_resource(GtkBuilderListItemFactoryHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBuilderScopeHandle gtk_builder_list_item_factory_get_scope(GtkBuilderListItemFactoryHandle self);

}
