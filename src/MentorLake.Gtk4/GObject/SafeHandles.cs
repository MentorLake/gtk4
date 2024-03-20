using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;
public class GObjectHandle : BaseSafeHandle
{
	private bool _hasRef;
	public GObjectHandle Ref()
	{
		_hasRef = true;
		this.g_object_ref();
		return this;
	}

	protected override void Dispose(bool disposing)
	{
		if (!IsInvalid && _hasRef)
		{
			this.g_object_unref();
		}

		base.Dispose(disposing);
	}

	public static GObjectHandle NewWithProperties(GType object_type, uint n_properties, string[] names, GValue[] values)
	{
		return GObjectExterns.g_object_new_with_properties(object_type, n_properties, names, values);
	}

	public static GObjectHandle NewValist(GType object_type, string first_property_name, IntPtr @__arglist)
	{
		return GObjectExterns.g_object_new_valist(object_type, first_property_name, @__arglist);
	}
}

public class GBindingGroupHandle : GObjectHandle
{
	public static GBindingGroupHandle New()
	{
		return GBindingGroupExterns.g_binding_group_new();
	}
}

public class GBindingHandle : GObjectHandle
{
}

public class GCClosureHandle : GTypeInstanceHandle
{
}

public class GClosureHandle : BaseSafeHandle
{
	public static GClosureHandle GCclosureNew(GCallback callback_func, IntPtr user_data, GClosureNotify destroy_data)
	{
		return GClosureExterns.g_cclosure_new(callback_func, user_data, destroy_data);
	}

	public static GClosureHandle GCclosureNewSwap(GCallback callback_func, IntPtr user_data, GClosureNotify destroy_data)
	{
		return GClosureExterns.g_cclosure_new_swap(callback_func, user_data, destroy_data);
	}

	public static GClosureHandle GSignalTypeCclosureNew(GType itype, uint struct_offset)
	{
		return GClosureExterns.g_signal_type_cclosure_new(itype, struct_offset);
	}

	public static GClosureHandle NewSimple(uint sizeof_closure, IntPtr data)
	{
		return GClosureExterns.g_closure_new_simple(sizeof_closure, data);
	}

	public static GClosureHandle GCclosureNewObject(GCallback callback_func, GObjectHandle @object)
	{
		return GClosureExterns.g_cclosure_new_object(callback_func, @object);
	}

	public static GClosureHandle GCclosureNewObjectSwap(GCallback callback_func, GObjectHandle @object)
	{
		return GClosureExterns.g_cclosure_new_object_swap(callback_func, @object);
	}

	public static GClosureHandle NewObject(uint sizeof_closure, GObjectHandle @object)
	{
		return GClosureExterns.g_closure_new_object(sizeof_closure, @object);
	}
}

public class GClosureNotifyDataHandle : GTypeInstanceHandle
{
}

public class GEnumClassHandle : GTypeInstanceHandle
{
}

public class GEnumValueHandle : GTypeInstanceHandle
{
}

public class GFlagsClassHandle : GTypeInstanceHandle
{
}

public class GFlagsValueHandle : GTypeInstanceHandle
{
}

public class GInterfaceInfoHandle : GTypeInstanceHandle
{
}

public class GObjectClassHandle : GTypeInstanceHandle
{
}

public class GObjectConstructParamHandle : GTypeInstanceHandle
{
}

public class GParamSpecBooleanHandle : GTypeInstanceHandle
{
}

public class GParamSpecBoxedHandle : GTypeInstanceHandle
{
}

public class GParamSpecCharHandle : GTypeInstanceHandle
{
}

public class GParamSpecClassHandle : GTypeInstanceHandle
{
}

public class GParamSpecDoubleHandle : GTypeInstanceHandle
{
}

public class GParamSpecEnumHandle : GTypeInstanceHandle
{
}

public class GParamSpecFlagsHandle : GTypeInstanceHandle
{
}

public class GParamSpecFloatHandle : GTypeInstanceHandle
{
}

public class GParamSpecGTypeHandle : GTypeInstanceHandle
{
}

public class GParamSpecHandle : GTypeInstanceHandle
{
}

public class GParamSpecInt64Handle : GTypeInstanceHandle
{
}

public class GParamSpecIntHandle : GTypeInstanceHandle
{
}

public class GParamSpecLongHandle : GTypeInstanceHandle
{
}

public class GParamSpecObjectHandle : GTypeInstanceHandle
{
}

public class GParamSpecOverrideHandle : GTypeInstanceHandle
{
}

public class GParamSpecParamHandle : GTypeInstanceHandle
{
}

public class GParamSpecPointerHandle : GTypeInstanceHandle
{
}

public class GParamSpecPoolHandle : GTypeInstanceHandle
{
	public static GParamSpecPoolHandle New(int type_prefixing)
	{
		return GParamSpecPoolExterns.g_param_spec_pool_new(type_prefixing);
	}
}

public class GParamSpecStringHandle : GTypeInstanceHandle
{
}

public class GParamSpecTypeInfoHandle : BaseSafeHandle
{
}

public class GParamSpecUCharHandle : GTypeInstanceHandle
{
}

public class GParamSpecUInt64Handle : GTypeInstanceHandle
{
}

public class GParamSpecUIntHandle : GTypeInstanceHandle
{
}

public class GParamSpecULongHandle : GTypeInstanceHandle
{
}

public class GParamSpecUnicharHandle : GTypeInstanceHandle
{
}

public class GParamSpecValueArrayHandle : GTypeInstanceHandle
{
}

public class GParamSpecVariantHandle : GTypeInstanceHandle
{
}

public class GParameterHandle : GTypeInstanceHandle
{
}

public class GSignalGroupHandle : GObjectHandle
{
	public static GSignalGroupHandle New(GType target_type)
	{
		return GSignalGroupExterns.g_signal_group_new(target_type);
	}
}

public class GSignalInvocationHintHandle : GTypeInstanceHandle
{
}

public class GSignalQueryHandle : GTypeInstanceHandle
{
}

public class GTypeCValueHandle : GTypeInstanceHandle
{
}

public class GTypeClassHandle : GTypeInstanceHandle
{
}

public class GTypeFundamentalInfoHandle : GTypeInstanceHandle
{
}

public class GTypeInfoHandle : GTypeInstanceHandle
{
}

public class GTypeInstanceHandle : BaseSafeHandle
{
}

public class GTypeInterfaceHandle : GTypeInstanceHandle
{
}

public class GTypeModuleClassHandle : GTypeInstanceHandle
{
}

public class GTypeModuleHandle : GObjectHandle
{
}

public class GTypePluginClassHandle : GTypeInstanceHandle
{
}

public class GTypePluginHandle : GObjectHandle
{
}

public class GTypeQueryHandle : GTypeInstanceHandle
{
}

public class GTypeValueTableHandle : GTypeInstanceHandle
{
}

public class GValueArrayHandle : GTypeInstanceHandle
{
	public static GValueArrayHandle New(uint n_prealloced)
	{
		return GValueArrayExterns.g_value_array_new(n_prealloced);
	}
}

public class GValueHandle : GTypeInstanceHandle
{
}

public class GWeakRefHandle : GTypeInstanceHandle
{
}
