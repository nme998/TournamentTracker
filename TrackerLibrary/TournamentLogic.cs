using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        //Order teams list randomly
        //Check if list is big enough, if not add byes, 2^n teams
        //Create first round of matchups
        //Create every round after that

        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> randomisedTeams = RandomiseTeamOrder(model.EnteredTeams);
            int rounds = FindNumberOfRounds(randomisedTeams.Count);
            int byes = FindNumberOfByes(rounds, randomisedTeams.Count);

            model.Rounds.Add(CreateFirstRound(randomisedTeams, byes));
            CreateAllRounds(model, rounds);
        }

        private static List<TeamModel> RandomiseTeamOrder(List<TeamModel> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }

        private static int FindNumberOfRounds(int teamCount)
        {
            int output = 1;
            int val = 2;

            while (val < teamCount)
            {
                output++;
                val *= 2;
            }


            return output;
        }

        private static int FindNumberOfByes(int rounds, int teams)
        {
            int output = 0;
            int totalTeams = 1;

            for (int i = 1; i <= rounds; i++)
            {
                totalTeams *= 2;
            }

            output = totalTeams - teams;

            return output;
        }

        private static List<MatchupModel> CreateFirstRound(List<TeamModel> teams, int byes)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel currentModel = new MatchupModel();

            foreach (TeamModel team in teams)
            {
                currentModel.Entries.Add(new MatchupEntryModel {  TeamCompeting = team });
                if (byes > 0 || currentModel.Entries.Count > 1)
                {
                    currentModel.MatchupRound = 1;
                    output.Add(currentModel);
                    currentModel = new MatchupModel();

                    if (byes > 0)
                    {
                        byes--;
                    }
                }
            }

            return output;
        }

        private static void CreateAllRounds(TournamentModel tournament, int rounds)
        {
            int round = 2;
            List<MatchupModel > previousRound = tournament.Rounds[0];
            List<MatchupModel> currentRound = new List<MatchupModel>();
            MatchupModel currentMatch = new MatchupModel();

            while (round <= rounds)
            {
                foreach (MatchupModel match in previousRound)
                {
                    currentMatch.Entries.Add(new MatchupEntryModel { ParentMatchup = match });

                    if (currentMatch.Entries.Count > 1)
                    {
                        currentMatch.MatchupRound = round;
                        currentRound.Add(currentMatch);
                        currentMatch = new MatchupModel();
                    }
                }

                tournament.Rounds.Add(currentRound);
                previousRound = currentRound;

                currentRound = new List<MatchupModel>();
                round++;
            }
        }
    }
}
