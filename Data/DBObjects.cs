using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Phone.Any())
            {
                content.AddRange(
                        new Phone
                        {
                            id = 1,
                            categortId = 1,
                            name = "T-shirt with a group print",
                            description = "T-shirt for real boys who listen to rock, not shit rap and pop. If you are a real punk, go fuck the faggots with nigger rap and listen to rock",
                            price = 22,
                            image = "~/img/23 (3)-300x350.jpg",
                            size = "M",
                            material = "100% cotton",
                            density = "150-170 g/m",
                            manufacturer = "Poland",
                            original = true,
                            unisex = false,
                            age = "for children",
                            tax = "20%"
                        },

                    new Phone
                    {
                        id = 2,
                        categortId = 1,
                        name = "Superman",
                        description = "T-shirt for children and fans of a series of movies about super heroes who likes this person",
                        price = 14,
                        image = "~/img/superman002-300x300.jpg",
                        size = "L",
                        material = "100% cotton",
                        density = "100-190 g/m",
                        manufacturer = "Russia",
                        original = true,
                        unisex = true,
                        age = "for adults",
                        tax = "20%"
                    },

                    new Phone
                    {
                        id = 3,
                        categortId = 4,
                        name = "Belarus",
                        description = "T-shirt for real degenerates, like those who make stickers on cars we can repeat that you want to piss on, and they also wear t-shirts I am Russian, thereby showing that they belong to their herd.",
                        price = 22,
                        image = "~/img/21150_bokov01-300x300.jpg",
                        size = "M",
                        material = "85% cotton",
                        density = "120-180 g/m",
                        manufacturer = "Belarus",
                        original = false,
                        unisex = true,
                        age = "for children",
                        tax = "10%"
                    },

                    new Phone
                    {
                        id = 4,
                        categortId = 5,
                        name = "T-shirt with a print",
                        description = "Just a fun t shirt for fans of sharp expressions and the ability to attract the attention of people around you",
                        price = 11,
                        image = "~/img/b78c4ac7a582dd3972abe618e81d1ef1.jpg",
                        size = "XL",
                        material = "80% cotton",
                        density = "160-190 g/m",
                        manufacturer = "Belarus",
                        original = true,
                        unisex = true,
                        age = "for adults",
                        tax = "20%"
                    },

                    new Phone
                    {
                        id = 5,
                        categortId = 3,
                        name = "Batman",
                        description = "T-shirt for children and fans of a series of movies about super heroes who likes this peron",
                        price = 13,
                        image = "~/img/batman002-300x300.jpg",
                        size = "XXL",
                        material = "95% cotton",
                        density = "150-200 g/m",
                        manufacturer = "Russia",
                        original = true,
                        unisex = true,
                        age = "for children",
                        tax = "10%"
                    },

                    new Phone
                    {
                        id = 6,
                        categortId = 2,
                        name = "Bad boy",
                        description = "What you need if you are a bad boy and take a picture at Geländewagen and post photos with cigarettes in your closed instagram from your mother",
                        price = 8,
                        image = "~/img/cfd1fff92668251c7d912d781243aaf8.jpg",
                        size = "XS",
                        material = "100% cotton",
                        density = "150-190 g/m",
                        manufacturer = "Germany",
                        original = false,
                        unisex = true,
                        age = "for adults",
                        tax = "15%"
                    }
                );
            }

            content.SaveChangesAsync();
        }

        private static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { id = 1, name = "Gucci"},
                        new Category { id = 2, name = "Louis Vuitton" },
                        new Category { id = 3, name = "Hermes" },
                        new Category { id = 4, name = "Armani" },
                        new Category { id = 5, name = "Chanel" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                    {
                        category.Add(el.name, el);
                    }
                }
                content.SaveChangesAsync();
                return category;
            }
        }
    }
}
