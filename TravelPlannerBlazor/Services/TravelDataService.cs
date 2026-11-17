using TravelPlannerBlazor.Models;

namespace TravelPlannerBlazor.Services;

public class TravelDataService
{
    public List<string> GetDivisions() => new()
    {
        "All", "Dhaka", "Chattogram", "Sylhet", "Rajshahi", "Khulna", "Barishal", "Rangpur", "Mymensingh"
    };

    public List<Destination> GetDestinations() => new()
    {
        new Destination
        {
            Id = 1,
            Name = "Lalbagh Fort",
            Division = "Dhaka",
            District = "Dhaka",
            Category = "Historical",
            ImageUrl = "Images/lalbagh.png",
            Description = "17th-century Mughal fort complex standing proudly by the Buriganga River.",
            IdealDuration = "Half Day (4-5 Hours)",
            EstimatedCostPerPerson = 500,
            Activities = new() { "Historical Sightseeing", "Photography", "Museum Visit" }
        },
        new Destination
        {
            Id = 2,
            Name = "Cox's Bazar Sea Beach",
            Division = "Chattogram",
            District = "Cox's Bazar",
            Category = "Beach & Nature",
            ImageUrl = "https://images.unsplash.com/photo-1582650625119-3a31f8fa2699?w=800&auto=format&fit=crop",
            Description = "The longest natural unbroken sea beach in the world with golden sand and vibrant waves.",
            IdealDuration = "3 Days, 2 Nights",
            EstimatedCostPerPerson = 6500,
            Activities = new() { "Beach Walking", "Parasailing", "Marine Drive Tour", "Seafood Tasting" }
        },
        new Destination
        {
            Id = 3,
            Name = "Ratargul Swamp Forest",
            Division = "Sylhet",
            District = "Sylhet",
            Category = "Nature & Adventure",
            ImageUrl = "https://images.unsplash.com/photo-1596895111956-bf1cf0599ce5?w=800&auto=format&fit=crop",
            Description = "One of the few freshwater swamp forests in the world, famous for boat rides through submerged trees.",
            IdealDuration = "2 Days, 1 Night",
            EstimatedCostPerPerson = 4500,
            Activities = new() { "Country Boat Ride", "Watchtower View", "Bird Watching" }
        },
        new Destination
        {
            Id = 4,
            Name = "Somapura Mahavihara (Paharpur)",
            Division = "Rajshahi",
            District = "Naogaon",
            Category = "Historical",
            ImageUrl = "Images/paharpur.png",
            Description = "UNESCO World Heritage Site and one of the most famous Buddhist Viharas in the Indian Subcontinent.",
            IdealDuration = "1 Day",
            EstimatedCostPerPerson = 2000,
            Activities = new() { "Archaeological Exploration", "Museum Tour", "Photography" }
        },
        new Destination
        {
            Id = 5,
            Name = "Sundarbans Mangrove Forest",
            Division = "Khulna",
            District = "Bagerhat / Khulna",
            Category = "Wildlife & Nature",
            ImageUrl = "https://images.unsplash.com/photo-1544735716-392fe2489ffa?w=800&auto=format&fit=crop",
            Description = "The largest mangrove forest in the world and home to the Royal Bengal Tiger.",
            IdealDuration = "3 Days, 2 Nights",
            EstimatedCostPerPerson = 9500,
            Activities = new() { "Ship Cruise", "Canal Boat Safari", "Wildlife Spotting", "Karamjal Eco-Park" }
        },
        new Destination
        {
            Id = 6,
            Name = "Ahsan Manzil (Pink Palace)",
            Division = "Dhaka",
            District = "Dhaka",
            Category = "Historical",
            ImageUrl = "Images/AhsanManjil.png",
            Description = "The former official residential palace and seat of the Nawab of Dhaka, famous for its iconic pink facade along the Buriganga River.",
            IdealDuration = "Half Day (3-4 Hours)",
            EstimatedCostPerPerson = 400,
            Activities = new() { "Palace Museum Tour", "Riverbank Walk", "Architectural Photography" }
        },
        new Destination
        {
            Id = 7,
            Name = "Sonargaon & Panam City",
            Division = "Dhaka",
            District = "Narayanganj",
            Category = "Historical",
            ImageUrl = "Images/PanamCity.png",
            Description = "An ancient administrative capital of Bengal featuring preserved 19th-century merchant buildings and the Folk Art and Crafts Museum.",
            IdealDuration = "1 Day",
            EstimatedCostPerPerson = 1200,
            Activities = new() { "Heritage Walk", "Folk Art Museum Visit", "Boating", "Photography" }
        },
        new Destination
        {
            Id = 8,
            Name = "Armenian Church",
            Division = "Dhaka",
            District = "Dhaka",
            Category = "Historical",
            ImageUrl = "Images/Armenia.png",
            Description = "Built in 1781 in Armanitola, this historic church stands as a reminder of the vibrant Armenian trading community in Old Dhaka.",
            IdealDuration = "2 Hours",
            EstimatedCostPerPerson = 300,
            Activities = new() { "Historical Sightseeing", "Old Dhaka Food Tour", "Photography" }
        },
        new Destination
        {
            Id = 9,
            Name = "Bara Katra & Choto Katra",
            Division = "Dhaka",
            District = "Dhaka",
            Category = "Historical",
            ImageUrl = "Images/BaraKatra.png",
            Description = "17th-century Mughal caravanserai relics located near Chawkbazar, showcasing classic Mughal gateway architecture.",
            IdealDuration = "2-3 Hours",
            EstimatedCostPerPerson = 300,
            Activities = new() { "Heritage Exploration", "Old Dhaka Street Food", "Photography" }
        },
        new Destination
        {
            Id = 10,
            Name = "Star Mosque (Tara Masjid)",
            Division = "Dhaka",
            District = "Dhaka",
            Category = "Historical",
            ImageUrl = "Images/StarMosque.png",
            Description = "A 19th-century mosque in Armanitola decorated with intricate blue star motifs made from Chinitikri mosaic work.",
            IdealDuration = "1-2 Hours",
            EstimatedCostPerPerson = 250,
            Activities = new() { "Architectural Sightseeing", "Cultural Visit", "Photography" }
        },
        new Destination
        {
            Id = 11,
            Name = "Curzon Hall",
            Division = "Dhaka",
            District = "Dhaka",
            Category = "Historical",
            ImageUrl = "Images/KarzonHall.png",
            Description = "A grand red-brick landmark blending Mughal and European architecture, originally built as a town hall in 1904 and now part of the University of Dhaka.",
            IdealDuration = "2 Hours",
            EstimatedCostPerPerson = 200,
            Activities = new() { "Campus Walk", "Architectural Photography", "Botanical Garden Visit" }
        },
        new Destination
        {
            Id = 12,
            Name = "Mahasthangarh",
            Division = "Rajshahi",
            District = "Bogura",
            Category = "Historical",
            ImageUrl = "Images/Mahasthangarh.png",
            Description = "One of the earliest urban archaeological sites in Bangladesh, dating back to at least the 3rd century BC, featuring ancient citadel ruins and a museum.",
            IdealDuration = "1 Day",
            EstimatedCostPerPerson = 1500,
            Activities = new() { "Archaeological Tour", "Museum Visit", "Govinda Bhita Exploration", "Photography" }
        },
        new Destination
        {
            Id = 13,
            Name = "Puthia Temple Complex",
            Division = "Rajshahi",
            District = "Rajshahi",
            Category = "Historical",
            ImageUrl = "Images/BaghaTemple.png",
            Description = "A cluster of notable old Hindu temples featuring exquisite terracotta ornamentation, located beside a serene lake and Rajbari.",
            IdealDuration = "Half Day (4-5 Hours)",
            EstimatedCostPerPerson = 1000,
            Activities = new() { "Temple Architecture Tour", "Terracotta Sightseeing", "Lakeside Walk", "Photography" }
        },
        new Destination
        {
            Id = 14,
            Name = "Natore Rajbari (Uttara Ganabhaban)",
            Division = "Rajshahi",
            District = "Natore",
            Category = "Historical",
            ImageUrl = "Images/UttaraGonobhobon.png",
            Description = "An 18th-century royal palace complex surrounded by moats and lush Italian-style gardens, famous as the estate of Rani Bhabani.",
            IdealDuration = "Half Day (3-4 Hours)",
            EstimatedCostPerPerson = 1200,
            Activities = new() { "Palace Heritage Walk", "Garden Sightseeing", "Tasting Kachagolla", "Photography" }
        },
        new Destination
        {
            Id = 15,
            Name = "Bagha Mosque",
            Division = "Rajshahi",
            District = "Rajshahi",
            Category = "Historical",
            ImageUrl = "Images/BaghaMosque.png",
            Description = "Built in 1523 by Sultan Nusrat Shah, this historic brick mosque is renowned for its intricate terracotta floral and geometric carvings.",
            IdealDuration = "2-3 Hours",
            EstimatedCostPerPerson = 800,
            Activities = new() { "Historical Sightseeing", "Terracotta Art Study", "Big Pond Visit" }
        },
        new Destination
        {
            Id = 16,
            Name = "Varendra Research Museum",
            Division = "Rajshahi",
            District = "Rajshahi",
            Category = "Historical & Cultural",
            ImageUrl = "Images/BarendraResearchMuseum.png",
            Description = "The oldest museum in Bangladesh (established in 1910), housing rare Pala-Sena sculptures, ancient inscriptions, and medieval artifacts.",
            IdealDuration = "2-3 Hours",
            EstimatedCostPerPerson = 500,
            Activities = new() { "Museum Tour", "Historical Research", "Padma Riverbank Visit" }
        },
        new Destination
        {
            Id = 17,
            Name = "Choto Sona Mosque",
            Division = "Rajshahi",
            District = "Chapainawabganj",
            Category = "Historical",
            ImageUrl = "Images/ChotoSonaMosque.png",
            Description = "A 15th-century Sultanate-era stone-faced mosque known as the 'Gem of Sultanate Architecture' with finely carved stone motifs.",
            IdealDuration = "Half Day (3-4 Hours)",
            EstimatedCostPerPerson = 1200,
            Activities = new() { "Heritage Exploration", "Stone Carving Photography", "Mango Orchard Visit (Seasonal)" }
            },
        new Destination
            {
                Id = 18,
                Name = "Saint Martin's Island",
                Division = "Chattogram",
                District = "Cox's Bazar",
                Category = "Island & Beach",
                ImageUrl = "Images/SaintMartinIsland.png",
                Description = "The only coral island in Bangladesh, famous for crystal-clear blue waters, coconut groves, and fresh seafood.",
                IdealDuration = "3 Days, 2 Nights",
                EstimatedCostPerPerson = 8500,
                Activities = new() { "Ship Cruise", "Chera Dwip Boat Trip", "Snorkeling", "Cycling on Beach", "Stargazing" }
            },
            new Destination
            {
                Id = 19,
                Name = "Sajek Valley",
                Division = "Chattogram",
                District = "Rangamati",
                Category = "Hills & Nature",
                ImageUrl = "Images/SajekValley.png",
                Description = "Known as the 'Queen of Hills' and 'Roof of Rangamati', famous for floating clouds above lush green mountain peaks.",
                IdealDuration = "3 Days, 2 Nights",
                EstimatedCostPerPerson = 6000,
                Activities = new() { "Chander Gari Jeep Ride", "Konglak Para Trek", "Cloud Watching", "Campfire & Bamboo Chicken" }
            },
            new Destination
            {
                Id = 20,
                Name = "Kaptai Lake & Hanging Bridge",
                Division = "Chattogram",
                District = "Rangamati",
                Category = "Lake & Nature",
                ImageUrl = "Images/KaptaiLake.png",
                Description = "The largest man-made lake in Bangladesh, surrounded by green hills, tribal villages, and the iconic 335-foot suspension bridge.",
                IdealDuration = "2 Days, 1 Night",
                EstimatedCostPerPerson = 4000,
                Activities = new() { "Lake Boat Cruise", "Hanging Bridge Walk", "Shuvolong Waterfall Visit", "Kayaking" }
            },
            new Destination
            {
                Id = 21,
                Name = "Nilgiri & Nilachal",
                Division = "Chattogram",
                District = "Bandarban",
                Category = "Hills & Adventure",
                ImageUrl = "Images/NilgiriNilachal.png",
                Description = "One of the highest tourist resorts in Bangladesh offering breathtaking panoramic views of mist-covered Bandarban hills.",
                IdealDuration = "3 Days, 2 Nights",
                EstimatedCostPerPerson = 6500,
                Activities = new() { "Hilltop Sightseeing", "Chander Gari Safari", "Boga Lake Trek", "Chimbuk Hill Visit" }
            },
            new Destination
            {
                Id = 22,
                Name = "Mainamati & Shalban Vihara",
                Division = "Chattogram",
                District = "Cumilla",
                Category = "Historical",
                ImageUrl = "Images/MainamatiShalbanBihara.png",
                Description = "An ancient 8th-century Buddhist archaeological site built by King Bhavadeva, featuring terracotta plaques and a rich museum.",
                IdealDuration = "1 Day",
                EstimatedCostPerPerson = 1500,
                Activities = new() { "Archaeological Tour", "Mainamati Museum Visit", "War Cemetery Visit", "Rasmalai Tasting" }
            },
            new Destination
            {
                Id = 23,
                Name = "Foy's Lake & Ethnological Museum",
                Division = "Chattogram",
                District = "Chattogram",
                Category = "Historical & Leisure",
                ImageUrl = "Images/foys_lake.png",
                Description = "A historic man-made lake dug in 1924 alongside Bangladesh's only Ethnological Museum showcasing indigenous heritage.",
                IdealDuration = "1 Day",
                EstimatedCostPerPerson = 2000,
                Activities = new() { "Lake Boating", "Ethnological Museum Tour", "Patenga Beach Sunset", "Cable Car Ride" }
            },
            new Destination
            {
                Id = 24,
                Name = "Sitakunda Eco Park & Chandranath Hill",
                Division = "Chattogram",
                District = "Chattogram",
                Category = "Hills & Waterfall",
                ImageUrl = "Images/sitakunda.png",
                Description = "A scenic trekking destination featuring waterfalls, botanical gardens, and the ancient Chandranath Temple atop a 1,020-foot peak.",
                IdealDuration = "1 Day",
                EstimatedCostPerPerson = 1800,
                Activities = new() { "Hill Trekking", "Khoiyachora Waterfall Trail", "Guliakhali Sea Beach Visit" }
            },            
        new Destination
        {
            Id = 25,
            Name = "Jaflong & Zero Point",
            Division = "Sylhet",
            District = "Sylhet",
            Category = "Nature & River",
            ImageUrl = "Images/jaflong.png",
            Description = "Located at the foothills of the Meghalaya mountains, famous for crystal-clear river waters, rolling stones, and scenic hanging bridges.",
            IdealDuration = "1 Day",
            EstimatedCostPerPerson = 1800,
            Activities = new() { "Piyain River Boat Ride", "Stone Collection Sightseeing", "Khasia Tribal Village Visit", "Photography" }
        },
        new Destination
        {
            Id = 26,
            Name = "Sada Pathor (Bholaganj)",
            Division = "Sylhet",
            District = "Sylhet",
            Category = "Nature & River",
            ImageUrl = "Images/sada_pathor.png",
            Description = "A breathtaking riverbed covered in smooth white stones with turquoise water flowing straight down from the Indian hills.",
            IdealDuration = "1 Day",
            EstimatedCostPerPerson = 1500,
            Activities = new() { "Engine Boat Ride", "Swimming in Clear Water", "Border Hill View", "Photography" }
        },
        new Destination
        {
            Id = 27,
            Name = "Srimangal Tea Gardens & Lawachara",
            Division = "Sylhet",
            District = "Moulvibazar",
            Category = "Nature & Wildlife",
            ImageUrl = "Images/srimangal.png",
            Description = "The tea capital of Bangladesh featuring rolling green tea estates, Lawachara Rainforest, and the famous Seven-Layer Tea.",
            IdealDuration = "2 Days, 1 Night",
            EstimatedCostPerPerson = 4200,
            Activities = new() { "Tea Garden Cycling", "Lawachara Rainforest Trek", "Seven-Layer Tea Tasting", "Baikka Beel Bird Watching" }
        },
        new Destination
        {
            Id = 28,
            Name = "Tanguar Haor & Niladri Lake",
            Division = "Sylhet",
            District = "Sunamganj",
            Category = "Wetland & Adventure",
            ImageUrl = "Images/TanguarHaor.png",
            Description = "A vast freshwater wetland ecosystem bordering the Meghalaya hills, famous for overnight houseboat stays and turquoise limestone lakes.",
            IdealDuration = "2 Days, 1 Night",
            EstimatedCostPerPerson = 5500,
            Activities = new() { "Houseboat Overnight Stay", "Niladri Lake Sightseeing", "Watchtower View", "Barikka Tila & Jadukata River" }
        },
        new Destination
        {
            Id = 29,
            Name = "Bichnakandi",
            Division = "Sylhet",
            District = "Sylhet",
            Category = "Nature & Hills",
            ImageUrl = "Images/bichnakandi.png",
            Description = "A picturesque meeting point of several mountain streams flowing over rocky beds amidst dramatic green hills.",
            IdealDuration = "1 Day",
            EstimatedCostPerPerson = 1600,
            Activities = new() { "Boat Safari", "Riverbed Walk", "Mountain Stream Bathing", "Photography" }
        },
        new Destination
        {
            Id = 30,
            Name = "Madhabkunda Waterfall",
            Division = "Sylhet",
            District = "Moulvibazar",
            Category = "Waterfall & Nature",
            ImageUrl = "Images/madhabkunda.png",
            Description = "One of the largest waterfalls in Bangladesh, surrounded by lush green hills, tea estates, and eco-park trails.",
            IdealDuration = "1 Day",
            EstimatedCostPerPerson = 2000,
            Activities = new() { "Waterfall Sightseeing", "Eco-Park Walk", "Hakaluki Haor Visit", "Photography" }
        },
        new Destination
        {
            Id = 31,
            Name = "Hazrat Shahjalal Mazar & Keane Bridge",
            Division = "Sylhet",
            District = "Sylhet",
            Category = "Historical & Heritage",
            ImageUrl = "Images/ShahjalalMazar.png",
            Description = "The historic 14th-century shrine of Sufi saint Hazrat Shahjalal alongside the iconic 1936 steel arch Keane Bridge and Ali Amjad's Clock.",
            IdealDuration = "Half Day (3-4 Hours)",
            EstimatedCostPerPerson = 500,
            Activities = new() { "Heritage Walk", "Surma Riverbank Evening", "Historical Sightseeing", "Local Sylheti Cuisine" }
        },
        new Destination
        {
            Id = 32,
            Name = "Sixty Dome Mosque (Shat Gombuj Masjid)",
            Division = "Khulna",
            District = "Bagerhat",
            Category = "Historical",
            ImageUrl = "Images/ShatGombuj.png",
            Description = "A 15th-century UNESCO World Heritage Site built by Khan Jahan Ali, famous as the largest historic brick mosque in Bangladesh with 77 low domes.",
            IdealDuration = "Half Day (3-4 Hours)",
            EstimatedCostPerPerson = 1200,
            Activities = new() { "UNESCO Heritage Tour", "Bagerhat Museum Visit", "Ghora Dighi Sightseeing", "Photography" }
        },
        new Destination
        {
            Id = 33,
            Name = "Shrine of Khan Jahan Ali & Nine Dome Mosque",
            Division = "Khulna",
            District = "Bagerhat",
            Category = "Historical",
            ImageUrl = "Images/khan_jahan_mazar.png",
            Description = "The 15th-century tomb complex of Sufi warrior-saint Khan Jahan Ali beside Thakur Dighi, surrounded by Sultanate-era mosques.",
            IdealDuration = "3-4 Hours",
            EstimatedCostPerPerson = 1000,
            Activities = new() { "Historical Sightseeing", "Nine Dome Mosque Visit", "Kodla Math Exploration", "Photography" }
        },
        new Destination
        {
            Id = 34,
            Name = "Shilaidaha Kuthibari",
            Division = "Khulna",
            District = "Kushtia",
            Category = "Historical & Cultural",
            ImageUrl = "Images/shilaidaha_kuthibari.png",
            Description = "The historic country estate of Nobel laureate Rabindranath Tagore where he wrote many of his famous poems and translated Gitanjali.",
            IdealDuration = "1 Day",
            EstimatedCostPerPerson = 1500,
            Activities = new() { "Tagore Museum Tour", "Padma Riverbank Walk", "Lalon Shah Mazar Visit", "Photography" }
        },
        new Destination
        {
            Id = 35,
            Name = "Mujibnagar Memorial Complex",
            Division = "Khulna",
            District = "Meherpur",
            Category = "Historical",
            ImageUrl = "Images/mujibnagar.png",
            Description = "The historic site where the first provisional government of independent Bangladesh took oath on April 17, 1971, featuring a 23-pillar monument.",
            IdealDuration = "Half Day (4-5 Hours)",
            EstimatedCostPerPerson = 1400,
            Activities = new() { "Liberation War Memorial Tour", "Historical Map & Sculpture Walk", "Amjhupi Neelkuthi Visit" }
        },
        new Destination
        {
            Id = 36,
            Name = "Bharat Bhayna Buddhist Stupa",
            Division = "Khulna",
            District = "Jashore",
            Category = "Historical & Archaeological",
            ImageUrl = "Images/bharat_bhayna.png",
            Description = "An ancient 5th-century Gupta-period terracotta Buddhist monastery ruin located along the Bhadra River.",
            IdealDuration = "3 Hours",
            EstimatedCostPerPerson = 1000,
            Activities = new() { "Archaeological Exploration", "Terracotta Relic Sightseeing", "Michael Madhusudan Bari Visit (Sagardari)" }
        },
        new Destination
        {
            Id = 37,
            Name = "Rabindra Complex (Dakkhindihi)",
            Division = "Khulna",
            District = "Khulna",
            Category = "Historical & Heritage",
            ImageUrl = "Images/dakkhindihi.png",
            Description = "The ancestral home of Rabindranath Tagore's in-laws in Phultala, preserved as a heritage museum surrounded by gardens.",
            IdealDuration = "2-3 Hours",
            EstimatedCostPerPerson = 800,
            Activities = new() { "Heritage House Tour", "Garden Walk", "Rupsha Riverfront Evening" }
        },
        new Destination
        {
            Id = 38,
            Name = "Kantajew Temple (Kantanagar)",
            Division = "Rangpur",
            District = "Dinajpur",
            Category = "Historical",
            ImageUrl = "Images/kantajew.png", 
            Description = "An iconic 18th-century late-medieval Hindu temple famous for its intricate terracotta plaques depicting epic stories.",
            IdealDuration = "Half Day (3-4 Hours)",
            EstimatedCostPerPerson = 1200,
            Activities = new() { "Terracotta Art Observation", "Historical Photography", "Dhepa River Walk" }
        },
        new Destination
        {
            Id = 39,
            Name = "Tajhat Palace (Tajhat Rajbari)",
            Division = "Rangpur",
            District = "Rangpur",
            Category = "Historical",
            ImageUrl = "Images/tajhat.png",
            Description = "A magnificent early 20th-century palace built by Maharaja Kumar Gopal Lal Roy, now serving as a museum.",
            IdealDuration = "Half Day (3-4 Hours)",
            EstimatedCostPerPerson = 800,
            Activities = new() { "Palace Architecture Tour", "Museum Visit", "Garden Stroll" }
        },
        new Destination
            {
            Id = 40,
            Name = "Guthia Mosque",
            Division = "Barishal",
            District = "Barishal",
            Category = "Historical",
            ImageUrl = "Images/guthia.png",
            Description = "A magnificent architectural landmark featuring a vast courtyard, minarets, and peaceful lakeside surroundings.",
            IdealDuration = "Half Day (3-4 Hours)",
            EstimatedCostPerPerson = 600,
            Activities = new() { "Architecture Viewing", "Photography", "Evening Walk" }
            },
            new Destination
            {
            Id = 41,
            Name = "Durga Sagar Dighi",
                Division = "Barishal",
                District = "Barishal",
                Category = "Historical & Nature",
                ImageUrl = "Images/durgasagar.png",
                Description = "The largest historical pond in southern Bangladesh, excavated in 1780, featuring a scenic central island and migratory birds.",
                IdealDuration = "Half Day (3-4 Hours)",
                EstimatedCostPerPerson = 500,
                Activities = new() { "Sightseeing", "Bird Watching", "Boating", "Picnic" }
            },
            new Destination
            {
                Id = 42,
                Name = "Lakhutia Zamindar Bari",
                Division = "Barishal",
                District = "Barishal",
                Category = "Historical",
                ImageUrl = "Images/lakhutia.png",
                Description = "An 18th-century zamindar estate showcasing classic Indo-European architecture, ancient temples, and historic ponds.",
                IdealDuration = "Half Day (2-3 Hours)",
                EstimatedCostPerPerson = 400,
                Activities = new() { "Heritage Walk", "Photography", "Historical Exploration" }
            },
            new Destination
            {
                Id = 43,
                Name = "Bibi Chini Mosque",
                Division = "Barishal",
                District = "Barguna",
                Category = "Historical",
                ImageUrl = "Images/bibichini.png",
                Description = "A 17th-century Mughal-era single-domed mosque perched atop a 30-foot-high artificial mound.",
                IdealDuration = "Half Day (3-4 Hours)",
                EstimatedCostPerPerson = 800,
                Activities = new() { "Historical Sightseeing", "Photography" }
            }
    };

    public List<TourPackage> GetPackages() => new()
    {
        new TourPackage
        {
            Id = 101,
            PackageName = "Sylhet Nature & Tea Garden Escape",
            Division = "Sylhet",
            Duration = "3 Days, 2 Nights",
            PricePerPerson = 5500,
            ImageUrl = "https://images.unsplash.com/photo-1596895111956-bf1cf0599ce5?w=800&auto=format&fit=crop",
            IncludedFeatures = new() { "AC Bus Ticket", "3-Star Resort", "Breakfast & Dinner", "Boat Ride Fees" }
        },
        new TourPackage
        {
            Id = 102,
            PackageName = "Cox's Bazar & Saint Martin Combo",
            Division = "Chattogram",
            Duration = "4 Days, 3 Nights",
            PricePerPerson = 8500,
            ImageUrl = "https://images.unsplash.com/photo-1582650625119-3a31f8fa2699?w=800&auto=format&fit=crop",
            IncludedFeatures = new() { "Sleeper Coach", "Beachfront Hotel", "Ship Ticket", "All Meals" }
        }

    };
}