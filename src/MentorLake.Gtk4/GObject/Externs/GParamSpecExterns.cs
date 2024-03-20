using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;

public static class GParamSpecExterns
{
	[DllImport(Libraries.GObject, EntryPoint = "g_param_spec_ref")]
	internal static extern GParamSpecHandle g_param_spec_ref(this GParamSpecHandle pspec);

	[DllImport(Libraries.GObject, EntryPoint = "g_param_spec_unref")]
	internal static extern void g_param_spec_unref(this GParamSpecHandle pspec);

	[DllImport(Libraries.GObject, EntryPoint = "g_param_spec_sink")]
	internal static extern void g_param_spec_sink(this GParamSpecHandle pspec);

	[DllImport(Libraries.GObject, EntryPoint = "g_param_spec_ref_sink")]
	internal static extern GParamSpecHandle g_param_spec_ref_sink(this GParamSpecHandle pspec);

	[DllImport(Libraries.GObject, EntryPoint = "g_param_spec_get_qdata")]
	internal static extern IntPtr g_param_spec_get_qdata(this GParamSpecHandle pspec, GQuark quark);

	[DllImport(Libraries.GObject, EntryPoint = "g_param_spec_set_qdata")]
	internal static extern void g_param_spec_set_qdata(this GParamSpecHandle pspec, GQuark quark, IntPtr data);

	[DllImport(Libraries.GObject, EntryPoint = "g_param_spec_set_qdata_full")]
	internal static extern void g_param_spec_set_qdata_full(this GParamSpecHandle pspec, GQuark quark, IntPtr data, GDestroyNotify destroy);

	[DllImport(Libraries.GObject, EntryPoint = "g_param_spec_steal_qdata")]
	internal static extern IntPtr g_param_spec_steal_qdata(this GParamSpecHandle pspec, GQuark quark);

	[DllImport(Libraries.GObject, EntryPoint = "g_param_spec_get_redirect_target")]
	internal static extern GParamSpecHandle g_param_spec_get_redirect_target(this GParamSpecHandle pspec);

	[DllImport(Libraries.GObject, EntryPoint = "g_param_value_set_default")]
	internal static extern void g_param_value_set_default(this GParamSpecHandle pspec, GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_param_value_defaults")]
	internal static extern int g_param_value_defaults(this GParamSpecHandle pspec, GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_param_value_validate")]
	internal static extern int g_param_value_validate(this GParamSpecHandle pspec, GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_param_value_convert")]
	internal static extern int g_param_value_convert(this GParamSpecHandle pspec, GValueHandle src_value, GValueHandle dest_value, int strict_validation);

	[DllImport(Libraries.GObject, EntryPoint = "g_param_values_cmp")]
	internal static extern int g_param_values_cmp(this GParamSpecHandle pspec, GValueHandle value1, GValueHandle value2);

	[DllImport(Libraries.GObject, EntryPoint = "g_param_spec_get_name")]
	internal static extern string g_param_spec_get_name(this GParamSpecHandle pspec);

	[DllImport(Libraries.GObject, EntryPoint = "g_param_spec_get_nick")]
	internal static extern string g_param_spec_get_nick(this GParamSpecHandle pspec);

	[DllImport(Libraries.GObject, EntryPoint = "g_param_spec_get_blurb")]
	internal static extern string g_param_spec_get_blurb(this GParamSpecHandle pspec);

	[DllImport(Libraries.GObject, EntryPoint = "g_param_spec_get_default_value")]
	internal static extern GValueHandle g_param_spec_get_default_value(this GParamSpecHandle pspec);

	[DllImport(Libraries.GObject, EntryPoint = "g_param_spec_get_name_quark")]
	internal static extern GQuark g_param_spec_get_name_quark(this GParamSpecHandle pspec);
}
