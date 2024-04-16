public class DateCalc
{
    // Class members go here
    public static void Main()
    {
        // Code goes here
    }

    public int calculateDaysBetweenDates(int date1, int date2)
    {
        TimeSpan difference = DateTime.FromOADate(date2) - DateTime.FromOADate(date1);
        return difference.Days;
    }

    // Identify all the images without alternate text
// and add a red border to them
void Process(List<Image> images)
{
    int updatedCount = 0;
    foreach (Image image in images)
    {
        if (image.AltText == null)
        {
            image.BorderColor = Color.Red;
            updatedCount++;
        }

        if (updatedCount % 2 == 0)
        {
            image.BorderColor = Color.Red;
        }
        else
        {
            image.BorderColor = Color.Black;
        }
    }
    Console.WriteLine($"Number of images updated: {updatedCount}");
}