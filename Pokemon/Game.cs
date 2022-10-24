using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Game
    {
        YourPokemons selectedPokemon { get; set; }
        WildPokemons wildPokemon { get; set; }
        public string placeExploring { get; set; }
        List<PokemonAll> YourPokeList = new List<PokemonAll>();
        List<WildPokemons> WildList = new List<WildPokemons>();
        List<WildPokemons> ForestList = new List<WildPokemons>();
        List<WildPokemons> OceanList = new List<WildPokemons>();
        List<WildPokemons> VoulcanList = new List<WildPokemons>();


        WildPokemons Growlithe = new WildPokemons("Growlithe", "Fire", 6, "Easy");
        WildPokemons Ponyta = new WildPokemons("Ponyta", "Fire", 5, "Easy");
        WildPokemons Cyndaquil = new WildPokemons("Cyndaquil", "Fire", 6, "Easy");
        WildPokemons Paras = new WildPokemons("Paras", "Plant", 3, "Easy");
        WildPokemons Chikorita = new WildPokemons("Chikorita", "Plant", 6, "Easy");
        WildPokemons Hoppip = new WildPokemons("Hoppip", "Plant", 6, "Easy");
        WildPokemons Poliwag = new WildPokemons("Poliwag", "Water", 4, "Easy");
        WildPokemons Tentacool = new WildPokemons("Tentacool", "Water", 6, "Easy");
        
       





        public Game()
        {
            WildList.Add(Growlithe);
            WildList.Add(Cyndaquil);    
            WildList.Add(Paras);
            WildList.Add(Poliwag);
            WildList.Add(Tentacool);
            WildList.Add(Ponyta);
            WildList.Add(Chikorita);
            WildList.Add(Hoppip);

            MainMenu();
        }

        public void MainMenu()
        {
            Console.WriteLine("Choose a Pokemon");
            Console.WriteLine("A - Squirtle!");
            Console.WriteLine("B - Bulbasaur!");
            Console.WriteLine("C - Charmander!");
            var YourChoice = Console.ReadLine();

            if (YourChoice == "A" || YourChoice == "a")
            {

               PokeChoice("Squirtle");

                FindPokemons(GotoPlaces(Explore()));


            }

            else if (YourChoice == "B" || YourChoice == "b")
            {
                PokeChoice("Bulbasaur");
                FindPokemons(GotoPlaces(Explore()));

            }

            else if (YourChoice == "C" || YourChoice == "c")
            {
            PokeChoice("Charmander");
                FindPokemons(GotoPlaces(Explore()));
            }

            else
            {
                Console.WriteLine("Invalid choice, choose again");
                Console.WriteLine("Choose a Pokemon");
                Console.WriteLine("A - Squirtle!");
                Console.WriteLine("B - Bulbasaur!");
                Console.WriteLine("C - Charmander!");
                YourChoice = Console.ReadLine();
                MainMenu();

            }

        }
        

    public  void PokeChoice(string pokeUchose)
    {

        var pokeType = " ";
        Console.WriteLine($"You chose {pokeUchose} ! Congratulations!");
        Console.WriteLine("Choose the name of your Pokemon");
        var pokename = Console.ReadLine();
        if (pokename == null)
        { pokename = " "; }

        if (pokeUchose == "Squirtle")
        { pokeType = "Water"; }

        else if (pokeUchose == "Bulbasaur")
        { pokeType = "Plant"; }

        else if (pokeUchose == "Charmander")
        { pokeType = "Fire"; }


        selectedPokemon = new YourPokemons(pokename, pokeUchose, pokeType, 10);
     
        YourPokeList.Add(selectedPokemon);

            Console.WriteLine(YourPokeList.Count);

            Console.WriteLine($" Your {selectedPokemon.Name} is now called {selectedPokemon.YourPokemonName}! and is a type : {pokeType}");
        }

    public  string Explore()
    {
        Console.WriteLine("\n");
        Console.WriteLine("Now that you are ready, lets catch some Pokemon!");
        Console.WriteLine("Where do you want to explore?");
        Console.WriteLine("A - Forest(plant)");
        Console.WriteLine("B - Ocean (water)");
        Console.WriteLine("C - Voulcan (fire)");
        var exploreChoice = Console.ReadLine();
        if (exploreChoice == null)
        { exploreChoice = ""; }
        return exploreChoice;
    }

    public  string GotoPlaces(string placechoice)
    {
        if (placechoice == "A" || placechoice == "a")
        {
            Console.WriteLine("\n");
            Console.WriteLine("Welcome to the FOREST!");
                placeExploring = "forest";
                return placeExploring;
        }
            else if (placechoice == "B" || placechoice == "b")
            {
                Console.WriteLine("\n");
                Console.WriteLine("Welcome to the OCEAN!");
                placeExploring = "ocean";
                return placeExploring;
            }
            else if(placechoice == "C" || placechoice == "c")
            {
                Console.WriteLine("\n");
                Console.WriteLine("Welcome to the VOULCAN!");
                placeExploring = "voulcan";
                return placeExploring;
            }
            else  
            {
                Console.WriteLine("\n");
                Console.WriteLine("Invalid choice");
                Console.WriteLine("Where do you want to explore?");
                Console.WriteLine("A - Forest(plant)");
                Console.WriteLine("B - Ocean (water)");
                Console.WriteLine("C - Voulcan (fire)");
                var exploreChoice = Console.ReadLine();
                if (exploreChoice == null)
                { exploreChoice = ""; }
                return exploreChoice;
            }

        
        }

        public void FindPokemons(string pE)
        {
            Random r = new Random();
            int someRandomN;
            if (pE == "forest")
            {
                ForestList = WildList.FindAll(x => x.Type == "Plant");
               
                someRandomN = r.Next(0, ForestList.Count);
                wildPokemon = ForestList[someRandomN];
                FightorIgnore(writingOptions(wildPokemon), wildPokemon.Type);

            }
            else if (pE == "ocean")
            {
                OceanList = WildList.FindAll(x => x.Type == "Water");

                someRandomN = r.Next(0, OceanList.Count);
                wildPokemon = OceanList[someRandomN];
                FightorIgnore(writingOptions(wildPokemon), wildPokemon.Type);

            }
            else if (pE == "voulcan")
            {
                VoulcanList = WildList.FindAll(x => x.Type == "Fire");

                someRandomN = r.Next(0, VoulcanList.Count);
                wildPokemon = VoulcanList[someRandomN];
                FightorIgnore(writingOptions(wildPokemon),wildPokemon.Type);

            }


        }

          string writingOptions(WildPokemons wildPk)
        {
            Console.WriteLine($"You found a wild:**** {wildPk.Name} **** Type: {wildPk.Type}");
            Console.WriteLine("You have 2 choices");
            Console.WriteLine("A - Fight");
            Console.WriteLine("B - Ignore");
            var playerFightDecision = Console.ReadLine();
            return playerFightDecision;
        }

        public void FightorIgnore(string AorBorInvalid, string WpkType)
        {
            if(AorBorInvalid == "A" || AorBorInvalid == "a")
            {

                AdvantagesorDisadvantages(WpkType);
                Fight();

            }
            else if(AorBorInvalid == "B" || AorBorInvalid == "b")
            { FindPokemons(GotoPlaces(Explore())); }
        }

        public void AdvantagesorDisadvantages(string wildPkmType)
        {
            Console.WriteLine("You decided to Fight!");
            if (wildPkmType == "Plant" && selectedPokemon.Type =="Fire" || wildPkmType =="Fire" && selectedPokemon.Type == "Water" 
                || wildPkmType =="Water" && selectedPokemon.Type =="Plant")
            {
                Console.WriteLine($"Your Pokemon type is {selectedPokemon.Type} and it has advantage against {wildPokemon.Name} Type: {wildPkmType}");
                selectedPokemon.Attack += 5;
                wildPokemon.Attack -= 1;
               
                
            }

            else if (wildPkmType == "Fire" && selectedPokemon.Type == "Plant" || wildPkmType == "Water" && selectedPokemon.Type == "Fire"
                || wildPkmType == "Plant" && selectedPokemon.Type == "Water")
            {

                Console.WriteLine($"Your Pokemon type is {selectedPokemon.Type} and it has disadvantage against {wildPokemon.Name} Type: {wildPkmType}");
                selectedPokemon.Attack -= 1;
                wildPokemon.Attack += 5;

            }
            else
            {
                Console.WriteLine($"Your Pokemon type is {selectedPokemon.Type} and it has neither advantage or disadvantage against {wildPokemon.Name} Type: {wildPkmType}");
            }
                 
        }

        public void Fight()
        {
           while(wildPokemon.Health >=0 || selectedPokemon.Health >= 0)
            {
                

                

                    int yourAttack = selectedPokemon.PokeAttack();
                wildPokemon.Health -= yourAttack;

                if (wildPokemon.Health < 0)
                {
                    wildPokemon.Health = 0;
                    Console.WriteLine("\n");
                    Console.WriteLine($"You gave {yourAttack} of damage to {wildPokemon.Name}! {wildPokemon.Name} has {wildPokemon.Health} of health ");
                    CatchPokemon();



                    break;
                }

                Console.WriteLine("\n");
                Console.WriteLine($"You gave {yourAttack} of damage to {wildPokemon.Name}! {wildPokemon.Name} has {wildPokemon.Health} of health ");
               
                    int wildPknAttack = wildPokemon.PokeAttack();
                    selectedPokemon.Health -= wildPknAttack;

                if (selectedPokemon.Health < 0)
                {
                    selectedPokemon.Health = 0;
                    Console.WriteLine($" {wildPokemon.Name} took {wildPknAttack} of damage at you! You now have {selectedPokemon.Health} of health");
                    break;
                }

                Console.WriteLine("\n");
                    Console.WriteLine($" {wildPokemon.Name} took {wildPknAttack} of damage at you! You now have {selectedPokemon.Health} of health");
               
               
            }
            
            
        }

        public void CatchPokemon()
        {
            Console.WriteLine("\n");
            Console.WriteLine($"You won! Press any button to throw a pokeball!");
            Console.ReadLine();
            Console.WriteLine($"Pokeball has been thrown!");

            Random random = new Random();
            int RandomN = random.Next(0, 10);
            if(RandomN <= 8)
            {
                Console.WriteLine($"You managed to capture {wildPokemon.Name}! Congratulations");
                YourPokeList.Add(wildPokemon);
                Console.WriteLine("Press A to see all your Pokemons");
                var checkAllPokemons = Console.ReadLine();

                if(checkAllPokemons == "A" || checkAllPokemons == "a")
                {
                    foreach (var pk in YourPokeList)
                    {
                        Console.WriteLine($"{pk.Name}");
                    }
                }
            }

            else
            {
                Console.WriteLine($"You didnt managed to capture {wildPokemon.Name}! Sorry");
            }
        }
}
}
