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


public static class GRandHandleExtensions
{
	public static GRandHandle Copy(this GRandHandle rand_)
	{
		return GRandExterns.g_rand_copy(rand_);
	}

	public static double Double(this GRandHandle rand_)
	{
		return GRandExterns.g_rand_double(rand_);
	}

	public static double DoubleRange(this GRandHandle rand_, double begin, double end)
	{
		return GRandExterns.g_rand_double_range(rand_, begin, end);
	}

	public static GRandHandle Free(this GRandHandle rand_)
	{
		GRandExterns.g_rand_free(rand_);
		return rand_;
	}

	public static uint Int(this GRandHandle rand_)
	{
		return GRandExterns.g_rand_int(rand_);
	}

	public static int IntRange(this GRandHandle rand_, int begin, int end)
	{
		return GRandExterns.g_rand_int_range(rand_, begin, end);
	}

	public static GRandHandle SetSeed(this GRandHandle rand_, uint seed)
	{
		GRandExterns.g_rand_set_seed(rand_, seed);
		return rand_;
	}

	public static GRandHandle SetSeedArray(this GRandHandle rand_, ref uint seed, uint seed_length)
	{
		GRandExterns.g_rand_set_seed_array(rand_, ref seed, seed_length);
		return rand_;
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

	[DllImport(Libraries.GLib)]
	internal static extern GRandHandle g_rand_copy(GRandHandle rand_);

	[DllImport(Libraries.GLib)]
	internal static extern double g_rand_double(GRandHandle rand_);

	[DllImport(Libraries.GLib)]
	internal static extern double g_rand_double_range(GRandHandle rand_, double begin, double end);

	[DllImport(Libraries.GLib)]
	internal static extern void g_rand_free(GRandHandle rand_);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_rand_int(GRandHandle rand_);

	[DllImport(Libraries.GLib)]
	internal static extern int g_rand_int_range(GRandHandle rand_, int begin, int end);

	[DllImport(Libraries.GLib)]
	internal static extern void g_rand_set_seed(GRandHandle rand_, uint seed);

	[DllImport(Libraries.GLib)]
	internal static extern void g_rand_set_seed_array(GRandHandle rand_, ref uint seed, uint seed_length);

}

public struct GRand
{
}
