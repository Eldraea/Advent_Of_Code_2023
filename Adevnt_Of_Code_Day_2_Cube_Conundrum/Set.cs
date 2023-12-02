namespace Advent_Of_Code_Day_2_Cube_Conundrum
{
    public class Set
    {
        const int MAX_RED = 12;
        const int MAX_GREEN = 13;
        const int MAX_BLUE = 14;
        public int Red {  get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public bool IsSetPossible { get; set; }

        public Set(string set) => IsSetPossible =SettingSet(SeparateColors(set));
        
        private string[] SeparateColors(string set)
        {
            set = set.Substring(set.IndexOf(':') + 2);
            return set.Split(',');
        }

        private bool SettingSet(string[] colors)
        {
            foreach (string color in colors)
            {  
                var colorToTreat = color.Trim().Split(' ');
                if (colorToTreat[1] == "red")
                    Red = Convert.ToInt32(colorToTreat[0]);
                else if (colorToTreat[1] == "blue")
                    Blue = Convert.ToInt32(colorToTreat[0]);
                else
                    Green = Convert.ToInt32(colorToTreat[0]);
            }
            return Red <= MAX_RED && Blue <= MAX_BLUE && Green <= MAX_GREEN;
        }

    }
}
