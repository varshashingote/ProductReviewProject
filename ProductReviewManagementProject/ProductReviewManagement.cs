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
            List<ProductReview> sortedInDesending=list.OrderByDescending(p => p.Rating).Take(3).ToList();
            Program.DisplayProductReview(sortedInDesending);
            //    List<ProductReview> result = (from product in list orderby product.Rating descending select product).Take(3).ToList();
            //    Program.DisplayProductReview(result);
            }
    }
}

