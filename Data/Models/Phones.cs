using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Phone
    {
        public int id { set; get; }

        public int categortId { set; get; }

        public string name { set; get; }

        public string description { set; get; }

        public int price { set; get; }

        public string image { set; get; }

        public string size { set; get; }

        public string material { set; get; }

        public string density { set; get; }

        public string manufacturer { set; get; }

        public bool original { set; get; }

        public bool unisex { set; get; }

        public string age { set; get; }

        public string tax { set; get; }
    }
}
/*id: '1',
        categoryId: '1',
        name: 'T-shirt with a group print',
        description:
            'T-shirt for real boys who listen to rock, not shit rap and pop. If you are a real punk, go fuck the faggots with nigger rap and listen to rock',
        price: 22,
        image: '/uploads/23 (3)-300x350.jpg',
        size: 'M',
        material: '100% cotton',
        density: '150-170 g\m',
        manufacturer: 'Poland',
        original: 'true',
        unisex: 'false',
        age: 'for children',
        tax: '20%'*/
