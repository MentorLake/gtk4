using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;
public static class GParamSpecAdaptors
{
    public static GParamSpecHandle Ref(this GParamSpecHandle pspec)
    {
        return GParamSpecExterns.g_param_spec_ref(pspec);
    }

    public static GParamSpecHandle Unref(this GParamSpecHandle pspec)
    {
        GParamSpecExterns.g_param_spec_unref(pspec);
        return pspec;
    }

    public static GParamSpecHandle Sink(this GParamSpecHandle pspec)
    {
        GParamSpecExterns.g_param_spec_sink(pspec);
        return pspec;
    }

    public static GParamSpecHandle RefSink(this GParamSpecHandle pspec)
    {
        return GParamSpecExterns.g_param_spec_ref_sink(pspec);
    }

    public static IntPtr GetQdata(this GParamSpecHandle pspec, GQuark quark)
    {
        return GParamSpecExterns.g_param_spec_get_qdata(pspec, quark);
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

    public static IntPtr StealQdata(this GParamSpecHandle pspec, GQuark quark)
    {
        return GParamSpecExterns.g_param_spec_steal_qdata(pspec, quark);
    }

    public static GParamSpecHandle GetRedirectTarget(this GParamSpecHandle pspec)
    {
        return GParamSpecExterns.g_param_spec_get_redirect_target(pspec);
    }

    public static GParamSpecHandle GParamValueSetDefault(this GParamSpecHandle pspec, GValueHandle value)
    {
        GParamSpecExterns.g_param_value_set_default(pspec, value);
        return pspec;
    }

    public static int GParamValueDefaults(this GParamSpecHandle pspec, GValueHandle value)
    {
        return GParamSpecExterns.g_param_value_defaults(pspec, value);
    }

    public static int GParamValueValidate(this GParamSpecHandle pspec, GValueHandle value)
    {
        return GParamSpecExterns.g_param_value_validate(pspec, value);
    }

    public static int GParamValueConvert(this GParamSpecHandle pspec, GValueHandle src_value, GValueHandle dest_value, int strict_validation)
    {
        return GParamSpecExterns.g_param_value_convert(pspec, src_value, dest_value, strict_validation);
    }

    public static int GParamValuesCmp(this GParamSpecHandle pspec, GValueHandle value1, GValueHandle value2)
    {
        return GParamSpecExterns.g_param_values_cmp(pspec, value1, value2);
    }

    public static string GetName(this GParamSpecHandle pspec)
    {
        return GParamSpecExterns.g_param_spec_get_name(pspec);
    }

    public static string GetNick(this GParamSpecHandle pspec)
    {
        return GParamSpecExterns.g_param_spec_get_nick(pspec);
    }

    public static string GetBlurb(this GParamSpecHandle pspec)
    {
        return GParamSpecExterns.g_param_spec_get_blurb(pspec);
    }

    public static GValueHandle GetDefaultValue(this GParamSpecHandle pspec)
    {
        return GParamSpecExterns.g_param_spec_get_default_value(pspec);
    }

    public static GQuark GetNameQuark(this GParamSpecHandle pspec)
    {
        return GParamSpecExterns.g_param_spec_get_name_quark(pspec);
    }
}
