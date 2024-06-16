using Microsoft.Graphics.Canvas.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WinverUWP.Helpers;

public class FirstDisposableTuple<T1, T2, T3> : Tuple<T1, T2, T3>, IDisposable where T1 : IDisposable
{
    public FirstDisposableTuple(T1 item1, T2 item2, T3 item3) : base(item1, item2, item3)
    { }

    public void Dispose() => Item1.Dispose();
}

public static class OSPathsHelper
{


}