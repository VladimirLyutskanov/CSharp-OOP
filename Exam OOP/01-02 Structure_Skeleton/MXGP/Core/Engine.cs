using MXGP.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Core
{
    public class Engine
    {
        private IChampionshipController championshipContraller;

        public Engine()
        {
            this.championshipContraller = new ChampionshipController();
        }
        public void Run()
        {

            string[] inputInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (inputInfo[0] != "End")
            {
                try
                {
                    string command = inputInfo[0];

                    if (command == "CreateRider")
                    {
                        string name = inputInfo[1];
                        championshipContraller.CreateRider(name);
                    }
                    if (command == "CreateMotorcycle")
                    {
                        string type = inputInfo[1];
                        string model = inputInfo[2];
                        int horsePower = int.Parse(inputInfo[3]);

                        championshipContraller.CreateMotorcycle(type, model, horsePower);
                    }

                    if (command == "AddMotorcycleToRider")
                    {
                        string name = inputInfo[1];
                        string model = inputInfo[2];
                        championshipContraller.AddMotorcycleToRider(name, model);
                    }
                    if (command == "StartRace")
                    {
                        string raceName = inputInfo[1];

                        championshipContraller.StartRace(raceName);
                    }
                    if (command == "AddRiderToRace")
                    {
                        string raceName = inputInfo[1];
                        string riderName = inputInfo[2];
                        championshipContraller.AddRiderToRace(raceName, riderName);
                    }
                    if (command == "CreateRace")
                    {
                        string name = inputInfo[1];
                        int laps = int.Parse(inputInfo[2]);

                        championshipContraller.CreateRace(name, laps);
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message); 
                }


                inputInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

          
        }
    }
}
