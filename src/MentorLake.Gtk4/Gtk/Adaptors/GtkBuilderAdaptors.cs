using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;
public static class GtkBuilderAdaptors
{
	public static int AddFromFile(this GtkBuilderHandle builder, string filename, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_add_from_file(builder, filename, out error);
	}

	public static int AddFromResource(this GtkBuilderHandle builder, string resource_path, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_add_from_resource(builder, resource_path, out error);
	}

	public static int AddFromString(this GtkBuilderHandle builder, string buffer, nint length, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_add_from_string(builder, buffer, length, out error);
	}

	public static int AddObjectsFromFile(this GtkBuilderHandle builder, string filename, string[] object_ids, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_add_objects_from_file(builder, filename, object_ids, out error);
	}

	public static int AddObjectsFromResource(this GtkBuilderHandle builder, string resource_path, string[] object_ids, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_add_objects_from_resource(builder, resource_path, object_ids, out error);
	}

	public static int AddObjectsFromString(this GtkBuilderHandle builder, string buffer, nint length, string[] object_ids, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_add_objects_from_string(builder, buffer, length, object_ids, out error);
	}

	public static GObjectHandle GetObject(this GtkBuilderHandle builder, string name)
	{
		return GtkBuilderExterns.gtk_builder_get_object(builder, name);
	}

	public static GSListHandle GetObjects(this GtkBuilderHandle builder)
	{
		return GtkBuilderExterns.gtk_builder_get_objects(builder);
	}

	public static GtkBuilderHandle ExposeObject(this GtkBuilderHandle builder, string name, GObjectHandle @object)
	{
		GtkBuilderExterns.gtk_builder_expose_object(builder, name, @object);
		return builder;
	}

	public static GObjectHandle GetCurrentObject(this GtkBuilderHandle builder)
	{
		return GtkBuilderExterns.gtk_builder_get_current_object(builder);
	}

	public static GtkBuilderHandle SetCurrentObject(this GtkBuilderHandle builder, GObjectHandle current_object)
	{
		GtkBuilderExterns.gtk_builder_set_current_object(builder, current_object);
		return builder;
	}

	public static GtkBuilderHandle SetTranslationDomain(this GtkBuilderHandle builder, string domain)
	{
		GtkBuilderExterns.gtk_builder_set_translation_domain(builder, domain);
		return builder;
	}

	public static string GetTranslationDomain(this GtkBuilderHandle builder)
	{
		return GtkBuilderExterns.gtk_builder_get_translation_domain(builder);
	}

	public static GtkBuilderScopeHandle GetScope(this GtkBuilderHandle builder)
	{
		return GtkBuilderExterns.gtk_builder_get_scope(builder);
	}

	public static GtkBuilderHandle SetScope(this GtkBuilderHandle builder, GtkBuilderScopeHandle scope)
	{
		GtkBuilderExterns.gtk_builder_set_scope(builder, scope);
		return builder;
	}

	public static GType GetTypeFromName(this GtkBuilderHandle builder, string type_name)
	{
		return GtkBuilderExterns.gtk_builder_get_type_from_name(builder, type_name);
	}

	public static int ValueFromString(this GtkBuilderHandle builder, GParamSpecHandle pspec, string @string, GValueHandle value, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_value_from_string(builder, pspec, @string, value, out error);
	}

	public static int ValueFromStringType(this GtkBuilderHandle builder, GType type, string @string, GValueHandle value, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_value_from_string_type(builder, type, @string, value, out error);
	}

	public static GClosureHandle CreateClosure(this GtkBuilderHandle builder, string function_name, GtkBuilderClosureFlags flags, GObjectHandle @object, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_create_closure(builder, function_name, flags, @object, out error);
	}

	public static int ExtendWithTemplate(this GtkBuilderHandle builder, GObjectHandle @object, GType template_type, string buffer, nint length, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_extend_with_template(builder, @object, template_type, buffer, length, out error);
	}

	public static GtkBuilderHandle NewFromFile(string filename)
	{
		return GtkBuilderExterns.gtk_builder_new_from_file(filename);
	}

	public static GtkBuilderHandle NewFromResource(string resource_path)
	{
		return GtkBuilderExterns.gtk_builder_new_from_resource(resource_path);
	}

	public static GtkBuilderHandle NewFromString(string @string, nint length)
	{
		return GtkBuilderExterns.gtk_builder_new_from_string(@string, length);
	}
}
