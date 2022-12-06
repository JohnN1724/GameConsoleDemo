using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameConsoleDemo.Models
{
    public class GameConsole
    {
        [Key]
        public int ConsoleID { get; set; }
        public String ConsoleName { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }

        public GameConsole()
        {

        }
    }
}
