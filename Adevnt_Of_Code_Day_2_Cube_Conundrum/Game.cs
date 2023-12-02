namespace Advent_Of_Code_Day_2_Cube_Conundrum
{
    public class Game
    {
       
        public int Id { get; set; }
        public bool IsPossible { get; set; }
        public int PowerOfSet {  get; set; }

        public Game(int id,string game)
        {
            Id = id;
            List<Set> listOfSets = GettingSets(game);
            IsGamePossible(listOfSets);
            PowerOfSet = GettingPowerOfSets(listOfSets);
        }

        private  List<Set> GettingSets(string game)
        {
            List<Set> sets = new List<Set>();
            var setsToTreat = game.Split(';');
            foreach (var set in setsToTreat)  
                sets.Add(new Set(set));
            return sets;
        }

        private void IsGamePossible(List<Set> sets)
        {
            foreach(var set in sets)
            {
               if(!set.IsSetPossible)
                {
                    IsPossible = false;
                    break;
                }
               else 
                    IsPossible = true;
            }
        }

        private int GettingPowerOfSets(List<Set> sets)
        {
            var power = 0;
            var maxRed = 0;
            var maxBlue = 0;
            var maxGreen = 0;

            foreach (var set in sets)
            {
               if(set.Red > maxRed)
                    maxRed = set.Red;
               if(set.Green > maxGreen)
                    maxGreen = set.Green;
               if(set.Blue > maxBlue)
                    maxBlue = set.Blue;
            }
            power = maxRed * maxGreen * maxBlue;
            return power;
        }
    }
}
