using Assets.Scripts.Model.Encounters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Model
{
    class DungeonGenerator
    {

        private static readonly string[] adjectives = 
        {
            "Death","Axes","Traps","Blood","Carnage","Bleeding","Arcane","Magic","Slaughter","Maniacs","Insanity","Delusions","Violence","Murder","Treachery",
            "Backstabs","Fanatics","Skulls"
        };

        private static readonly System.Random rand = new System.Random();

        public static Dungeon generateRandomDungeon(int averageLevel)
        {
            Dungeon dungeon = new Dungeon();
            //Calculate the variance in levels, the generated dungeons level is level + (0 to variance)
            int levelVariance = 1 + (int)(Math.Sqrt(averageLevel));
            int level = averageLevel + (int)((levelVariance) * rand.NextDouble());

            dungeon.RecommendedLevel = level;
            dungeon.Hazardousness = GenerateRandomHazardousness(level);
            dungeon.Enviroment = Dungeon.enviroments[UnityEngine.Random.Range(0, Dungeon.enviroments.Length)];
            dungeon.Name = Dungeon.hazardousnessLevels[dungeon.Hazardousness] + " " + dungeon.Enviroment + " of " + 
                adjectives[UnityEngine.Random.Range(0, adjectives.Length)];
            generateDungeonContent(dungeon);

            return dungeon;
        }

        private static void generateDungeonContent(Dungeon d)
        {
            float loc = 0.08f + (float)(rand.NextDouble() * 0.04);
            while (loc <= 0.9f)
            {
                Combat combat = new Combat();
                combat.Location = loc;
                d.Encounters.Add(combat);
                loc += 0.06f + (float)(rand.NextDouble() * 0.12);
            }
        }

        private static int GenerateRandomHazardousness(int level) {
            int max = (int)(Mathf.Sqrt(level));
            if (max > 5)
            {
                max = 5;
            }
            //Fancy math incoming, Box-Muller transformation
            double r = Math.Sqrt(-2 * Math.Log(rand.NextDouble()));
            double a = 2 * Math.PI * rand.NextDouble();
            double x = Math.Abs(r * Math.Cos(a)) / 2;
            //Fancy math ends
            return Math.Min(4, (int)(x * max));
        }

    }
}
