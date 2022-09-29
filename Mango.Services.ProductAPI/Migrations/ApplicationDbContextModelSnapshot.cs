﻿// <auto-generated />
using Mango.Services.ProductAPI.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mango.Services.ProductAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mango.Services.ProductAPI.Models.Dto.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryName = "Appetizer",
                            Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                            ImageUrl = "https://storage.yandexcloud.net/vladicher/11.jpg?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=YCAJEUn20GdYTe5ki6R5MDDLU%2F20220921%2Fru-central1%2Fs3%2Faws4_request&X-Amz-Date=20220921T091219Z&X-Amz-Expires=36000&X-Amz-Signature=76505D4D331BE072C2CD6E7D4CDA99FE00E06F4967440D19112B1A4F9E93C5B9&X-Amz-SignedHeaders=host",
                            Name = "Samosa",
                            Price = 15.0
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryName = "Appetizer",
                            Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                            ImageUrl = "https://storage.yandexcloud.net/vladicher/12.jpg?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=YCAJEUn20GdYTe5ki6R5MDDLU%2F20220921%2Fru-central1%2Fs3%2Faws4_request&X-Amz-Date=20220921T091352Z&X-Amz-Expires=36000&X-Amz-Signature=4E7211734BD4686DFE07CC3475DBB5AD826325D3280BAB1994131AF749BB4687&X-Amz-SignedHeaders=host",
                            Name = "Paneer Tikka",
                            Price = 13.99
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryName = "Dessert",
                            Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                            ImageUrl = "https://storage.yandexcloud.net/vladicher/13.jpg?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=YCAJEUn20GdYTe5ki6R5MDDLU%2F20220921%2Fru-central1%2Fs3%2Faws4_request&X-Amz-Date=20220921T091411Z&X-Amz-Expires=36000&X-Amz-Signature=A5CD6D5B8BC8159477FE56520A718B34A733DC254C630CD6420B169875943728&X-Amz-SignedHeaders=host",
                            Name = "Sweet Pie",
                            Price = 10.99
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryName = "Entree",
                            Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                            ImageUrl = "https://storage.yandexcloud.net/vladicher/14.jpg?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=YCAJEUn20GdYTe5ki6R5MDDLU%2F20220921%2Fru-central1%2Fs3%2Faws4_request&X-Amz-Date=20220921T091428Z&X-Amz-Expires=36000&X-Amz-Signature=62A8934F651B58E2E6E9E6AA885E391E00A9EBF425B28FB5906AA0BBFA5B74B5&X-Amz-SignedHeaders=host",
                            Name = "Pav Bhaji",
                            Price = 15.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
