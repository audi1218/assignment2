using System;
using System.IO;
using System.Runtime.CompilerServices;
using VideoGameLab;

string projectRootFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();

string filePath = projectRootFolder + "/videogames.csv";

List<VideoGame> Games = new List<VideoGame>();

using (var sr = new StreamReader(filePath))
{
    sr.ReadLine();

    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine();

        string[] lineData = line.Split(',');

         VideoGame game = new VideoGame();

        game.Name = lineData[0];
        game.Platform = lineData[1];
        game.Year = int.Parse(lineData[2]);
        game.Genre= lineData[3];
        game.Publisher = lineData[4];
        game.NASales = double.Parse(lineData[5]);
        game.EUSales = double.Parse(lineData[6]);   
        game.JPSales = double.Parse(lineData[7]);
        game.OtherSales = double.Parse(lineData[8]);
        game.GlobalSales = double.Parse(lineData[9]);

        Games.Add(game);

       
    }
}