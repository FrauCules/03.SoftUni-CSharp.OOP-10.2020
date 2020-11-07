using Demo5_AbsractedRendering.Contracts;
using Demo5_AbsractedRendering.Drawers;
using System;
using System.Diagnostics;

namespace Demo5_AbsractedRendering
{
    class Program
    {
        static void Main(string[] args)
        {
            // IDrawer drawer = new ConsoleDrawer(); - когато искаме да печата на конзолата
            // IDrawer drawer = new FileDrawer("../../../game.txt"); // когато искаме да пише във файл
            IDrawer drawer = new HtmlDrawer("../../../game"); // когато искаме да пише във HTML
            Game game = new Game(drawer);
            game.Start();
        }
    }
}
