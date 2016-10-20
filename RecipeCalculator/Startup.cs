﻿using RecipeCalculator;
using System;
using System.Windows.Forms;

static class Startup
{
    /// <summary>
    /// The main entry point for the application
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainView());
    }
}