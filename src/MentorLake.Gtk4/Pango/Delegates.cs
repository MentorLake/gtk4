using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int PangoFontsetForeachFunc(PangoFontsetHandle fontset, PangoFontHandle font, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int PangoAttrFilterFunc(PangoAttributeHandle attribute, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr PangoAttrDataCopyFunc(IntPtr user_data);
