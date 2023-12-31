﻿using Advent_Of_Code_Day_2_Cube_Conundrum;

string filename = "input.txt";
List<Game> games = GettingTheListOfGames(filename);

PartOne(filename);
PartTwo(filename);

void PartOne(string filename)
{
    if (File.Exists(filename))
      Console.WriteLine("The sum of games possible is equal to " + SumOfGamePossible(games));
}

void PartTwo(string filename)
{
    if(File.Exists(filename))
        Console.WriteLine("The sum of power of set of cubes for all games is equal to " + AddingPowers(games));
}

List<Game> GettingTheListOfGames(string filename)
{
    var games = new List<Game>();
    string[] gamesToTreat = File.ReadAllLines(filename);
    int i = 1;
    foreach (var game in gamesToTreat)
    {
        games.Add(new Game(i, game));
        i++;
    }
    return games;
}

int SumOfGamePossible(List<Game> games)
{
    int sum = 0;
    foreach(Game game in games)
        if (game.IsPossible)
            sum += game.Id;  
    return sum;
}

int AddingPowers(List<Game> games)
{
    var sum = 0;
    foreach (Game game in games)
        sum += game.PowerOfSet;
    return sum;
}