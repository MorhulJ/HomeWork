using System;

public class GameSystem
{
   const string SaveFile = "savegame.dat";
   
   public static void SaveGame(Player p)
   {
      using StreamWriter writer = new StreamWriter(SaveFile);
      writer.WriteLine($"Name:{p.Name}|Level:{p.Level}|Health:{p.Health}");
      
      Console.WriteLine("Game saved");
   }

   public static void LoadGame()
   {
      if (!File.Exists(SaveFile))
      {
         throw new ArgumentException("Save file not found");
      }

      using (StreamReader reader = new StreamReader(SaveFile))
      {
         string line = reader.ReadLine();

         string[] parts = line.Split('|');
         
         Player p = new Player();

         foreach (string part in parts)
         {
            string[] keyValue = part.Split(':');
            switch (keyValue[0])
            {
               case "Name":
                  p.Name = keyValue[1];
                  break;
               case "Level":
                  p.Level = int.Parse(keyValue[1]);
                  break;
               case "Health":
                  p.Health = int.Parse(keyValue[1]);
                  break;
            }
         }
         Console.WriteLine($"Loaded player: ");
         p.Show();
      }
   }
}