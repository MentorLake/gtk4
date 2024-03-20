using Microsoft.Win32.SafeHandles;

namespace MentorLake.Gtk4.GLib;
public class GLibSafeHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	public GLibSafeHandle() : base(false)
	{
	}

	public GLibSafeHandle(bool ownsHandle) : base(ownsHandle)
	{
	}

	protected override bool ReleaseHandle() => throw new NotImplementedException();
}

public class GHookHandle : GLibSafeHandle
{
}

public class GThreadFunctionsHandle : GLibSafeHandle
{
}

public class GDataHandle : GLibSafeHandle
{
}

public class GNodeHandle : GLibSafeHandle
{
	public static GNodeHandle New(IntPtr data)
	{
		return GNodeExterns.g_node_new(data);
	}
}

public class GMatchInfoHandle : GLibSafeHandle
{
}

public class GRWLockHandle : GLibSafeHandle
{
}

public class GLogFieldHandle : GLibSafeHandle
{
}

public class GPollFDHandle : GLibSafeHandle
{
}

public class GTrashStackHandle : GLibSafeHandle
{
}

public class GMutexHandle : GLibSafeHandle
{
	public static GMutexHandle New()
	{
		return GMutexExterns.g_mutex_new();
	}
}

public class GThreadHandle : GLibSafeHandle
{
	public static GThreadHandle New(string name, GThreadFunc func, IntPtr data)
	{
		return GThreadExterns.g_thread_new(name, func, data);
	}

	public static GThreadHandle TryNew(string name, GThreadFunc func, IntPtr data, out GErrorHandle error)
	{
		return GThreadExterns.g_thread_try_new(name, func, data, out error);
	}
}

public class GTokenValueHandle : GLibSafeHandle
{
}

public class GOptionContextHandle : GLibSafeHandle
{
	public static GOptionContextHandle New(string parameter_string)
	{
		return GOptionContextExterns.g_option_context_new(parameter_string);
	}
}

public class GHookListHandle : GLibSafeHandle
{
}

public class GSourceCallbackFuncsHandle : GLibSafeHandle
{
}

public class GAllocatorHandle : GLibSafeHandle
{
	public static GAllocatorHandle New(string name, uint n_preallocs)
	{
		return GAllocatorExterns.g_allocator_new(name, n_preallocs);
	}
}

public class GBytesHandle : GLibSafeHandle
{
	public static GBytesHandle New(IntPtr data, nuint size)
	{
		return GBytesExterns.g_bytes_new(data, size);
	}

	public static GBytesHandle NewTake(IntPtr data, nuint size)
	{
		return GBytesExterns.g_bytes_new_take(data, size);
	}

	public static GBytesHandle NewStatic(IntPtr data, nuint size)
	{
		return GBytesExterns.g_bytes_new_static(data, size);
	}

	public static GBytesHandle NewWithFreeFunc(IntPtr data, nuint size, GDestroyNotify free_func, IntPtr user_data)
	{
		return GBytesExterns.g_bytes_new_with_free_func(data, size, free_func, user_data);
	}
}

public class GStringHandle : GLibSafeHandle
{
	public static GStringHandle New(string init)
	{
		return GStringExterns.g_string_new(init);
	}

	public static GStringHandle NewLen(string init, nint len)
	{
		return GStringExterns.g_string_new_len(init, len);
	}

	public static GStringHandle SizedNew(nuint dfl_size)
	{
		return GStringExterns.g_string_sized_new(dfl_size);
	}
}

public class GMemVTableHandle : GLibSafeHandle
{
}

public class GStrvBuilderHandle : GLibSafeHandle
{
	public static GStrvBuilderHandle New()
	{
		return GStrvBuilderExterns.g_strv_builder_new();
	}
}

public class GVariantDictHandle : GLibSafeHandle
{
}

public class GTestSuiteHandle : GLibSafeHandle
{
}

public class GOnceHandle : GLibSafeHandle
{
}

public class GIOFuncsHandle : GLibSafeHandle
{
}

public class GTreeHandle : GLibSafeHandle
{
	public static GTreeHandle New(GCompareFunc key_compare_func)
	{
		return GTreeExterns.g_tree_new(key_compare_func);
	}

	public static GTreeHandle NewWithData(GCompareDataFunc key_compare_func, IntPtr key_compare_data)
	{
		return GTreeExterns.g_tree_new_with_data(key_compare_func, key_compare_data);
	}

	public static GTreeHandle NewFull(GCompareDataFunc key_compare_func, IntPtr key_compare_data, GDestroyNotify key_destroy_func, GDestroyNotify value_destroy_func)
	{
		return GTreeExterns.g_tree_new_full(key_compare_func, key_compare_data, key_destroy_func, value_destroy_func);
	}
}

public class GPtrArrayHandle : GLibSafeHandle
{
	public static GPtrArrayHandle New()
	{
		return GPtrArrayExterns.g_ptr_array_new();
	}

	public static GPtrArrayHandle NewWithFreeFunc(GDestroyNotify element_free_func)
	{
		return GPtrArrayExterns.g_ptr_array_new_with_free_func(element_free_func);
	}

	public static GPtrArrayHandle SizedNew(uint reserved_size)
	{
		return GPtrArrayExterns.g_ptr_array_sized_new(reserved_size);
	}

	public static GPtrArrayHandle NewFull(uint reserved_size, GDestroyNotify element_free_func)
	{
		return GPtrArrayExterns.g_ptr_array_new_full(reserved_size, element_free_func);
	}
}

public class GErrorHandle : GLibSafeHandle
{
	public static GErrorHandle New(GQuark domain, int code, string format, IntPtr @__arglist)
	{
		return GErrorExterns.g_error_new(domain, code, format, @__arglist);
	}

	public static GErrorHandle NewLiteral(GQuark domain, int code, string message)
	{
		return GErrorExterns.g_error_new_literal(domain, code, message);
	}

	public static GErrorHandle NewValist(GQuark domain, int code, string format, IntPtr @__arglist)
	{
		return GErrorExterns.g_error_new_valist(domain, code, format, @__arglist);
	}
}

public class GChecksumHandle : GLibSafeHandle
{
	public static GChecksumHandle New(GChecksumType checksum_type)
	{
		return GChecksumExterns.g_checksum_new(checksum_type);
	}
}

public class GCacheHandle : GLibSafeHandle
{
	public static GCacheHandle New(GCacheNewFunc value_new_func, GCacheDestroyFunc value_destroy_func, GCacheDupFunc key_dup_func, GCacheDestroyFunc key_destroy_func, GHashFunc hash_key_func, GHashFunc hash_value_func, GEqualFunc key_equal_func)
	{
		return GCacheExterns.g_cache_new(value_new_func, value_destroy_func, key_dup_func, key_destroy_func, hash_key_func, hash_value_func, key_equal_func);
	}
}

public class GSListHandle : GLibSafeHandle
{
}

public class GHashTableIterHandle : GLibSafeHandle
{
}

public class GPrivateHandle : GLibSafeHandle
{
	public static GPrivateHandle New(GDestroyNotify notify)
	{
		return GPrivateExterns.g_private_new(notify);
	}
}

public class GArrayHandle : GLibSafeHandle
{
	public static GArrayHandle New(int zero_terminated, int clear_, uint element_size)
	{
		return GArrayExterns.g_array_new(zero_terminated, clear_, element_size);
	}

	public static GArrayHandle SizedNew(int zero_terminated, int clear_, uint element_size, uint reserved_size)
	{
		return GArrayExterns.g_array_sized_new(zero_terminated, clear_, element_size, reserved_size);
	}
}

public class GVariantTypeHandle : GLibSafeHandle
{
	public static GVariantTypeHandle New(string type_string)
	{
		return GVariantTypeExterns.g_variant_type_new(type_string);
	}
}

public class GSourcePrivateHandle : GLibSafeHandle
{
}

public class GListHandle : GLibSafeHandle
{
}

public class GCompletionHandle : GLibSafeHandle
{
	public static GCompletionHandle New(GCompletionFunc func)
	{
		return GCompletionExterns.g_completion_new(func);
	}
}

public class GDirHandle : GLibSafeHandle
{
}

public class GTestCaseHandle : GLibSafeHandle
{
}

public class GRecMutexHandle : GLibSafeHandle
{
}

public class GVariantBuilderHandle : GLibSafeHandle
{
}

public class GHashTableHandle : GLibSafeHandle
{
	public static GHashTableHandle New(GHashFunc hash_func, GEqualFunc key_equal_func)
	{
		return GHashTableExterns.g_hash_table_new(hash_func, key_equal_func);
	}

	public static GHashTableHandle NewFull(GHashFunc hash_func, GEqualFunc key_equal_func, GDestroyNotify key_destroy_func, GDestroyNotify value_destroy_func)
	{
		return GHashTableExterns.g_hash_table_new_full(hash_func, key_equal_func, key_destroy_func, value_destroy_func);
	}
}

public class GRandHandle : GLibSafeHandle
{
	public static GRandHandle NewWithSeed(uint seed)
	{
		return GRandExterns.g_rand_new_with_seed(seed);
	}

	public static GRandHandle NewWithSeedArray(uint[] seed, uint seed_length)
	{
		return GRandExterns.g_rand_new_with_seed_array(seed, seed_length);
	}

	public static GRandHandle New()
	{
		return GRandExterns.g_rand_new();
	}
}

public class GBookmarkFileHandle : GLibSafeHandle
{
	public static GBookmarkFileHandle New()
	{
		return GBookmarkFileExterns.g_bookmark_file_new();
	}
}

public class GStaticRecMutexHandle : GLibSafeHandle
{
}

public class GTuplesHandle : GLibSafeHandle
{
}

public class GDebugKeyHandle : GLibSafeHandle
{
}

public class GTimeZoneHandle : GLibSafeHandle
{
	public static GTimeZoneHandle New(string identifier)
	{
		return GTimeZoneExterns.g_time_zone_new(identifier);
	}

	public static GTimeZoneHandle NewIdentifier(string identifier)
	{
		return GTimeZoneExterns.g_time_zone_new_identifier(identifier);
	}

	public static GTimeZoneHandle NewUtc()
	{
		return GTimeZoneExterns.g_time_zone_new_utc();
	}

	public static GTimeZoneHandle NewLocal()
	{
		return GTimeZoneExterns.g_time_zone_new_local();
	}

	public static GTimeZoneHandle NewOffset(int seconds)
	{
		return GTimeZoneExterns.g_time_zone_new_offset(seconds);
	}
}

public class GMarkupParseContextHandle : GLibSafeHandle
{
	public static GMarkupParseContextHandle New(GMarkupParserHandle parser, GMarkupParseFlags flags, IntPtr user_data, GDestroyNotify user_data_dnotify)
	{
		return GMarkupParseContextExterns.g_markup_parse_context_new(parser, flags, user_data, user_data_dnotify);
	}
}

public class GDateHandle : GLibSafeHandle
{
	public static GDateHandle New()
	{
		return GDateExterns.g_date_new();
	}

	public static GDateHandle NewDmy(GDateDay day, GDateMonth month, GDateYear year)
	{
		return GDateExterns.g_date_new_dmy(day, month, year);
	}

	public static GDateHandle NewJulian(uint julian_day)
	{
		return GDateExterns.g_date_new_julian(julian_day);
	}
}

public class GFloatIEEE754Handle : GLibSafeHandle
{
}

public class GStaticMutexHandle : GLibSafeHandle
{
}

public class GIOChannelHandle : GLibSafeHandle
{
	public static GIOChannelHandle GIoChannelNewFile(string filename, string mode, out GErrorHandle error)
	{
		return GIOChannelExterns.g_io_channel_new_file(filename, mode, out error);
	}

	public static GIOChannelHandle GIoChannelUnixNew(int fd)
	{
		return GIOChannelExterns.g_io_channel_unix_new(fd);
	}
}

public class GIConvHandle : GLibSafeHandle
{
}

public class GAsyncQueueHandle : GLibSafeHandle
{
	public static GAsyncQueueHandle New()
	{
		return GAsyncQueueExterns.g_async_queue_new();
	}

	public static GAsyncQueueHandle NewFull(GDestroyNotify item_free_func)
	{
		return GAsyncQueueExterns.g_async_queue_new_full(item_free_func);
	}
}

public class GKeyFileHandle : GLibSafeHandle
{
	public static GKeyFileHandle New()
	{
		return GKeyFileExterns.g_key_file_new();
	}
}

public class GMainContextHandle : GLibSafeHandle
{
	public static GMainContextHandle New()
	{
		return GMainContextExterns.g_main_context_new();
	}

	public static GMainContextHandle NewWithFlags(GMainContextFlags flags)
	{
		return GMainContextExterns.g_main_context_new_with_flags(flags);
	}
}

public class GMarkupParserHandle : GLibSafeHandle
{
}

public class GTimeValHandle : GLibSafeHandle
{
}

public class GMemChunkHandle : GLibSafeHandle
{
	public static GMemChunkHandle New(string name, int atom_size, nuint area_size, int type)
	{
		return GMemChunkExterns.g_mem_chunk_new(name, atom_size, area_size, type);
	}
}

public class GTreeNodeHandle : GLibSafeHandle
{
}

public class GMappedFileHandle : GLibSafeHandle
{
	public static GMappedFileHandle New(string filename, int writable, out GErrorHandle error)
	{
		return GMappedFileExterns.g_mapped_file_new(filename, writable, out error);
	}

	public static GMappedFileHandle NewFromFd(int fd, int writable, out GErrorHandle error)
	{
		return GMappedFileExterns.g_mapped_file_new_from_fd(fd, writable, out error);
	}
}

public class GPatternSpecHandle : GLibSafeHandle
{
	public static GPatternSpecHandle New(string pattern)
	{
		return GPatternSpecExterns.g_pattern_spec_new(pattern);
	}
}

public class GSequenceNodeHandle : GLibSafeHandle
{
}

public class GSequenceHandle : GLibSafeHandle
{
	public static GSequenceHandle New(GDestroyNotify data_destroy)
	{
		return GSequenceExterns.g_sequence_new(data_destroy);
	}
}

public class GSourceFuncsHandle : GLibSafeHandle
{
}

public class GTestConfigHandle : GLibSafeHandle
{
}

public class GDateTimeHandle : GLibSafeHandle
{
	public static GDateTimeHandle NewNowLocal()
	{
		return GDateTimeExterns.g_date_time_new_now_local();
	}

	public static GDateTimeHandle NewNowUtc()
	{
		return GDateTimeExterns.g_date_time_new_now_utc();
	}

	public static GDateTimeHandle NewFromUnixLocal(nint t)
	{
		return GDateTimeExterns.g_date_time_new_from_unix_local(t);
	}

	public static GDateTimeHandle NewFromUnixUtc(nint t)
	{
		return GDateTimeExterns.g_date_time_new_from_unix_utc(t);
	}

	public static GDateTimeHandle NewFromTimevalLocal(GTimeValHandle tv)
	{
		return GDateTimeExterns.g_date_time_new_from_timeval_local(tv);
	}

	public static GDateTimeHandle NewFromTimevalUtc(GTimeValHandle tv)
	{
		return GDateTimeExterns.g_date_time_new_from_timeval_utc(tv);
	}

	public static GDateTimeHandle NewFromIso8601(string text, GTimeZoneHandle default_tz)
	{
		return GDateTimeExterns.g_date_time_new_from_iso8601(text, default_tz);
	}

	public static GDateTimeHandle NewLocal(int year, int month, int day, int hour, int minute, double seconds)
	{
		return GDateTimeExterns.g_date_time_new_local(year, month, day, hour, minute, seconds);
	}

	public static GDateTimeHandle NewUtc(int year, int month, int day, int hour, int minute, double seconds)
	{
		return GDateTimeExterns.g_date_time_new_utc(year, month, day, hour, minute, seconds);
	}
}

public class GSourceHandle : GLibSafeHandle
{
	public static GSourceHandle New(GSourceFuncsHandle source_funcs, uint struct_size)
	{
		return GSourceExterns.g_source_new(source_funcs, struct_size);
	}

	public static GSourceHandle GIdleSourceNew()
	{
		return GSourceExterns.g_idle_source_new();
	}

	public static GSourceHandle GChildWatchSourceNew(GPid pid)
	{
		return GSourceExterns.g_child_watch_source_new(pid);
	}

	public static GSourceHandle GTimeoutSourceNew(uint interval)
	{
		return GSourceExterns.g_timeout_source_new(interval);
	}

	public static GSourceHandle GTimeoutSourceNewSeconds(uint interval)
	{
		return GSourceExterns.g_timeout_source_new_seconds(interval);
	}
}

public class GTestLogBufferHandle : GLibSafeHandle
{
	public static GTestLogBufferHandle New()
	{
		return GTestLogBufferExterns.g_test_log_buffer_new();
	}
}

public class GRegexHandle : GLibSafeHandle
{
	public static GRegexHandle New(string pattern, GRegexCompileFlags compile_options, GRegexMatchFlags match_options, out GErrorHandle error)
	{
		return GRegexExterns.g_regex_new(pattern, compile_options, match_options, out error);
	}
}

public class GStringChunkHandle : GLibSafeHandle
{
	public static GStringChunkHandle New(nuint size)
	{
		return GStringChunkExterns.g_string_chunk_new(size);
	}
}

public class GUriParamsIterHandle : GLibSafeHandle
{
}

public class GStaticPrivateHandle : GLibSafeHandle
{
}

public class GStaticRWLockHandle : GLibSafeHandle
{
}

public class GThreadPoolHandle : GLibSafeHandle
{
	public static GThreadPoolHandle New(IntPtr func, IntPtr user_data, int max_threads, int exclusive, out GErrorHandle error)
	{
		return GThreadPoolExterns.g_thread_pool_new(func, user_data, max_threads, exclusive, out error);
	}

	public static GThreadPoolHandle NewFull(IntPtr func, IntPtr user_data, GDestroyNotify item_free_func, int max_threads, int exclusive, out GErrorHandle error)
	{
		return GThreadPoolExterns.g_thread_pool_new_full(func, user_data, item_free_func, max_threads, exclusive, out error);
	}
}

public class GQueueHandle : GLibSafeHandle
{
	public static GQueueHandle New()
	{
		return GQueueExterns.g_queue_new();
	}
}

public class GOptionEntryHandle : GLibSafeHandle
{
}

public class GVariantIterHandle : GLibSafeHandle
{
}

public class GOptionGroupHandle : GLibSafeHandle
{
	public static GOptionGroupHandle New(string name, string description, string help_description, IntPtr user_data, GDestroyNotify destroy)
	{
		return GOptionGroupExterns.g_option_group_new(name, description, help_description, user_data, destroy);
	}
}

public class GScannerHandle : GLibSafeHandle
{
	public static GScannerHandle New(GScannerConfigHandle config_templ)
	{
		return GScannerExterns.g_scanner_new(config_templ);
	}
}

public class GTimerHandle : GLibSafeHandle
{
	public static GTimerHandle New()
	{
		return GTimerExterns.g_timer_new();
	}
}

public class GRelationHandle : GLibSafeHandle
{
	public static GRelationHandle New(int fields)
	{
		return GRelationExterns.g_relation_new(fields);
	}
}

public class GVariantHandle : GLibSafeHandle
{
	public static GVariantHandle NewBoolean(int value)
	{
		return GVariantExterns.g_variant_new_boolean(value);
	}

	public static GVariantHandle NewByte(byte value)
	{
		return GVariantExterns.g_variant_new_byte(value);
	}

	public static GVariantHandle NewInt16(short value)
	{
		return GVariantExterns.g_variant_new_int16(value);
	}

	public static GVariantHandle NewUint16(ushort value)
	{
		return GVariantExterns.g_variant_new_uint16(value);
	}

	public static GVariantHandle NewInt32(int value)
	{
		return GVariantExterns.g_variant_new_int32(value);
	}

	public static GVariantHandle NewUint32(uint value)
	{
		return GVariantExterns.g_variant_new_uint32(value);
	}

	public static GVariantHandle NewInt64(nint value)
	{
		return GVariantExterns.g_variant_new_int64(value);
	}

	public static GVariantHandle NewUint64(nuint value)
	{
		return GVariantExterns.g_variant_new_uint64(value);
	}

	public static GVariantHandle NewHandle(int value)
	{
		return GVariantExterns.g_variant_new_handle(value);
	}

	public static GVariantHandle NewDouble(double value)
	{
		return GVariantExterns.g_variant_new_double(value);
	}

	public static GVariantHandle NewString(string @string)
	{
		return GVariantExterns.g_variant_new_string(@string);
	}

	public static GVariantHandle NewTakeString(string @string)
	{
		return GVariantExterns.g_variant_new_take_string(@string);
	}

	public static GVariantHandle NewPrintf(string format_string, IntPtr @__arglist)
	{
		return GVariantExterns.g_variant_new_printf(format_string, @__arglist);
	}

	public static GVariantHandle NewObjectPath(string object_path)
	{
		return GVariantExterns.g_variant_new_object_path(object_path);
	}

	public static GVariantHandle NewSignature(string signature)
	{
		return GVariantExterns.g_variant_new_signature(signature);
	}

	public static GVariantHandle NewStrv(string strv, nint length)
	{
		return GVariantExterns.g_variant_new_strv(strv, length);
	}

	public static GVariantHandle NewObjv(string strv, nint length)
	{
		return GVariantExterns.g_variant_new_objv(strv, length);
	}

	public static GVariantHandle NewBytestring(string @string)
	{
		return GVariantExterns.g_variant_new_bytestring(@string);
	}

	public static GVariantHandle NewBytestringArray(string strv, nint length)
	{
		return GVariantExterns.g_variant_new_bytestring_array(strv, length);
	}

	public static GVariantHandle NewTuple(GVariant children, nuint n_children)
	{
		return GVariantExterns.g_variant_new_tuple(children, n_children);
	}

	public static GVariantHandle New(string format_string, IntPtr @__arglist)
	{
		return GVariantExterns.g_variant_new(format_string, @__arglist);
	}

	public static GVariantHandle NewVa(string format_string, out string endptr, IntPtr @__arglist)
	{
		return GVariantExterns.g_variant_new_va(format_string, out endptr, @__arglist);
	}

	public static GVariantHandle NewParsed(string format, IntPtr @__arglist)
	{
		return GVariantExterns.g_variant_new_parsed(format, @__arglist);
	}

	public static GVariantHandle NewParsedVa(string format, IntPtr @__arglist)
	{
		return GVariantExterns.g_variant_new_parsed_va(format, @__arglist);
	}
}

public class GDoubleIEEE754Handle : GLibSafeHandle
{
}

public class GTestLogMsgHandle : GLibSafeHandle
{
}

public class GMainLoopHandle : GLibSafeHandle
{
}

public class GCondHandle : GLibSafeHandle
{
	public static GCondHandle New()
	{
		return GCondExterns.g_cond_new();
	}
}

public class GScannerConfigHandle : GLibSafeHandle
{
}

public class GUriHandle : GLibSafeHandle
{
}

public class GHmacHandle : GLibSafeHandle
{
	public static GHmacHandle New(GChecksumType digest_type, string key, nuint key_len)
	{
		return GHmacExterns.g_hmac_new(digest_type, key, key_len);
	}
}

public class GByteArrayHandle : GLibSafeHandle
{
	public static GByteArrayHandle New()
	{
		return GByteArrayExterns.g_byte_array_new();
	}

	public static GByteArrayHandle NewTake(byte[] data, nuint len)
	{
		return GByteArrayExterns.g_byte_array_new_take(data, len);
	}

	public static GByteArrayHandle SizedNew(uint reserved_size)
	{
		return GByteArrayExterns.g_byte_array_sized_new(reserved_size);
	}
}

public class GSequenceIterHandle : GLibSafeHandle
{
}

public class GTimeSpanHandle : GLibSafeHandle
{
}

public class GDateDayHandle : GLibSafeHandle
{
}

public class GDateYearHandle : GLibSafeHandle
{
}

public class time_tHandle : GLibSafeHandle
{
}

public class GQuarkHandle : GLibSafeHandle
{
}

public class GTimeHandle : GLibSafeHandle
{
}

public class GStrvHandle : GLibSafeHandle
{
}

public class GPidHandle : GLibSafeHandle
{
}

public class GTypeHandle : GLibSafeHandle
{
}
