namespace ReadTrack.Console;
public static class ReadingProgressCalculator
{
    public const int MinTotalPages = 1;

    public static double Calculate(
        int currentPage,
        int totalPages)
    {
        if (totalPages < MinTotalPages)
        {
            throw new ArgumentOutOfRangeException(
                nameof(totalPages),
                "Total pages must be greater than zero.");
        }

        if (currentPage < 0 || currentPage > totalPages)
        {
            throw new ArgumentOutOfRangeException(
                nameof(currentPage),
                "Current page must be between zero and total pages.");
        }

        return (double)currentPage / totalPages * 100;
    }
}
