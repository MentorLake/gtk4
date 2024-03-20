using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class Methods
{
	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_atomic_int_get(ref int atomic);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_atomic_int_set(ref int atomic, int newval);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_atomic_int_inc(ref int atomic);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_atomic_int_dec_and_test(ref int atomic);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_atomic_int_compare_and_exchange(ref int atomic, int oldval, int newval);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_atomic_int_add(ref int atomic, int val);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_atomic_int_and(ref uint atomic, uint val);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_atomic_int_or(ref uint atomic, uint val);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_atomic_int_xor(ref uint atomic, uint val);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_atomic_pointer_get(IntPtr atomic);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_atomic_pointer_set(IntPtr atomic, IntPtr newval);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_atomic_pointer_compare_and_exchange(IntPtr atomic, IntPtr oldval, IntPtr newval);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern nint g_atomic_pointer_add(IntPtr atomic, nint val);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern nuint g_atomic_pointer_and(IntPtr atomic, nuint val);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern nuint g_atomic_pointer_or(IntPtr atomic, nuint val);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern nuint g_atomic_pointer_xor(IntPtr atomic, nuint val);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern int g_atomic_int_exchange_and_add(ref int atomic, int val);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark g_quark_try_string(string @string);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark g_quark_from_static_string(string @string);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark g_quark_from_string(string @string);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_quark_to_string(GQuark quark);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_intern_string(string @string);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_intern_static_string(string @string);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark g_error_domain_register_static(string error_type_name, nuint error_type_private_size, GErrorInitFunc error_type_init, GErrorCopyFunc error_type_copy, GErrorClearFunc error_type_clear);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark g_error_domain_register(string error_type_name, nuint error_type_private_size, GErrorInitFunc error_type_init, GErrorCopyFunc error_type_copy, GErrorClearFunc error_type_clear);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_set_error(out GErrorHandle err, GQuark domain, int code, string format, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_set_error_literal(out GErrorHandle err, GQuark domain, int code, string message);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_propagate_error(out GErrorHandle dest, GErrorHandle src);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_clear_error(out GErrorHandle err);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_prefix_error(out GErrorHandle err, string format, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_prefix_error_literal(out GErrorHandle err, string prefix);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_propagate_prefixed_error(out GErrorHandle dest, GErrorHandle src, string format, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_get_user_name();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_get_real_name();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_get_home_dir();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_get_tmp_dir();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_get_host_name();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_get_prgname();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_set_prgname(string prgname);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_get_application_name();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_set_application_name(string application_name);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_get_os_info(string key_name);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_reload_user_special_dirs_cache();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_get_user_data_dir();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_get_user_config_dir();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_get_user_cache_dir();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_get_user_state_dir();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_get_system_data_dirs();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_get_system_config_dirs();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_get_user_runtime_dir();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_get_user_special_dir(GUserDirectory directory);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_parse_debug_string(string @string, GDebugKeyHandle keys, uint nkeys);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_snprintf(string @string, nuint n, string format, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_vsnprintf(string @string, nuint n, string format, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_nullify_pointer(ref IntPtr nullify_location);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_format_size_full(nuint size, GFormatSizeFlags flags);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_format_size(nuint size);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_format_size_for_display(nint size);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern void g_atexit(GVoidFunc func);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_find_program_in_path(string program);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_bit_nth_lsf(nuint mask, int nth_bit);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_bit_nth_msf(nuint mask, int nth_bit);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_bit_storage(nuint number);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark g_thread_error_quark();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GThreadHandle g_thread_self();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_thread_exit(IntPtr retval);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_thread_yield();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_once_init_enter(IntPtr location);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_once_init_leave(IntPtr location, nuint result);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_get_num_processors();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_on_error_query(string prg_name);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_on_error_stack_trace(string prg_name);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern nuint g_base64_encode_step(string @in, nuint len, int break_lines, string @out, out int state, out int save);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern nuint g_base64_encode_close(int break_lines, string @out, out int state, out int save);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_base64_encode(string data, nuint len);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern nuint g_base64_decode_step(string @in, nuint len, string @out, out int state, out uint save);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_base64_decode(string text, out nuint out_len);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_base64_decode_inplace(string text, out nuint out_len);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_bit_lock(IntPtr address, int lock_bit);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_bit_trylock(IntPtr address, int lock_bit);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_bit_unlock(IntPtr address, int lock_bit);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_pointer_bit_lock(IntPtr address, int lock_bit);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_pointer_bit_trylock(IntPtr address, int lock_bit);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_pointer_bit_unlock(IntPtr address, int lock_bit);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_date_time_compare(IntPtr dt1, IntPtr dt2);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_date_time_hash(IntPtr datetime);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_date_time_equal(IntPtr dt1, IntPtr dt2);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark g_bookmark_file_error_quark();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_bytes_hash(IntPtr bytes);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_bytes_equal(IntPtr bytes1, IntPtr bytes2);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_bytes_compare(IntPtr bytes1, IntPtr bytes2);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_get_charset(out string charset);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_get_codeset();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_get_console_charset(out string charset);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_get_language_names();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_get_language_names_with_category(string category_name);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string[] g_get_locale_variants(string locale);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern nint g_checksum_type_get_length(GChecksumType checksum_type);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_compute_checksum_for_data(GChecksumType checksum_type, string data, nuint length);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_compute_checksum_for_string(GChecksumType checksum_type, string str, nint length);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_compute_checksum_for_bytes(GChecksumType checksum_type, GBytesHandle data);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark g_convert_error_quark();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GIConv g_iconv_open(string to_codeset, string from_codeset);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern nuint g_iconv(GIConv converter, byte[] inbuf, ref nuint inbytes_left, out byte[] outbuf, out nuint outbytes_left);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_iconv_close(GIConv converter);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_convert(string str, nint len, string to_codeset, string from_codeset, out nuint bytes_read, out nuint bytes_written, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_convert_with_iconv(string str, nint len, GIConv converter, out nuint bytes_read, out nuint bytes_written, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_convert_with_fallback(string str, nint len, string to_codeset, string from_codeset, string fallback, out nuint bytes_read, out nuint bytes_written, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_locale_to_utf8(string opsysstring, nint len, out nuint bytes_read, out nuint bytes_written, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_locale_from_utf8(string utf8string, nint len, out nuint bytes_read, out nuint bytes_written, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_filename_to_utf8(string opsysstring, nint len, out nuint bytes_read, out nuint bytes_written, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_filename_from_utf8(string utf8string, nint len, out nuint bytes_read, out nuint bytes_written, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_filename_from_uri(string uri, string[] hostname, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_filename_to_uri(string filename, string hostname, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_filename_display_name(string filename);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_get_filename_charsets(out string[] filename_charsets);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_filename_display_basename(string filename);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string[] g_uri_list_extract_uris(string uri_list);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_datalist_init(out GDataHandle datalist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_datalist_clear(out GDataHandle datalist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_datalist_id_get_data(out GDataHandle datalist, GQuark key_id);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_datalist_id_set_data_full(out GDataHandle datalist, GQuark key_id, IntPtr data, GDestroyNotify destroy_func);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_datalist_id_dup_data(out GDataHandle datalist, GQuark key_id, GDuplicateFunc dup_func, IntPtr user_data);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_datalist_id_replace_data(out GDataHandle datalist, GQuark key_id, IntPtr oldval, IntPtr newval, GDestroyNotify destroy, out GDestroyNotify old_destroy);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_datalist_id_remove_no_notify(out GDataHandle datalist, GQuark key_id);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_datalist_foreach(out GDataHandle datalist, GDataForeachFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_datalist_set_flags(out GDataHandle datalist, uint flags);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_datalist_unset_flags(out GDataHandle datalist, uint flags);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_datalist_get_flags(out GDataHandle datalist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_dataset_destroy(IntPtr dataset_location);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_dataset_id_get_data(IntPtr dataset_location, GQuark key_id);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_datalist_get_data(out GDataHandle datalist, string key);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_dataset_id_set_data_full(IntPtr dataset_location, GQuark key_id, IntPtr data, GDestroyNotify destroy_func);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_dataset_id_remove_no_notify(IntPtr dataset_location, GQuark key_id);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_dataset_foreach(IntPtr dataset_location, GDataForeachFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_date_valid_day(GDateDay day);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_date_valid_month(GDateMonth month);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_date_valid_year(GDateYear year);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_date_valid_weekday(GDateWeekday weekday);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_date_valid_julian(uint julian_date);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_date_valid_dmy(GDateDay day, GDateMonth month, GDateYear year);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_date_is_leap_year(GDateYear year);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern byte g_date_get_days_in_month(GDateMonth month, GDateYear year);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern byte g_date_get_monday_weeks_in_year(GDateYear year);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern byte g_date_get_sunday_weeks_in_year(GDateYear year);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern nuint g_date_strftime(string s, nuint slen, string format, GDateHandle date);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GDirHandle g_dir_open(string path, uint flags, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_getenv(string variable);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_setenv(string variable, string value, int overwrite);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_unsetenv(string variable);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string[] g_listenv();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string[] g_get_environ();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_environ_getenv(string[] envp, string variable);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string[] g_environ_setenv(string[] envp, string variable, string value, int overwrite);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string[] g_environ_unsetenv(string[] envp, string variable);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark g_file_error_quark();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GFileError g_file_error_from_errno(int err_no);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_file_test(string filename, GFileTest test);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_file_get_contents(string filename, out string contents, out nuint length, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_file_set_contents(string filename, string contents, nint length, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_file_set_contents_full(string filename, string contents, nint length, GFileSetContentsFlags flags, int mode, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_file_read_link(string filename, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_mkdtemp(string tmpl);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_mkdtemp_full(string tmpl, int mode);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_mkstemp(string tmpl);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_mkstemp_full(string tmpl, int flags, int mode);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_file_open_tmp(string tmpl, string[] name_used, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_dir_make_tmp(string tmpl, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_build_path(string separator, string first_element, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_build_pathv(string separator, string[] args);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_build_filename(string first_element, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_build_filenamev(string[] args);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_build_filename_valist(string first_element, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_mkdir_with_parents(string pathname, int mode);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_path_is_absolute(string file_name);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_path_skip_root(string file_name);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_basename(string file_name);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_get_current_dir();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_path_get_basename(string file_name);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_path_get_dirname(string file_name);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_canonicalize_filename(string filename, string relative_to);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_strip_context(string msgid, string msgval);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_dgettext(string domain, string msgid);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_dcgettext(string domain, string msgid, int category);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_dngettext(string domain, string msgid, string msgid_plural, nuint n);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_dpgettext(string domain, string msgctxtid, nuint msgidoffset);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_dpgettext2(string domain, string context, string msgid);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_free(IntPtr mem);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_clear_pointer(ref IntPtr pp, GDestroyNotify destroy);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_malloc(nuint n_bytes);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_malloc0(nuint n_bytes);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_realloc(IntPtr mem, nuint n_bytes);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_try_malloc(nuint n_bytes);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_try_malloc0(nuint n_bytes);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_try_realloc(IntPtr mem, nuint n_bytes);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_malloc_n(nuint n_blocks, nuint n_block_bytes);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_malloc0_n(nuint n_blocks, nuint n_block_bytes);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_realloc_n(IntPtr mem, nuint n_blocks, nuint n_block_bytes);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_try_malloc_n(nuint n_blocks, nuint n_block_bytes);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_try_malloc0_n(nuint n_blocks, nuint n_block_bytes);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_try_realloc_n(IntPtr mem, nuint n_blocks, nuint n_block_bytes);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_aligned_alloc(nuint n_blocks, nuint n_block_bytes, nuint alignment);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_aligned_alloc0(nuint n_blocks, nuint n_block_bytes, nuint alignment);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_aligned_free(IntPtr mem);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern int g_mem_is_system_malloc();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern void g_mem_profile();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GListHandle g_list_alloc();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_clear_list(out GListHandle list_ptr, GDestroyNotify destroy);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_str_equal(IntPtr v1, IntPtr v2);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_str_hash(IntPtr v);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_int_equal(IntPtr v1, IntPtr v2);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_int_hash(IntPtr v);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_int64_equal(IntPtr v1, IntPtr v2);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_int64_hash(IntPtr v);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_double_equal(IntPtr v1, IntPtr v2);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_double_hash(IntPtr v);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_direct_hash(IntPtr v);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_direct_equal(IntPtr v1, IntPtr v2);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_compute_hmac_for_data(GChecksumType digest_type, string key, nuint key_len, string data, nuint length);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_compute_hmac_for_string(GChecksumType digest_type, string key, nuint key_len, string str, nint length);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_compute_hmac_for_bytes(GChecksumType digest_type, GBytesHandle key, GBytesHandle data);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_hostname_is_non_ascii(string hostname);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_hostname_is_ascii_encoded(string hostname);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_hostname_is_ip_address(string hostname);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_hostname_to_ascii(string hostname);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_hostname_to_unicode(string hostname);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GSListHandle g_slist_alloc();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_clear_slist(out GSListHandle slist_ptr, GDestroyNotify destroy);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GMainContextHandle g_main_context_default();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_main_depth();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GSourceHandle g_main_current_source();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GMainContextHandle g_main_context_get_thread_default();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GMainContextHandle g_main_context_ref_thread_default();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_source_set_name_by_id(uint tag, string name);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern nint g_get_monotonic_time();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern nint g_get_real_time();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_source_remove(uint tag);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_source_remove_by_user_data(IntPtr user_data);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_clear_handle_id(IntPtr tag_ptr, GClearHandleFunc clear_func);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_timeout_add_full(int priority, uint interval, GSourceFunc function, IntPtr data, GDestroyNotify notify);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_timeout_add(uint interval, GSourceFunc function, IntPtr data);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_timeout_add_seconds_full(int priority, uint interval, GSourceFunc function, IntPtr data, GDestroyNotify notify);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_timeout_add_seconds(uint interval, GSourceFunc function, IntPtr data);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_child_watch_add_full(int priority, GPid pid, GChildWatchFunc function, IntPtr data, GDestroyNotify notify);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_child_watch_add(GPid pid, GChildWatchFunc function, IntPtr data);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_idle_add(GSourceFunc function, IntPtr data);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_idle_add_full(int priority, GSourceFunc function, IntPtr data, GDestroyNotify notify);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_idle_remove_by_data(IntPtr data);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_unicode_script_to_iso15924(GUnicodeScript script);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GUnicodeScript g_unicode_script_from_iso15924(uint iso15924);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_unichar_isalnum(uint c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_unichar_isalpha(uint c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_unichar_iscntrl(uint c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_unichar_isdigit(uint c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_unichar_isgraph(uint c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_unichar_islower(uint c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_unichar_isprint(uint c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_unichar_ispunct(uint c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_unichar_isspace(uint c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_unichar_isupper(uint c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_unichar_isxdigit(uint c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_unichar_istitle(uint c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_unichar_isdefined(uint c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_unichar_iswide(uint c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_unichar_iswide_cjk(uint c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_unichar_iszerowidth(uint c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_unichar_ismark(uint c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_unichar_toupper(uint c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_unichar_tolower(uint c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_unichar_totitle(uint c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_unichar_digit_value(uint c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_unichar_xdigit_value(uint c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GUnicodeType g_unichar_type(uint c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GUnicodeBreakType g_unichar_break_type(uint c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_unichar_combining_class(uint uc);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_unichar_get_mirror_char(uint ch, out uint mirrored_ch);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GUnicodeScript g_unichar_get_script(uint ch);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_unichar_validate(uint ch);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_unichar_compose(uint a, uint b, out uint ch);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_unichar_decompose(uint ch, out uint a, out uint b);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern nuint g_unichar_fully_decompose(uint ch, int compat, out uint result, nuint result_len);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_unicode_canonical_ordering(char[] @string, nuint len);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern string g_unicode_canonical_decomposition(uint ch, out nuint result_len);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_utf8_get_char(string p);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_utf8_get_char_validated(string p, nint max_len);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_utf8_offset_to_pointer(string str, nint offset);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern nint g_utf8_pointer_to_offset(string str, string pos);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_utf8_prev_char(string p);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_utf8_find_next_char(string p, string end);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_utf8_find_prev_char(string str, string p);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern nint g_utf8_strlen(string p, nint max);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_utf8_substring(string str, nint start_pos, nint end_pos);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_utf8_strncpy(string dest, string src, nuint n);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_utf8_strchr(string p, nint len, uint c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_utf8_strrchr(string p, nint len, uint c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_utf8_strreverse(string str, nint len);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_utf8_to_utf16(string str, nint len, out nint items_read, out nint items_written, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_utf8_to_ucs4(string str, nint len, out nint items_read, out nint items_written, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_utf8_to_ucs4_fast(string str, nint len, out nint items_written);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_utf16_to_ucs4(string str, nint len, out nint items_read, out nint items_written, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_utf16_to_utf8(string str, nint len, out nint items_read, out nint items_written, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_ucs4_to_utf16(string str, nint len, out nint items_read, out nint items_written, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_ucs4_to_utf8(string str, nint len, out nint items_read, out nint items_written, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_unichar_to_utf8(uint c, string outbuf);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_utf8_validate(string str, nint max_len, out string end);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_utf8_validate_len(string str, nuint max_len, out string end);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_utf8_strup(string str, nint len);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_utf8_strdown(string str, nint len);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_utf8_casefold(string str, nint len);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_utf8_normalize(string str, nint len, GNormalizeMode mode);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_utf8_collate(string str1, string str2);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_utf8_collate_key(string str, nint len);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_utf8_collate_key_for_filename(string str, nint len);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_utf8_make_valid(string str, nint len);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark g_io_channel_error_quark();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GIOChannelError g_io_channel_error_from_errno(int en);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark g_key_file_error_quark();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark g_markup_error_quark();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_markup_escape_text(string text, nint length);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_markup_printf_escaped(string format, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_markup_vprintf_escaped(string format, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_markup_collect_attributes(string element_name, string[] attribute_names, string[] attribute_values, out GErrorHandle error, GMarkupCollectType first_type, string first_attr, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_variant_type_string_is_valid(string type_string);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_variant_type_string_scan(string @string, string limit, out string endptr);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_variant_type_hash(IntPtr type);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_variant_type_equal(IntPtr type1, IntPtr type2);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GVariantTypeHandle g_variant_type_checked_(string param0);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern nuint g_variant_type_string_get_depth_(string type_string);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_variant_is_object_path(string @string);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_variant_is_signature(string @string);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_variant_hash(IntPtr value);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_variant_equal(IntPtr one, IntPtr two);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark g_variant_parser_get_error_quark();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark g_variant_parse_error_quark();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_variant_compare(IntPtr one, IntPtr two);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern nuint g_printf_string_upper_bound(string format, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_log_set_handler(string log_domain, GLogLevelFlags log_levels, GLogFunc log_func, IntPtr user_data);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_log_set_handler_full(string log_domain, GLogLevelFlags log_levels, GLogFunc log_func, IntPtr user_data, GDestroyNotify destroy);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_log_remove_handler(string log_domain, uint handler_id);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_log_default_handler(string log_domain, GLogLevelFlags log_level, string message, IntPtr unused_data);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GLogFunc g_log_set_default_handler(GLogFunc log_func, IntPtr user_data);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_log(string log_domain, GLogLevelFlags log_level, string format, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_logv(string log_domain, GLogLevelFlags log_level, string format, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GLogLevelFlags g_log_set_fatal_mask(string log_domain, GLogLevelFlags fatal_mask);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GLogLevelFlags g_log_set_always_fatal(GLogLevelFlags fatal_mask);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_log_structured(string log_domain, GLogLevelFlags log_level, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_log_structured_array(GLogLevelFlags log_level, GLogFieldHandle fields, nuint n_fields);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_log_variant(string log_domain, GLogLevelFlags log_level, GVariantHandle fields);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_log_set_writer_func(GLogWriterFunc func, IntPtr user_data, GDestroyNotify user_data_free);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_log_writer_supports_color(int output_fd);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_log_writer_is_journald(int output_fd);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_log_writer_format_fields(GLogLevelFlags log_level, GLogFieldHandle fields, nuint n_fields, int use_color);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GLogWriterOutput g_log_writer_journald(GLogLevelFlags log_level, GLogFieldHandle fields, nuint n_fields, IntPtr user_data);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GLogWriterOutput g_log_writer_standard_streams(GLogLevelFlags log_level, GLogFieldHandle fields, nuint n_fields, IntPtr user_data);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GLogWriterOutput g_log_writer_default(GLogLevelFlags log_level, GLogFieldHandle fields, nuint n_fields, IntPtr user_data);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_log_writer_default_set_use_stderr(int use_stderr);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_log_writer_default_would_drop(GLogLevelFlags log_level, string log_domain);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_log_get_debug_enabled();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_log_set_debug_enabled(int enabled);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void _g_log_fallback_handler(string log_domain, GLogLevelFlags log_level, string message, IntPtr unused_data);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_return_if_fail_warning(string log_domain, string pretty_function, string expression);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_warn_message(string domain, string file, int line, string func, string warnexpr);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern void g_assert_warning(string log_domain, string file, int line, string pretty_function, string expression);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_log_structured_standard(string log_domain, GLogLevelFlags log_level, string file, string line, string func, string message_format, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_print(string format, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GPrintFunc g_set_print_handler(GPrintFunc func);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_printerr(string format, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GPrintFunc g_set_printerr_handler(GPrintFunc func);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark g_option_error_quark();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_pattern_match_simple(string pattern, string @string);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_spaced_primes_closest(uint num);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_qsort_with_data(IntPtr pbase, int total_elems, nuint size, GCompareDataFunc compare_func, IntPtr user_data);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_random_set_seed(uint seed);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_random_int();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_random_int_range(int begin, int end);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern double g_random_double();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern double g_random_double_range(double begin, double end);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_rc_box_alloc(nuint block_size);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_rc_box_alloc0(nuint block_size);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_rc_box_dup(nuint block_size, IntPtr mem_block);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_rc_box_acquire(IntPtr mem_block);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_rc_box_release(IntPtr mem_block);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_rc_box_release_full(IntPtr mem_block, GDestroyNotify clear_func);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern nuint g_rc_box_get_size(IntPtr mem_block);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_atomic_rc_box_alloc(nuint block_size);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_atomic_rc_box_alloc0(nuint block_size);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_atomic_rc_box_dup(nuint block_size, IntPtr mem_block);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_atomic_rc_box_acquire(IntPtr mem_block);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_atomic_rc_box_release(IntPtr mem_block);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_atomic_rc_box_release_full(IntPtr mem_block, GDestroyNotify clear_func);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern nuint g_atomic_rc_box_get_size(IntPtr mem_block);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_ref_count_init(ref int rc);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_ref_count_inc(ref int rc);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_ref_count_dec(ref int rc);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_ref_count_compare(ref int rc, int val);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_atomic_ref_count_init(ref int arc);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_atomic_ref_count_inc(ref int arc);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_atomic_ref_count_dec(ref int arc);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_atomic_ref_count_compare(ref int arc, int val);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_ref_string_new(string str);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_ref_string_new_len(string str, nint len);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_ref_string_new_intern(string str);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_ref_string_acquire(string str);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_ref_string_release(string str);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern nuint g_ref_string_length(string str);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark g_regex_error_quark();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_regex_escape_string(string @string, int length);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_regex_escape_nul(string @string, int length);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_regex_match_simple(string pattern, string @string, GRegexCompileFlags compile_options, GRegexMatchFlags match_options);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string[] g_regex_split_simple(string pattern, string @string, GRegexCompileFlags compile_options, GRegexMatchFlags match_options);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_regex_check_replacement(string replacement, out bool has_references, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark g_shell_error_quark();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_shell_quote(string unquoted_string);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_shell_unquote(string quoted_string, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_shell_parse_argv(string command_line, out int argcp, out string[] argvp, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_slice_alloc(nuint block_size);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_slice_alloc0(nuint block_size);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_slice_copy(nuint block_size, IntPtr mem_block);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_slice_free1(nuint block_size, IntPtr mem_block);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_slice_free_chain_with_offset(nuint block_size, IntPtr mem_chain, nuint next_offset);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern void g_slice_set_config(GSliceConfig ckey, nint value);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern nint g_slice_get_config(GSliceConfig ckey);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern nint[] g_slice_get_config_state(GSliceConfig ckey, nint address, out uint n_values);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark g_spawn_error_quark();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark g_spawn_exit_error_quark();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_spawn_async(string working_directory, string[] argv, string[] envp, GSpawnFlags flags, GSpawnChildSetupFunc child_setup, IntPtr user_data, GPidHandle child_pid, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_spawn_async_with_pipes(string working_directory, string[] argv, string[] envp, GSpawnFlags flags, GSpawnChildSetupFunc child_setup, IntPtr user_data, GPidHandle child_pid, out int standard_input, out int standard_output, out int standard_error, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_spawn_async_with_pipes_and_fds(string working_directory, string argv, string envp, GSpawnFlags flags, GSpawnChildSetupFunc child_setup, IntPtr user_data, int stdin_fd, int stdout_fd, int stderr_fd, int[] source_fds, int[] target_fds, nuint n_fds, GPidHandle child_pid_out, out int stdin_pipe_out, out int stdout_pipe_out, out int stderr_pipe_out, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_spawn_async_with_fds(string working_directory, string[] argv, string[] envp, GSpawnFlags flags, GSpawnChildSetupFunc child_setup, IntPtr user_data, GPidHandle child_pid, int stdin_fd, int stdout_fd, int stderr_fd, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_spawn_sync(string working_directory, string[] argv, string[] envp, GSpawnFlags flags, GSpawnChildSetupFunc child_setup, IntPtr user_data, string[] standard_output, string[] standard_error, out int wait_status, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_spawn_command_line_sync(string command_line, string[] standard_output, string[] standard_error, out int wait_status, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_spawn_command_line_async(string command_line, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_spawn_check_wait_status(int wait_status, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern int g_spawn_check_exit_status(int wait_status, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_spawn_close_pid(GPid pid);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern char g_ascii_tolower(char c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern char g_ascii_toupper(char c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_ascii_digit_value(char c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_ascii_xdigit_value(char c);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_strdelimit(string @string, string delimiters, char new_delimiter);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_strcanon(string @string, string valid_chars, char substitutor);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_strerror(int errnum);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_strsignal(int signum);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_strreverse(string @string);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern nuint g_strlcpy(string dest, string src, nuint dest_size);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern nuint g_strlcat(string dest, string src, nuint dest_size);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_strstr_len(string haystack, nint haystack_len, string needle);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_strrstr(string haystack, string needle);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_strrstr_len(string haystack, nint haystack_len, string needle);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_str_has_suffix(string str, string suffix);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_str_has_prefix(string str, string prefix);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern double g_strtod(string nptr, string[] endptr);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern double g_ascii_strtod(string nptr, string[] endptr);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern nuint g_ascii_strtoull(string nptr, string[] endptr, uint @base);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern nint g_ascii_strtoll(string nptr, string[] endptr, uint @base);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_ascii_dtostr(string buffer, int buf_len, double d);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_ascii_formatd(string buffer, int buf_len, string format, double d);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_strchug(string @string);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_strchomp(string @string);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_ascii_strcasecmp(string s1, string s2);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_ascii_strncasecmp(string s1, string s2, nuint n);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_ascii_strdown(string str, nint len);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_ascii_strup(string str, nint len);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_str_is_ascii(string str);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern int g_strcasecmp(string s1, string s2);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern int g_strncasecmp(string s1, string s2, uint n);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_strdown(string @string);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_strup(string @string);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_strdup(string str);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_strdup_printf(string format, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_strdup_vprintf(string format, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_strndup(string str, nuint n);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_strnfill(nuint length, char fill_char);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_strconcat(string string1, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_strjoin(string separator, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_strcompress(string source);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_strescape(string source, string exceptions);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_memdup(IntPtr mem, uint byte_size);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_memdup2(IntPtr mem, nuint byte_size);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string[] g_strsplit(string @string, string delimiter, int max_tokens);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string[] g_strsplit_set(string @string, string delimiters, int max_tokens);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_strjoinv(string separator, string[] str_array);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_strfreev(string[] str_array);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string[] g_strdupv(string[] str_array);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_strv_length(string[] str_array);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_stpcpy(string dest, string src);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_str_to_ascii(string str, string from_locale);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string[] g_str_tokenize_and_fold(string @string, string translit_locale, out string[] ascii_alternates);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_str_match_string(string search_term, string potential_hit, int accept_alternates);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_strv_contains(string strv, string str);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_strv_equal(string strv1, string strv2);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark g_number_parser_error_quark();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_ascii_string_to_signed(string str, uint @base, nint min, nint max, out nint out_num, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_ascii_string_to_unsigned(string str, uint @base, nuint min, nuint max, out nuint out_num, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_strcmp0(string str1, string str2);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_test_minimized_result(double minimized_quantity, string format, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_test_maximized_result(double maximized_quantity, string format, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_test_init(ref int argc, ref string[] argv, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_test_subprocess();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_test_run();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_test_add_func(string testpath, GTestFunc test_func);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_test_add_data_func(string testpath, IntPtr test_data, GTestDataFunc test_func);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_test_add_data_func_full(string testpath, IntPtr test_data, GTestDataFunc test_func, GDestroyNotify data_free_func);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_test_get_path();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_test_fail();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_test_fail_printf(string format, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_test_incomplete(string msg);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_test_incomplete_printf(string format, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_test_skip(string msg);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_test_skip_printf(string format, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_test_failed();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_test_set_nonfatal_assertions();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_test_message(string format, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_test_bug_base(string uri_pattern);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_test_bug(string bug_uri_snippet);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_test_summary(string summary);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_test_timer_start();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern double g_test_timer_elapsed();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern double g_test_timer_last();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_test_queue_free(IntPtr gfree_pointer);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_test_queue_destroy(GDestroyNotify destroy_func, IntPtr destroy_data);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern int g_test_trap_fork(nuint usec_timeout, GTestTrapFlags test_trap_flags);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_test_trap_subprocess(string test_path, nuint usec_timeout, GTestSubprocessFlags test_flags);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_test_trap_has_passed();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_test_trap_reached_timeout();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_test_rand_int();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_test_rand_int_range(int begin, int end);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern double g_test_rand_double();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern double g_test_rand_double_range(double range_start, double range_end);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GTestCaseHandle g_test_create_case(string test_name, nuint data_size, IntPtr test_data, GTestFixtureFunc data_setup, GTestFixtureFunc data_test, GTestFixtureFunc data_teardown);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GTestSuiteHandle g_test_create_suite(string suite_name);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GTestSuiteHandle g_test_get_root();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_test_trap_assertions(string domain, string file, int line, string func, nuint assertion_flags, string pattern);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_assertion_message(string domain, string file, int line, string func, string message);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_assertion_message_expr(string domain, string file, int line, string func, string expr);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_assertion_message_cmpstr(string domain, string file, int line, string func, string expr, string arg1, string cmp, string arg2);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_assertion_message_cmpstrv(string domain, string file, int line, string func, string expr, string arg1, string arg2, nuint first_wrong_idx);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_assertion_message_cmpnum(string domain, string file, int line, string func, string expr, decimal arg1, string cmp, decimal arg2, char numtype);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_assertion_message_error(string domain, string file, int line, string func, string expr, GErrorHandle error, GQuark error_domain, int error_code);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_test_add_vtable(string testpath, nuint data_size, IntPtr test_data, GTestFixtureFunc data_setup, GTestFixtureFunc data_test, GTestFixtureFunc data_teardown);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_test_log_type_name(GTestLogType log_type);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_test_log_set_fatal_handler(GTestLogFatalFunc log_func, IntPtr user_data);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_test_expect_message(string log_domain, GLogLevelFlags log_level, string pattern);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_test_assert_expected_messages_internal(string domain, string file, int line, string func);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_test_build_filename(GTestFileType file_type, string first_path, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_test_get_dir(GTestFileType file_type);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_test_get_filename(GTestFileType file_type, string first_path, __arglist);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_thread_pool_set_max_unused_threads(int max_threads);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_thread_pool_get_max_unused_threads();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_thread_pool_get_num_unused_threads();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_thread_pool_stop_unused_threads();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_thread_pool_set_max_idle_time(uint interval);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_thread_pool_get_max_idle_time();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_usleep(nuint microseconds);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern int g_time_val_from_iso8601(string iso_date, GTimeValHandle time_);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern void g_trash_stack_push(out GTrashStackHandle stack_p, IntPtr data_p);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_trash_stack_pop(out GTrashStackHandle stack_p);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_trash_stack_peek(out GTrashStackHandle stack_p);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern uint g_trash_stack_height(out GTrashStackHandle stack_p);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_uri_split(string uri_ref, GUriFlags flags, string[] scheme, string[] userinfo, string[] host, out int port, string[] path, string[] query, string[] fragment, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_uri_split_with_user(string uri_ref, GUriFlags flags, string[] scheme, string[] user, string[] password, string[] auth_params, string[] host, out int port, string[] path, string[] query, string[] fragment, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_uri_split_network(string uri_string, GUriFlags flags, string[] scheme, string[] host, out int port, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_uri_is_valid(string uri_string, GUriFlags flags, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_uri_join(GUriFlags flags, string scheme, string userinfo, string host, int port, string path, string query, string fragment);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_uri_join_with_user(GUriFlags flags, string scheme, string user, string password, string auth_params, string host, int port, string path, string query, string fragment);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GUriHandle g_uri_parse(string uri_string, GUriFlags flags, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_uri_resolve_relative(string base_uri_string, string uri_ref, GUriFlags flags, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GUriHandle g_uri_build(GUriFlags flags, string scheme, string userinfo, string host, int port, string path, string query, string fragment);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GUriHandle g_uri_build_with_user(GUriFlags flags, string scheme, string user, string password, string auth_params, string host, int port, string path, string query, string fragment);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GHashTableHandle g_uri_parse_params(string @params, nint length, string separators, GUriParamsFlags flags, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark g_uri_error_quark();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_uri_unescape_string(string escaped_string, string illegal_characters);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_uri_unescape_segment(string escaped_string, string escaped_string_end, string illegal_characters);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_uri_parse_scheme(string uri);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_uri_peek_scheme(string uri);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_uri_escape_string(string unescaped, string reserved_chars_allowed, int allow_utf8);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GBytesHandle g_uri_unescape_bytes(string escaped_string, nint length, string illegal_characters, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_uri_escape_bytes(byte[] unescaped, nuint length, string reserved_chars_allowed);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_uuid_string_is_valid(string str);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_uuid_string_random();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string glib_check_version(uint required_major, uint required_minor, uint required_micro);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern void g_mem_chunk_info();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern void g_blow_chunks();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern void g_list_pop_allocator();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern void g_slist_pop_allocator();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern void g_node_pop_allocator();

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GThreadHandle g_thread_create(GThreadFunc func, IntPtr data, int joinable, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GThreadHandle g_thread_create_full(GThreadFunc func, IntPtr data, nuint stack_size, int joinable, int bound, GThreadPriority priority, out GErrorHandle error);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern void g_thread_foreach(IntPtr thread_func, IntPtr user_data);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern int g_once_init_enter_impl(ref nuint location);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern void g_thread_init(IntPtr vtable);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern void g_thread_init_with_errorcheck_mutexes(IntPtr vtable);

	[DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern int g_thread_get_initialized();
}
