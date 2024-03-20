using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GPrivateAdaptors
{
	public static IntPtr Get(this GPrivateHandle key)
	{
		return GPrivateExterns.g_private_get(key);
	}

	public static GPrivateHandle Set(this GPrivateHandle key, IntPtr value)
	{
		GPrivateExterns.g_private_set(key, value);
		return key;
	}

	public static GPrivateHandle Replace(this GPrivateHandle key, IntPtr value)
	{
		GPrivateExterns.g_private_replace(key, value);
		return key;
	}
}
