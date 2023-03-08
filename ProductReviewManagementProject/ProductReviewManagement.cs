using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementProject
{
    public class ProductReviewManagement
    {
        public static void RetriveTop3records(List<ProductReview> list)
        {
            List<ProductReview> sortedInDesending = list.OrderByDescending(p => p.Rating).Take(3).ToList();
            Program.DisplayProductReview(sortedInDesending);
            //    List<ProductReview> result = (from product in list orderby product.Rating descending select product).Take(3).ToList();
            //    Program.DisplayProductReview(result);
        }

        public static void FetchRecordBasedonRatingAndProductId(List<ProductReview> list)
        {
            List<ProductReview> result = list.Where(p => p.Rating > 3 && (p.ProductId == 1 || p.ProductId == 4 || p.ProductId == 9)).ToList();
            Program.DisplayProductReview(result);

        }
        public static void FindingEachCountOfProductId(List<ProductReview> list)
        {
            Console.WriteLine("\n Finding each count of ProductId");
            var result = list.GroupBy(p => p.ProductId).Select(p => new { Id = p.Key, count = p.Count() }).ToList();
            foreach(var product in result)
            {
                Console.WriteLine(product.Id+" ->" +product.count);
            }
        }

        public static void DisplayProductIdAndReview(List<ProductReview> list)
        {
            Console.WriteLine("\n Display productId and review");
            var result = list.Select(p => new { Id = p.ProductId, review = p.Review }).ToList();
            foreach(var product in result)
            {
                Console.WriteLine("ProductId:" +product.Id + " " + "Review:" + product.review) ;
            }
        }
        public static void SkipTop5Records(List<ProductReview> list)
        {
            Console.WriteLine("Skip Top 5 Records");
            List<ProductReview> result = list.Skip(5).ToList();
            Program.DisplayProductReview(result);
        }

        //UC7
        public static void DisplayProductIdAndReview2(List<ProductReview> list)
        {
            Console.WriteLine("\n Display productId and review");
            var result = list.Select(p => new { Id = p.ProductId, review = p.Review }).ToList();
            foreach (var product in result)
            {
                Console.WriteLine("ProductId:" + product.Id + " " + "Review:" + product.review);
            }
        }


        //UC9
        public static void FindRecordsWhoseIsLikeValueIsTrue(List<ProductReview> list)
        {
            List<ProductReview> result = list.Where(x => x.isLike == true).OrderBy(x => x.isLike).ToList();
            Program.DisplayProductReview(result);
        }
        //UC10
        public static void FindAverageRecords(List<ProductReview> list)
        {
            var result = list.Average(p => p.Rating);
            Console.WriteLine("Average records are: {0}", result);
        }
    }
}

