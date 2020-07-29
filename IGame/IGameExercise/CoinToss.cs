using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGameExercise
{
	class CoinToss : IGame
	{
		public string Username { get; set; }
		public int Score { get; set; }
		public int GamesPlayed { get; set; }
		Random random = new Random();

		public CoinToss()
		{

		} // public CoinToss() end //

		public void PlayGame()
		{
			string UserInput = string.Empty;
			int toss = 0;
			SetUserName();
			CoinTossMenu1();
			CoinTossRules();

			for (GamesPlayed = 1; GamesPlayed <= 5; GamesPlayed++)
			{
				toss = random.Next(0, 2);
				Console.WriteLine(" Please give your guess: ");
				Hint();
				UserInput = Console.ReadLine();
				
				if (UserInput == "H" || UserInput == "h")
				{
					if (toss == 0)
					{
						CorrectGuess();
						Score++;
					}
					else
					{
						WrongGuess();
					}
				}
				else if (UserInput == "T" || UserInput == "t")
				{
					if (toss == 1)
					{
						CorrectGuess();
						Score++;
					}
					else
					{
						WrongGuess();
					}
				}
				else if (UserInput == "E" || UserInput == "e")
				{
					ExitGame();
				}
				else 
				{
					WrongInputGuess();
				}
			} // for (GamesPlayed = 1; GamesPlayed <= 5; GamesPlayed++) end //

			Console.Clear();
			Console.WriteLine("\n Your total score is: {0} \n", Score);
			ScoreCheck();
			Console.WriteLine("\n Thank you so much for playing {0} !!! Press any key to exit... ", Username);
			Console.ReadKey();

		} // public void PlayGame() //

		public void CoinTossMenu1()
		{
			Console.Clear();
			Console.WriteLine("\n Game 1: Coin Toss! \n");
			Console.WriteLine(" You will toss a coin five times! Each time you need to guess for 'Heads' or 'Tails'. ");
			Console.WriteLine(" If you guess three out of five (or more) correct you win, otherwise you loose! ");
			Console.WriteLine("\n When you feel ready to start press any key... ");
			Console.ReadKey();
			Console.Clear();
		} // public void CoinTossMenu1() //

		public void CoinTossRules()
		{
			Console.WriteLine("\n Pay attention to the messages below, ok {0}? ", Username);
			Console.WriteLine("\n Rules: \n");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(" Give 'H' or 'h' for Heads! ");
			Console.WriteLine(" Give 'T' or 't' for Tails! ");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine(" Give 'E' or 'e' to stop the game and exit! ");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(" Any other input will be considered an instant Loss! ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("\n Ready??? (press any key to start...) ");
			Console.ReadKey();
			Console.Clear();
		} // public void CoinTossRules() //

		public string SetUserName() 
		{
			Console.WriteLine("\n Before we start... \n");
			Console.WriteLine(" What's your name? (write your name and press 'Enter') ");
			Username = Console.ReadLine();
			return Username;
		} // public void UserName() //

		public void ExitGame() 
		{
			Console.Clear();
			Console.WriteLine(" Thank you and goodbye :( Press any key to exit... ");
			Console.ReadKey();
			Environment.Exit(0);
		} // public void ExitGame() //

		public void Hint() 
		{
			Console.WriteLine("\n (Remember!!!) ");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(" Give 'H' or 'h' for Heads! ");
			Console.WriteLine(" Give 'T' or 't' for Tails! ");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine(" Give 'E' or 'e' to stop the game and exit! ");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(" Any other input will be considered an instant Loss! \n");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(" -----> ");
		} // public void Hint() //

		public void CorrectGuess() 
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(" Your guess was right! ");
			Console.WriteLine(" You get 1 point! ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("\n Press any key to continue... ");
			Console.ReadKey();
			Console.Clear();
		} // public void CorrectGuess() end //

		public void WrongGuess()
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(" Your guess was wrong! ");
			Console.WriteLine(" You get 0 points! ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("\n Press any key to continue... ");
			Console.ReadKey();
			Console.Clear();
		} // public void WrongGuess()

		public void WrongInputGuess() 
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(" You gave an invalid input so you get 0 points! ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("\n Press any key to continue... ");
			Console.ReadKey();
			Console.Clear();
		} // public void WrongInputGuess() end //

		public void ScoreCheck() 
		{
			switch (Score)
			{
				case 0:
				case 1:
				case 2:
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(" Too bad!!! ");
					Console.WriteLine(" Your score was less than three out of five so you have lost this round! ");
					Console.WriteLine(" Feel free to try again anytime! ");
					Console.ForegroundColor = ConsoleColor.White;
					break;
				case 3:
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine(" Congrats!!! ");
					Console.WriteLine(" Your score was three out of five so you have won this round! ");
					Console.ForegroundColor = ConsoleColor.White;
					break;
				case 4:
				case 5:
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine(" Congrats!!! ");
					Console.WriteLine(" Your score was more than three out of five so you have won this round! ");
					Console.ForegroundColor = ConsoleColor.White;
					break;
			} // switch (Score) end //
		} // public void ScoreCheck() //

	} // class CoinToss : IGame //

} // namespace end //
