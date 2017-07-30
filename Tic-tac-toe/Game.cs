using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_tac_toe
{
   public class Game
    {
       public char[] sign = new char[9];
       public bool NowX { get; set;}
       public bool BotNow { get; set; }
       public bool PlayBot { get; set; }
       public bool PlayBotHard { get; set; }
       public bool MovePlayer { get; set; }
       Random random = new Random();

        public Game ()
        {
            Restart();
        }

        public bool CheckWin()
        {
            if((sign[0]=='x' && sign[1]=='x' && sign[2]=='x') || sign[0]== 'o' && sign[1] == 'o' && sign[2] == 'o')         
            {
                return true;
            }
            else if((sign[3] == 'x' && sign[4] == 'x' && sign[5] == 'x') || sign[3] == 'o' && sign[4] == 'o' && sign[5] == 'o')
            {
                return true;
            }
            else if ((sign[6] == 'x' && sign[7] == 'x' && sign[8] == 'x') || sign[6] == 'o' && sign[7] == 'o' && sign[8] == 'o')
            {
                return true;
            }
            else if ((sign[0] == 'x' && sign[3] == 'x' && sign[6] == 'x') || sign[0] == 'o' && sign[3] == 'o' && sign[6] == 'o')
            {
                return true;
            }
            else if ((sign[1] == 'x' && sign[4] == 'x' && sign[7] == 'x') || sign[1] == 'o' && sign[4] == 'o' && sign[7] == 'o')
            {
                return true;
            }
            else if ((sign[2] == 'x' && sign[5] == 'x' && sign[8] == 'x') || sign[2] == 'o' && sign[5] == 'o' && sign[8] == 'o')
            {
                return true;
            }
            else if ((sign[0] == 'x' && sign[4] == 'x' && sign[8] == 'x') || sign[0] == 'o' && sign[4] == 'o' && sign[8] == 'o')
            {
                return true;
            }
            else if ((sign[2] == 'x' && sign[4] == 'x' && sign[6] == 'x') || sign[2] == 'o' && sign[4] == 'o' && sign[6] == 'o')
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool CheckFull()
        {
            for (int i = 0; i < sign.Length; i++)
            {
                if(sign[i]=='e')
                {
                    return false;
                }
            }

            return true;
        }

        public void Restart()
        {
            for (int i = 0; i < sign.Length; i++)
            {
                sign[i] = 'e';
            }

            NowX = true;
        }

        // Cpu easy move
        public int BotMove()
        {
            int rand;
            rand = RandomNumber();

            while (sign[rand]!='e')
            {
                rand = RandomNumber();
            }

            sign[rand] = 'o';
            Application.DoEvents();
            System.Threading.Thread.Sleep(100);
           
                MovePlayer = true;
                return rand;
            }

        private int RandomNumber()
        {
           return random.Next(9);
        }

        //Cpu hard move
        public int BotMoveHard()
        {
            //Attack
            if (sign[0] == 'o' && sign[1] == 'o' && sign[2] == 'e')
            {
                sign[2] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 2;
            }
               
            else if (sign[3] == 'o' && sign[4] == 'o' && sign[5] == 'e')
            {
                sign[5] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 5;
            }
                
            else if (sign[6] == 'o' && sign[7] == 'o' && sign[8] == 'e')
            {
                sign[8] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 8;
            }
               
            else if (sign[2] == 'o' && sign[1] == 'o' && sign[0] == 'e')
            {
                sign[0] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 0;
            }
                
            else if (sign[5] == 'o' && sign[4] == 'o' && sign[3] == 'e')
            {
                sign[3] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 3;
            }
             
            else if (sign[8] == 'o' && sign[7] == 'o' && sign[6] == 'e')
            {
                sign[6] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 6;
            }
                
            else if (sign[0] == 'o' && sign[3] == 'o' && sign[6] == 'e')
            {
                sign[6] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 6;
            }
               
            else if (sign[1] == 'o' && sign[4] == 'o' && sign[7] == 'e')
            {
                sign[7] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 7;
            }
           
            else if (sign[2] == 'o' && sign[5] == 'o' && sign[8] == 'e')
            {
                sign[8] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 8;
            }
             
            else if (sign[6] == 'o' && sign[3] == 'o' && sign[0] == 'e')
            {
                sign[0] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 0;
            }
               
            else if (sign[7] == 'o' && sign[4] == 'o' && sign[1] == 'e')
            {
                sign[1] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 1;
            }
       
            else if (sign[8] == 'o' && sign[5] == 'o' && sign[2] == 'e')
            {
                sign[2] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 2;
            }
                
            else if (sign[0] == 'o' && sign[4] == 'o' && sign[8] == 'e')
            {
                sign[8] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 8;
            }
               
            else if (sign[8] == 'o' && sign[4] == 'o' && sign[0] == 'e')
            {
                sign[0] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 0;
            }             

            else if (sign[6] == 'o' && sign[4] == 'o' && sign[2] == 'e')
            {
                sign[2] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 2;
            }
              
            else if (sign[2] == 'o' && sign[4] == 'o' && sign[6] == 'e')
            {
                sign[6] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 6;
            }
            
            else if (sign[3] == 'o' && sign[5] == 'o' && sign[4] == 'e')
            {
                sign[4] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 4;
            }

            else if (sign[6] == 'o' && sign[8] == 'o' && sign[7] == 'e')
            {
                sign[7] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 7;
            }

            else if (sign[0] == 'o' && sign[2] == 'o' && sign[1] == 'e')
            {
                sign[1] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 1;
            }

            else if (sign[0] == 'o' && sign[6] == 'o' && sign[3] == 'e')
            {
                sign[3] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 3;
            }

            else if (sign[1] == 'o' && sign[7] == 'o' && sign[4] == 'e')
            {
                sign[4] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 4;
            }

            else if (sign[2] == 'o' && sign[8] == 'o' && sign[5] == 'e')
            {
                sign[5] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 5;
            }

            else if (sign[2] == 'o' && sign[6] == 'o' && sign[4] == 'e')
            {
                sign[4] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 4;
            }

            else if (sign[0] == 'o' && sign[8] == 'o' && sign[4] == 'e')
            {
                sign[4] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 4;
            }


            //Defence
            if (sign[0] == 'x' && sign[1] == 'x' && sign[2] == 'e')
            {
                sign[2] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 2;
            }

            else if (sign[3] == 'x' && sign[4] == 'x' && sign[5] == 'e')
            {
                sign[5] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 5;
            }

            else if (sign[6] == 'x' && sign[7] == 'x' && sign[8] == 'e')
            {
                sign[8] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 8;
            }

            else if (sign[2] == 'x' && sign[1] == 'x' && sign[0] == 'e')
            {
                sign[0] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 0;
            }

            else if (sign[5] == 'x' && sign[4] == 'x' && sign[3] == 'e')
            {
                sign[3] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 3;
            }

            else if (sign[8] == 'x' && sign[7] == 'x' && sign[6] == 'e')
            {
                sign[6] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 6;
            }

            else if (sign[0] == 'x' && sign[3] == 'x' && sign[6] == 'e')
            {
                sign[6] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 6;
            }

            else if (sign[1] == 'x' && sign[4] == 'x' && sign[7] == 'e')
            {
                sign[7] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 7;
            }

            else if (sign[2] == 'x' && sign[5] == 'x' && sign[8] == 'e')
            {
                sign[8] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 8;
            }

            else if (sign[6] == 'x' && sign[3] == 'x' && sign[0] == 'e')
            {
                sign[0] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 0;
            }

            else if (sign[7] == 'x' && sign[4] == 'x' && sign[1] == 'e')
            {
                sign[1] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 1;
            }

            else if (sign[8] == 'x' && sign[5] == 'x' && sign[2] == 'e')
            {
                sign[2] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 2;
            }

            else if (sign[0] == 'x' && sign[4] == 'x' && sign[8] == 'e')
            {
                sign[8] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 8;
            }

            else if (sign[8] == 'x' && sign[4] == 'x' && sign[0] == 'e')
            {
                sign[0] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 0;
            }

            else if (sign[6] == 'x' && sign[4] == 'x' && sign[2] == 'e')
            {
                sign[2] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 2;
            }

            else if (sign[2] == 'x' && sign[4] == 'x' && sign[6] == 'e')
            {
                sign[6] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 6;
            }

            else if (sign[3] == 'x' && sign[5] == 'x' && sign[4] == 'e')
            {
                sign[4] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 4;
            }

            else if (sign[6] == 'x' && sign[8] == 'x' && sign[7] == 'e')
            {
                sign[7] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 7;
            }

            else if (sign[0] == 'x' && sign[2] == 'x' && sign[1] == 'e')
            {
                sign[1] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 1;
            }

            else if (sign[0] == 'x' && sign[6] == 'x' && sign[3] == 'e')
            {
                sign[3] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 3;
            }

            else if (sign[1] == 'x' && sign[7] == 'x' && sign[4] == 'e')
            {
                sign[4] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 4;
            }

            else if (sign[2] == 'x' && sign[8] == 'x' && sign[5] == 'e')
            {
                sign[5] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 5;
            }

            else if (sign[2] == 'x' && sign[6] == 'x' && sign[4] == 'e')
            {
                sign[4] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 4;
            }

            else if (sign[0] == 'x' && sign[8] == 'x' && sign[4] == 'e')
            {
                sign[4] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return 4;
            }



            //Random
            else
            {
                int rand;
                rand = RandomNumber();

                while (sign[rand] != 'e')
                {
                    rand = RandomNumber();
                }

                sign[rand] = 'o';
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                MovePlayer = true;
                return rand;
            }
        }
    }
}
