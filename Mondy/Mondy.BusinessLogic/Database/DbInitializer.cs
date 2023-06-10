using Mondy.Domain.Entities;
using Mondy.Helpers;
using System.Data.Entity;

namespace Mondy.BusinessLogic.Database
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<UserContext>
	{
		protected override void Seed(UserContext context)
		{
            var userStepan = context.Users.Add(new User()
            {
                Name = "Admin",
                PasswordHash = AuthHelper.GeneratePasswordHash("123"),
                Email = "admin.admin@isa.utm.md",
                Avatar = "https://pbs.twimg.com/profile_images/1615039593828450326/mDTwNfzL_400x400.jpg",
                Role = UserRole.Admin
            });

            base.Seed(context);

            //--------------------------------------------------------------------//
            // WINES
            //--------------------------------------------------------------------//

            #region RED
            context.Products.Add(new Product
            {
                Title = "CABERNET SAUVIGNON",
                Category = "Red",
                Image = "https://marvel-b1-cdn.bc0a.com/f00000000255487/images.commerce7.com/sutter-home/images/large/shw-nv2021-cs-front-bottle-lr-1652386525737.png",

                PricePerUnit = 7,
                Unit = "750mL",

                Acid = 0.6f,
                pH = 3.54f,
                Alcohol = 12.9f,

                Notes = "Sutter Home Cabernet Sauvignon is an intense ruby color, with fragrant aromas",
            });

            context.Products.Add(new Product
            {
                Title = "FOUNDER'S SELECTION SANGIOVESE 2019",
                Category = "Red",
                Image = "https://marvel-b1-cdn.bc0a.com/f00000000255487/images.commerce7.com/sutter-home/images/large/founders-sangiovese-1645816895646.png",

                PricePerUnit = 20,
                Unit = "750mL",

                Acid = 0.6f,
                pH = 3.54f,
                Alcohol = 12f,

                Notes = "Our passion for perfecting the traditional flavors of each varietal is reflected in our Sangiovese, which delivers the delicious flavors of ripe cherries and jammy red fruits characteristic of the warm Amador region. Aromas of sweet, spicy oak and vanilla are complemented by a long, lingering finish. Enjoy this wine on its own or with red pasta sauce or hard cheeses.",
            });

            context.Products.Add(new Product
            {
                Title = "MERLOT",
                Category = "Red",
                Image = "https://marvel-b1-cdn.bc0a.com/f00000000255487/images.commerce7.com/sutter-home/images/large/sh-2016-me-750-bottle-lr-1621369803828.png",

                PricePerUnit = 7,
                Unit = "750mL",

                Acid = 0.55f,
                pH = 3.48f,
                Alcohol = 13.4f,

                Notes = "Sutter Home Merlot is lush and velvety, brimming with generous fresh fruit flavors. Ripe black cherry aromas with hints of tobacco and herbal spice lead to smoky black cherry and spiced plum flavors on the palate, and a plush, lingering finish. Medium-bodied with soft tannins and a round mouthfeel.",
            });
            #endregion

            #region WHITE
            context.Products.Add(new Product
            {
                Title = "FOUNDER'S SELECTION PINOT GRIGIO 2018",
                Category = "White",
                Image = "https://marvel-b1-cdn.bc0a.com/f00000000255487/images.commerce7.com/sutter-home/images/large/shdtc-v2013-retro-pg-bottle-lr-1621457796829.png",

                PricePerUnit = 7,
                Unit = "750mL",

                Acid = 0.6f,
                pH = 3.54f,
                Alcohol = 12.9f,

                Notes = "Retro Sutter Home Pinot Grigio is light-to-medium bodied and round in texture with a delightful white peach and sweet citrus character on the palate. This well-balanced wine boasts soft aromas of tangerine and sweet fruit, a perfect wine for entertaining."
            });

            context.Products.Add(new Product
            {
                Title = "MOSCATO SANGRIA",
                Category = "White",
                Image = "https://marvel-b1-cdn.bc0a.com/f00000000255487/images.commerce7.com/sutter-home/images/medium/sh-2017-mc-sangria-750-bottle-lr-1621370779889.png",

                PricePerUnit = 7,
                Unit = "750mL",

                Acid = 0.6f,
                pH = 3.54f,
                Alcohol = 12f,

                Notes = "Sutter Home Moscato Sangria is a fruity and floral white wine with hints of raspberry, cranberry, strawberry, citrus, and loads of pineapple flavors. The natural residual grape sweetness provides a luscious mouthfeel.",
            });

            context.Products.Add(new Product
            {
                Title = "CHARDONNAY",
                Category = "White",
                Image = "https://marvel-b1-cdn.bc0a.com/f00000000255487/images.commerce7.com/sutter-home/images/medium/shw-nv2021-ch-front-bottle-lr-1652386543629.png",

                PricePerUnit = 7,
                Unit = "750mL",

                Acid = 0.55f,
                pH = 3.38f,
                Alcohol = 13.1f,

                Notes = "Sutter Home Chardonnay is rich and elegant with silky-smooth texture. The fresh aromas of ripe pear and zesty citrus lead to creamy peach and juicy apple flavors on the palate. It’s a luxurious experience from the first refreshing sip to the full, lingering finish.",
            });
            #endregion
        }
    }
}