using System;
using System.Collections.Generic;
using System.IO;

namespace Emudev
{

    public enum Debug
    {
        Instruction,
        Timer,
        Register,
        Stack,
        Input,
        Display,
        Memory,
        All
    }
    
    public class Chip8
    {
        private Dictionary<byte, Action<ushort>> _handlers;

        private Stack<ushort> _stack;
        private Queue<bool[]> _input;

        private byte[] _memory;
        private byte[] _registers;
        private bool[] _gfx;

        private ushort _I;
        private ushort _PC;
        private byte _delayTimer;
        private byte _soundTimer;

        private Random _random;
 
        public Chip8(Random random)
        {
            byte[] font = new byte[]
            {
                0xF0, 0x90, 0x90, 0x90, 0xF0,
                0x20, 0x60, 0x20, 0x20, 0x70,
                0xF0, 0x10, 0xF0, 0x80, 0xF0,
                0xF0, 0x10, 0xF0, 0x10, 0xF0,
                0x90, 0x90, 0xF0, 0x10, 0x10,
                0xF0, 0x80, 0xF0, 0x10, 0xF0,
                0xF0, 0x80, 0xF0, 0x90, 0xF0,
                0xF0, 0x10, 0x20, 0x40, 0x40,
                0xF0, 0x90, 0xF0, 0x90, 0xF0,
                0xF0, 0x90, 0xF0, 0x10, 0xF0,
                0xF0, 0x90, 0xF0, 0x90, 0x90,
                0xE0, 0x90, 0xE0, 0x90, 0xE0,
                0xF0, 0x80, 0x80, 0x80, 0xF0,
                0xE0, 0x90, 0x90, 0x90, 0xE0,
                0xF0, 0x80, 0xF0, 0x80, 0xF0,
                0xF0, 0x80, 0xF0, 0x80, 0x80
            };

            _memory = new byte[4096];
            _gfx = new bool[32 * 64];
            _input = new Queue<bool[]>();
            _handlers = new Dictionary<byte, Action<ushort>>(16);
            _random = random;
            _PC = 0x200;
            _stack = new Stack<ushort>();
            _registers = new byte[16];
            _delayTimer = 0;
            _soundTimer = 0;
            _I = 0x0;

            for (int i = 0; i < font.Length; i++)
            {
                _memory[i] = font[i];
            }
        }

        public Dictionary<byte, Action<ushort>> Handlers { get; }
        
        public ushort this[int i]
        {
            get { return (ushort)(_memory[i] << 8 | _memory[i + 1]); }
        }
        
        private byte GetNibble(ushort instruction, int n)
        {
            return (byte)((instruction >> (n * 4)) & 0xF);
        }
        /*
    X or Y, indexes of registers. When used, X is always the second nibble and Y the third.
    NNN, an address. When used, NNN is always the last three nibbles.
    NN, a value (from 0 to 256). When used, NN is always the last two nibbles.
    N, a value (from 0 to 16). When used, N is always the last nibble.
*/
        private byte GetN(ushort instruction)
        {
            return (byte)(instruction & 0xF);
        }

        private byte GetNN(ushort instruction)
        {
            return (byte)(instruction & 0xFF);
        }
        
        private ushort GetNNN(ushort instruction)
        {
            return (ushort)(instruction & 0xFFF);
        }
        
        private byte GetX(ushort instruction)
        {
            return GetNibble(instruction, 2);
        }
        
        private byte GetY(ushort instruction)
        {
            return GetNibble(instruction, 3);
        }
        public void ParseInput(string filepath)
        {
            throw new NotImplementedException();
        }
        
        private void Display(bool clearScreen)
        {
            /*This method displays the graphical memory of the computer.
If a pixel is on (true) it will be represented by two █ (219 in extended ascii).
Else, it will be two spaces.
The clear value says wether you should clear the terminal before printing or not.
There should be a frame around the display. See the example below.
There is a trailing new line. */
            int i = 0;
            if (clearScreen)
            {
                Console.Clear();
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            for (int y = 0; y < 32; y++)
            {
                Console.Write("|");
                for (int x = 0; x < 64; x++)
                {
                    if (_gfx[i])
                    {
                        Console.Write("██");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    i++;
                }
                Console.WriteLine("|");
            }
            
        }

        private void DebugInstruction()
        {
            Console.WriteLine("PC = " + this[_PC]);
            Console.WriteLine("Instruction = " + _I);

        }

        private void DebugTimer()
        {
            Console.WriteLine("Delay = " + _delayTimer);
            Console.WriteLine("Sound = " + _soundTimer);
        }

        private void DebugRegister()
        {
            throw new NotImplementedException();
        }

        private void DebugStack()
        {
            throw new NotImplementedException();
        }

        private void DebugMemory()
        {
            throw new NotImplementedException();
        }

        private void DebugInput()
        {
            throw new NotImplementedException();
        }

        public void PrintDebug(Debug part)
        {
            throw new NotImplementedException();
        }
        public void LoadRom(string filePath)
        {
            throw new NotImplementedException();
        }

        public bool ExecuteOp()
        {
            throw new NotImplementedException();
        }

        public void RunProgram()
        {
            throw new NotImplementedException();
        }
        
        private void Handle0(ushort opcode)
        {
   
            throw new NotImplementedException(); 
        }
        
        private void Handle1(ushort opcode)
        {
            throw new NotImplementedException();
        }

        private void Handle2(ushort opcode)
        {
            throw new NotImplementedException();
        }

        private void Handle3(ushort opcode)
        {
            throw new NotImplementedException();
        }

        private void Handle4(ushort opcode)
        {
            throw new NotImplementedException();
        }

        private void Handle5(ushort opcode)
        {
            throw new NotImplementedException();
        }

        private void Handle6(ushort opcode)
        {
            throw new NotImplementedException();
        }

        private void Handle7(ushort opcode)
        {
            throw new NotImplementedException();
        }

        private void Handle8(ushort opcode)
        {
            throw new NotImplementedException();
        }
        
        private void Handle9(ushort opcode)
        {
            throw new NotImplementedException();
        }

        private void HandleA(ushort opcode)
        {
            throw new NotImplementedException();
        }

        private void HandleB(ushort opcode)
        {
            throw new NotImplementedException();
        }

        private void HandleC(ushort opcode)
        {
            throw new NotImplementedException();
        }

        private void HandleD(ushort opcode)
        {
            throw new NotImplementedException();
        }

        private void HandleE(ushort opcode)
        {
            throw new NotImplementedException();
        }

        private void HandleF(ushort opcode)
        {
            throw new NotImplementedException();
        }
    }
}





for(int i = 0; i < 16; i++)
{
    stuff ;
}

_list[0] = the value at i = 0;
_list[1] = the value at i = 1;
_list[2] = the value at i = 2;
_list[3] = the value at i = 3;
_list[4] = the value at i = 4;