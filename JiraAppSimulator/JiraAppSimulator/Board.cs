using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraAppSimulator
{
    class Board
    {
        private static Board instance;

        private static List<BaseTask> _tasks;
        private Board()
        { 
            //TODO: implement generating tasks list, report, filter
        }

        private static Board GetInstance()
        {
            if (instance == null)
            {
                instance = new Board();
            }

            return instance;
        }
    }
}
