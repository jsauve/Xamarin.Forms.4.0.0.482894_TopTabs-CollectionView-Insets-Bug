using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TopTabsCollectionViewInsetsDemo
{
    public abstract class BaseListViewModel : BaseViewModel
    {
        public ObservableCollection<Item> Items { set; get; }

        protected BaseListViewModel()
        {
            var items = new List<Item>
            {
                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Text = "Baboon",
                    Description = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae."
                },

                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Text = "Capuchin Monkey",
                    Description = "The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus."
                },

                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Text = "Blue Monkey",
                    Description = "The blue monkey or diademed monkey is a species of Old World monkey native to Central and East Africa, ranging from the upper Congo River basin east to the East African Rift and south to northern Angola and Zambia"
                },

                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Text = "Squirrel Monkey",
                    Description = "The squirrel monkeys are the New World monkeys of the genus Saimiri. They are the only genus in the subfamily Saimirinae. The name of the genus Saimiri is of Tupi origin, and was also used as an English name by early researchers."
                },

                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Text = "Golden Lion Tamarin",
                    Description = "The golden lion tamarin also known as the golden marmoset, is a small New World monkey of the family Callitrichidae."
                },

                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Text = "Howler Monkey",
                    Description = "Howler monkeys are among the largest of the New World monkeys. Fifteen species are currently recognised. Previously classified in the family Cebidae, they are now placed in the family Atelidae."
                },

                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Text = "Japanese Macaque",
                    Description = "The Japanese macaque, is a terrestrial Old World monkey species native to Japan. They are also sometimes known as the snow monkey because they live in areas where snow covers the ground for months each"
                },

                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Text = "Mandrill",
                    Description = "The mandrill is a primate of the Old World monkey family, closely related to the baboons and even more closely to the drill. It is found in southern Cameroon, Gabon, Equatorial Guinea, and Congo."
                },

                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Text = "Proboscis Monkey",
                    Description = "The proboscis monkey or long-nosed monkey, known as the bekantan in Malay, is a reddish-brown arboreal Old World monkey that is endemic to the south-east Asian island of Borneo."
                },

                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Text = "Red-shanked Douc",
                    Description = "The red-shanked douc is a species of Old World monkey, among the most colourful of all primates. This monkey is sometimes called the \"costumed ape\" for its extravagant appearance. From its knees to its ankles it sports maroon-red \"stockings\", and it appears to wear white forearm length gloves. Its attire is finished with black hands and feet. The golden face is framed by a white ruff, which is considerably fluffier in males. The eyelids are a soft powder blue. The tail is white with a triangle of white hair at the base. Males of all ages have a white spot on both sides of the corners of the rump patch, and red and white genitals."
                },

                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Text = "Gray-shanked Douc",
                    Description = "The gray-shanked douc langur is a douc species native to the Vietnamese provinces of Quảng Nam, Quảng Ngãi, Bình Định, Kon Tum, and Gia Lai. The total population is estimated at 550 to 700 individuals. In 2016, Dr Benjamin Rawson, Country Director of Fauna & Flora International - Vietnam Programme, announced a discovery of an additional population of more than 500 individuals found in Central Vietnam, bringing the total population up to approximately 1000 individuals."
                },

                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Text = "Golden Snub-nosed Monkey",
                    Description = "The golden snub-nosed monkey is an Old World monkey in the Colobinae subfamily. It is endemic to a small area in temperate, mountainous forests of central and Southwest China. They inhabit these mountainous forests of Southwestern China at elevations of 1,500-3,400 m above sea level. The Chinese name is Sichuan golden hair monkey. It is also widely referred to as the Sichuan snub-nosed monkey. Of the three species of snub-nosed monkeys in China, the golden snub-nosed monkey is the most widely distributed throughout China."
                },

                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Text = "Black Snub-nosed Monkey",
                    Description = "The black snub-nosed monkey, also known as the Yunnan snub-nosed monkey, is an endangered species of primate in the family Cercopithecidae. It is endemic to China, where it is known to the locals as the Yunnan golden hair monkey and the black golden hair monkey. It is threatened by habitat loss. It was named after Bishop Félix Biet."
                },

                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Text = "Tonkin Snub-nosed Monkey",
                    Description = "The Tonkin snub-nosed monkey or Dollman's snub-nosed monkey is a slender-bodied arboreal Old World monkey, endemic to northern Vietnam. It is a black and white monkey with a pink nose and lips and blue patches round the eyes. It is found at altitudes of 200 to 1,200 m (700 to 3,900 ft) on fragmentary patches of forest on craggy limestone areas. First described in 1912, the monkey was rediscovered in 1990 but is exceedingly rare. In 2008, fewer than 250 individuals were thought to exist, and the species was the subject of intense conservation effort. The main threats faced by these monkeys is habitat loss and hunting, and the International Union for Conservation of Nature has rated the species as \"critically endangered\"."
                },

                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Text = "Thomas's Langur",
                    Description = "Thomas's langur is a species of primate in the family Cercopithecidae. It is endemic to North Sumatra, Indonesia. Its natural habitat is subtropical or tropical dry forests. It is threatened by habitat loss. Its native names are reungkah in Acehnese and kedih in Alas."
                },

                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Text = "Purple-faced Langur",
                    Description = "The purple-faced langur, also known as the purple-faced leaf monkey, is a species of Old World monkey that is endemic to Sri Lanka. The animal is a long-tailed arboreal species, identified by a mostly brown appearance, dark face (with paler lower face) and a very shy nature. The species was once highly prevalent, found in suburban Colombo and the \"wet zone\" villages (areas with high temperatures and high humidity throughout the year, whilst rain deluges occur during the monsoon seasons), but rapid urbanization has led to a significant decrease in the population level of the monkeys."
                },

                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Text = "Gelada",
                    Description = "The gelada, sometimes called the bleeding-heart monkey or the gelada baboon, is a species of Old World monkey found only in the Ethiopian Highlands, with large populations in the Semien Mountains. Theropithecus is derived from the Greek root words for \"beast-ape.\" Like its close relatives the baboons, it is largely terrestrial, spending much of its time foraging in grasslands."
                }
            };

            Items = new ObservableCollection<Item>(items.OrderBy(x => x.Text));
        }
    }
}
