using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectReact
{
	public class Profile
	{
		public string Name { get; set; }

		public string Email { get; set; }

		public int Nummer { get; set; }

		public LostAd MyLostAdds { get; set; }

		public FoundAd myFoundAdds { get; set; }


	}
}
