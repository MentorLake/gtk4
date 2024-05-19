namespace MentorLake.Gtk4.GObject;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GSignalEmissionHook([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GSignalInvocationHintHandle>))] GSignalInvocationHintHandle ihint, uint n_param_values, GValue[] param_values, IntPtr data);
