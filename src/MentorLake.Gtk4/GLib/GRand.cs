namespace MentorLake.Gtk4.GLib;

public class GRandHandle : BaseSafeHandle
{
	public static GRandHandle New()
	{
		return GRandExterns.g_rand_new();
	}

	public static GRandHandle NewWithSeed(uint seed)
	{
		return GRandExterns.g_rand_new_with_seed(seed);
	}

	public static GRandHandle NewWithSeedArray(uint[] seed, uint seed_length)
	{
		return GRandExterns.g_rand_new_with_seed_array(seed, seed_length);
	}

}

internal class GRandExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GRandHandle g_rand_new();

	[DllImport(Libraries.GLib)]
	internal static extern GRandHandle g_rand_new_with_seed(uint seed);

	[DllImport(Libraries.GLib)]
	internal static extern GRandHandle g_rand_new_with_seed_array(uint[] seed, uint seed_length);

}

public struct GRand
{
}
