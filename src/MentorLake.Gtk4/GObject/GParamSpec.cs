namespace MentorLake.Gtk4.GObject;

public class GParamSpecHandle : GTypeInstanceHandle
{
	public static GParamSpecHandle Internal(GType param_type, string name, string nick, string blurb, GParamFlags flags)
	{
		return GParamSpecExterns.g_param_spec_internal(param_type, name, nick, blurb, flags);
	}

	public static bool IsValidName(string name)
	{
		return GParamSpecExterns.g_param_spec_is_valid_name(name);
	}

}

public static class GParamSpecHandleExtensions
{
	public static string GetBlurb(this GParamSpecHandle pspec)
	{
		return GParamSpecExterns.g_param_spec_get_blurb(pspec);
	}

	public static GValueHandle GetDefaultValue(this GParamSpecHandle pspec)
	{
		return GParamSpecExterns.g_param_spec_get_default_value(pspec);
	}

	public static string GetName(this GParamSpecHandle pspec)
	{
		return GParamSpecExterns.g_param_spec_get_name(pspec);
	}

	public static GQuark GetNameQuark(this GParamSpecHandle pspec)
	{
		return GParamSpecExterns.g_param_spec_get_name_quark(pspec);
	}

	public static string GetNick(this GParamSpecHandle pspec)
	{
		return GParamSpecExterns.g_param_spec_get_nick(pspec);
	}

	public static IntPtr GetQdata(this GParamSpecHandle pspec, GQuark quark)
	{
		return GParamSpecExterns.g_param_spec_get_qdata(pspec, quark);
	}

	public static GParamSpecHandle GetRedirectTarget(this GParamSpecHandle pspec)
	{
		return GParamSpecExterns.g_param_spec_get_redirect_target(pspec);
	}

	public static GParamSpecHandle Ref(this GParamSpecHandle pspec)
	{
		return GParamSpecExterns.g_param_spec_ref(pspec);
	}

	public static GParamSpecHandle RefSink(this GParamSpecHandle pspec)
	{
		return GParamSpecExterns.g_param_spec_ref_sink(pspec);
	}

	public static GParamSpecHandle SetQdata(this GParamSpecHandle pspec, GQuark quark, IntPtr data)
	{
		GParamSpecExterns.g_param_spec_set_qdata(pspec, quark, data);
		return pspec;
	}

	public static GParamSpecHandle SetQdataFull(this GParamSpecHandle pspec, GQuark quark, IntPtr data, GDestroyNotify destroy)
	{
		GParamSpecExterns.g_param_spec_set_qdata_full(pspec, quark, data, destroy);
		return pspec;
	}

	public static GParamSpecHandle Sink(this GParamSpecHandle pspec)
	{
		GParamSpecExterns.g_param_spec_sink(pspec);
		return pspec;
	}

	public static IntPtr StealQdata(this GParamSpecHandle pspec, GQuark quark)
	{
		return GParamSpecExterns.g_param_spec_steal_qdata(pspec, quark);
	}

	public static GParamSpecHandle Unref(this GParamSpecHandle pspec)
	{
		GParamSpecExterns.g_param_spec_unref(pspec);
		return pspec;
	}

	public static bool GParamValueConvert(this GParamSpecHandle pspec, GValueHandle src_value, GValueHandle dest_value, bool strict_validation)
	{
		return GParamSpecExterns.g_param_value_convert(pspec, src_value, dest_value, strict_validation);
	}

	public static GParamSpecHandle GParamValueSetDefault(this GParamSpecHandle pspec, GValueHandle value)
	{
		GParamSpecExterns.g_param_value_set_default(pspec, value);
		return pspec;
	}

	public static bool GParamValueIsValid(this GParamSpecHandle pspec, GValueHandle value)
	{
		return GParamSpecExterns.g_param_value_is_valid(pspec, value);
	}

	public static bool GParamValueValidate(this GParamSpecHandle pspec, GValueHandle value)
	{
		return GParamSpecExterns.g_param_value_validate(pspec, value);
	}

	public static bool GParamValueDefaults(this GParamSpecHandle pspec, GValueHandle value)
	{
		return GParamSpecExterns.g_param_value_defaults(pspec, value);
	}

	public static int GParamValuesCmp(this GParamSpecHandle pspec, GValueHandle value1, GValueHandle value2)
	{
		return GParamSpecExterns.g_param_values_cmp(pspec, value1, value2);
	}

}

internal class GParamSpecExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern string g_param_spec_get_blurb(GParamSpecHandle pspec);

	[DllImport(Libraries.GObject)]
	internal static extern GValueHandle g_param_spec_get_default_value(GParamSpecHandle pspec);

	[DllImport(Libraries.GObject)]
	internal static extern string g_param_spec_get_name(GParamSpecHandle pspec);

	[DllImport(Libraries.GObject)]
	internal static extern GQuark g_param_spec_get_name_quark(GParamSpecHandle pspec);

	[DllImport(Libraries.GObject)]
	internal static extern string g_param_spec_get_nick(GParamSpecHandle pspec);

	[DllImport(Libraries.GObject)]
	internal static extern IntPtr g_param_spec_get_qdata(GParamSpecHandle pspec, GQuark quark);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_get_redirect_target(GParamSpecHandle pspec);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_ref(GParamSpecHandle pspec);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_ref_sink(GParamSpecHandle pspec);

	[DllImport(Libraries.GObject)]
	internal static extern void g_param_spec_set_qdata(GParamSpecHandle pspec, GQuark quark, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_param_spec_set_qdata_full(GParamSpecHandle pspec, GQuark quark, IntPtr data, GDestroyNotify destroy);

	[DllImport(Libraries.GObject)]
	internal static extern void g_param_spec_sink(GParamSpecHandle pspec);

	[DllImport(Libraries.GObject)]
	internal static extern IntPtr g_param_spec_steal_qdata(GParamSpecHandle pspec, GQuark quark);

	[DllImport(Libraries.GObject)]
	internal static extern void g_param_spec_unref(GParamSpecHandle pspec);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_param_value_convert(GParamSpecHandle pspec, GValueHandle src_value, GValueHandle dest_value, bool strict_validation);

	[DllImport(Libraries.GObject)]
	internal static extern void g_param_value_set_default(GParamSpecHandle pspec, GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_param_value_is_valid(GParamSpecHandle pspec, GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_param_value_validate(GParamSpecHandle pspec, GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_param_value_defaults(GParamSpecHandle pspec, GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern int g_param_values_cmp(GParamSpecHandle pspec, GValueHandle value1, GValueHandle value2);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_internal(GType param_type, string name, string nick, string blurb, GParamFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_param_spec_is_valid_name(string name);

}
