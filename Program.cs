using AssetTracking;
using ListWithDifferentObjects;
using System.Numerics;

namespace AssetTrackingWeek41
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filepath = "logfile.txt";
            var info = new FileInfo(filepath);
            List<Assets> assets = new List<Assets>();
            
            assets.Add(new PolishPhone("iPhone", "8", 5700.50, new DateTime(2024, 5, 29)));

            assets.Add(new PolishComputer("HP", "Elitebook", 13700, new DateTime(2023, 6, 1)));

            assets.Add(new PolishPhone("iPhone", "11", 6700, new DateTime(2023, 9, 25)));

            assets.Add(new SWEphone("iPhone", "X", 8000, new DateTime(2022, 2, 15)));

            assets.Add(new SWEphone("Motorola", "Razr", 3700, new DateTime(2021, 12, 16)));

            assets.Add(new SWEComputer("HP", "Elitebook", 17700, new DateTime(2023, 10, 2)));

            assets.Add(new USComputer("ASUS", "W234", 1200, new DateTime(2022, 4, 21)));

            assets.Add(new USComputer("Lenovo", "Yoga 730", 1540, new DateTime(2020, 5, 28)));

            assets.Add(new USComputer("Lenovo", "Yoga 530", 1030, new DateTime(2023, 5, 21)));

            List<Assets> assetsSortedList = assets.OrderBy(asset => asset.Office).ThenBy(asset => asset.LocalPrice).ToList();
            StreamWriter writer = new StreamWriter(filepath, true);

            if (info.Length < 6)
            {

                foreach (Assets assets1 in assetsSortedList)
                {
                    writer.WriteLine(assets1.Office + "," + assets1.Asset + "," + assets1.Brand + "," + assets1.Model + "," + assets1.LocalPrice.ToString() + "," + assets1.Currency);

                }

                writer.Close();
            }
            

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Office".PadRight(10) + " " + "Asset".PadRight(10) + " " + "Brand".PadRight(10) + " " + "Model".PadRight(10) + " " + "Price(EUR)".PadRight(10) + " " + "Currency".PadRight(10) + " " + "Price(local)".PadRight(10) + " " + "Purchase date".PadRight(10));
            Console.ResetColor();

            foreach (var asset in assetsSortedList)
            {
                double inEURO = DoConversion.PerformConversion(asset.Currency, "EUR", asset.LocalPrice);
                double toEURO = Math.Round(inEURO, 1);
                formatDate checkDate = new formatDate();
                int difference = checkDate.RedDate(checkDate.start, asset.purchaseDate);
                if (difference > 33)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(asset.Office.PadRight(10) + " " + asset.Asset.PadRight(10) + " " + asset.Brand.PadRight(10) + " " + asset.Model.PadRight(10) + " " + toEURO.ToString().PadRight(10) + " " + asset.Currency.PadRight(10) + " " + asset.LocalPrice.ToString().PadRight(10) + asset.purchaseDate.ToString("yyyy-MM-dd").PadRight(10));
                    Console.ResetColor();
                }

                else if (difference > 30 && difference < 33)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(asset.Office.PadRight(10) + " " + asset.Asset.PadRight(10) + " " + asset.Brand.PadRight(10) + " " + asset.Model.PadRight(10) + " " + toEURO.ToString().PadRight(10) + " " + asset.Currency.PadRight(10) + " " + asset.LocalPrice.ToString().PadRight(10) + asset.purchaseDate.ToString("yyyy-MM-dd").PadRight(10));
                    Console.ResetColor();
                }

                else
                {
                    Console.WriteLine(asset.Office.PadRight(10) + " " + asset.Asset.PadRight(10) + " " + asset.Brand.PadRight(10) + " " + asset.Model.PadRight(10) + " " + toEURO.ToString().PadRight(10) + " " + asset.Currency.PadRight(10) + " " + asset.LocalPrice.ToString().PadRight(10) + asset.purchaseDate.ToString("yyyy-MM-dd").PadRight(10));
                }

            }

           
        }
    }
}




