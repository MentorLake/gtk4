using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;
public static class GValueAdaptors
{
    public static int GTypeCheckValue(this GValueHandle value)
    {
        return GValueExterns.g_type_check_value(value);
    }

    public static int GTypeCheckValueHolds(this GValueHandle value, GType type)
    {
        return GValueExterns.g_type_check_value_holds(value, type);
    }

    public static GValueHandle Init(this GValueHandle value, GType g_type)
    {
        return GValueExterns.g_value_init(value, g_type);
    }

    public static GValueHandle Copy(this GValueHandle src_value, GValueHandle dest_value)
    {
        GValueExterns.g_value_copy(src_value, dest_value);
        return src_value;
    }

    public static GValueHandle Reset(this GValueHandle value)
    {
        return GValueExterns.g_value_reset(value);
    }

    public static GValueHandle Unset(this GValueHandle value)
    {
        GValueExterns.g_value_unset(value);
        return value;
    }

    public static GValueHandle SetInstance(this GValueHandle value, IntPtr instance)
    {
        GValueExterns.g_value_set_instance(value, instance);
        return value;
    }

    public static GValueHandle InitFromInstance(this GValueHandle value, IntPtr instance)
    {
        GValueExterns.g_value_init_from_instance(value, instance);
        return value;
    }

    public static int FitsPointer(this GValueHandle value)
    {
        return GValueExterns.g_value_fits_pointer(value);
    }

    public static IntPtr PeekPointer(this GValueHandle value)
    {
        return GValueExterns.g_value_peek_pointer(value);
    }

    public static int Transform(this GValueHandle src_value, GValueHandle dest_value)
    {
        return GValueExterns.g_value_transform(src_value, dest_value);
    }

    public static GValueHandle SetParam(this GValueHandle value, GParamSpecHandle param1)
    {
        GValueExterns.g_value_set_param(value, param1);
        return value;
    }

    public static GParamSpecHandle GetParam(this GValueHandle value)
    {
        return GValueExterns.g_value_get_param(value);
    }

    public static GParamSpecHandle DupParam(this GValueHandle value)
    {
        return GValueExterns.g_value_dup_param(value);
    }

    public static GValueHandle TakeParam(this GValueHandle value, GParamSpecHandle param1)
    {
        GValueExterns.g_value_take_param(value, param1);
        return value;
    }

    public static GValueHandle SetParamTakeOwnership(this GValueHandle value, GParamSpecHandle param1)
    {
        GValueExterns.g_value_set_param_take_ownership(value, param1);
        return value;
    }

    public static GValueHandle GSignalEmitv(this GValueHandle instance_and_params, uint signal_id, GQuark detail, GValueHandle return_value)
    {
        GValueExterns.g_signal_emitv(instance_and_params, signal_id, detail, return_value);
        return instance_and_params;
    }

    public static GValueHandle GSignalChainFromOverridden(this GValueHandle instance_and_params, GValueHandle return_value)
    {
        GValueExterns.g_signal_chain_from_overridden(instance_and_params, return_value);
        return instance_and_params;
    }

    public static GValueHandle SetBoxed(this GValueHandle value, IntPtr v_boxed)
    {
        GValueExterns.g_value_set_boxed(value, v_boxed);
        return value;
    }

    public static GValueHandle SetStaticBoxed(this GValueHandle value, IntPtr v_boxed)
    {
        GValueExterns.g_value_set_static_boxed(value, v_boxed);
        return value;
    }

    public static GValueHandle TakeBoxed(this GValueHandle value, IntPtr v_boxed)
    {
        GValueExterns.g_value_take_boxed(value, v_boxed);
        return value;
    }

    public static GValueHandle SetBoxedTakeOwnership(this GValueHandle value, IntPtr v_boxed)
    {
        GValueExterns.g_value_set_boxed_take_ownership(value, v_boxed);
        return value;
    }

    public static IntPtr GetBoxed(this GValueHandle value)
    {
        return GValueExterns.g_value_get_boxed(value);
    }

    public static IntPtr DupBoxed(this GValueHandle value)
    {
        return GValueExterns.g_value_dup_boxed(value);
    }

    public static GValueHandle SetObject(this GValueHandle value, IntPtr v_object)
    {
        GValueExterns.g_value_set_object(value, v_object);
        return value;
    }

    public static IntPtr GetObject(this GValueHandle value)
    {
        return GValueExterns.g_value_get_object(value);
    }

    public static IntPtr DupObject(this GValueHandle value)
    {
        return GValueExterns.g_value_dup_object(value);
    }

    public static GValueHandle TakeObject(this GValueHandle value, IntPtr v_object)
    {
        GValueExterns.g_value_take_object(value, v_object);
        return value;
    }

    public static GValueHandle SetObjectTakeOwnership(this GValueHandle value, IntPtr v_object)
    {
        GValueExterns.g_value_set_object_take_ownership(value, v_object);
        return value;
    }

    public static GValueHandle SetEnum(this GValueHandle value, int v_enum)
    {
        GValueExterns.g_value_set_enum(value, v_enum);
        return value;
    }

    public static int GetEnum(this GValueHandle value)
    {
        return GValueExterns.g_value_get_enum(value);
    }

    public static GValueHandle SetFlags(this GValueHandle value, uint v_flags)
    {
        GValueExterns.g_value_set_flags(value, v_flags);
        return value;
    }

    public static uint GetFlags(this GValueHandle value)
    {
        return GValueExterns.g_value_get_flags(value);
    }

    public static GValueHandle SetChar(this GValueHandle value, char v_char)
    {
        GValueExterns.g_value_set_char(value, v_char);
        return value;
    }

    public static char GetChar(this GValueHandle value)
    {
        return GValueExterns.g_value_get_char(value);
    }

    public static GValueHandle SetSchar(this GValueHandle value, sbyte v_char)
    {
        GValueExterns.g_value_set_schar(value, v_char);
        return value;
    }

    public static sbyte GetSchar(this GValueHandle value)
    {
        return GValueExterns.g_value_get_schar(value);
    }

    public static GValueHandle SetUchar(this GValueHandle value, char v_uchar)
    {
        GValueExterns.g_value_set_uchar(value, v_uchar);
        return value;
    }

    public static char GetUchar(this GValueHandle value)
    {
        return GValueExterns.g_value_get_uchar(value);
    }

    public static GValueHandle SetBoolean(this GValueHandle value, int v_boolean)
    {
        GValueExterns.g_value_set_boolean(value, v_boolean);
        return value;
    }

    public static int GetBoolean(this GValueHandle value)
    {
        return GValueExterns.g_value_get_boolean(value);
    }

    public static GValueHandle SetInt(this GValueHandle value, int v_int)
    {
        GValueExterns.g_value_set_int(value, v_int);
        return value;
    }

    public static int GetInt(this GValueHandle value)
    {
        return GValueExterns.g_value_get_int(value);
    }

    public static GValueHandle SetUint(this GValueHandle value, uint v_uint)
    {
        GValueExterns.g_value_set_uint(value, v_uint);
        return value;
    }

    public static uint GetUint(this GValueHandle value)
    {
        return GValueExterns.g_value_get_uint(value);
    }

    public static GValueHandle SetLong(this GValueHandle value, nint v_long)
    {
        GValueExterns.g_value_set_long(value, v_long);
        return value;
    }

    public static nint GetLong(this GValueHandle value)
    {
        return GValueExterns.g_value_get_long(value);
    }

    public static GValueHandle SetUlong(this GValueHandle value, nuint v_ulong)
    {
        GValueExterns.g_value_set_ulong(value, v_ulong);
        return value;
    }

    public static nuint GetUlong(this GValueHandle value)
    {
        return GValueExterns.g_value_get_ulong(value);
    }

    public static GValueHandle SetInt64(this GValueHandle value, nint v_int64)
    {
        GValueExterns.g_value_set_int64(value, v_int64);
        return value;
    }

    public static nint GetInt64(this GValueHandle value)
    {
        return GValueExterns.g_value_get_int64(value);
    }

    public static GValueHandle SetUint64(this GValueHandle value, nuint v_uint64)
    {
        GValueExterns.g_value_set_uint64(value, v_uint64);
        return value;
    }

    public static nuint GetUint64(this GValueHandle value)
    {
        return GValueExterns.g_value_get_uint64(value);
    }

    public static GValueHandle SetFloat(this GValueHandle value, float v_float)
    {
        GValueExterns.g_value_set_float(value, v_float);
        return value;
    }

    public static float GetFloat(this GValueHandle value)
    {
        return GValueExterns.g_value_get_float(value);
    }

    public static GValueHandle SetDouble(this GValueHandle value, double v_double)
    {
        GValueExterns.g_value_set_double(value, v_double);
        return value;
    }

    public static double GetDouble(this GValueHandle value)
    {
        return GValueExterns.g_value_get_double(value);
    }

    public static GValueHandle SetString(this GValueHandle value, string v_string)
    {
        GValueExterns.g_value_set_string(value, v_string);
        return value;
    }

    public static GValueHandle SetStaticString(this GValueHandle value, string v_string)
    {
        GValueExterns.g_value_set_static_string(value, v_string);
        return value;
    }

    public static GValueHandle SetInternedString(this GValueHandle value, string v_string)
    {
        GValueExterns.g_value_set_interned_string(value, v_string);
        return value;
    }

    public static string GetString(this GValueHandle value)
    {
        return GValueExterns.g_value_get_string(value);
    }

    public static string DupString(this GValueHandle value)
    {
        return GValueExterns.g_value_dup_string(value);
    }

    public static GValueHandle SetPointer(this GValueHandle value, IntPtr v_pointer)
    {
        GValueExterns.g_value_set_pointer(value, v_pointer);
        return value;
    }

    public static IntPtr GetPointer(this GValueHandle value)
    {
        return GValueExterns.g_value_get_pointer(value);
    }

    public static GValueHandle SetGtype(this GValueHandle value, GType v_gtype)
    {
        GValueExterns.g_value_set_gtype(value, v_gtype);
        return value;
    }

    public static GType GetGtype(this GValueHandle value)
    {
        return GValueExterns.g_value_get_gtype(value);
    }

    public static GValueHandle SetVariant(this GValueHandle value, GVariantHandle variant)
    {
        GValueExterns.g_value_set_variant(value, variant);
        return value;
    }

    public static GValueHandle TakeVariant(this GValueHandle value, GVariantHandle variant)
    {
        GValueExterns.g_value_take_variant(value, variant);
        return value;
    }

    public static GVariantHandle GetVariant(this GValueHandle value)
    {
        return GValueExterns.g_value_get_variant(value);
    }

    public static GVariantHandle DupVariant(this GValueHandle value)
    {
        return GValueExterns.g_value_dup_variant(value);
    }

    public static string GStrdupValueContents(this GValueHandle value)
    {
        return GValueExterns.g_strdup_value_contents(value);
    }

    public static GValueHandle TakeString(this GValueHandle value, string v_string)
    {
        GValueExterns.g_value_take_string(value, v_string);
        return value;
    }

    public static GValueHandle SetStringTakeOwnership(this GValueHandle value, string v_string)
    {
        GValueExterns.g_value_set_string_take_ownership(value, v_string);
        return value;
    }
}
