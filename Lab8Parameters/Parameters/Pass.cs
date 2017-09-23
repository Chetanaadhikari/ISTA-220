using System;

namespace Parameters
{
    class Pass
    {
        // TODO:
        public static void Value(ref int param)
        {
            param = 42;
        }

        public static void Reference(WrappedInt param)
        { param.Number = 42; }
    }

}
