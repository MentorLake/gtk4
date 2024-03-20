using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;
public static class GtkBuilderExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_add_from_file")]
    internal static extern int gtk_builder_add_from_file(this GtkBuilderHandle builder, string filename, out GErrorHandle error);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_add_from_resource")]
    internal static extern int gtk_builder_add_from_resource(this GtkBuilderHandle builder, string resource_path, out GErrorHandle error);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_add_from_string")]
    internal static extern int gtk_builder_add_from_string(this GtkBuilderHandle builder, string buffer, nint length, out GErrorHandle error);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_add_objects_from_file")]
    internal static extern int gtk_builder_add_objects_from_file(this GtkBuilderHandle builder, string filename, string[] object_ids, out GErrorHandle error);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_add_objects_from_resource")]
    internal static extern int gtk_builder_add_objects_from_resource(this GtkBuilderHandle builder, string resource_path, string[] object_ids, out GErrorHandle error);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_add_objects_from_string")]
    internal static extern int gtk_builder_add_objects_from_string(this GtkBuilderHandle builder, string buffer, nint length, string[] object_ids, out GErrorHandle error);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_get_object")]
    internal static extern GObjectHandle gtk_builder_get_object(this GtkBuilderHandle builder, string name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_get_objects")]
    internal static extern GSListHandle gtk_builder_get_objects(this GtkBuilderHandle builder);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_expose_object")]
    internal static extern void gtk_builder_expose_object(this GtkBuilderHandle builder, string name, GObjectHandle @object);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_get_current_object")]
    internal static extern GObjectHandle gtk_builder_get_current_object(this GtkBuilderHandle builder);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_set_current_object")]
    internal static extern void gtk_builder_set_current_object(this GtkBuilderHandle builder, GObjectHandle current_object);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_set_translation_domain")]
    internal static extern void gtk_builder_set_translation_domain(this GtkBuilderHandle builder, string domain);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_get_translation_domain")]
    internal static extern string gtk_builder_get_translation_domain(this GtkBuilderHandle builder);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_get_scope")]
    internal static extern GtkBuilderScopeHandle gtk_builder_get_scope(this GtkBuilderHandle builder);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_set_scope")]
    internal static extern void gtk_builder_set_scope(this GtkBuilderHandle builder, GtkBuilderScopeHandle scope);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_get_type_from_name")]
    internal static extern GType gtk_builder_get_type_from_name(this GtkBuilderHandle builder, string type_name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_value_from_string")]
    internal static extern int gtk_builder_value_from_string(this GtkBuilderHandle builder, GParamSpecHandle pspec, string @string, GValueHandle value, out GErrorHandle error);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_value_from_string_type")]
    internal static extern int gtk_builder_value_from_string_type(this GtkBuilderHandle builder, GType type, string @string, GValueHandle value, out GErrorHandle error);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_create_closure")]
    internal static extern GClosureHandle gtk_builder_create_closure(this GtkBuilderHandle builder, string function_name, GtkBuilderClosureFlags flags, GObjectHandle @object, out GErrorHandle error);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_extend_with_template")]
    internal static extern int gtk_builder_extend_with_template(this GtkBuilderHandle builder, GObjectHandle @object, GType template_type, string buffer, nint length, out GErrorHandle error);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkBuilderHandle gtk_builder_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkBuilderHandle gtk_builder_new_from_file(string filename);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkBuilderHandle gtk_builder_new_from_resource(string resource_path);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkBuilderHandle gtk_builder_new_from_string(string @string, nint length);
}
