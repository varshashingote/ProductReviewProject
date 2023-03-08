using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ProductReview> list = new List<ProductReview>()
            {
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 50, Review = "Excellent", isLike = true },
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 50, Review = "nice",      isLike = true },
                new ProductReview() { ProductId = 2, UserId = 2, Rating = 60, Review = "Good",     isLike = false },
                new ProductReview() { ProductId = 4, UserId = 3, Rating = 40, Review = "nice",     isLike = true },
                new ProductReview() { ProductId = 3, UserId = 3, Rating = 36, Review = "Average",  isLike = false },
                new ProductReview() { ProductId = 3, UserId = 4, Rating = 58, Review = "Excellent", isLike = true },
                new ProductReview() { ProductId = 4, UserId = 5, Rating = 30, Review = "Average",  isLike = true },
                new ProductReview() { ProductId = 5, UserId = 5, Rating = 20, Review = "Bad",      isLike = true },
                new ProductReview() { ProductId = 5, UserId = 6, Rating = 20, Review = "Bad",      isLike = true },
                new ProductReview() { ProductId = 6, UserId = 7, Rating = 10, Review = "Very Bad", isLike = true },
                new ProductReview() { ProductId = 9, UserId = 8, Rating = 30, Review = "nice" ,    isLike = true }
            };
            // DisplayProductReview(list);
            ProductReviewManagement.FindAverageRecords(list);
            Console.ReadLine();
        }
        public static void DisplayProductReview(List<ProductReview> list)
        {
            foreach(ProductReview product in list)
            {
                Console.WriteLine(product);
            }
        }
          
    }
}
