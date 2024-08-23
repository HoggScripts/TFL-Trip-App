using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TFLTripPlanner
{
    public class TextWriter
    {   
        public void WriteToFile(string content) {
         using (StreamWriter writer = new StreamWriter("../../../V2_output.txt", true)) {
         writer.WriteLine(content);
    }
}

    }
}