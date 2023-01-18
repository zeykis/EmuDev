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
            throw new NotImplementedException();
        }

        public Dictionary<byte, Action<ushort>> Handlers { get; }
        
        public ushort this[int i]
        {
            get { throw new NotImplementedException(); }
        }
        
        private byte GetNibble(ushort instruction, int n)
        {
            throw new NotImplementedException();
        }

        private byte GetN(ushort instruction)
        {
            throw new NotImplementedException();
        }

        private byte GetNN(ushort instruction)
        {
            throw new NotImplementedException();
        }
        
        private ushort GetNNN(ushort instruction)
        {
            throw new NotImplementedException();
        }
        
        private byte GetX(ushort instruction)
        {
            throw new NotImplementedException();
        }
        
        private byte GetY(ushort instruction)
        {
            throw new NotImplementedException();
        }
        public void ParseInput(string filepath)
        {
            throw new NotImplementedException();
        }
        
        private void Display(bool clearScreen)
        {
            throw new NotImplementedException();
            
        }

        private void DebugInstruction()
        {
            throw new NotImplementedException();
        }

        private void DebugTimer()
        {
            throw new NotImplementedException();
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