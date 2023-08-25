using PInvoke;
using System.Runtime.InteropServices;

namespace XJ64QSD
{
    public class XJ64QSD
    {
        static void Main() { }
        public void DoWorkInfinite()
        {
        }
        public async Task<object> DoWork(object param)
        {
            var inp = new User32.INPUT
            {
                type = User32.InputType.INPUT_MOUSE,
                Inputs = new User32.INPUT.InputUnion
                {
                    mi = new User32.MOUSEINPUT
                    {
                        dx = 0,
                        dy = 0,
                        mouseData = 0,
                        dwFlags = User32.MOUSEEVENTF.MOUSEEVENTF_MOVE,
                        time = 0,
                        dwExtraInfo_IntPtr = IntPtr.Zero
                    },
                }
            };

            uint returnValue = User32.SendInput(nInputs: 1, pInputs: new[] { inp }, cbSize: Marshal.SizeOf<User32.INPUT>());

            if (returnValue != 1)
            {
                var errorCode = Marshal.GetLastWin32Error();
                Console.WriteLine($"{returnValue}:::{errorCode}");
            }

            return returnValue;
        }
    }
}