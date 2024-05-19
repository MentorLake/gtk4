using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.GLib;

internal class GlobalFunctionExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_dataset_destroy(IntPtr dataset_location);

	[DllImport(Libraries.GLib)]
	internal static extern void g_usleep(ulong microseconds);

	[DllImport(Libraries.GLib)]
	internal static extern string glib_check_version(uint required_major, uint required_minor, uint required_micro);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_datalist_id_dup_data(ref GDataHandle datalist, GQuark key_id, GDuplicateFunc dup_func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_propagate_error(out GErrorHandle dest, GErrorHandle src);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_idle_remove_by_data(IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_memdup2(IntPtr mem, int byte_size);

	[DllImport(Libraries.GLib)]
	internal static extern void g_ref_count_init(ref int rc);

	[DllImport(Libraries.GLib)]
	internal static extern string g_utf8_substring(string str, long start_pos, long end_pos);

	[DllImport(Libraries.GLib)]
	internal static extern string g_basename(string file_name);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_log_set_handler_full(string log_domain, GLogLevelFlags log_levels, GLogFunc log_func, IntPtr user_data, GDestroyNotify destroy);

	[DllImport(Libraries.GLib)]
	internal static extern string[] g_str_tokenize_and_fold(string @string, string translit_locale, out string[] ascii_alternates);

	[DllImport(Libraries.GLib)]
	internal static extern void g_log_set_writer_func(GLogWriterFunc func, IntPtr user_data, GDestroyNotify user_data_free);

	[DllImport(Libraries.GLib)]
	internal static extern string[] g_listenv();

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_minimized_result(double minimized_quantity, string format, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern int g_access(string filename, int mode);

	[DllImport(Libraries.GLib)]
	internal static extern void g_pointer_bit_unlock(IntPtr address, int lock_bit);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_atomic_ref_count_dec(ref int arc);

	[DllImport(Libraries.GLib)]
	internal static extern string g_dngettext(string domain, string msgid, string msgid_plural, ulong n);

	[DllImport(Libraries.GLib)]
	internal static extern string g_str_to_ascii(string str, string from_locale);

	[DllImport(Libraries.GLib)]
	internal static extern string g_get_real_name();

	[DllImport(Libraries.GLib)]
	internal static extern string g_utf8_find_prev_char(string str, string p);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_aligned_alloc0(int n_blocks, int n_block_bytes, int alignment);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_pattern_match(GPatternSpecHandle pspec, uint string_length, string @string, string string_reversed);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_skip_printf(string format, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_double_hash(IntPtr v);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_trap_subprocess(string test_path, ulong usec_timeout, GTestSubprocessFlags test_flags);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_unichar_islower(char c);

	[DllImport(Libraries.GLib)]
	internal static extern GFileError g_file_error_from_errno(int err_no);

	[DllImport(Libraries.GLib)]
	internal static extern void g_dataset_foreach(IntPtr dataset_location, GDataForeachFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern string g_test_log_type_name(GTestLogType log_type);

	[DllImport(Libraries.GLib)]
	internal static extern int g_bit_nth_msf(ulong mask, int nth_bit);

	[DllImport(Libraries.GLib)]
	internal static extern int g_atomic_int_exchange_and_add(ref int atomic, int val);

	[DllImport(Libraries.GLib)]
	internal static extern int g_atomic_rc_box_get_size(IntPtr mem_block);

	[DllImport(Libraries.GLib)]
	internal static extern string g_strndup(string str, int n);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_file_set_contents_full(string filename, string contents, int length, GFileSetContentsFlags flags, int mode, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern string g_hostname_to_ascii(string hostname);

	[DllImport(Libraries.GLib)]
	internal static extern int g_fdwalk_set_cloexec(int lowfd);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_init(ref int argc, ref string[] argv, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern void g_free_sized(IntPtr mem, int size);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_unix_set_fd_nonblocking(int fd, bool nonblock, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern int g_iconv(GIConv converter, ref string inbuf, ref int inbytes_left, ref string outbuf, ref int outbytes_left);

	[DllImport(Libraries.GLib)]
	internal static extern string[] g_get_environ();

	[DllImport(Libraries.GLib)]
	internal static extern long g_slice_get_config(GSliceConfig ckey);

	[DllImport(Libraries.GLib)]
	internal static extern string g_compute_checksum_for_bytes(GChecksumType checksum_type, GBytesHandle data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_timer_start();

	[DllImport(Libraries.GLib)]
	internal static extern string g_build_filenamev(string[] args);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_datalist_get_data(ref GDataHandle datalist, string key);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_unichar_ismark(char c);

	[DllImport(Libraries.GLib)]
	internal static extern void g_atomic_rc_box_release_full(IntPtr mem_block, GDestroyNotify clear_func);

	[DllImport(Libraries.GLib)]
	internal static extern GSourceHandle g_timeout_source_new(uint interval);

	[DllImport(Libraries.GLib)]
	internal static extern int g_strcasecmp(string s1, string s2);

	[DllImport(Libraries.GLib)]
	internal static extern int g_lstat(string filename, GStatBufHandle buf);

	[DllImport(Libraries.GLib)]
	internal static extern int g_ref_string_length(string str);

	[DllImport(Libraries.GLib)]
	internal static extern string g_convert_with_fallback(string str, int len, string to_codeset, string from_codeset, string fallback, out int bytes_read, out int bytes_written, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern int g_ascii_xdigit_value(char c);

	[DllImport(Libraries.GLib)]
	internal static extern int g_strlcpy(string dest, string src, int dest_size);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_log_get_debug_enabled();

	[DllImport(Libraries.GLib)]
	internal static extern void g_clear_handle_id(ref uint tag_ptr, GClearHandleFunc clear_func);

	[DllImport(Libraries.GLib)]
	internal static extern string g_compute_checksum_for_string(GChecksumType checksum_type, string str, int length);

	[DllImport(Libraries.GLib)]
	internal static extern string[] g_environ_unsetenv(string[] envp, string variable);

	[DllImport(Libraries.GLib)]
	internal static extern int g_vprintf(string format, IntPtr args);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_unichar_isdefined(char c);

	[DllImport(Libraries.GLib)]
	internal static extern nuint g_atomic_pointer_or(IntPtr atomic, int val);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_memdup(IntPtr mem, uint byte_size);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_datalist_id_remove_no_notify(ref GDataHandle datalist, GQuark key_id);

	[DllImport(Libraries.GLib)]
	internal static extern GQuark g_option_error_quark();

	[DllImport(Libraries.GLib)]
	internal static extern bool g_double_equal(IntPtr v1, IntPtr v2);

	[DllImport(Libraries.GLib)]
	internal static extern GLogWriterOutput g_log_writer_journald(GLogLevelFlags log_level, GLogField[] fields, int n_fields, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern int g_vsprintf(string @string, string format, IntPtr args);

	[DllImport(Libraries.GLib)]
	internal static extern int g_strncasecmp(string s1, string s2, uint n);

	[DllImport(Libraries.GLib)]
	internal static extern string g_compute_hmac_for_string(GChecksumType digest_type, string key, int key_len, string str, int length);

	[DllImport(Libraries.GLib)]
	internal static extern void g_log_writer_default_set_debug_domains(string domains);

	[DllImport(Libraries.GLib)]
	internal static extern string[] g_strsplit_set(string @string, string delimiters, int max_tokens);

	[DllImport(Libraries.GLib)]
	internal static extern string g_path_get_dirname(string file_name);

	[DllImport(Libraries.GLib)]
	internal static extern void g_nullify_pointer(ref IntPtr nullify_location);

	[DllImport(Libraries.GLib)]
	internal static extern int g_rename(string oldfilename, string newfilename);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_freopen(string filename, string mode, IntPtr stream);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_unichar_istitle(char c);

	[DllImport(Libraries.GLib)]
	internal static extern string g_strreverse(string @string);

	[DllImport(Libraries.GLib)]
	internal static extern string g_path_get_basename(string file_name);

	[DllImport(Libraries.GLib)]
	internal static extern string g_get_language_names_with_category(string category_name);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_pointer_bit_lock_mask_ptr(IntPtr ptr, uint lock_bit, bool set, nuint preserve_mask, IntPtr preserve_ptr);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_trap_assertions(string domain, string file, int line, string func, ulong assertion_flags, string pattern);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_atomic_rc_box_alloc0(int block_size);

	[DllImport(Libraries.GLib)]
	internal static extern string g_strdup_printf(string format, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern int g_stat(string filename, GStatBufHandle buf);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_file_get_contents(string filename, out string contents, out int length, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_atomic_pointer_compare_and_exchange(IntPtr atomic, IntPtr oldval, IntPtr newval);

	[DllImport(Libraries.GLib)]
	internal static extern string g_mkdtemp(string tmpl);

	[DllImport(Libraries.GLib)]
	internal static extern string g_strdup_vprintf(string format, IntPtr args);

	[DllImport(Libraries.GLib)]
	internal static extern string g_strdelimit(string @string, string delimiters, char new_delimiter);

	[DllImport(Libraries.GLib)]
	internal static extern void g_set_application_name(string application_name);

	[DllImport(Libraries.GLib)]
	internal static extern string g_utf8_strncpy(string dest, string src, int n);

	[DllImport(Libraries.GLib)]
	internal static extern void g_log_structured_standard(string log_domain, GLogLevelFlags log_level, string file, string line, string func, string message_format, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern void g_propagate_prefixed_error(out GErrorHandle dest, GErrorHandle src, string format, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern string g_strrstr(string haystack, string needle);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_spawn_async_with_fds(string working_directory, string[] argv, string[] envp, GSpawnFlags flags, GSpawnChildSetupFunc child_setup, IntPtr user_data, out GPid child_pid, int stdin_fd, int stdout_fd, int stderr_fd, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_spawn_sync(string working_directory, string[] argv, string[] envp, GSpawnFlags flags, GSpawnChildSetupFunc child_setup, IntPtr user_data, out string standard_output, out string standard_error, out int wait_status, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_utf8_validate(string str, int max_len, out string end);

	[DllImport(Libraries.GLib)]
	internal static extern string g_dgettext(string domain, string msgid);

	[DllImport(Libraries.GLib)]
	internal static extern int g_strcmp0(string str1, string str2);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_atomic_int_compare_and_exchange(ref int atomic, int oldval, int newval);

	[DllImport(Libraries.GLib)]
	internal static extern int g_vsnprintf(string @string, ulong n, string format, IntPtr args);

	[DllImport(Libraries.GLib)]
	internal static extern double g_test_rand_double_range(double range_start, double range_end);

	[DllImport(Libraries.GLib)]
	internal static extern int g_ascii_strncasecmp(string s1, string s2, int n);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_queue_free(IntPtr gfree_pointer);

	[DllImport(Libraries.GLib)]
	internal static extern string g_utf8_collate_key_for_filename(string str, int len);

	[DllImport(Libraries.GLib)]
	internal static extern int g_unichar_fully_decompose(char ch, bool compat, out string result, int result_len);

	[DllImport(Libraries.GLib)]
	internal static extern double g_test_rand_double();

	[DllImport(Libraries.GLib)]
	internal static extern uint g_int64_hash(IntPtr v);

	[DllImport(Libraries.GLib)]
	internal static extern string g_get_prgname();

	[DllImport(Libraries.GLib)]
	internal static extern string g_utf8_make_valid(string str, int len);

	[DllImport(Libraries.GLib)]
	internal static extern int g_atomic_int_exchange(ref int atomic, int newval);

	[DllImport(Libraries.GLib)]
	internal static extern int g_printf(string format, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern string g_utf8_collate_key(string str, int len);

	[DllImport(Libraries.GLib)]
	internal static extern int g_vfprintf(IntPtr file, string format, IntPtr args);

	[DllImport(Libraries.GLib)]
	internal static extern void g_prefix_error_literal(out GErrorHandle err, string prefix);

	[DllImport(Libraries.GLib)]
	internal static extern string g_locale_to_utf8(string opsysstring, int len, out int bytes_read, out int bytes_written, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_unichar_get_mirror_char(char ch, out string mirrored_ch);

	[DllImport(Libraries.GLib)]
	internal static extern string g_get_user_data_dir();

	[DllImport(Libraries.GLib)]
	internal static extern string g_markup_escape_text(string text, int length);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_unix_fd_add_full(int priority, int fd, GIOCondition condition, GUnixFDSourceFunc function, IntPtr user_data, GDestroyNotify notify);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_dataset_id_remove_no_notify(IntPtr dataset_location, GQuark key_id);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_utf8_validate_len(string str, int max_len, out string end);

	[DllImport(Libraries.GLib)]
	internal static extern string g_build_pathv(string separator, string[] args);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_hostname_is_ip_address(string hostname);

	[DllImport(Libraries.GLib)]
	internal static extern string g_build_filename_valist(string first_element, IntPtr args);

	[DllImport(Libraries.GLib)]
	internal static extern GLogWriterOutput g_log_writer_standard_streams(GLogLevelFlags log_level, GLogField[] fields, int n_fields, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_atomic_ref_count_init(ref int arc);

	[DllImport(Libraries.GLib)]
	internal static extern string g_strchomp(string @string);

	[DllImport(Libraries.GLib)]
	internal static extern void g_pointer_bit_lock(IntPtr address, int lock_bit);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_bit_storage(ulong number);

	[DllImport(Libraries.GLib)]
	internal static extern string g_utf8_strchr(string p, int len, char c);

	[DllImport(Libraries.GLib)]
	internal static extern string g_hostname_to_unicode(string hostname);

	[DllImport(Libraries.GLib)]
	internal static extern string g_unicode_canonical_decomposition(char ch, ref int result_len);

	[DllImport(Libraries.GLib)]
	internal static extern GLogLevelFlags g_log_set_fatal_mask(string log_domain, GLogLevelFlags fatal_mask);

	[DllImport(Libraries.GLib)]
	internal static extern string g_get_system_data_dirs();

	[DllImport(Libraries.GLib)]
	internal static extern void g_rc_box_release(IntPtr mem_block);

	[DllImport(Libraries.GLib)]
	internal static extern void g_log_structured_array(GLogLevelFlags log_level, GLogField[] fields, int n_fields);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_log_writer_default_would_drop(GLogLevelFlags log_level, string log_domain);

	[DllImport(Libraries.GLib)]
	internal static extern string g_mkdtemp_full(string tmpl, int mode);

	[DllImport(Libraries.GLib)]
	internal static extern string g_convert(string str, int len, string to_codeset, string from_codeset, out int bytes_read, out int bytes_written, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_spawn_check_wait_status(int wait_status, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_malloc_n(int n_blocks, int n_block_bytes);

	[DllImport(Libraries.GLib)]
	internal static extern string g_compute_checksum_for_data(GChecksumType checksum_type, string data, int length);

	[DllImport(Libraries.GLib)]
	internal static extern string g_get_user_special_dir(GUserDirectory directory);

	[DllImport(Libraries.GLib)]
	internal static extern GUnicodeType g_unichar_type(char c);

	[DllImport(Libraries.GLib)]
	internal static extern string g_get_system_config_dirs();

	[DllImport(Libraries.GLib)]
	internal static extern int g_main_depth();

	[DllImport(Libraries.GLib)]
	internal static extern long g_get_real_time();

	[DllImport(Libraries.GLib)]
	internal static extern void g_datalist_id_set_data_full(ref GDataHandle datalist, GQuark key_id, IntPtr data, GDestroyNotify destroy_func);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_unichar_decompose(char ch, out string a, out string b);

	[DllImport(Libraries.GLib)]
	internal static extern string g_ref_string_new_len(string str, int len);

	[DllImport(Libraries.GLib)]
	internal static extern int g_poll(GPollFDHandle fds, uint nfds, int timeout);

	[DllImport(Libraries.GLib)]
	internal static extern GTestSuiteHandle g_test_create_suite(string suite_name);

	[DllImport(Libraries.GLib)]
	internal static extern string g_get_tmp_dir();

	[DllImport(Libraries.GLib)]
	internal static extern void g_atomic_pointer_set(IntPtr atomic, IntPtr newval);

	[DllImport(Libraries.GLib)]
	internal static extern int g_utf8_collate(string str1, string str2);

	[DllImport(Libraries.GLib)]
	internal static extern GUnicodeScript g_unichar_get_script(char ch);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_datalist_id_get_data(ref GDataHandle datalist, GQuark key_id);

	[DllImport(Libraries.GLib)]
	internal static extern nuint g_atomic_pointer_and(IntPtr atomic, int val);

	[DllImport(Libraries.GLib)]
	internal static extern void g_datalist_foreach(ref GDataHandle datalist, GDataForeachFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_clear_list(ref GListHandle list_ptr, GDestroyNotify destroy);

	[DllImport(Libraries.GLib)]
	internal static extern string[] g_get_locale_variants(string locale);

	[DllImport(Libraries.GLib)]
	internal static extern int g_unichar_xdigit_value(char c);

	[DllImport(Libraries.GLib)]
	internal static extern string g_utf16_to_ucs4(string str, long len, out long items_read, out long items_written, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_test_trap_fork(ulong usec_timeout, GTestTrapFlags test_trap_flags);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_close(int fd, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern int g_atomic_int_get(ref int atomic);

	[DllImport(Libraries.GLib)]
	internal static extern string g_ascii_dtostr(string buffer, int buf_len, double d);

	[DllImport(Libraries.GLib)]
	internal static extern string g_intern_string(string @string);

	[DllImport(Libraries.GLib)]
	internal static extern string g_stpcpy(string dest, string src);

	[DllImport(Libraries.GLib)]
	internal static extern void g_atomic_int_inc(ref int atomic);

	[DllImport(Libraries.GLib)]
	internal static extern string g_strchug(string @string);

	[DllImport(Libraries.GLib)]
	internal static extern string g_strsignal(int signum);

	[DllImport(Libraries.GLib)]
	internal static extern void g_ref_string_release(string str);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_realloc(IntPtr mem, int n_bytes);

	[DllImport(Libraries.GLib)]
	internal static extern void g_spawn_close_pid(GPid pid);

	[DllImport(Libraries.GLib)]
	internal static extern string g_get_user_state_dir();

	[DllImport(Libraries.GLib)]
	internal static extern bool g_atomic_ref_count_compare(ref int arc, int val);

	[DllImport(Libraries.GLib)]
	internal static extern void g_log_variant(string log_domain, GLogLevelFlags log_level, GVariantHandle fields);

	[DllImport(Libraries.GLib)]
	internal static extern GQuark g_number_parser_error_quark();

	[DllImport(Libraries.GLib)]
	internal static extern char g_utf8_get_char_validated(string p, int max_len);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_maximized_result(double maximized_quantity, string format, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern string g_locale_from_utf8(string utf8string, int len, out int bytes_read, out int bytes_written, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_timeout_add_seconds_once(uint interval, GSourceOnceFunc function, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern string g_get_os_info(string key_name);

	[DllImport(Libraries.GLib)]
	internal static extern void g_log_remove_handler(string log_domain, uint handler_id);

	[DllImport(Libraries.GLib)]
	internal static extern void g_slice_free1(int block_size, IntPtr mem_block);

	[DllImport(Libraries.GLib)]
	internal static extern int g_unichar_to_utf8(char c, out string outbuf);

	[DllImport(Libraries.GLib)]
	internal static extern string g_utf8_offset_to_pointer(string str, long offset);

	[DllImport(Libraries.GLib)]
	internal static extern string g_find_program_in_path(string program);

	[DllImport(Libraries.GLib)]
	internal static extern int g_test_run_suite(GTestSuiteHandle suite);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_fail();

	[DllImport(Libraries.GLib)]
	internal static extern void g_mem_profile();

	[DllImport(Libraries.GLib)]
	internal static extern bool g_uuid_string_is_valid(string str);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_test_subprocess();

	[DllImport(Libraries.GLib)]
	internal static extern void g_on_error_query(string prg_name);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_atomic_pointer_exchange(IntPtr atomic, IntPtr newval);

	[DllImport(Libraries.GLib)]
	internal static extern string g_filename_from_utf8(string utf8string, int len, out int bytes_read, out int bytes_written, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_spawn_async_with_pipes(string working_directory, string[] argv, string[] envp, GSpawnFlags flags, GSpawnChildSetupFunc child_setup, IntPtr user_data, out GPid child_pid, out int standard_input, out int standard_output, out int standard_error, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern string g_base64_decode_inplace(string text, ref int out_len);

	[DllImport(Libraries.GLib)]
	internal static extern int g_rc_box_get_size(IntPtr mem_block);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_get_num_processors();

	[DllImport(Libraries.GLib)]
	internal static extern bool g_hostname_is_ascii_encoded(string hostname);

	[DllImport(Libraries.GLib)]
	internal static extern string g_strstr_len(string haystack, int haystack_len, string needle);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_fopen(string filename, string mode);

	[DllImport(Libraries.GLib)]
	internal static extern GType g_strv_get_type();

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_incomplete_printf(string format, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern double g_random_double_range(double begin, double end);

	[DllImport(Libraries.GLib)]
	internal static extern GQuark g_spawn_exit_error_quark();

	[DllImport(Libraries.GLib)]
	internal static extern long g_ascii_strtoll(string nptr, out string endptr, uint @base);

	[DllImport(Libraries.GLib)]
	internal static extern void g_pointer_bit_lock_and_get(IntPtr address, uint lock_bit, out nuint out_ptr);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_add_vtable(string testpath, int data_size, IntPtr test_data, GTestFixtureFunc data_setup, GTestFixtureFunc data_test, GTestFixtureFunc data_teardown);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_int_equal(IntPtr v1, IntPtr v2);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_unix_get_passwd_entry(string user_name, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern void g_blow_chunks();

	[DllImport(Libraries.GLib)]
	internal static extern bool g_atomic_int_dec_and_test(ref int atomic);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_atomic_int_and(ref uint atomic, uint val);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_parse_debug_string(string @string, GDebugKey[] keys, uint nkeys);

	[DllImport(Libraries.GLib)]
	internal static extern void g_warn_message(string domain, string file, int line, string func, string warnexpr);

	[DllImport(Libraries.GLib)]
	internal static extern string g_ucs4_to_utf8(string str, long len, out long items_read, out long items_written, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern string g_filename_display_basename(string filename);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_idle_add(GSourceFunc function, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_assertion_message_error(string domain, string file, int line, string func, string expr, GErrorHandle error, GQuark error_domain, int error_code);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_set_nonfatal_assertions();

	[DllImport(Libraries.GLib)]
	internal static extern string g_quark_to_string(GQuark quark);

	[DllImport(Libraries.GLib)]
	internal static extern int g_bit_nth_lsf(ulong mask, int nth_bit);

	[DllImport(Libraries.GLib)]
	internal static extern int g_atomic_int_add(ref int atomic, int val);

	[DllImport(Libraries.GLib)]
	internal static extern long g_utf8_strlen(string p, int max);

	[DllImport(Libraries.GLib)]
	internal static extern int g_remove(string filename);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_bug_base(string uri_pattern);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_log_set_handler(string log_domain, GLogLevelFlags log_levels, GLogFunc log_func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_atomic_pointer_get(IntPtr atomic);

	[DllImport(Libraries.GLib)]
	internal static extern string g_utf8_prev_char(string p);

	[DllImport(Libraries.GLib)]
	internal static extern void g_rc_box_release_full(IntPtr mem_block, GDestroyNotify clear_func);

	[DllImport(Libraries.GLib)]
	internal static extern string g_utf8_casefold(string str, int len);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_test_trap_reached_timeout();

	[DllImport(Libraries.GLib)]
	internal static extern bool g_log_writer_supports_color(int output_fd);

	[DllImport(Libraries.GLib)]
	internal static extern double g_test_timer_last();

	[DllImport(Libraries.GLib)]
	internal static extern uint g_unix_signal_add_full(int priority, int signum, GSourceFunc handler, IntPtr user_data, GDestroyNotify notify);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_atomic_pointer_compare_and_exchange_full(IntPtr atomic, IntPtr oldval, IntPtr newval, out IntPtr preval);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_strv_contains(string strv, string str);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_mem_is_system_malloc();

	[DllImport(Libraries.GLib)]
	internal static extern void g_assert_warning(string log_domain, string file, int line, string pretty_function, string expression);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_unichar_isalnum(char c);

	[DllImport(Libraries.GLib)]
	internal static extern void g_log_set_debug_enabled(bool enabled);

	[DllImport(Libraries.GLib)]
	internal static extern double g_random_double();

	[DllImport(Libraries.GLib)]
	internal static extern void g_log_structured(string log_domain, GLogLevelFlags log_level, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern string g_convert_with_iconv(string str, int len, GIConv converter, out int bytes_read, out int bytes_written, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern void g_assertion_message_cmpstr(string domain, string file, int line, string func, string expr, string arg1, string cmp, string arg2);

	[DllImport(Libraries.GLib)]
	internal static extern int g_mkdir_with_parents(string pathname, int mode);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_str_has_prefix(string str, string prefix);

	[DllImport(Libraries.GLib)]
	internal static extern GSourceHandle g_unix_signal_source_new(int signum);

	[DllImport(Libraries.GLib)]
	internal static extern GQuark g_quark_from_string(string @string);

	[DllImport(Libraries.GLib)]
	internal static extern GPrintFunc g_set_print_handler(GPrintFunc func);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_rc_box_acquire(IntPtr mem_block);

	[DllImport(Libraries.GLib)]
	internal static extern void g_set_error(out GErrorHandle err, GQuark domain, int code, string format, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_incomplete(string msg);

	[DllImport(Libraries.GLib)]
	internal static extern GQuark g_markup_error_quark();

	[DllImport(Libraries.GLib)]
	internal static extern string g_get_home_dir();

	[DllImport(Libraries.GLib)]
	internal static extern GTestSuiteHandle g_test_get_root();

	[DllImport(Libraries.GLib)]
	internal static extern bool g_unichar_isalpha(char c);

	[DllImport(Libraries.GLib)]
	internal static extern int g_test_rand_int();

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_rc_box_dup(int block_size, IntPtr mem_block);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_spawn_command_line_async(string command_line, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern int g_open(string filename, int flags, int mode);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_direct_hash(IntPtr v);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_dataset_id_get_data(IntPtr dataset_location, GQuark key_id);

	[DllImport(Libraries.GLib)]
	internal static extern int g_ascii_strcasecmp(string s1, string s2);

	[DllImport(Libraries.GLib)]
	internal static extern void g_slice_free_chain_with_offset(int block_size, IntPtr mem_chain, int next_offset);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_atomic_int_compare_and_exchange_full(ref int atomic, int oldval, int newval, out int preval);

	[DllImport(Libraries.GLib)]
	internal static extern string g_get_language_names();

	[DllImport(Libraries.GLib)]
	internal static extern GType g_variant_get_gtype();

	[DllImport(Libraries.GLib)]
	internal static extern bool g_markup_collect_attributes(string element_name, ref string attribute_names, ref string attribute_values, out GErrorHandle error, GMarkupCollectType first_type, string first_attr, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern GLogWriterOutput g_log_writer_syslog(GLogLevelFlags log_level, GLogField[] fields, int n_fields, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_trap_subprocess_with_envp(string test_path, string envp, ulong usec_timeout, GTestSubprocessFlags test_flags);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_timeout_add_once(uint interval, GSourceOnceFunc function, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern string g_intern_static_string(string @string);

	[DllImport(Libraries.GLib)]
	internal static extern int g_creat(string filename, int mode);

	[DllImport(Libraries.GLib)]
	internal static extern void g_log_writer_default_set_use_stderr(bool use_stderr);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_queue_destroy(GDestroyNotify destroy_func, IntPtr destroy_data);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_path_is_absolute(string file_name);

	[DllImport(Libraries.GLib)]
	internal static extern string g_format_size_for_display(int size);

	[DllImport(Libraries.GLib)]
	internal static extern double g_strtod(string nptr, out string endptr);

	[DllImport(Libraries.GLib)]
	internal static extern int g_sprintf(string @string, string format, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_int64_equal(IntPtr v1, IntPtr v2);

	[DllImport(Libraries.GLib)]
	internal static extern string g_format_size_full(ulong size, GFormatSizeFlags flags);

	[DllImport(Libraries.GLib)]
	internal static extern void g_mem_set_vtable(GMemVTableHandle vtable);

	[DllImport(Libraries.GLib)]
	internal static extern string g_ascii_strup(string str, int len);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_test_trap_has_passed();

	[DllImport(Libraries.GLib)]
	internal static extern void g_printerr(string format, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern string g_dpgettext2(string domain, string context, string msgid);

	[DllImport(Libraries.GLib)]
	internal static extern int g_test_run();

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_message(string format, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern GTestCaseHandle g_test_create_case(string test_name, int data_size, IntPtr test_data, GTestFixtureFunc data_setup, GTestFixtureFunc data_test, GTestFixtureFunc data_teardown);

	[DllImport(Libraries.GLib)]
	internal static extern GQuark g_quark_from_static_string(string @string);

	[DllImport(Libraries.GLib)]
	internal static extern void g_atomic_rc_box_release(IntPtr mem_block);

	[DllImport(Libraries.GLib)]
	internal static extern void g_bit_lock(ref int address, int lock_bit);

	[DllImport(Libraries.GLib)]
	internal static extern string[] g_strdupv(string[] str_array);

	[DllImport(Libraries.GLib)]
	internal static extern string g_compute_hmac_for_data(GChecksumType digest_type, string key, int key_len, string data, int length);

	[DllImport(Libraries.GLib)]
	internal static extern string g_get_application_name();

	[DllImport(Libraries.GLib)]
	internal static extern string g_get_user_runtime_dir();

	[DllImport(Libraries.GLib)]
	internal static extern string g_get_user_name();

	[DllImport(Libraries.GLib)]
	internal static extern int g_unichar_digit_value(char c);

	[DllImport(Libraries.GLib)]
	internal static extern string g_file_read_link(string filename, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern string g_format_size(ulong size);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_hostname_is_non_ascii(string hostname);

	[DllImport(Libraries.GLib)]
	internal static extern void g_dataset_id_set_data_full(IntPtr dataset_location, GQuark key_id, IntPtr data, GDestroyNotify destroy_func);

	[DllImport(Libraries.GLib)]
	internal static extern string g_filename_to_utf8(string opsysstring, int len, out int bytes_read, out int bytes_written, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern void g_assertion_message_cmpint(string domain, string file, int line, string func, string expr, ulong arg1, string cmp, ulong arg2, char numtype);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_unichar_compose(char a, char b, out string ch);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_unix_signal_add(int signum, GSourceFunc handler, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern string g_compute_hmac_for_bytes(GChecksumType digest_type, GBytesHandle key, GBytesHandle data);

	[DllImport(Libraries.GLib)]
	internal static extern GLogFunc g_log_set_default_handler(GLogFunc log_func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern int g_fsync(int fd);

	[DllImport(Libraries.GLib)]
	internal static extern string g_test_get_dir(GTestFileType file_type);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_atomic_rc_box_dup(int block_size, IntPtr mem_block);

	[DllImport(Libraries.GLib)]
	internal static extern string g_get_user_cache_dir();

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_try_malloc0(int n_bytes);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_atomic_int_xor(ref uint atomic, uint val);

	[DllImport(Libraries.GLib)]
	internal static extern string g_filename_to_uri(string filename, string hostname, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_ref_count_compare(ref int rc, int val);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_malloc0_n(int n_blocks, int n_block_bytes);

	[DllImport(Libraries.GLib)]
	internal static extern long g_get_monotonic_time();

	[DllImport(Libraries.GLib)]
	internal static extern void g_return_if_fail_warning(string log_domain, string pretty_function, string expression);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_io_add_watch(GIOChannelHandle channel, GIOCondition condition, GIOFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern string g_strcanon(string @string, string valid_chars, char substitutor);

	[DllImport(Libraries.GLib)]
	internal static extern string g_strdup(string str);

	[DllImport(Libraries.GLib)]
	internal static extern string g_base64_encode(string data, int len);

	[DllImport(Libraries.GLib)]
	internal static extern int g_test_rand_int_range(int begin, int end);

	[DllImport(Libraries.GLib)]
	internal static extern long[] g_slice_get_config_state(GSliceConfig ckey, long address, ref uint n_values);

	[DllImport(Libraries.GLib)]
	internal static extern void g_print(string format, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_unichar_isprint(char c);

	[DllImport(Libraries.GLib)]
	internal static extern string g_utf8_to_ucs4_fast(string str, long len, out long items_written);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_spawn_command_line_sync(string command_line, out string standard_output, out string standard_error, out int wait_status, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern int g_snprintf(string @string, ulong n, string format, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_get_filename_charsets(out string[] filename_charsets);

	[DllImport(Libraries.GLib)]
	internal static extern double g_test_timer_elapsed();

	[DllImport(Libraries.GLib)]
	internal static extern int g_random_int_range(int begin, int end);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_shell_parse_argv(string command_line, out int argcp, out string[] argvp, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_spawn_async_with_pipes_and_fds(string working_directory, string argv, string envp, GSpawnFlags flags, GSpawnChildSetupFunc child_setup, IntPtr user_data, int stdin_fd, int stdout_fd, int stderr_fd, int[] source_fds, int[] target_fds, int n_fds, out GPid child_pid_out, out int stdin_pipe_out, out int stdout_pipe_out, out int stderr_pipe_out, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern char g_ascii_toupper(char c);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_str_match_string(string search_term, string potential_hit, bool accept_alternates);

	[DllImport(Libraries.GLib)]
	internal static extern int g_chdir(string path);

	[DllImport(Libraries.GLib)]
	internal static extern int g_ascii_digit_value(char c);

	[DllImport(Libraries.GLib)]
	internal static extern string g_ascii_formatd(string buffer, int buf_len, string format, double d);

	[DllImport(Libraries.GLib)]
	internal static extern void g_atexit(GVoidFunc func);

	[DllImport(Libraries.GLib)]
	internal static extern void g_get_current_time(GTimeValHandle result);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_strv_equal(string strv1, string strv2);

	[DllImport(Libraries.GLib)]
	internal static extern string g_utf8_find_next_char(string p, string end);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_child_watch_add(GPid pid, GChildWatchFunc function, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern string g_utf8_to_ucs4(string str, long len, out long items_read, out long items_written, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_timeout_add_seconds_full(int priority, uint interval, GSourceFunc function, IntPtr data, GDestroyNotify notify);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_skip(string msg);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_slice_alloc0(int block_size);

	[DllImport(Libraries.GLib)]
	internal static extern char g_unichar_totitle(char c);

	[DllImport(Libraries.GLib)]
	internal static extern void g_pointer_bit_unlock_and_set(IntPtr address, uint lock_bit, IntPtr ptr, nuint preserve_mask);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_get_console_charset(out string charset);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_timeout_add_full(int priority, uint interval, GSourceFunc function, IntPtr data, GDestroyNotify notify);

	[DllImport(Libraries.GLib)]
	internal static extern ulong g_ascii_strtoull(string nptr, out string endptr, uint @base);

	[DllImport(Libraries.GLib)]
	internal static extern string g_canonicalize_filename(string filename, string relative_to);

	[DllImport(Libraries.GLib)]
	internal static extern GSourceHandle g_unix_fd_source_new(int fd, GIOCondition condition);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_try_realloc(IntPtr mem, int n_bytes);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_realloc_n(IntPtr mem, int n_blocks, int n_block_bytes);

	[DllImport(Libraries.GLib)]
	internal static extern GSourceHandle g_io_create_watch(GIOChannelHandle channel, GIOCondition condition);

	[DllImport(Libraries.GLib)]
	internal static extern void g_slice_set_config(GSliceConfig ckey, long value);

	[DllImport(Libraries.GLib)]
	internal static extern void g_unsetenv(string variable);

	[DllImport(Libraries.GLib)]
	internal static extern string g_filename_from_uri(string uri, out string hostname, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_unichar_iswide(char c);

	[DllImport(Libraries.GLib)]
	internal static extern void g_bit_unlock(ref int address, int lock_bit);

	[DllImport(Libraries.GLib)]
	internal static extern string g_strip_context(string msgid, string msgval);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_bug(string bug_uri_snippet);

	[DllImport(Libraries.GLib)]
	internal static extern string g_markup_printf_escaped(string format, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_timeout_add_seconds(uint interval, GSourceFunc function, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_unichar_isdigit(char c);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_ascii_string_to_signed(string str, uint @base, long min, long max, out long out_num, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern void g_set_error_literal(out GErrorHandle err, GQuark domain, int code, string message);

	[DllImport(Libraries.GLib)]
	internal static extern void g_reload_user_special_dirs_cache();

	[DllImport(Libraries.GLib)]
	internal static extern bool g_unichar_iscntrl(char c);

	[DllImport(Libraries.GLib)]
	internal static extern string g_test_get_path();

	[DllImport(Libraries.GLib)]
	internal static extern bool g_setenv(string variable, string value, bool overwrite);

	[DllImport(Libraries.GLib)]
	internal static extern void g_datalist_unset_flags(ref GDataHandle datalist, uint flags);

	[DllImport(Libraries.GLib)]
	internal static extern string g_strnfill(int length, char fill_char);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_ref_count_dec(ref int rc);

	[DllImport(Libraries.GLib)]
	internal static extern void g_aligned_free_sized(IntPtr mem, int alignment, int size);

	[DllImport(Libraries.GLib)]
	internal static extern void g_aligned_free(IntPtr mem);

	[DllImport(Libraries.GLib)]
	internal static extern string g_utf8_strrchr(string p, int len, char c);

	[DllImport(Libraries.GLib)]
	internal static extern GQuark g_convert_error_quark();

	[DllImport(Libraries.GLib)]
	internal static extern GLogWriterOutput g_log_writer_default(GLogLevelFlags log_level, GLogField[] fields, int n_fields, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern int g_strlcat(string dest, string src, int dest_size);

	[DllImport(Libraries.GLib)]
	internal static extern int g_unichar_combining_class(char uc);

	[DllImport(Libraries.GLib)]
	internal static extern string g_strdown(string @string);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_io_add_watch_full(GIOChannelHandle channel, int priority, GIOCondition condition, GIOFunc func, IntPtr user_data, GDestroyNotify notify);

	[DllImport(Libraries.GLib)]
	internal static extern string g_strconcat(string string1, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern string g_ref_string_new_intern(string str);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_timeout_add(uint interval, GSourceFunc function, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_test_failed();

	[DllImport(Libraries.GLib)]
	internal static extern string g_strup(string @string);

	[DllImport(Libraries.GLib)]
	internal static extern int g_rmdir(string filename);

	[DllImport(Libraries.GLib)]
	internal static extern int g_fprintf(IntPtr file, string format, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern int g_file_open_tmp(string tmpl, out string name_used, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern GQuark g_unix_error_quark();

	[DllImport(Libraries.GLib)]
	internal static extern void g_atomic_ref_count_inc(ref int arc);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_int_hash(IntPtr v);

	[DllImport(Libraries.GLib)]
	internal static extern void g_assertion_message_cmpnum(string domain, string file, int line, string func, string expr, decimal arg1, string cmp, decimal arg2, char numtype);

	[DllImport(Libraries.GLib)]
	internal static extern int g_mkstemp_full(string tmpl, int flags, int mode);

	[DllImport(Libraries.GLib)]
	internal static extern void g_strfreev(string[] str_array);

	[DllImport(Libraries.GLib)]
	internal static extern GUnicodeBreakType g_unichar_break_type(char c);

	[DllImport(Libraries.GLib)]
	internal static extern string g_ref_string_acquire(string str);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_rc_box_alloc0(int block_size);

	[DllImport(Libraries.GLib)]
	internal static extern string g_environ_getenv(string[] envp, string variable);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_add_func(string testpath, GTestFunc test_func);

	[DllImport(Libraries.GLib)]
	internal static extern string g_get_current_dir();

	[DllImport(Libraries.GLib)]
	internal static extern void g_prefix_error(out GErrorHandle err, string format, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern int g_base64_decode_step(string @in, int len, out string @out, ref int state, ref uint save);

	[DllImport(Libraries.GLib)]
	internal static extern void g_clear_slist(ref GSListHandle slist_ptr, GDestroyNotify destroy);

	[DllImport(Libraries.GLib)]
	internal static extern nint g_atomic_pointer_add(IntPtr atomic, int val);

	[DllImport(Libraries.GLib)]
	internal static extern string g_get_user_config_dir();

	[DllImport(Libraries.GLib)]
	internal static extern void g_qsort_with_data(IntPtr pbase, int total_elems, int size, GCompareDataFunc compare_func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern char g_utf8_get_char(string p);

	[DllImport(Libraries.GLib)]
	internal static extern void g_datalist_init(ref GDataHandle datalist);

	[DllImport(Libraries.GLib)]
	internal static extern string g_utf8_strup(string str, int len);

	[DllImport(Libraries.GLib)]
	internal static extern GSourceHandle g_main_current_source();

	[DllImport(Libraries.GLib)]
	internal static extern string g_uuid_string_random();

	[DllImport(Libraries.GLib)]
	internal static extern int g_printf_string_upper_bound(string format, IntPtr args);

	[DllImport(Libraries.GLib)]
	internal static extern void g_clear_pointer(ref IntPtr pp, GDestroyNotify destroy);

	[DllImport(Libraries.GLib)]
	internal static extern void g_clear_error(out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_datalist_get_flags(ref GDataHandle datalist);

	[DllImport(Libraries.GLib)]
	internal static extern void g_ref_count_inc(ref int rc);

	[DllImport(Libraries.GLib)]
	internal static extern string g_utf8_truncate_middle(string @string, int truncate_length);

	[DllImport(Libraries.GLib)]
	internal static extern char g_ascii_tolower(char c);

	[DllImport(Libraries.GLib)]
	internal static extern string[] g_strsplit(string @string, string delimiter, int max_tokens);

	[DllImport(Libraries.GLib)]
	internal static extern GLogLevelFlags g_log_set_always_fatal(GLogLevelFlags fatal_mask);

	[DllImport(Libraries.GLib)]
	internal static extern int g_mkstemp(string tmpl);

	[DllImport(Libraries.GLib)]
	internal static extern long g_utf8_pointer_to_offset(string str, string pos);

	[DllImport(Libraries.GLib)]
	internal static extern int g_base64_encode_close(bool break_lines, out string @out, ref int state, ref int save);

	[DllImport(Libraries.GLib)]
	internal static extern char g_unichar_toupper(char c);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_spawn_async(string working_directory, string[] argv, string[] envp, GSpawnFlags flags, GSpawnChildSetupFunc child_setup, IntPtr user_data, out GPid child_pid, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_summary(string summary);

	[DllImport(Libraries.GLib)]
	internal static extern string g_get_codeset();

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_rc_box_alloc(int block_size);

	[DllImport(Libraries.GLib)]
	internal static extern void g_assertion_message(string domain, string file, int line, string func, string message);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_try_malloc(int n_bytes);

	[DllImport(Libraries.GLib)]
	internal static extern GSourceHandle g_child_watch_source_new(GPid pid);

	[DllImport(Libraries.GLib)]
	internal static extern void g_log_default_handler(string log_domain, GLogLevelFlags log_level, string message, IntPtr unused_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_add_data_func(string testpath, IntPtr test_data, GTestDataFunc test_func);

	[DllImport(Libraries.GLib)]
	internal static extern GQuark g_quark_try_string(string @string);

	[DllImport(Libraries.GLib)]
	internal static extern string g_strerror(int errnum);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_atomic_rc_box_acquire(IntPtr mem_block);

	[DllImport(Libraries.GLib)]
	internal static extern string g_ascii_strdown(string str, int len);

	[DllImport(Libraries.GLib)]
	internal static extern int g_vasprintf(out string @string, string format, IntPtr args);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_atomic_int_or(ref uint atomic, uint val);

	[DllImport(Libraries.GLib)]
	internal static extern string g_getenv(string variable);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_unichar_isgraph(char c);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_ascii_string_to_unsigned(string str, uint @base, ulong min, ulong max, out ulong out_num, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern void g_atomic_int_set(ref int atomic, int newval);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_try_realloc_n(IntPtr mem, int n_blocks, int n_block_bytes);

	[DllImport(Libraries.GLib)]
	internal static extern void g_datalist_set_flags(ref GDataHandle datalist, uint flags);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_random_int();

	[DllImport(Libraries.GLib)]
	internal static extern uint g_idle_add_once(GSourceOnceFunc function, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_spaced_primes_closest(uint num);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_expect_message(string log_domain, GLogLevelFlags log_level, string pattern);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_unix_open_pipe(int[] fds, int flags, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern string g_strjoin(string separator, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern void g_logv(string log_domain, GLogLevelFlags log_level, string format, IntPtr args);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_unichar_isxdigit(char c);

	[DllImport(Libraries.GLib)]
	internal static extern string g_base64_decode(string text, out int out_len);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_slice_copy(int block_size, IntPtr mem_block);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_bit_trylock(ref int address, int lock_bit);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_spawn_check_exit_status(int wait_status, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_unix_fd_add(int fd, GIOCondition condition, GUnixFDSourceFunc function, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_unichar_isupper(char c);

	[DllImport(Libraries.GLib)]
	internal static extern void g_assertion_message_expr(string domain, string file, int line, string func, string expr);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_add_data_func_full(string testpath, IntPtr test_data, GTestDataFunc test_func, GDestroyNotify data_free_func);

	[DllImport(Libraries.GLib)]
	internal static extern string g_strcompress(string source);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_atomic_rc_box_alloc(int block_size);

	[DllImport(Libraries.GLib)]
	internal static extern void g_random_set_seed(uint seed);

	[DllImport(Libraries.GLib)]
	internal static extern string g_dcgettext(string domain, string msgid, int category);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_child_watch_add_full(int priority, GPid pid, GChildWatchFunc function, IntPtr data, GDestroyNotify notify);

	[DllImport(Libraries.GLib)]
	internal static extern int g_base64_encode_step(string @in, int len, bool break_lines, out string @out, ref int state, ref int save);

	[DllImport(Libraries.GLib)]
	internal static extern string g_test_build_filename(GTestFileType file_type, string first_path, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern void g_datalist_id_remove_multiple(ref GDataHandle datalist, GQuark[] keys, int n_keys);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_disable_crash_reporting();

	[DllImport(Libraries.GLib)]
	internal static extern bool g_unichar_isspace(char c);

	[DllImport(Libraries.GLib)]
	internal static extern string g_utf8_strreverse(string str, int len);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_strv_length(string[] str_array);

	[DllImport(Libraries.GLib)]
	internal static extern int g_mkdir(string filename, int mode);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_str_hash(IntPtr v);

	[DllImport(Libraries.GLib)]
	internal static extern GQuark g_file_error_quark();

	[DllImport(Libraries.GLib)]
	internal static extern string g_strjoinv(string separator, string[] str_array);

	[DllImport(Libraries.GLib)]
	internal static extern string g_build_filename(string first_element, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_unichar_iswide_cjk(char c);

	[DllImport(Libraries.GLib)]
	internal static extern void g_set_prgname(string prgname);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_try_malloc0_n(int n_blocks, int n_block_bytes);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_log_set_fatal_handler(GTestLogFatalFunc log_func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_get_charset(out string charset);

	[DllImport(Libraries.GLib)]
	internal static extern string g_dpgettext(string domain, string msgctxtid, int msgidoffset);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_unichar_iszerowidth(char c);

	[DllImport(Libraries.GLib)]
	internal static extern GQuark g_shell_error_quark();

	[DllImport(Libraries.GLib)]
	internal static extern string g_filename_display_name(string filename);

	[DllImport(Libraries.GLib)]
	internal static extern char g_unichar_tolower(char c);

	[DllImport(Libraries.GLib)]
	internal static extern string g_log_writer_format_fields(GLogLevelFlags log_level, GLogField[] fields, int n_fields, bool use_color);

	[DllImport(Libraries.GLib)]
	internal static extern nuint g_atomic_pointer_xor(IntPtr atomic, int val);

	[DllImport(Libraries.GLib)]
	internal static extern string g_ucs4_to_utf16(string str, long len, out long items_read, out long items_written, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern void g_datalist_clear(ref GDataHandle datalist);

	[DllImport(Libraries.GLib)]
	internal static extern string g_path_skip_root(string file_name);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_str_is_ascii(string str);

	[DllImport(Libraries.GLib)]
	internal static extern string g_test_get_filename(GTestFileType file_type, string first_path, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern string[] g_environ_setenv(string[] envp, string variable, string value, bool overwrite);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_str_equal(IntPtr v1, IntPtr v2);

	[DllImport(Libraries.GLib)]
	internal static extern string g_markup_vprintf_escaped(string format, IntPtr args);

	[DllImport(Libraries.GLib)]
	internal static extern int g_chmod(string filename, int mode);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_try_malloc_n(int n_blocks, int n_block_bytes);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_unichar_validate(char ch);

	[DllImport(Libraries.GLib)]
	internal static extern void g_free(IntPtr mem);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_aligned_alloc(int n_blocks, int n_block_bytes, int alignment);

	[DllImport(Libraries.GLib)]
	internal static extern int g_closefrom(int lowfd);

	[DllImport(Libraries.GLib)]
	internal static extern string g_strrstr_len(string haystack, int haystack_len, string needle);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_direct_equal(IntPtr v1, IntPtr v2);

	[DllImport(Libraries.GLib)]
	internal static extern string g_utf8_strdown(string str, int len);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_str_has_suffix(string str, string suffix);

	[DllImport(Libraries.GLib)]
	internal static extern int g_unlink(string filename);

	[DllImport(Libraries.GLib)]
	internal static extern string g_ref_string_new(string str);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_pointer_bit_trylock(IntPtr address, int lock_bit);

	[DllImport(Libraries.GLib)]
	internal static extern GSourceHandle g_timeout_source_new_seconds(uint interval);

	[DllImport(Libraries.GLib)]
	internal static extern GPrintFunc g_set_printerr_handler(GPrintFunc func);

	[DllImport(Libraries.GLib)]
	internal static extern string g_utf8_normalize(string str, int len, GNormalizeMode mode);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_datalist_id_replace_data(ref GDataHandle datalist, GQuark key_id, IntPtr oldval, IntPtr newval, GDestroyNotify destroy, out GDestroyNotify old_destroy);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_unichar_ispunct(char c);

	[DllImport(Libraries.GLib)]
	internal static extern GQuark g_spawn_error_quark();

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_malloc(int n_bytes);

	[DllImport(Libraries.GLib)]
	internal static extern void g_log(string log_domain, GLogLevelFlags log_level, string format, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_fail_printf(string format, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern string g_strescape(string source, string exceptions);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_slice_alloc(int block_size);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_file_test(string filename, GFileTest test);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_log_writer_is_journald(int output_fd);

	[DllImport(Libraries.GLib)]
	internal static extern string g_utf16_to_utf8(string str, long len, out long items_read, out long items_written, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern double g_ascii_strtod(string nptr, out string endptr);

	[DllImport(Libraries.GLib)]
	internal static extern string g_build_path(string separator, string first_element, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern void g_assertion_message_cmpstrv(string domain, string file, int line, string func, string expr, string arg1, string arg2, int first_wrong_idx);

	[DllImport(Libraries.GLib)]
	internal static extern string g_shell_unquote(string quoted_string, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_file_set_contents(string filename, string contents, int length, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern void g_on_error_stack_trace(string prg_name);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_malloc0(int n_bytes);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_pattern_match_string(GPatternSpecHandle pspec, string @string);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_pattern_match_simple(string pattern, string @string);

	[DllImport(Libraries.GLib)]
	internal static extern string g_get_host_name();

	[DllImport(Libraries.GLib)]
	internal static extern int g_utime(string filename, IntPtr utb);

	[DllImport(Libraries.GLib)]
	internal static extern GSourceHandle g_idle_source_new();

	[DllImport(Libraries.GLib)]
	internal static extern uint g_idle_add_full(int priority, GSourceFunc function, IntPtr data, GDestroyNotify notify);

	[DllImport(Libraries.GLib)]
	internal static extern void g_unicode_canonical_ordering(string @string, int len);

	[DllImport(Libraries.GLib)]
	internal static extern string g_shell_quote(string unquoted_string);

	[DllImport(Libraries.GLib)]
	internal static extern string g_utf8_to_utf16(string str, long len, out long items_read, out long items_written, out GErrorHandle error);

}
