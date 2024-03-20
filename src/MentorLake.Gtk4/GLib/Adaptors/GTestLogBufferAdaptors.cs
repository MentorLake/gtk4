using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GTestLogBufferAdaptors
{
	public static GTestLogBufferHandle Free(this GTestLogBufferHandle tbuffer)
	{
		GTestLogBufferExterns.g_test_log_buffer_free(tbuffer);
		return tbuffer;
	}

	public static GTestLogBufferHandle Push(this GTestLogBufferHandle tbuffer, uint n_bytes, byte[] bytes)
	{
		GTestLogBufferExterns.g_test_log_buffer_push(tbuffer, n_bytes, bytes);
		return tbuffer;
	}

	public static GTestLogMsgHandle Pop(this GTestLogBufferHandle tbuffer)
	{
		return GTestLogBufferExterns.g_test_log_buffer_pop(tbuffer);
	}
}
