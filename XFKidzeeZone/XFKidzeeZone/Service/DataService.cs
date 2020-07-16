using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using XFKidzeeZone.Models;

namespace XFKidzeeZone.Service
{
    public class DataService
    {
        public static ObservableCollection<Game> GetGames()
        {
            return new ObservableCollection<Game>()
            {
                new Game()
                {
                    name = "Super Mario Bros. 2",
                    company = "Nintendo Co. Ltd",
                    rating = 4.5,
                    image = "mario.png",
                    backgroundStartColor = "#EB507B",
                    backgroundEndColor = "#D92556",
                    genre = "Action",
                    install = 5.3,
                    reviewNumbers = 802,
                    about = "A new kind of Mario game that you can play with one hand. You control Mario by tapping as he constantly runs forward. You time yourtaps to pull off stylish jumps, midair spins, and wall jumps to gather coins and reach the goal!",
                    stars = new List<Star>()
                    {
                        new Star(){ number = 1 },
                        new Star(){ number = 2 },
                        new Star(){ number = 3 },
                        new Star(){ number = 4 },
                        new Star(){ number = 4.5 },
                    },
                    reviews = new List<Review>()
                    {
                        new Review() { order = 1, percentual = 5, progress = 0.05 },
                        new Review() { order = 2, percentual = 10, progress = 0.10 },
                        new Review() { order = 3, percentual = 20, progress = 0.20 },
                        new Review() { order = 4, percentual = 30, progress = 0.30 },
                        new Review() { order = 5, percentual = 48, progress = 0.40 }
                    }.OrderByDescending(p => p.order).ToList()
                },
                new Game()
                {
                    name = "Angry Bird Friends 2.0",
                    company = "Rovio Entertainment",
                    rating = 4,
                    image = "angry_birds.png",
                    backgroundStartColor = "#FBC25F",
                    backgroundEndColor = "#D99825",
                    genre = "Strategy",
                    install = 5.2,
                    reviewNumbers = 901,
                    about = "Play all of the classic bird-flinging, tower-crumbling and pig-popping of the original Angry Birds, condensed into bite-sized, competitive tournaments. Compete with your friends and players around the globe!",
                    stars = new List<Star>()
                    {
                        new Star(){ number = 1 },
                        new Star(){ number = 2 },
                        new Star(){ number = 3 },
                        new Star(){ number = 4 }
                    },
                    reviews = new List<Review>()
                    {
                        new Review() { order = 1, percentual = 4, progress = 0.04 },
                        new Review() { order = 2, percentual = 12, progress = 0.12 },
                        new Review() { order = 3, percentual = 25, progress = 0.25 },
                        new Review() { order = 4, percentual = 38, progress = 0.38 },
                        new Review() { order = 5, percentual = 50, progress = 0.5 }
                    }.OrderByDescending(p => p.order).ToList()
                },
                new Game()
                {
                    name = "Clash of Clans",
                    company = "Supercell",
                    rating = 4.5,
                    image = "clashofclans.png",
                    backgroundStartColor = "#71D7F6",
                    backgroundEndColor = "#13A1CC",
                    genre = "Strategy",
                    install = 7.1,
                    reviewNumbers = 892,
                    about = "Answer the call of the mustache! Join the international fray that is Clash of Clans. Customize your village, build an army and crush your opponents. Like using friendship to strike fear into your enemies? Join a Clan, or establish a Clashing legacy by creating your own. The choice is yours in this millions-strong community of Barbarians. Download for free and Clash on, Chief!",
                    stars = new List<Star>()
                    {
                        new Star(){ number = 1 },
                        new Star(){ number = 2 },
                        new Star(){ number = 3 },
                        new Star(){ number = 4 },
                        new Star(){ number = 4.5 },
                    },
                    reviews = new List<Review>()
                    {
                        new Review() { order = 1, percentual = 10, progress = 0.10 },
                        new Review() { order = 2, percentual = 20, progress = 0.20 },
                        new Review() { order = 3, percentual = 35, progress = 0.35 },
                        new Review() { order = 4, percentual = 45, progress = 0.45 },
                        new Review() { order = 5, percentual = 70, progress = 0.70 }
                    }.OrderByDescending(p => p.order).ToList()
                }
                ,
                new Game()
                {
                    name = "Brawl Stars",
                    company = "Supercell",
                    rating = 4.7,
                    image = "colt.png",
                    backgroundStartColor = "#01C478",
                    backgroundEndColor = "#01C478",
                    genre = "Action",
                    install = 12.4,
                    reviewNumbers = 2302,
                    about = "Fast-paced 3v3 multiplayer and battle royale made for mobile! Play with friends or solo across a variety of game modes in under three minutes.",
                    stars = new List<Star>()
                    {
                        new Star(){ number = 1 },
                        new Star(){ number = 2 },
                        new Star(){ number = 3 },
                        new Star(){ number = 4 },
                        new Star(){ number = 4.5 },
                    },
                    reviews = new List<Review>()
                    {
                        new Review() { order = 1, percentual = 5, progress = 0.05 },
                        new Review() { order = 2, percentual = 1, progress = 0.01 },
                        new Review() { order = 3, percentual = 3, progress = 0.03 },
                        new Review() { order = 4, percentual = 8, progress = 0.08 },
                        new Review() { order = 5, percentual = 84, progress = 0.84 }
                    }.OrderByDescending(p => p.order).ToList()
                },
                new Game()
                {
                    name = "KartRider Rush+",
                    company = "NEXON Company",
                    rating = 4.6,
                    image = "dao.png",
                    backgroundStartColor = "#FF9929",
                    backgroundEndColor = "#FF9929",
                    genre = "Racing",
                    install = 3.5,
                    reviewNumbers = 125,
                    about = "The kart racing sensation enjoyed by over 300M players worldwide is back and better than ever with more style, more game modes, more thrill! Race with friends or just play it solo through a variety of gameplay modes. Collect and upgrade iconic characters and karts from the KartRider universe. Climb the leaderboard ranks and become the ultimate racing legend!",
                    stars = new List<Star>()
                    {
                        new Star(){ number = 1 },
                        new Star(){ number = 2 },
                        new Star(){ number = 3 },
                        new Star(){ number = 4 },
                        new Star(){ number = 4.5 },
                    },
                    reviews = new List<Review>()
                    {
                       new Review() { order = 1, percentual = 8, progress = 0.08 },
                        new Review() { order = 2, percentual = 1, progress = 0.01 },
                        new Review() { order = 3, percentual = 3, progress = 0.03 },
                        new Review() { order = 4, percentual = 6, progress = 0.06 },
                        new Review() { order = 5, percentual = 84, progress = 0.84 }
                    }.OrderByDescending(p => p.order).ToList()
                },
                new Game()
                {
                    name = "Pokémon Go",
                    company = "Niantic, Inc.",
                    rating = 4.1,
                    image = "pikachu.png",
                    backgroundStartColor = "#02EFFF",
                    backgroundEndColor = "#02EFFF",
                    genre = "Strategy",
                    install = 1.4,
                    reviewNumbers = 422,
                    about = "Join Trainers across the globe who are discovering Pokémon as they explore the world around them. Pokémon GO is the global gaming sensation that has been downloaded over 1 billion times and named “Best Mobile Game” by the Game Developers Choice Awards and “Best App of the Year” by TechCrunch.",
                    stars = new List<Star>()
                    {
                        new Star(){ number = 1 },
                        new Star(){ number = 2 },
                        new Star(){ number = 3 },
                        new Star(){ number = 4 }
                    },
                    reviews = new List<Review>()
                    {
                        new Review() { order = 1, percentual = 10, progress = 0.10 },
                        new Review() { order = 2, percentual = 20, progress = 0.20 },
                        new Review() { order = 3, percentual = 35, progress = 0.35 },
                        new Review() { order = 4, percentual = 45, progress = 0.45 },
                        new Review() { order = 5, percentual = 70, progress = 0.70 }
                    }.OrderByDescending(p => p.order).ToList()
                },
                new Game()
                {
                    name = "Minecraft",
                    company = "Mojang",
                    rating = 4.5,
                    image = "steve.png",
                    backgroundStartColor = "#643820",
                    backgroundEndColor = "#643820",
                    genre = "Adventure",
                    install = 30.3,
                    reviewNumbers = 699,
                    about = "Explore infinite worlds and build everything from the simplest of homes to the grandest of castles. Play in creative mode with unlimited resources or mine deep into the world in survival mode, crafting weapons and armor to fend off dangerous mobs. Create, explore and survive alone or play with friends on all different devices.",
                    stars = new List<Star>()
                    {
                        new Star(){ number = 1 },
                        new Star(){ number = 2 },
                        new Star(){ number = 3 },
                        new Star(){ number = 4 },
                        new Star(){ number = 4.5 },
                    },
                    reviews = new List<Review>()
                    {
                        new Review() { order = 1, percentual = 5, progress = 0.05 },
                        new Review() { order = 2, percentual = 10, progress = 0.10 },
                        new Review() { order = 3, percentual = 20, progress = 0.20 },
                        new Review() { order = 4, percentual = 30, progress = 0.30 },
                        new Review() { order = 5, percentual = 48, progress = 0.40 }
                    }.OrderByDescending(p => p.order).ToList()
                },
                new Game()
                {
                    name = "Luigi’s Mansion™ 3",
                    company = "Next Level Games",
                    rating = 4.5,
                    image = "lu2.png",
                    backgroundStartColor = "#10D011",
                    backgroundEndColor = "#10D011",
                    genre = "Adventure",
                    install = 30.3,
                    reviewNumbers = 699,
                    about = "Luigi’s invited to the towering Last Resort hotel, but when Mario and friends go missing, our green-clad hero will have to conquer his fears to save them! Slam, blow away, and vacuum up ghosts with the all-new Poltergust G-00, and join forces with Gooigi to overcome the puzzling contraptions and mischievous boss on each themed floor.",
                    stars = new List<Star>()
                    {
                        new Star(){ number = 1 },
                        new Star(){ number = 2 },
                        new Star(){ number = 3 },
                        new Star(){ number = 4 },
                        new Star(){ number = 4.5 },
                    },
                    reviews = new List<Review>()
                    {
                        new Review() { order = 1, percentual = 5, progress = 0.05 },
                        new Review() { order = 2, percentual = 10, progress = 0.10 },
                        new Review() { order = 3, percentual = 20, progress = 0.20 },
                        new Review() { order = 4, percentual = 30, progress = 0.30 },
                        new Review() { order = 5, percentual = 48, progress = 0.40 }
                    }.OrderByDescending(p => p.order).ToList()
                }
            };
        }

        public static ObservableCollection<BestOfWeek> GetBestOfWeeks()
        {
            return new ObservableCollection<BestOfWeek>()
            {
                new BestOfWeek()
                {
                    name = "Word Show - Legends",
                    company = "Etermax",
                    rating = 4.5,
                    image = "word.png"
                },
                new BestOfWeek()
                {
                    name = "Ludo Club",
                    company = "Moonfrog",
                    rating = 4.2,
                    image = "ludoclub.png"
                },
                new BestOfWeek()
                {
                    name = "Brawl Stars",
                    company = "Supercell",
                    rating = 4.7,
                    image = "brawl.png"
                },
                new BestOfWeek()
                {
                    name = "Pokémon Quest",
                    company = "The Pokemon Company",
                    rating = 4.3,
                    image = "pokemonquest.png"
                },
                new BestOfWeek()
                {
                    name = "Mario Kart Tour",
                    company = "Nintendo Co., Ltd.",
                    rating = 4.7,
                    image = "mariokart.png"
                },
                new BestOfWeek()
                {
                    name = "Candy Crush Saga",
                    company = "King",
                    rating = 4.7,
                    image = "candycrush.png"
                },
                new BestOfWeek()
                {
                    name = "Cookie Run: OvenBreak",
                    company = "Devsisters",
                    rating = 4.8,
                    image = "cookierun.png"
                },
                new BestOfWeek()
                {
                    name = "Minecraft",
                    company = "Mojang",
                    rating = 4.5,
                    image = "minecraft.png"
                },
                new BestOfWeek()
                {
                    name = "Clash Royale",
                    company = "Supercell",
                    rating = 4.7,
                    image = "clashroyal.png"
                },
                new BestOfWeek()
                {
                    name = "FIFA Soccer ",
                    company = "Electronic Arts",
                    rating = 4.6,
                    image = "fifa.png"
                },
                new BestOfWeek()
                {
                    name = "NBA 2K20",
                    company = "2K",
                    rating = 3.3,
                    image = "nba.png"
                },
            };
        }
    }
}
