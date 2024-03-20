using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pixbuf;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GdkPixbufSaveFunc(string buf, nuint count, out GErrorHandle error, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GdkPixbufDestroyNotify(string pixels, IntPtr data);
