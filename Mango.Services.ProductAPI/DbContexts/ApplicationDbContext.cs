using Mango.Services.ProductAPI.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Samosa",
                Price = 15,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "https://storage.yandexcloud.net/vladicher/11.jpg?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=YCAJEUn20GdYTe5ki6R5MDDLU%2F20220921%2Fru-central1%2Fs3%2Faws4_request&X-Amz-Date=20220921T091219Z&X-Amz-Expires=36000&X-Amz-Signature=76505D4D331BE072C2CD6E7D4CDA99FE00E06F4967440D19112B1A4F9E93C5B9&X-Amz-SignedHeaders=host",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Paneer Tikka",
                Price = 13.99,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "https://storage.yandexcloud.net/vladicher/12.jpg?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=YCAJEUn20GdYTe5ki6R5MDDLU%2F20220921%2Fru-central1%2Fs3%2Faws4_request&X-Amz-Date=20220921T091352Z&X-Amz-Expires=36000&X-Amz-Signature=4E7211734BD4686DFE07CC3475DBB5AD826325D3280BAB1994131AF749BB4687&X-Amz-SignedHeaders=host",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Sweet Pie",
                Price = 10.99,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "https://storage.yandexcloud.net/vladicher/13.jpg?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=YCAJEUn20GdYTe5ki6R5MDDLU%2F20220921%2Fru-central1%2Fs3%2Faws4_request&X-Amz-Date=20220921T091411Z&X-Amz-Expires=36000&X-Amz-Signature=A5CD6D5B8BC8159477FE56520A718B34A733DC254C630CD6420B169875943728&X-Amz-SignedHeaders=host",
                CategoryName = "Dessert"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Pav Bhaji",
                Price = 15,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "https://storage.yandexcloud.net/vladicher/14.jpg?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=YCAJEUn20GdYTe5ki6R5MDDLU%2F20220921%2Fru-central1%2Fs3%2Faws4_request&X-Amz-Date=20220921T091428Z&X-Amz-Expires=36000&X-Amz-Signature=62A8934F651B58E2E6E9E6AA885E391E00A9EBF425B28FB5906AA0BBFA5B74B5&X-Amz-SignedHeaders=host",
                CategoryName = "Entree"
            });
        }
    }
}
