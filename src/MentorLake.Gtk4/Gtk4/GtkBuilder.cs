namespace MentorLake.Gtk4.Gtk4;

public class GtkBuilderHandle : GObjectHandle
{
	public static GtkBuilderHandle New()
	{
		return GtkBuilderExterns.gtk_builder_new();
	}

	public static GtkBuilderHandle NewFromFile(string filename)
	{
		return GtkBuilderExterns.gtk_builder_new_from_file(filename);
	}

	public static GtkBuilderHandle NewFromResource(string resource_path)
	{
		return GtkBuilderExterns.gtk_builder_new_from_resource(resource_path);
	}

	public static GtkBuilderHandle NewFromString(string @string, int length)
	{
		return GtkBuilderExterns.gtk_builder_new_from_string(@string, length);
	}

}

public static class GtkBuilderHandleExtensions
{
	public static bool AddFromFile(this GtkBuilderHandle builder, string filename, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_add_from_file(builder, filename, out error);
	}

	public static bool AddFromResource(this GtkBuilderHandle builder, string resource_path, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_add_from_resource(builder, resource_path, out error);
	}

	public static bool AddFromString(this GtkBuilderHandle builder, string buffer, int length, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_add_from_string(builder, buffer, length, out error);
	}

	public static bool AddObjectsFromFile(this GtkBuilderHandle builder, string filename, string[] object_ids, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_add_objects_from_file(builder, filename, object_ids, out error);
	}

	public static bool AddObjectsFromResource(this GtkBuilderHandle builder, string resource_path, string[] object_ids, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_add_objects_from_resource(builder, resource_path, object_ids, out error);
	}

	public static bool AddObjectsFromString(this GtkBuilderHandle builder, string buffer, int length, string[] object_ids, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_add_objects_from_string(builder, buffer, length, object_ids, out error);
	}

	public static GClosureHandle CreateClosure(this GtkBuilderHandle builder, string function_name, GtkBuilderClosureFlags flags, GObjectHandle @object, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_create_closure(builder, function_name, flags, @object, out error);
	}

	public static GtkBuilderHandle ExposeObject(this GtkBuilderHandle builder, string name, GObjectHandle @object)
	{
		GtkBuilderExterns.gtk_builder_expose_object(builder, name, @object);
		return builder;
	}

	public static bool ExtendWithTemplate(this GtkBuilderHandle builder, GObjectHandle @object, GType template_type, string buffer, int length, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_extend_with_template(builder, @object, template_type, buffer, length, out error);
	}

	public static GObjectHandle GetCurrentObject(this GtkBuilderHandle builder)
	{
		return GtkBuilderExterns.gtk_builder_get_current_object(builder);
	}

	public static GObjectHandle GetObject(this GtkBuilderHandle builder, string name)
	{
		return GtkBuilderExterns.gtk_builder_get_object(builder, name);
	}

	public static GSListHandle GetObjects(this GtkBuilderHandle builder)
	{
		return GtkBuilderExterns.gtk_builder_get_objects(builder);
	}

	public static GtkBuilderScopeHandle GetScope(this GtkBuilderHandle builder)
	{
		return GtkBuilderExterns.gtk_builder_get_scope(builder);
	}

	public static string GetTranslationDomain(this GtkBuilderHandle builder)
	{
		return GtkBuilderExterns.gtk_builder_get_translation_domain(builder);
	}

	public static GType GetTypeFromName(this GtkBuilderHandle builder, string type_name)
	{
		return GtkBuilderExterns.gtk_builder_get_type_from_name(builder, type_name);
	}

	public static GtkBuilderHandle SetCurrentObject(this GtkBuilderHandle builder, GObjectHandle current_object)
	{
		GtkBuilderExterns.gtk_builder_set_current_object(builder, current_object);
		return builder;
	}

	public static GtkBuilderHandle SetScope(this GtkBuilderHandle builder, GtkBuilderScopeHandle scope)
	{
		GtkBuilderExterns.gtk_builder_set_scope(builder, scope);
		return builder;
	}

	public static GtkBuilderHandle SetTranslationDomain(this GtkBuilderHandle builder, string domain)
	{
		GtkBuilderExterns.gtk_builder_set_translation_domain(builder, domain);
		return builder;
	}

	public static bool ValueFromString(this GtkBuilderHandle builder, GParamSpecHandle pspec, string @string, out GValue value, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_value_from_string(builder, pspec, @string, out value, out error);
	}

	public static bool ValueFromStringType(this GtkBuilderHandle builder, GType type, string @string, out GValue value, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_value_from_string_type(builder, type, @string, out value, out error);
	}

}

internal class GtkBuilderExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBuilderHandle gtk_builder_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBuilderHandle gtk_builder_new_from_file(string filename);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBuilderHandle gtk_builder_new_from_resource(string resource_path);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBuilderHandle gtk_builder_new_from_string(string @string, int length);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_builder_add_from_file(GtkBuilderHandle builder, string filename, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_builder_add_from_resource(GtkBuilderHandle builder, string resource_path, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_builder_add_from_string(GtkBuilderHandle builder, string buffer, int length, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_builder_add_objects_from_file(GtkBuilderHandle builder, string filename, string[] object_ids, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_builder_add_objects_from_resource(GtkBuilderHandle builder, string resource_path, string[] object_ids, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_builder_add_objects_from_string(GtkBuilderHandle builder, string buffer, int length, string[] object_ids, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern GClosureHandle gtk_builder_create_closure(GtkBuilderHandle builder, string function_name, GtkBuilderClosureFlags flags, GObjectHandle @object, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_builder_expose_object(GtkBuilderHandle builder, string name, GObjectHandle @object);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_builder_extend_with_template(GtkBuilderHandle builder, GObjectHandle @object, GType template_type, string buffer, int length, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern GObjectHandle gtk_builder_get_current_object(GtkBuilderHandle builder);

	[DllImport(Libraries.Gtk4)]
	internal static extern GObjectHandle gtk_builder_get_object(GtkBuilderHandle builder, string name);

	[DllImport(Libraries.Gtk4)]
	internal static extern GSListHandle gtk_builder_get_objects(GtkBuilderHandle builder);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBuilderScopeHandle gtk_builder_get_scope(GtkBuilderHandle builder);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_builder_get_translation_domain(GtkBuilderHandle builder);

	[DllImport(Libraries.Gtk4)]
	internal static extern GType gtk_builder_get_type_from_name(GtkBuilderHandle builder, string type_name);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_builder_set_current_object(GtkBuilderHandle builder, GObjectHandle current_object);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_builder_set_scope(GtkBuilderHandle builder, GtkBuilderScopeHandle scope);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_builder_set_translation_domain(GtkBuilderHandle builder, string domain);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_builder_value_from_string(GtkBuilderHandle builder, GParamSpecHandle pspec, string @string, out GValue value, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_builder_value_from_string_type(GtkBuilderHandle builder, GType type, string @string, out GValue value, out GErrorHandle error);

}
