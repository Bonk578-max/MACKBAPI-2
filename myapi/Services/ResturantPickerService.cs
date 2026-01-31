using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myapi.Services
{
    public class ResturantPickerService
    {
        public string Picker(string Category)
    {
        if (string.IsNullOrWhiteSpace(Category))
        {
            return "Please choose a category: 'Steakhouse', 'Vegan', or 'Street Food'";
        }

        string restaurant = Category.Trim().ToLowerInvariant();
        Random rng = new Random();

        if (restaurant == "steakhouse")
        {
            string[] steakhouse = new[] {
                "Try Ember & Oak Steakhouse",
                "Try The Sizzling Fork",
                "Try Blackstone Chophouse",
                "Try Iron & Flame Grill",
                "Try The Carver's Table",
                "Try Oakcrest Steak Bar",
                "Try Prime & Plate",
                "Try Copper Skillet Steakhouse",
                "Try The Butcher's Garden",
                "Try Hearthstone Steaks"
            };
            return steakhouse[rng.Next(steakhouse.Length)];
        }

        if (restaurant == "vegan")
        {
            string[] vegan = new[] {
                "Try Green Harbor Vegan Café",
                "Try Garden Pulse Bistro",
                "Try Sprout & Seed",
                "Try Verdant Plate",
                "Try Blossom Leaf Kitchen",
                "Try PureRoot Eatery",
                "Try Herbivore Haven",
                "Try Seedling Social",
                "Try Lush Leaf Lounge",
                "Try Sun & Soil Vegan"
            };
            return vegan[rng.Next(vegan.Length)];
        }

        if (restaurant == "street food")
        {
            string[] streetFood = new[] {
                "Try Rolling Wok Street Eats",
                "Try Midnight Taco Cart",
                "Try Noodle Alley",
                "Try Smoke & Skewer Truck",
                "Try The Fry Stand",
                "Try Banh Mi on Wheels",
                "Try Kebab Corner",
                "Try The Crepe Cart",
                "Try Bao Street",
                "Try Samosa Stop"
            };
            return streetFood[rng.Next(streetFood.Length)];
        }

        return "Please choose a category: 'Steakhouse', 'Vegan', or 'Street Food'";
    }
    }
}