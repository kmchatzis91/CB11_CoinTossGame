using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGameExercise
{
	interface IGame
	{
		string Username { get; set; }
		int Score { get; set; }
		int GamesPlayed { get; set; }
		void PlayGame();

	} // interface IGame end //

} // namespace end //
