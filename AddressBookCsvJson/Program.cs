using System;

namespace AddressBookCsvJson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book with Csv and Json :");

            Console.WriteLine("# Read data from CSV & Write data in CSV");
            CSVHandler.ImplementCSVDataHandling();
            ReadCSV_And_WriteJSON.ImplementCSVToJSON();

            Console.ReadKey();
        }
    }
}