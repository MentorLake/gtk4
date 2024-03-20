using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GRandAdaptors
{
	public static GRandHandle Free(this GRandHandle rand_)
	{
		GRandExterns.g_rand_free(rand_);
		return rand_;
	}

	public static GRandHandle Copy(this GRandHandle rand_)
	{
		return GRandExterns.g_rand_copy(rand_);
	}

	public static GRandHandle SetSeed(this GRandHandle rand_, uint seed)
	{
		GRandExterns.g_rand_set_seed(rand_, seed);
		return rand_;
	}

	public static GRandHandle SetSeedArray(this GRandHandle rand_, uint[] seed, uint seed_length)
	{
		GRandExterns.g_rand_set_seed_array(rand_, seed, seed_length);
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

	public static double Double(this GRandHandle rand_)
	{
		return GRandExterns.g_rand_double(rand_);
	}

	public static double DoubleRange(this GRandHandle rand_, double begin, double end)
	{
		return GRandExterns.g_rand_double_range(rand_, begin, end);
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
