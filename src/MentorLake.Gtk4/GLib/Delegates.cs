using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GClearHandleFunc(uint handle_id);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GPollFunc(GPollFDHandle ufds, uint nfsd, int timeout_);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GOptionErrorFunc(GOptionContextHandle context, GOptionGroupHandle group, IntPtr data, out GErrorHandle error);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GSpawnChildSetupFunc(IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GHookCompareFunc(GHookHandle new_hook, GHookHandle sibling);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GTraverseFunc(IntPtr key, IntPtr value, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GCacheDupFunc(IntPtr value);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GSourceDisposeFunc(GSourceHandle source);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GFreeFunc(IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GLogFunc(string log_domain, GLogLevelFlags log_level, string message, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GThreadFunc(IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GCompletionStrncmpFunc(string s1, string s2, nuint n);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate string GTranslateFunc(string str, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GHFunc(IntPtr key, IntPtr value, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GTestDataFunc(IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GHookMarshaller(GHookHandle hook, IntPtr marshal_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GRegexEvalCallback(GMatchInfoHandle match_info, GStringHandle result, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GTestFunc();

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GErrorCopyFunc(GErrorHandle src_error, GErrorHandle dest_error);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GTraverseNodeFunc(GTreeNodeHandle node, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GErrorInitFunc(GErrorHandle error);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GSourceFunc(IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GCacheNewFunc(IntPtr key);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GErrorClearFunc(GErrorHandle error);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
[Obsolete]
public delegate void GCacheDestroyFunc(IntPtr value);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GEqualFunc(IntPtr a, IntPtr b);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GSourceDummyMarshal();

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GHookCheckFunc(IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GFunc(IntPtr data, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GSequenceIterCompareFunc(GSequenceIterHandle a, GSequenceIterHandle b, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GOptionArgFunc(string option_name, string value, IntPtr data, out GErrorHandle error);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GTestFixtureFunc(IntPtr fixture, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GOptionParseFunc(GOptionContextHandle context, GOptionGroupHandle group, IntPtr data, out GErrorHandle error);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GDuplicateFunc(IntPtr data, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GCompareDataFunc(IntPtr a, IntPtr b, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GHookFunc(IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate uint GHashFunc(IntPtr key);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GChildWatchFunc(GPid pid, int wait_status, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GScannerMsgFunc(GScannerHandle scanner, string message, int error);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GHookCheckMarshaller(GHookHandle hook, IntPtr marshal_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GDestroyNotify(IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GDataForeachFunc(GQuark key_id, IntPtr data, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GHookFinalizeFunc(GHookListHandle hook_list, GHookHandle hook);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
[Obsolete]
public delegate void GVoidFunc();

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GPrintFunc(string @string);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GTestLogFatalFunc(string log_domain, GLogLevelFlags log_level, string message, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GNodeTraverseFunc(GNodeHandle node, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate GLogWriterOutput GLogWriterFunc(GLogLevelFlags log_level, GLogFieldHandle fields, nuint n_fields, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GNodeForeachFunc(GNodeHandle node, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GHRFunc(IntPtr key, IntPtr value, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GCompareFunc(IntPtr a, IntPtr b);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GIOFunc(GIOChannelHandle source, GIOCondition condition, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GCopyFunc(IntPtr src, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GHookFindFunc(GHookHandle hook, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate string GCompletionFunc(IntPtr param0);
