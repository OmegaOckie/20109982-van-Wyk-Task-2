using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_van_Wyk_POE
{
    //Q.3.3 | Create GameEngine Class
    class GameEngine
    {
        //Q.3.3 | Declare variables
        private Map myMap {get; set;}

        public GameEngine(int inputMapMinWidth, int inputMapMaxWidth, int inputMapMinHeight, int inputMapMaxHeight)
        {
            //Creates a Map object with hardcoded amount of enemies
            myMap = new Map(inputMapMinWidth, inputMapMaxWidth, inputMapMinHeight, inputMapMaxHeight, 5);
        }

        public bool MovePlayer(Character.Movement direction)
        {

            switch (direction)
            {
                case Character.Movement.UP:
                    break;
                case Character.Movement.DOWN:
                    break;
                case Character.Movement.LEFT:
                    break;
                case Character.Movement.RIGHT:
                    break;
                default:
                    return false;
                    break;
            }
        }
    }
}
