using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAdvice
{
    public class MobileDevice
    {
        public string Brand { get; set; }
        public double Size { get; set; }
        public int StorageCapacity { get; set; }

        public MobileDevice(string brand, double size, int storageCapacity)
        {
            Brand = brand;
            Size = size;
            StorageCapacity = storageCapacity;
        }

        public void ChangeBrand(string newBrand)
        {
            Brand = newBrand;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine($"Storage Capacity: {StorageCapacity} GB");
        }
    }
}
