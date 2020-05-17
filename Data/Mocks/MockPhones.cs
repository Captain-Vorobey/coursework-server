using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockPhones : IAllPhones
    {
        public IEnumerable<Phone> Phones
        {
            get
            {
                return new List<Phone>
                {
                    new Phone { id = 1,
                                categortId = 1,
                                name = "T-shirt with a group print",
                                description = "T-shirt for real boys who listen to rock, not shit rap and pop. If you are a real punk, go fuck the faggots with nigger rap and listen to rock",
                                price = 22,
                                image = "~/img/23 (3)-300x350.jpg",
                                size = "M",
                                material = "100% cotton",
                                density = "150-170 g/m",
                                manufacturer = "Poland",
                                original = true, unisex = false, age = "for children", tax = "20%"},

                    new Phone { id = 2,
                                categortId = 1,
                                name = "T-shirt with a group print",
                                description = "T-shirt for real boys who listen to rock, not shit rap and pop. If you are a real punk, go fuck the faggots with nigger rap and listen to rock",
                                price = 22,
                                image = "~/img/superman002-300x300.jpg",
                                size = "M",
                                material = "100% cotton",
                                density = "150-170 g/m",
                                manufacturer = "Poland",
                                original = true, unisex = false, age = "for children", tax = "20%"},

                    new Phone { id = 3,
                                categortId = 4,
                                name = "T-shirt with a group print",
                                description = "T-shirt for real boys who listen to rock, not shit rap and pop. If you are a real punk, go fuck the faggots with nigger rap and listen to rock",
                                price = 22,
                                image = "~/img/21150_bokov01-300x300.jpg",
                                size = "M",
                                material = "100% cotton",
                                density = "150-170 g/m",
                                manufacturer = "Poland",
                                original = true, unisex = false, age = "for children", tax = "20%"},

                    new Phone { id = 4,
                                categortId = 5,
                                name = "T-shirt with a group print",
                                description = "T-shirt for real boys who listen to rock, not shit rap and pop. If you are a real punk, go fuck the faggots with nigger rap and listen to rock",
                                price = 22,
                                image = "~/img/b78c4ac7a582dd3972abe618e81d1ef1.jpg",
                                size = "M",
                                material = "100% cotton",
                                density = "150-170 g/m",
                                manufacturer = "Poland",
                                original = true, unisex = false, age = "for children", tax = "20%"},

                    new Phone { id = 5,
                                categortId = 3,
                                name = "T-shirt with a group print",
                                description = "T-shirt for real boys who listen to rock, not shit rap and pop. If you are a real punk, go fuck the faggots with nigger rap and listen to rock",
                                price = 22,
                                image = "~/img/batman002-300x300.jpg",
                                size = "M",
                                material = "100% cotton",
                                density = "150-170 g/m",
                                manufacturer = "Poland",
                                original = true, unisex = false, age = "for children", tax = "20%"},

                    new Phone { id = 6,
                                categortId = 2,
                                name = "T-shirt with a group print",
                                description = "T-shirt for real boys who listen to rock, not shit rap and pop. If you are a real punk, go fuck the faggots with nigger rap and listen to rock",
                                price = 22,
                                image = "~/img/cfd1fff92668251c7d912d781243aaf8.jpg",
                                size = "M",
                                material = "100% cotton",
                                density = "150-170 g/m",
                                manufacturer = "Poland",
                                original = true, unisex = false, age = "for children", tax = "20%"}
                };
            }
        }

        public Phone getObjectPhone(int phoneId)
        {
            throw new NotImplementedException();
        }
    }
}
