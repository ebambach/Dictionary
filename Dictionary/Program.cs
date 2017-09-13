using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary {
	class Program {
		static void Main(string[] args) {
			new Program().Run();
		}
		void Run() {
			//When setting up a "Dictionary," unlike a "List," you input two data types.
			//The first type is considered to be a "Key," and the second type is the "Value."
			//In the example below, the state code "OH" is the Key for the Value of "Ohio."
			Dictionary<string, string> States = new Dictionary<string, string>();
			States["IN"] = "Indiana";
			States["KY"] = "Kentucky";
			States["OH"] = "Ohio";

			//This foreach loop uses the Keys we defined above to search the Dictionary
			//for the Values.
			foreach (var key in States.Keys) {
				Console.WriteLine($"{key} is the state code for {States[key]}");
			}
		}
	}
}
