using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7._8
{
    internal class testRemote
    {
        public static bool PowerOn(bool powerStatus)
        {
            if (powerStatus == true)
            {
                testRemote.DisplayMessage("TV already on");
            }
            else
            {
                powerStatus = true;
                testRemote.DisplayMessage("TV On, Your Channel is 3 and the Volume is 5");
            }
            return powerStatus;
        }

        public static bool PowerOff(bool powerStatus)
        {
            if (powerStatus == false)
            {
                testRemote.DisplayMessage("TV already off");
            }
            else
            {
                powerStatus = false;
                testRemote.DisplayMessage("TV is now off");
            }
            return powerStatus;
        }

        public static int VolumeUp(bool powerStat, int vol)
        {
            if (powerStat == false)
            {
                testRemote.DisplayMessage("TV is off");
            }
            else
            {
                if (vol >= 10)
                {
                    testRemote.DisplayMessage("TV is already on Maximum Volume.");
                }
                else
                {
                    vol++;
                    if (vol == 10)
                    {
                        testRemote.DisplayMessage("Maximum Volume.");
                    }
                }
            }
            return vol;
        }

        public static int VolumeDown(bool powerStat, int vol)
        {
            if (powerStat == false)
            {
                testRemote.DisplayMessage("TV is off");
            }
            else
            {
                if (vol <= 0)
                {
                    testRemote.DisplayMessage("Sound Muted");
                }
                else
                {
                    vol--;
                    if (vol == 0)
                    {
                        testRemote.DisplayMessage("Sound Muted");
                    }
                }
            }
            return vol;
        }

        public static int ChannelUp(bool powerStat, int channelNo)
        {
            if (powerStat == false)
            {
                testRemote.DisplayMessage("TV is off");
            }
            else
            {
                if (channelNo < 99)
                {
                    channelNo++;
                }
                else
                {
                    channelNo = 2;
                }
                Console.WriteLine("Channel " + channelNo.ToString());
            }
            return channelNo;
        }

        public static int ChannelDown(bool powerStat, int channelNo)
        {
            if (powerStat == false)
            {
                testRemote.DisplayMessage("TV is off");
            }
            else
            {
                if (channelNo == 2)
                {
                    channelNo = 99;
                }
                else
                {
                    channelNo--;
                }
                Console.WriteLine("Channel " + channelNo.ToString());
            }
            return channelNo;
        }

        public static String SmartMenu(bool powerStat, String md)
        {
            if (powerStat == false)
            {
                testRemote.DisplayMessage("TV is off");
            }
            else
            {
                testRemote.DisplayMessage("Smart Menu On");
                md = "TV";
            }
            return md;
        }

        public static String SetSettings(bool powerStat, String md)
        {
            if (powerStat == false)
            {
                testRemote.DisplayMessage("TV is off");
            }
            else
            {
                testRemote.DisplayMessage("Settings On");
                md = "Settings";
            }
            return md;
        }
        public static void DisplayMessage(String msg)
        {
            Console.WriteLine(msg);
        }

        public static void Banner()
        {
            Console.WriteLine("Welcome to TV Remote Control");
            Console.WriteLine("Please enter your selection");
            Console.WriteLine("Power On - turns on your TV");
            Console.WriteLine("Power Off - turns off your TV");
            Console.WriteLine("Increase volume - turns up the volume");
            Console.WriteLine("Decrease volume - turn down the volume");
            Console.WriteLine("Channel Up - increments the channel");
            Console.WriteLine("Channel Down - decrements the channel");
            Console.WriteLine("Smart Menu");
            Console.WriteLine("Settings");
            Console.WriteLine();
            Console.WriteLine("Please enter your selection");
        }


    }
}
