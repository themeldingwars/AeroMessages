using System;
using AeroMessages.Matrix;

namespace AeroMessages
{
    public class Test
    {
        public Test()
        {
            var loginMsg = new Login();
            var buffer   = new byte[100];
            loginMsg.Unpack(buffer.AsSpan());
            
            var size   = loginMsg.GetPackedSize();
            var packBuffer = new byte[size];
            loginMsg.Pack(packBuffer.AsSpan());
        }
    }
}