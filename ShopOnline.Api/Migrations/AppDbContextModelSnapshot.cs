﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopOnline.Api.Data;

#nullable disable

namespace ShopOnline.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ShopOnline.Api.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "A small gregarious Australian parakeet that in the wild is green with a yellow head. It is popular as a pet bird and has been bred in a variety of colors.",
                            ImageUrl = "/img/pet/bird/budgerigar.jpg",
                            Name = "Budgerigar",
                            Price = 2762.68m,
                            Qty = 14
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "A slender long-crested Australian parrot related to the cockatoos, with a mainly gray body, white shoulders, and a yellow and orange face.",
                            ImageUrl = "/img/pet/bird/cockatiel.jpg",
                            Name = "Cockatiel",
                            Price = 2278.8m,
                            Qty = 18
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "A parrot with an erectile crest, found in Australia, eastern Indonesia, and neighboring islands.",
                            ImageUrl = "/img/pet/bird/cackatoo.jpg",
                            Name = "Cackatoo",
                            Price = 56970m,
                            Qty = 21
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "A parrot native to central and eastern South America. With a length (from the top of its head to the tip of its long pointed tail) of about one meter it is longer than any other species of parrot.",
                            ImageUrl = "/img/pet/bird/hyacinth-macaw.jpg",
                            Name = "Hyacinth Macaw",
                            Price = 34182m,
                            Qty = 5
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "A stocky seed- or fruit-eating bird with a small head, short legs, and a cooing voice. Doves are generally smaller and more delicate than pigeons, but many kinds have been given both names.",
                            ImageUrl = "/img/pet/bird/dove.jpg",
                            Name = "Dove",
                            Price = 3703.05m,
                            Qty = 26
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Description = "The most sexually dimorphic of all the parrot species. The contrast between the brilliant emerald green plumage of the male and the deep red/purple plumage of the female is so marked that the birds were, until the early 20th century, considered to be different species.",
                            ImageUrl = "/img/pet/bird/eclectus-parrot.jpg",
                            Name = "Eclectus Parrot",
                            Price = 7121.25m,
                            Qty = 25
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            Description = "Known for the sweet singing of the males, canaries are friendly birds that are a type of finch native to the Canary Islands.",
                            ImageUrl = "/img/pet/bird/canary.jpg",
                            Name = "Canary",
                            Price = 1139.4m,
                            Qty = 10
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "One of the first distinctly recognised breeds of Asian cat.",
                            ImageUrl = "/img/pet/cat/siamese.jpg",
                            Name = "Siamese",
                            Price = 15000m,
                            Qty = 120
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Description = "A long-haired breed of cat characterised by a round face and short muzzle.",
                            ImageUrl = "/img/pet/cat/persian.jpg",
                            Name = "Persian",
                            Price = 15000m,
                            Qty = 119
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            Description = "The breed's distinctive appearance, seeming long, lean and finely colored compared to other cats, has been analogized to that of human fashion models.",
                            ImageUrl = "/img/pet/cat/abyssinian.jpg",
                            Name = "Abyssinian",
                            Price = 5697m,
                            Qty = 34
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Description = "A breed of cat known for its lack of fur.",
                            ImageUrl = "/img/pet/cat/sphynx.jpg",
                            Name = "Sphynx",
                            Price = 34182m,
                            Qty = 20
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 3,
                            Description = "A breed or sub-breed of long-haired cat similar in type to the Persian, with the exception of its blue eyes and its point colouration, which were derived from crossing the Persian with the Siamese.",
                            ImageUrl = "/img/pet/cat/himalayan.jpg",
                            Name = "Himalayan",
                            Price = 17091m,
                            Qty = 19
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 3,
                            Description = "A long-legged wild cat with black tufted ears and a uniform brown coat, native to Africa and western Asia.",
                            ImageUrl = "/img/pet/cat/caracal.jpg",
                            Name = "Caracal",
                            Price = 85455m,
                            Qty = 5
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
                            Description = "A large American wild cat with a plain tawny to grayish coat, found from Canada to Patagonia.",
                            ImageUrl = "/img/pet/cat/cougar.jpg",
                            Name = "Cougar",
                            Price = 56970m,
                            Qty = 3
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 3,
                            Description = "A slender African wildcat with long legs, large ears, and a black-spotted orange-brown coat.",
                            ImageUrl = "/img/pet/cat/serval.jpeg",
                            Name = "Serval",
                            Price = 170910m,
                            Qty = 1
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 2,
                            Description = "It has erect ears that are in proportion to the equilateral triangle of the head. The breed standard indicates that the ears should be firm, medium in size, and tapered slightly to a rounded point.",
                            ImageUrl = "/img/pet/dog/pembroke-welsh-corgi.jpg",
                            Name = "Pembroke Welsh Corgi",
                            Price = 25000m,
                            Qty = 212
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 2,
                            Description = "A small sturdy hound of a breed with a coat of medium length, bred especially for hunting.",
                            ImageUrl = "/img/pet/dog/beagle.jpg",
                            Name = "Beagle",
                            Price = 28485m,
                            Qty = 112
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 2,
                            Description = "A small dog of a breed with long silky hair, a pointed muzzle, and pricked ears.",
                            ImageUrl = "/img/pet/dog/pomeranian.jpg",
                            Name = "Pomeranian",
                            Price = 30000m,
                            Qty = 90
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 2,
                            Description = "A dog of a white, short-haired breed with dark spots.",
                            ImageUrl = "/img/pet/dog/dalmatian.jpg",
                            Name = "Dalmatian",
                            Price = 34182m,
                            Qty = 95
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 2,
                            Description = "A British breed of toy dog of spaniel type. Four colours are recognised: Blenheim (chestnut and white), tricolour (black/white/tan), black and tan, and ruby; the coat is smooth and silky. The lifespan is usually between eight and twelve years.",
                            ImageUrl = "/img/pet/dog/cavalier-king-charles-spaniel.jpg",
                            Name = "Cavalier King Charles Spaniel",
                            Price = 56970m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 2,
                            Description = "A medium-sized working sled dog breed. The breed belongs to the Spitz genetic family. It is recognizable by its thickly furred double coat, erect triangular ears, and distinctive markings, and is smaller than the similar-looking Alaskan Malamute.",
                            ImageUrl = "/img/pet/dog/siberian-husky.jpg",
                            Name = "Siberian Husky",
                            Price = 13500m,
                            Qty = 73
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 4,
                            Description = "A large genus of small, active, often colorful, freshwater ray-finned fishes, in the gourami family.",
                            ImageUrl = "/img/pet/fish/betta-fish.jpg",
                            Name = "Betta Fish",
                            Price = 1000m,
                            Qty = 5000
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 4,
                            Description = "A genus of freshwater catfish in the family Callichthyidae and subfamily Corydoradinae. The species usually have more restricted areas of endemism than other callichthyids, but the area of distribution of the entire genus almost equals the area of distribution of the family, except for Panama where Corydoras is not present.",
                            ImageUrl = "/img/pet/fish/corydoras-catfish.jpg",
                            Name = "Corydoras Catfish",
                            Price = 1993m,
                            Qty = 6000
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 4,
                            Description = "A goldfish that possesses an egg-shaped body, a high dorsal fin, a long quadruple caudal fin, and no shoulder hump.",
                            ImageUrl = "/img/pet/fish/fantail-goldfish.jpg",
                            Name = "Fantail Goldfish",
                            Price = 284m,
                            Qty = 7000
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 4,
                            Description = "A small, livebearing freshwater fish widely kept in aquariums. Native to tropical America, it has been introduced elsewhere to control mosquito larvae.",
                            ImageUrl = "/img/pet/fish/guppy.jpg",
                            Name = "Guppy",
                            Price = 100m,
                            Qty = 1200
                        },
                        new
                        {
                            Id = 26,
                            CategoryId = 4,
                            Description = "A small genus of freshwater fish from the family Cichlidae known to most aquarists as angelfish.",
                            ImageUrl = "/img/pet/fish/silver-angelfish.jpg",
                            Name = "Silver Angelfish",
                            Price = 1139m,
                            Qty = 3450
                        },
                        new
                        {
                            Id = 27,
                            CategoryId = 4,
                            Description = "A marine fish belonging to the family Pomacentridae, which includes clownfishes and damselfishes. Amphiprion ocellaris are found in different colors, depending on where they are located.",
                            ImageUrl = "/img/pet/fish/ocellaris-clownfish.jpg",
                            Name = "Ocellaris Clownfish (False Percula Clownfish)",
                            Price = 1139m,
                            Qty = 10
                        },
                        new
                        {
                            Id = 28,
                            CategoryId = 4,
                            Description = "The twospined angelfish has a basic dark purplish-blue body. This is marked with irregular orange vertical bars on its flanks.",
                            ImageUrl = "/img/pet/fish/coral-beauty-angelfish.jpg",
                            Name = "Coral Beauty Angelfish (Two-Spined Angelfish)",
                            Price = 3417.63m,
                            Qty = 10
                        },
                        new
                        {
                            Id = 29,
                            CategoryId = 4,
                            Description = "Typically olive to brown with dark bars and a large number of round or elongated white spots of different sizes. The blenny has many pale spots, dark streaks that run anteriorly, and several dark bands.",
                            ImageUrl = "/img/pet/fish/lawnmower-blenny.jpg",
                            Name = "Lawnmower Blenny (Jeweled Rockskipper)",
                            Price = 8539.803m,
                            Qty = 10
                        },
                        new
                        {
                            Id = 30,
                            CategoryId = 4,
                            Description = "It differs from all the other hawkfish species in its elongated snout, the length of the snout fitting roughly twice into the overall length of the head. The canine teeth in the jaws are of uniform size and are only slightly larger than the inner band of villiform teeth.",
                            ImageUrl = "/img/pet/fish/longnose-hawkfish.jpg",
                            Name = "Longnose Hawkfish",
                            Price = 56959.6m,
                            Qty = 1
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "/resources/icons/bird.svg",
                            Name = "Bird"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "/resources/icons/dog.svg",
                            Name = "Dog"
                        },
                        new
                        {
                            Id = 3,
                            Icon = "/resources/icons/cat.svg",
                            Name = "Cat"
                        },
                        new
                        {
                            Id = 4,
                            Icon = "/resources/icons/fish.svg",
                            Name = "Fish"
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserName = "Air-wind"
                        },
                        new
                        {
                            Id = 2,
                            UserName = "Blaziken"
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.Product", b =>
                {
                    b.HasOne("ShopOnline.Api.Entities.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });
#pragma warning restore 612, 618
        }
    }
}