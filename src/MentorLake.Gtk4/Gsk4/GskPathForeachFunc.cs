namespace MentorLake.Gtk4.Gsk4;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GskPathForeachFunc(GskPathOperation op, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<graphene_point_tHandle>))] graphene_point_tHandle pts, int n_pts, float weight, IntPtr user_data);
