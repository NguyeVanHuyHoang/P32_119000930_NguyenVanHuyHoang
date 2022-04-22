using Microsoft.EntityFrameworkCore;


namespace RazorPagesMovie.Models
{
    public static class SeedDataNews
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.News == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.News.Any())
                {
                    return;   // DB has been seeded
                }

                context.News.AddRange(
                    new News
                    {
                        ID =1,
                        Title ="Bai Viet So  1",
                        ImageUrl="image/1_32.png",
                        Content="Content 1",
                        Author= "Nguyen Van 1",
                        CreatedAt="CreateAt 1",
                    },

                    new News
                    {
                         ID =2,
                        Title ="Bai Viet So  2",
                        ImageUrl="image/2_32.png",
                        Content="Content 2",
                        Author= "Nguyen Van 2",
                        CreatedAt="CreateAt 2",
                    },

                    new News
                    {
                         ID =3,
                        Title ="Bai Viet So  3",
                        ImageUrl="image/3_32.png",
                        Content="Content 3",
                        Author= "Nguyen Van 3",
                        CreatedAt="CreateAt 3",
                    },

                    new News
                    {
                        ID =4,
                        Title ="Bai Viet So 4",
                        ImageUrl="image/4_32.png",
                        Content="Content 4",
                        Author= "Nguyen Van 4",
                        CreatedAt="CreateAt 4",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}