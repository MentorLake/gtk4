using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gsk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GskParseErrorFunc(GskParseLocationHandle start, GskParseLocationHandle end, GErrorHandle error, IntPtr user_data);
